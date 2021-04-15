using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneracionDeNumerosAleatorios
{
    public partial class frmNumAleatorio : Form
    {
        double[] vectorXi = new double[2];
        double[] vectorXi1 = new double[2];
        int x0, g, a, c, k;
        double m;
        IEstrategiaNumAleatorio estrategia = new EstrategiaMixto();
        public frmNumAleatorio()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (txtA.Text != string.Empty && txtX0.Text != string.Empty && txtG.Text != string.Empty && txtM.Text != string.Empty)
            {
                dgvTabla.Rows.Clear();
                vectorXi = estrategia.calcularSiguiente(x0, a, c, m);
                dgvTabla.Rows.Add(1, Math.Truncate(10000 * vectorXi[0]) / 10000, vectorXi[1]);
                for (int i = 1; i < 20; i++)
                {
                    int xi = Convert.ToInt32(vectorXi[1]);
                    vectorXi1 = estrategia.calcularSiguiente(xi, a, c, m);
                    dgvTabla.Rows.Add(i + 1, Math.Truncate(10000 * vectorXi1[0]) / 10000, vectorXi1[1]);
                    vectorXi = vectorXi1;
                }
                btnProximo.Enabled = true;
                deshabilitarCampos();
                btnGenerarGrafico.Enabled = true;

            }
            else
                MessageBox.Show("¡Por favor complete los campos obligatorios!", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtX0_Leave(object sender, EventArgs e)
        {
            if (!(txtX0.Text == string.Empty))
            {
                if (!(int.TryParse(txtX0.Text, out x0) && x0 > 0))
                {
                    MessageBox.Show("Datos ingresados no válidos. La variable X0 debe ser un número entero positivo.", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtX0.Clear();
                    txtX0.Focus();
                }
                else
                {
                    if (!estrategia.validarX0impar(x0) && !(txtX0.Text == string.Empty))
                        MessageBox.Show("Se aconseja que la variable x0 sea impar", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtK_Leave(object sender, EventArgs e)
        {
            if (!(txtK.Text == string.Empty))
            {
                if (!(int.TryParse(txtK.Text, out k) && estrategia.validarK(k)))
                {
                    MessageBox.Show(estrategia.stringVerk(), "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtK.Clear();
                    txtK.Focus();

                }
                else
                {
                    if (!(txtK.Text == string.Empty))
                    {
                        txtA.Enabled = false;
                        a = estrategia.calcularA(k);
                        txtA.Text = a.ToString();
                    }
                }
            }
            else
            {
                txtA.Enabled = true;
                txtA.Text = string.Empty;
                a = 0;
            }
        }

        private void txtA_Leave(object sender, EventArgs e)
        {
            if (!(txtA.Text == string.Empty))
            {
                if (!(int.TryParse(txtA.Text, out a) && a > 0))
                {
                    MessageBox.Show("Datos ingresados no válidos. La variable a debe ser un número entero positivo.", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtA.Clear();
                    txtA.Focus();
                }
                else
                {
                    txtK.Enabled = false;
                }

            }
            else
                txtK.Enabled = true;
        }

        private void txtG_Leave(object sender, EventArgs e)
        {
            if (!(txtG.Text == string.Empty))
            {
                if (!(int.TryParse(txtG.Text, out g) && g > 0))
                {
                    MessageBox.Show("Datos ingresados no válidos. La variable g debe ser un número entero positivo.", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtG.Clear();
                    txtG.Focus();
                }
                else
                {
                    m = estrategia.calcularM(g);
                    txtM.Text = m.ToString();
                    txtM.Enabled = false;
                    if (txtC.Text != string.Empty && !estrategia.verificarMyCPrimos(m, c))
                    {
                        MessageBox.Show("Se recomienda que las variables M y C sean coprimas.", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                txtM.Enabled = true;
                txtM.Text = string.Empty;
                m = 0;
            }
        }

        private void txtM_Leave(object sender, EventArgs e)
        {
            if (!(txtM.Text == string.Empty))
            {
                if (!(double.TryParse(txtM.Text, out m) && m > 0))
                {
                    MessageBox.Show("Datos ingresados no válidos. La variable m debe ser un número entero positivo.", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtM.Clear();
                    txtM.Focus();
                }
                else
                {
                    txtG.Enabled = false;
                    if (txtC.Text != string.Empty && !estrategia.verificarMyCPrimos(m, c))
                    {
                        MessageBox.Show("Se recomienda que las variables M y C sean coprimas.", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
                txtG.Enabled = true;
        }

        private void txtC_Leave(object sender, EventArgs e)
        {
            if (!(txtC.Text == string.Empty))
            {
                if (!(int.TryParse(txtC.Text, out c) && c > 0))
                {
                    MessageBox.Show("Datos ingresados no válidos. La variable C debe ser un número entero positivo.", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtC.Clear();
                    txtC.Focus();
                }
                else
                {
                    if (txtM.Text != string.Empty && !estrategia.verificarMyCPrimos(m, c))
                    {
                        MessageBox.Show("Se recomienda que las variables M y C sean coprimas.", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            int xi = Convert.ToInt32(vectorXi[1]);
            vectorXi1 = estrategia.calcularSiguiente(xi, a, c, m);
            dgvTabla.Rows.Add(dgvTabla.Rows.Count + 1, Math.Truncate(10000 * vectorXi1[0]) / 10000, vectorXi1[1]);
            vectorXi = vectorXi1;
        }

        private void btnGenerarGrafico_Click(object sender, EventArgs e)
        {
            frmGraficoChiCuadrado gcc = new frmGraficoChiCuadrado(dgvTabla);
            gcc.Show();
        }

        private void btnLineal_CheckedChanged(object sender, EventArgs e)
        {
            estrategia = new EstrategiaMixto();
            borrarCampos();
        }

        private void btnMultiplicativo_CheckedChanged(object sender, EventArgs e)
        {
            estrategia = new EstrategiaMultiplicativo();
            borrarCampos();
            c = 0;
            txtC.Text = "0";
            txtC.Enabled = false;
        }


        public void borrarCampos()
        {
            txtA.Clear();
            txtC.Clear();
            txtG.Clear();
            txtX0.Clear();
            txtK.Clear();
            txtM.Clear();
            txtA.Enabled = true;
            txtK.Enabled = true;
            txtM.Enabled = true;
            txtG.Enabled = true;
            txtC.Enabled = true;
            dgvTabla.Rows.Clear();
            btnProximo.Enabled = false;
            

            x0 = c = a = k = g = 0;
            m = 0;
        }
        
        public void deshabilitarCampos()
        {
            txtA.Enabled = false;
            txtK.Enabled = false;
            txtM.Enabled = false;
            txtG.Enabled = false;
            txtC.Enabled = false;
            txtX0.Enabled = false;
        }


        
    }
}
