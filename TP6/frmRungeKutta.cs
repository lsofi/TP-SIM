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
                    tiemposLlenado[0] = actual.T;
                if (anterior.X < 70 && actual.X >= 70)
                    tiemposLlenado[1] = actual.T;
                if (anterior.X < 100 && actual.X >= 100)
                    tiemposLlenado[2] = actual.T;
                cargarDgv(actual);
            }
            return tiemposLlenado;
        }

        public double rungeKuttaGraficoVaciado()
        {
            VectorRungeKuttaVaciado anterior = new VectorRungeKuttaVaciado(0, e, h);
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

            return actual.T * 0.001;
        }

        public double rungeKuttaLlenado()
        {
            VectorRungeKuttaLlenado anterior = new VectorRungeKuttaLlenado(h, e);
            VectorRungeKuttaLlenado actual = anterior.siguiente();
            while (actual.X < e)
            {
                anterior = actual;
                actual = anterior.siguiente();
            }
            return actual.T;
        }

        public double rungeKuttaVaciado()
        {
            VectorRungeKuttaVaciado anterior = new VectorRungeKuttaVaciado(h, e);
            VectorRungeKuttaVaciado actual = anterior.siguiente();
            do
            {
                anterior = actual;
                actual = anterior.siguiente();
            } while (Math.Abs(anterior.X - actual.X) < 0.02);

            return actual.T;
        }


        private void cargarDgv(VectorRungeKuttaLlenado v)
        {
            dgvRungeKutta.Rows.Add(v.T, v.X, v.K1, v.Th2, v.Xk1h2, v.K2, v.Th2, v.Xk2h2, v.K3, v.Th, v.Xk3h, v.K4);
        }

        private void cargarDgv(VectorRungeKuttaVaciado v)
        {
            dgvRungeKutta.Rows.Add(v.T, v.X, v.K1, v.Th2, v.Xk1h2, v.K2, v.Th2, v.Xk2h2, v.K3, v.Th, v.Xk3h, v.K4);
        }
    }
}
