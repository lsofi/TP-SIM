using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP5
{
    public partial class frmRungeKutta : Form
    {
        private double h;
        private double e;
        private int numInt = 0;
        public frmRungeKutta(double e)
        {
            InitializeComponent();
            this.h = 0.01;
            this.e = e;
            cargarTxt();
        }

        public frmRungeKutta(double h, double e)
        {
            InitializeComponent();
            this.h = h;
            this.e = e;
            cargarTxt();
        }

        private void cargarTxt()
        {
            txtH.Text = h.ToString();
        }

        public double[] rungeKuttaGraficoLlenado()
        {
            double[] tiemposLlenado = new double[3];
            bool encontro = false;
            VectorRungeKuttaLlenado anterior = new VectorRungeKuttaLlenado(0, 15, h);
            anterior.calcularValores();
            cargarDgv(anterior);
            VectorRungeKuttaLlenado actual = anterior.siguiente();
            cargarDgv(actual);
            while (actual.X < e)
            {
                anterior = actual;
                actual = anterior.siguiente();
                if (anterior.X < 50 && actual.X >= 50)
                {
                    tiemposLlenado[0] = actual.T;
                    encontro = true;
                }
                if (anterior.X < 70 && actual.X >= 70)
                {
                    tiemposLlenado[1] = actual.T;
                    encontro = true;
                }
                if (anterior.X < 100 && actual.X >= 100)
                {
                    tiemposLlenado[2] = actual.T;
                    encontro = true;
                }
                cargarDgv(actual);
                if (encontro)
                {
                    dgvRungeKutta.Rows[dgvRungeKutta.Rows.Count - 1].Cells[2].Style.BackColor = Color.FromArgb(3,192,74);
                    dgvRungeKutta.Rows[dgvRungeKutta.Rows.Count - 1].Cells[1].Style.BackColor = Color.FromArgb(3, 192, 74);
                    encontro = false;
                }
            }
            return tiemposLlenado;
        }

        public double rungeKuttaGraficoVaciado(int desborde)
        {
            numInt++;
            VectorRungeKuttaVaciado anterior = new VectorRungeKuttaVaciado(0, desborde, h);
            anterior.calcularValores();
            cargarDgv(anterior);
            VectorRungeKuttaVaciado actual = anterior.siguiente();
            cargarDgv(actual);
            do
            {
                anterior = actual;
                actual = anterior.siguiente();
                cargarDgv(actual);
            } while (Math.Abs(anterior.X - actual.X) > 0.02);
            dgvRungeKutta.Rows[dgvRungeKutta.Rows.Count - 1].Cells[2].Style.BackColor = Color.FromArgb(3,192,74);
            dgvRungeKutta.Rows[dgvRungeKutta.Rows.Count - 1].Cells[1].Style.BackColor = Color.FromArgb(3,192,74);
            return actual.T * 0.1;
        }
        public double rungeKuttaVaciado(int desborde)
        {
            numInt++;
            VectorRungeKuttaVaciado anterior = new VectorRungeKuttaVaciado(0, desborde, h);
            anterior.calcularValores();
            VectorRungeKuttaVaciado actual = anterior.siguiente();
            do
            {
                anterior = actual;
                actual = anterior.siguiente();
            } while (Math.Abs(anterior.X - actual.X) > 0.02);

            return actual.T * 0.1;
        }

        private void cargarDgv(VectorRungeKuttaLlenado v)
        {
            dgvRungeKutta.Rows.Add("",v.T, v.X, v.K1, v.Th2, v.Xk1h2, v.K2, v.Th2, v.Xk2h2, v.K3, v.Th, v.Xk3h, v.K4);
        }

        private void cargarDgv(VectorRungeKuttaVaciado v)
        {
            dgvRungeKutta.Rows.Add(numInt, v.T, v.X, v.K1, v.Th2, v.Xk1h2, v.K2, v.Th2, v.Xk2h2, v.K3, v.Th, v.Xk3h, v.K4);
        }

        private void frmRungeKutta_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true ;
        }
    }
}
