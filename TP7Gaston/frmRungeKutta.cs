using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP7
{
    public partial class frmRungeKutta : Form
    {
        private double h;
        private double e0;
        private double t0;
        private double z0;
        private int numInt = 0;

        public frmRungeKutta(double h, int e0, double t0, double z0)
        {
            InitializeComponent();
            this.h = h;
            this.e0 = e0;
            this.t0 = t0;
            this.z0 = z0;
        }

        public double rungeKutta(int edad)
        {
            numInt++;
            VectorRungeKutta anterior = new VectorRungeKutta(e0, t0, z0, h);
            anterior.calcularValores();
            cargarDgv(anterior);
            VectorRungeKutta actual = anterior.siguiente();
            cargarDgv(actual);
            do
            {
                anterior = actual;
                actual = anterior.siguiente();
                cargarDgv(actual);
            }
            while (actual.E < edad);
            dgvRungeKutta.Rows[dgvRungeKutta.Rows.Count - 1].Cells[2].Style.BackColor = Color.FromArgb(3, 192, 74);
            dgvRungeKutta.Rows[dgvRungeKutta.Rows.Count - 1].Cells[1].Style.BackColor = Color.FromArgb(3, 192, 74);
            return actual.T;
        }

        private void cargarDgv(VectorRungeKutta v)
        {
            dgvRungeKutta.Rows.Add(numInt, v.E, v.T, v.Z, v.Eh2, v.Tk1h2, v.Zl1h2, v.K2, v.L2, v.Eh2, v.Tk2h2, v.Zl2h2, v.K3, v.L3, v.Eh, v.Tk3h, v.Zl3h, v.K4, v.L4);
        }

        private void frmRungeKutta_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
