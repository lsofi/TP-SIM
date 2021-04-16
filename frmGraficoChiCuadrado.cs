using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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
            estrategia = new Estrategia5Intervalos();
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
            chrtDistribucion.Series["Series1"].Points.Clear();
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
                float probabilidad = calcularProbabilidad(intervalos[i, 0], intervalos[i, 1]);

                dgvTabla.Rows.Add(intervalos[i, 0], intervalos[i, 1], marcaClase, frecuenciaObservada[i], probabilidad, calcularFrecuenciaEsperada(probabilidad, numerosAleatorios.Count));
            }

            generarGrafico(intervalos, frecuenciaObservada);
        }

        public void generarGrafico(float[,] intervalos, List<int> frecuencia)
        {
            Series Series2 = new Series();
            chrtDistribucion.Series.Add(Series2);
            chrtDistribucion.Series["Series1"].LegendText = "Frecuencia observada";
            chrtDistribucion.Series["Series2"].LegendText = "Frecuencia esperada";

            Dictionary<string, int> dic = new Dictionary<string, int>();
            Dictionary<string, float> dick = new Dictionary<string, float>();

            for (int i = 0; i < frecuencia.Count; i++)
            {
                dic.Add(intervalos[i, 0] + " - " + intervalos[i, 1], frecuencia[i]);
                dick.Add(intervalos[i, 0] + " - " + intervalos[i, 1],calcularFrecuenciaEsperada(calcularProbabilidad(intervalos[i, 0], intervalos[i, 1]), numeros.Rows.Count));
            }

            foreach (KeyValuePair<string, int> d in dic)
            {
                chrtDistribucion.Series["Series1"].Points.AddXY(d.Key, d.Value);
            }

            foreach (KeyValuePair<string, float> d in dick)
            {
                chrtDistribucion.Series["Series2"].Points.AddXY(d.Key, d.Value);
            }
        }

        public float calcularProbabilidad(float desde, float hasta)
        {
            float prob = (1 / (float) estrategia.cantInt());
            return prob;
        }

        public float calcularFrecuenciaEsperada(float prob, int n)
        {
            return prob * n;
        }
    }
}
