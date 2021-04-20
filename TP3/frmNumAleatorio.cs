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
            if(validarCampos())
        }

        private void btnNormal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnUniforme_CheckedChanged(object sender, EventArgs e)
        {
            txtA.Enabled = txtB.Enabled = true;
            txtDE.Enabled = txtLambda.Enabled = txtMedia.Enabled = false;
        }

        private void btnExponencial_CheckedChanged(object sender, EventArgs e)
        {
            txtLambda.Enabled = txtMedia.Enabled = true;
            txtA.Enabled = txtDE.Enabled = txtB.Enabled = false;
        }

        private void btnPoisson_CheckedChanged(object sender, EventArgs e)
        {
            txtLambda.Enabled = txtMedia.Enabled = true;
            txtA.Enabled = txtDE.Enabled = txtB.Enabled = false;
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

        private bool validarCampos()
        {
            if(btnNormal.Checked)
            {
                if (double.TryParse(txtDE.Text, out double d) && d > 0 && double.TryParse(txtMedia.Text, out double m) && m > 0)
                    return true;
                else
                    MessageBox.Show("Datos ingresados no válidos. La desviación estandar debe ser un número mayor a 0.", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(btnUniforme.Checked)
            {
                if (double.TryParse(txtA.Text, out double a) && double.TryParse(txtB.Text, out double b) && b < a)
                    return true;
                else
                {
                    MessageBox.Show("Datos ingresados no válidos. B tiene que ser un número mayor que A", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }    
            }
            if(btnExponencial.Checked)
            {
                if (double.TryParse(txtMedia.Text, out double m) && m > 0)
                    return true;
                else
                    MessageBox.Show("Datos ingresados no válidos. La media debe ser un número positivo", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(btnPoisson.Checked)
            {
                if (double.TryParse(txtLambda.Text, out double l) && l > 0)
                    return true;
                else
                    MessageBox.Show("Datos ingresados no válidos. Lambda debe ser un número positivo", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return false;
        }
    }
}
