using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using GeneracionDeNumerosAleatorios.EstrategiasGraficoCantIntervalos;
using MathNet.Numerics.Distributions;

namespace GeneracionDeNumerosAleatorios
{
    public partial class frmGraficoChiCuadrado : Form
    {
        private DataGridView numeros;
        private IEstrategiaGraficoCantIntervalos estrategia;
        Series Series2 = new Series();
        Series Series3 = new Series();

        public frmGraficoChiCuadrado(DataGridView numeros)
        {
            InitializeComponent();
            this.numeros = numeros;
            chrtDistribucion.Series.Add(Series2);
            chrtChi.Series.Add(Series3);
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
            dgvChiCuadrado.Rows.Clear();
            chrtDistribucion.Visible = true;
            chrtChi.Visible = true;
            
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

                dgvTabla.Rows.Add(Math.Truncate(10000 * intervalos[i, 0]) / 10000, Math.Truncate(10000 * intervalos[i, 1]) / 10000, marcaClase, frecuenciaObservada[i], probabilidad, calcularFrecuenciaEsperada(probabilidad, numerosAleatorios.Count));
            }

            generarGrafico(intervalos, frecuenciaObservada);
            string[,] intervalosChi = chiCuadrado();
            generarGraficoChi(intervalosChi);
            lblCalculadoRes.Text = getAcumulado().ToString();
            lblCalculadoRes.Visible = true;
            lblTablaRes.Text = tablaChiCuadrado().ToString();
            lblTablaRes.Visible = true;
            conclusion();


        }

        public void generarGrafico(float[,] intervalos, List<int> frecuencia)
        {
            chrtDistribucion.Series["Series1"].Points.Clear();
            chrtDistribucion.Series["Series2"].Points.Clear();
            chrtDistribucion.Series["Series1"].LegendText = "Frecuencia observada";
            chrtDistribucion.Series["Series2"].LegendText = "Frecuencia esperada";

            Dictionary<string, int> dic = new Dictionary<string, int>();
            Dictionary<string, float> dic2 = new Dictionary<string, float>();

            for (int i = 0; i < frecuencia.Count; i++)
            {
                dic.Add(intervalos[i, 0] + " - " + intervalos[i, 1], frecuencia[i]);
                dic2.Add(intervalos[i, 0] + " - " + intervalos[i, 1],calcularFrecuenciaEsperada(calcularProbabilidad(intervalos[i, 0], intervalos[i, 1]), numeros.Rows.Count));
            }

            foreach (KeyValuePair<string, int> d in dic)
            {
                chrtDistribucion.Series["Series1"].Points.AddXY(d.Key, d.Value);
            }

            foreach (KeyValuePair<string, float> d in dic2)
            {
                chrtDistribucion.Series["Series2"].Points.AddXY(d.Key, d.Value);
            }

        }

        public void generarGraficoChi(string[,] intervalos)
        {
            chrtChi.Series["Series1"].Points.Clear();
            chrtChi.Series["Series2"].Points.Clear();
            chrtChi.Series["Series1"].LegendText = "Frecuencia observada";
            chrtChi.Series["Series2"].LegendText = "Frecuencia esperada";

            Dictionary<string, int> dic3 = new Dictionary<string, int>();
            Dictionary<string, float> dic4 = new Dictionary<string, float>();

            int i = 0;
            while(i < intervalos.GetLength(0) && !(intervalos[i, 0] == null))
            {
                dic3.Add(intervalos[i, 0] + " - " + intervalos[i, 1], Convert.ToInt32(intervalos[i,2]));
                dic4.Add(intervalos[i, 0] + " - " + intervalos[i, 1], (float) Convert.ToDouble(intervalos[i, 3]));
                i++;
            }

            foreach (KeyValuePair<string, int> d in dic3)
            {
                chrtChi.Series["Series1"].Points.AddXY(d.Key, d.Value);
            }

            foreach (KeyValuePair<string, float> d in dic4)
            {
                chrtChi.Series["Series2"].Points.AddXY(d.Key, d.Value);
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

        public string[,] chiCuadrado()
        {
            float cAcum = 0;
            String[,] intervalos = new String[dgvTabla.Rows.Count, 4];
            int j = 0;
            for (int i = 0; i < dgvTabla.Rows.Count; i++)
            {
                string desde = dgvTabla.Rows[i].Cells["desde"].Value.ToString();
                string hasta = dgvTabla.Rows[i].Cells["hasta"].Value.ToString();
                float sumaEsperada = (float) Convert.ToDouble(dgvTabla.Rows[i].Cells["frecuenciaEsperada"].Value);
                int sumaObservada = Convert.ToInt32(dgvTabla.Rows[i].Cells["frecuenciaObservada"].Value);

                while (sumaEsperada < 5 || verificarProximos(i))
                {
                    if (i == dgvTabla.Rows.Count - 1)
                        break;
                    i++;
                    sumaEsperada += (float) Convert.ToDouble(dgvTabla.Rows[i].Cells["frecuenciaEsperada"].Value);
                    sumaObservada += Convert.ToInt32(dgvTabla.Rows[i].Cells["frecuenciaObservada"].Value);
                    hasta = dgvTabla.Rows[i].Cells["hasta"].Value.ToString();
                    
                }
                float c = (float) Math.Pow(((float) sumaEsperada - (float) sumaObservada),2)/sumaEsperada;
                cAcum += c;
                dgvChiCuadrado.Rows.Add(desde, hasta, sumaObservada, sumaEsperada, Math.Truncate(10000 * c) / 10000, Math.Truncate(10000 * cAcum) / 10000);
                intervalos[j,0] = desde;
                intervalos[j, 1] = hasta;
                intervalos[j, 2] = sumaObservada.ToString();
                intervalos[j, 3] = sumaEsperada.ToString();
                j++;
            }

            return intervalos;

        }

        public bool verificarProximos(int i)
        {
            int suma = 0;
            for (int j = i + 1; j < dgvTabla.Rows.Count; j++)
            {
                suma += Convert.ToInt32(dgvTabla.Rows[j].Cells["frecuenciaEsperada"].Value);
            }
            return suma < 5;
        }

        public float getAcumulado()
        {
            return (float)Convert.ToDouble(dgvChiCuadrado.Rows[dgvChiCuadrado.Rows.Count - 1].Cells["cAcumulativo"].Value);
        }


        public float tablaChiCuadrado()
        {
            return (float) Math.Round(ChiSquared.InvCDF(dgvChiCuadrado.Rows.Count - 1, 0.95),4);
        }

        private void lblTabla_Click(object sender, EventArgs e)
        {

        }

        public void conclusion()
        {
            string txt;
            if (getAcumulado() < tablaChiCuadrado())
                txt = "Conclusión: La hipótesis se acepta, los datos se aproximan a una distribución uniforme.";
            else
                txt = "Conclusión: La hipótesis no se acepta, los datos no se aproximan a una distribución uniforme.";

            lblConclusion.Text = txt;
            lblConclusion.Visible = true;
        }
    }
}
