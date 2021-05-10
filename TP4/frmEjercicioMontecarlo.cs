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
        private IEstrategiaPedidos estrategia = new Estrategia1();
        private int diasAMostrar;
        private int diasASimular;
        private int diasDesde;
        public frmEjercicioMontecarlo()
        {
            InitializeComponent();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                dataGridView1.Rows.Clear();
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
                    actual.AleatorioDemanda = Math.Round(random.NextDouble(),2);
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
                        actual.GananciaReventa = actual.Stock * 0.2;
                    }
                    actual.CostoPeriodicos = 0.8 * actual.Pedido;
                    actual.CostoTotal = actual.CostoPeriodicos + actual.CostoFaltante - actual.GananciaReventa;
                    actual.AcumuladorCostos += actual.CostoTotal;
                    if (i >= Convert.ToInt32(txtMostrarDesde.Text) - 1 && i+1 < Convert.ToInt32(txtMostrarDesde.Text) + Convert.ToInt32(txtCantidadMostrar.Text))
                    {
                        dataGridView1.Rows.Add(actual.Reloj, actual.AleatorioDemanda, actual.Demanda, actual.Pedido, actual.Stock, actual.CostoPeriodicos, actual.CostoFaltante, actual.GananciaReventa, actual.CostoTotal, actual.AcumuladorCostos);
                    }
                }
                if(diasAMostrar + diasDesde <= diasASimular)
                {
                    dataGridView1.Rows.Add(actual.Reloj, actual.AleatorioDemanda, actual.Demanda, actual.Pedido, actual.Stock, actual.CostoPeriodicos, actual.CostoFaltante, actual.GananciaReventa, actual.CostoTotal, actual.AcumuladorCostos);
                }
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

        private void rbtEstrategia1_CheckedChanged(object sender, EventArgs e)
        {
            borrarCampos();
            this.estrategia = new Estrategia1();
            btnSimular.Enabled = true;

        }

        private void rbtEstrategia2_CheckedChanged(object sender, EventArgs e)
        {
            borrarCampos();
            this.estrategia = new Estrategia2();
            btnSimular.Enabled = true;
        }

        private bool validarCampos()
        {
            if (!(int.TryParse(txtCantidadMostrar.Text, out diasAMostrar) && diasAMostrar > 0))
            {
                MessageBox.Show("Por favor ingrese una cantidad de dias a mostrar valida.", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(!(int.TryParse(txtDias.Text, out diasASimular) && diasASimular> 0))
            {
                MessageBox.Show("Por favor ingrese una cantidad de dias a simular valida.", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(int.TryParse(txtMostrarDesde.Text, out diasDesde) && diasDesde > 0 && diasDesde <= diasASimular))
            {
                MessageBox.Show("Por favor ingrese un dia para mostrar desde valido.", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void borrarCampos()
        {
            txtCantidadMostrar.Text = txtDias.Text = txtMostrarDesde.Text = "";
            dataGridView1.Rows.Clear();
        }

    }
}
