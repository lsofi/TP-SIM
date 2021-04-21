using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP3.Distribuciones;

namespace TP3
{
    public partial class frmNumAleatorio : Form
    {

        IDistribucion distribucion;
        public frmNumAleatorio()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                dgvTabla.Rows.Clear();
                for (int i = 0; i < Convert.ToInt32(txtN.Text); i++)
                    {
                        dgvTabla.Rows.Add(i, Math.Round(distribucion.getRandomVar(),4));
                    }
            }
        }

        private void btnNormalMuller_CheckedChanged(object sender, EventArgs e)
        {
            txtDE.Enabled = txtMedia.Enabled = true;
            txtA.Enabled = txtLambda.Enabled = txtB.Enabled = false;
            vaciarCampos();
        }

        private void btnNormalConvolucion_CheckedChanged(object sender, EventArgs e)
        {
            btnNormalMuller_CheckedChanged(sender, e);
        }

        private void btnUniforme_CheckedChanged(object sender, EventArgs e)
        {
            txtA.Enabled = txtB.Enabled = true;
            txtDE.Enabled = txtLambda.Enabled = txtMedia.Enabled = false;
            vaciarCampos();
        }

        private void btnExponencial_CheckedChanged(object sender, EventArgs e)
        {
            txtLambda.Enabled = txtMedia.Enabled = true;
            txtA.Enabled = txtDE.Enabled = txtB.Enabled = false;
            vaciarCampos();
        }

        private void btnPoisson_CheckedChanged(object sender, EventArgs e)
        {
            txtLambda.Enabled = txtMedia.Enabled = true;
            txtA.Enabled = txtDE.Enabled = txtB.Enabled = false;
            vaciarCampos();
        }

        private void txtN_Leave(object sender, EventArgs e)
        {
            if (!(txtN.Text == string.Empty))
            {
                if(!(int.TryParse(txtN.Text, out int g) && g <= 50000 && g > 0))
                {
                    MessageBox.Show("Datos ingresados no válidos. La variable N debe ser un número entero positivo menor a 50000.", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtN.Clear();
                    txtN.Focus();
                }
            }
        }

        private void txtLambda_Leave(object sender, EventArgs e)
        {
            if (!(txtLambda.Text == string.Empty))
            {
                if (!(double.TryParse(txtLambda.Text, out double l)))
                {
                    MessageBox.Show("Datos ingresados no válidos. La variable Lambda debe ser un número.", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLambda.Clear();
                    txtLambda.Focus();
                }
                else
                    txtMedia.Enabled = false;
            }
        }

        private void txtMedia_Leave(object sender, EventArgs e)
        {
            if (!(txtMedia.Text == string.Empty))
            {
                if (!(double.TryParse(txtMedia.Text, out double m)))
                {
                    MessageBox.Show("Datos ingresados no válidos. La variable M debe ser un número entero positivo.", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMedia.Clear();
                    txtMedia.Focus();
                }
                else
                {
                    if (btnExponencial.Checked)
                        txtLambda.Text = (1.0 / m).ToString();
                    else
                    {
                        txtLambda.Text = m.ToString();
                        txtLambda.Enabled = false;
                    }
                }

            }
        }

        private bool validarCampos()
        {
            if (int.TryParse(txtN.Text, out int n) && n > 0)
            {
                if (btnNormalMuller.Checked)
                {
                    if (double.TryParse(txtDE.Text, out double d) && d > 0 && double.TryParse(txtMedia.Text, out double m))
                    {
                        distribucion = new NormalMuller(m, d);
                        return true;
                    }
                    else
                        MessageBox.Show("Datos ingresados no válidos. La desviación estandar debe ser un número mayor a 0.", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (btnNormalConvolucion.Checked)
                {
                    if (double.TryParse(txtDE.Text, out double d) && d > 0 && double.TryParse(txtMedia.Text, out double m))
                    {
                        distribucion = new NormalConvolucion(m, d);
                        return true;
                    }
                    else
                        MessageBox.Show("Datos ingresados no válidos. La desviación estandar debe ser un número mayor a 0.", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (btnUniforme.Checked)
                {
                    if (double.TryParse(txtA.Text, out double a) && double.TryParse(txtB.Text, out double b) && b > a)
                    {
                        distribucion = new Uniforme(a, b);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Datos ingresados no válidos. B tiene que ser un número mayor que A", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                if (btnExponencial.Checked)
                {
                    if (double.TryParse(txtMedia.Text, out double m))
                    {
                        distribucion = new ExponencialNegativa(m);
                        return true;
                    }

                    else
                        MessageBox.Show("Datos ingresados no válidos. La media debe ser un número positivo", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (btnPoisson.Checked)
                {
                    if (double.TryParse(txtLambda.Text, out double l) && l > 0)
                    {
                        distribucion = new Poisson(l);
                        return true;
                    }
                    else
                        MessageBox.Show("Datos ingresados no válidos. Lambda debe ser un número positivo", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show("Datos ingresados no válidos. N debe ser un número entero positivo", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return false;
        }

        public void vaciarCampos()
        {
            txtA.Clear();
            txtB.Clear();
            txtMedia.Clear();
            txtN.Clear();
            txtLambda.Clear();
            txtDE.Clear();
        }


    }
}
