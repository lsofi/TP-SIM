using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP4.EstrategiaPedidos;

namespace TP4
{
    public partial class frmEjercicioMontecarlo : Form
    {
        private Random random = new Random();
        private IEstrategiaPedidos estrategia;
        public frmEjercicioMontecarlo()
        {
            InitializeComponent();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            VectorEstado anterior = new VectorEstado();
            VectorEstado actual = new VectorEstado();
            VectorEstado aux;
            actual.Reloj = 0;
            actual.Demanda = 20;
            actual.Pedido = 17;
            actual.AcumuladorCostos = 0;
            for (int i = 0; i < Convert.ToInt64(txtDias.Text); i++)
            {
                aux = anterior;
                anterior = actual;
                actual = aux;
                actual.Reloj = anterior.Reloj + 1;
                actual.AleatorioDemanda = random.NextDouble();
                actual.Demanda = calcularDemanda(actual.AleatorioDemanda);
                estrategia.calcularCantidadPedidos(anterior, actual);
                if (actual.Pedido < actual.Demanda)
                {
                    actual.Stock = 0;
                    actual.CostoFaltante = (actual.Demanda - actual.Pedido) * 0.4;
                }
                else
                {
                    actual.Stock = actual.Pedido - actual.Demanda;
                    actual.CostoFaltante = 0;
                }
                actual.CostoPeriodicos = 0.8 * actual.Pedido;
                actual.CostoMantenimiento = actual.Stock * 0.6;
                actual.CostoTotal = actual.CostoPeriodicos + actual.CostoMantenimiento + actual.CostoFaltante;
                actual.AcumuladorCostos += actual.CostoTotal;
            }
        }

        private int calcularDemanda(double aleatorio)
        {
            int demanda = 0;
            if (aleatorio < 0.3)
            {
                demanda = 20;
            }
            else
            {
                if (aleatorio < 0.55)
                {
                    demanda = 21;
                }
                else
                {
                    if (aleatorio < 0.75)
                    {
                        demanda = 22;
                    }
                    else
                    {
                        if (aleatorio < 0.9)
                        {
                            demanda = 23;
                        }
                        else
                        {
                            if (aleatorio < 0.95)
                            {
                                demanda = 24;
                            }
                            else
                            {
                                demanda = 25;
                            }
                        }
                    }
                }
            }
            return demanda;
        }
    }
}
