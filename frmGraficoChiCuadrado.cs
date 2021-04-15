using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GeneracionDeNumerosAleatorios.EstrategiasGraficoCantIntervalos;


namespace GeneracionDeNumerosAleatorios
{
    public partial class frmGraficoChiCuadrado : Form
    {
        private DataGridView numeros;
        private IEstrategiaGraficoCantIntervalos estrategia;
        public frmGraficoChiCuadrado(DataGridView numeros)
        {
            InitializeComponent();
            this.numeros = numeros;
        }

        private void btn5_CheckedChanged(object sender, EventArgs e)
        {
            estrategia = new Estrategia5Intervalos() ;
        }

        private void btn10_CheckedChanged(object sender, EventArgs e)
        {
            estrategia = new Estrategia10Intervalos();
        }

        private void btn15_CheckedChanged(object sender, EventArgs e)
        {
            estrategia = new Estrategia15Intervalos();
        }

        private void btn20_CheckedChanged(object sender, EventArgs e)
        {
            estrategia = new Estrategia20Intervalos();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dgvTabla.Rows.Clear();
            List<float> numerosAleatorios = new List<float>();
            for (int i = 0; i < numeros.Rows.Count; i++)
            {
                numerosAleatorios.Add((float)(Convert.ToDouble(numeros.Rows[i].Cells[1].Value)));
            }

            List<int> frecuenciaObservada = estrategia.frecuenciaObservada(numerosAleatorios);
            float[,] intervalos = estrategia.calcularIntervalos();

            for (int i = 0; i < frecuenciaObservada.Count; i++)
            {
                float marcaClase = (float)(intervalos[i, 0] + intervalos[i, 1]) / 2;
                dgvTabla.Rows.Add(intervalos[i, 0], intervalos[i, 1], marcaClase, frecuenciaObservada[i]);
            }
        }
    }
}
