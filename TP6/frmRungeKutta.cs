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
        private double alfa;
        private double desb1;
        private double desb2;
        private double desb3;
        private int numInt = 0;


        public frmRungeKutta(double h, double alfa , double desb1, double desb2, double desb3)
        {
            InitializeComponent();
            this.h = h;
            this.alfa = alfa;
            this.desb1 = desb1;
            this.desb2 = desb2;
            this.desb3 = desb3;
        }

        public double[] rungeKuttaGraficoLlenado()
        {
            double[] tiemposLlenado = new double[3];
            bool encontro = false;
            VectorRungeKuttaLlenado anterior = new VectorRungeKuttaLlenado(0, 15, h, alfa);
            anterior.calcularValores();
            cargarDgv(anterior);
            VectorRungeKuttaLlenado actual = anterior.siguiente();
            cargarDgv(actual);
            while (actual.X < desb3)
            {
                anterior = actual;
                actual = anterior.siguiente();
                if (anterior.X < desb1 && actual.X >= desb1)
                {
                    tiemposLlenado[0] = actual.T;
                    encontro = true;
                }
                if (anterior.X < desb2 && actual.X >= desb2)
                {
                    tiemposLlenado[1] = actual.T;
                    encontro = true;
                }
                if (anterior.X < desb3 && actual.X >= desb3)
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
            VectorRungeKuttaVaciado anterior = new VectorRungeKuttaVaciado(0, desborde, h, alfa);
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
            VectorRungeKuttaVaciado anterior = new VectorRungeKuttaVaciado(0, desborde, h, alfa);
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
