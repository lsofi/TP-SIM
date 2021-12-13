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
        private int capacidadVaso;
        private int numCliente = 0;


        public frmRungeKutta(double h, int capacidadVaso)
        {
            InitializeComponent();
            this.h = h;
            this.capacidadVaso = capacidadVaso;

        }

        public double rungeKuttaConsumoCargaDGV(double t)
        {
            numCliente++;
            VectorRungeKuttaConsumo anterior = new VectorRungeKuttaConsumo(t,capacidadVaso,h);
            anterior.calcularValores();
            cargarDgv(anterior);
            VectorRungeKuttaConsumo actual = anterior.siguiente();
            cargarDgv(actual);
            do
            {
                anterior = actual;
                actual = anterior.siguiente();
                cargarDgv(actual);
            } while (actual.X > 0);
            dgvRungeKutta.Rows[dgvRungeKutta.Rows.Count - 1].Cells[2].Style.BackColor = Color.LightBlue;
            dgvRungeKutta.Rows[dgvRungeKutta.Rows.Count - 1].Cells[1].Style.BackColor = Color.LightBlue;
            
            return actual.T;
        }
        public double rungeKuttaConsumoNoCargaDGV(double t)
        {
            numCliente++;
            VectorRungeKuttaConsumo anterior = new VectorRungeKuttaConsumo(t, capacidadVaso, h);
            anterior.calcularValores();
            VectorRungeKuttaConsumo actual = anterior.siguiente();
            do
            {
                anterior = actual;
                actual = anterior.siguiente();
            } while (actual.X > 0);

            return actual.T;
        }

        private void cargarDgv(VectorRungeKuttaConsumo v)
        {
            dgvRungeKutta.Rows.Add(numCliente, v.T, v.X, v.K1, v.Th2, v.Xk1h2, v.K2, v.Th2, v.Xk2h2, v.K3, v.Th, v.Xk3h, v.K4);
        }

        private void frmRungeKutta_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true ;
        }
    }
}
