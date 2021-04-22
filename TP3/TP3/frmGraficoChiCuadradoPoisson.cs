using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TP3.Distribuciones;

namespace TP3
{
    public partial class frmGraficoChiCuadradoPoisson : Form
    {
        private double[] numeros;
        private IDistribucion distribucion;
        private int cantIntervalos;
        Series Series2 = new Series();

        public frmGraficoChiCuadradoPoisson(double[] numeros, IDistribucion distribucion)
        {
            InitializeComponent();
            this.numeros = numeros;
            this.distribucion = distribucion;
            chrtDistribucion.Series.Add(Series2);

        }

        private void btnGenerar_Click_1(object sender, EventArgs e)
        {
            
            dgvTabla.Rows.Clear();
            dgvChiCuadrado.Rows.Clear();
            chrtDistribucion.Visible = true;

            int[] intervalos = calcularIntervalos();
            int[] frecuenciaObservada = calcularFrecuenciaObservada(intervalos);
            

            for (int i = 0; i < frecuenciaObservada.Length; i++)
            {
                float probabilidad = distribucion.calcularProbabilidad(intervalos[i],0,0);

                dgvTabla.Rows.Add(intervalos[i], frecuenciaObservada[i], probabilidad, probabilidad * numeros.Length);
            }

            generarGrafico(intervalos, frecuenciaObservada);
            chiCuadrado();
            lblCalculadoRes.Text = getAcumulado().ToString();
            lblCalculadoRes.Visible = true;
            lblTablaRes.Text = tablaChiCuadrado().ToString();
            lblTablaRes.Visible = true;
            conclusion();


        }

        private int[] calcularIntervalos()
        {
            int max = (int) numeros[0];
            int min = (int) numeros[0];

            for (int i = 1; i < numeros.Length; i++) 
            {
                if (numeros[i] > max) max = (int) numeros[i];
                if (numeros[i] < min) min = (int) numeros[i];
            }

            cantIntervalos = max - min;

            int[] intervalos = new int[cantIntervalos];

            for (int i = 0; i < cantIntervalos; i++)
            {
                intervalos[i] = min + i ;
            }

            return intervalos;

        }

        private int[] calcularFrecuenciaObservada(int [] intervalos)
        {
            int[] frecuencias = new int[cantIntervalos];

            for (int i = 0; i < numeros.Length ; i++)
            {
                for (int j = 0; j < cantIntervalos; j++)
                {
                    if((int) numeros[i] == intervalos[j])
                    {
                        frecuencias[j] += 1;
                        break;
                    }
                }
            }

            return frecuencias;
        }



        public float calcularFrecuenciaEsperada(float prob, int n)
        {
            return prob * n;
        }

        public void generarGrafico(int[] intervalos, int[] frecuencia)
        {
            chrtDistribucion.Series["Series1"].Points.Clear();
            chrtDistribucion.Series["Series2"].Points.Clear();
            chrtDistribucion.Series["Series1"].LegendText = "Frecuencia observada";
            chrtDistribucion.Series["Series2"].LegendText = "Frecuencia esperada";

            Dictionary<string, int> dic = new Dictionary<string, int>();
            Dictionary<string, float> dic2 = new Dictionary<string, float>();

            for (int i = 0; i < frecuencia.Length; i++)
            {
                dic.Add(intervalos[i].ToString(), frecuencia[i]);
                dic2.Add(intervalos[i].ToString(), calcularFrecuenciaEsperada(distribucion.calcularProbabilidad(intervalos[i],0,0), numeros.Length));
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

        public void chiCuadrado()
        {
            float cAcum = 0;
            for (int i = 0; i < dgvTabla.Rows.Count; i++)
            {
                string valor = dgvTabla.Rows[i].Cells["valor"].Value.ToString();
                float sumaEsperada = (float)Convert.ToDouble(dgvTabla.Rows[i].Cells["frecuenciaEsperada"].Value);
                int sumaObservada = Convert.ToInt32(dgvTabla.Rows[i].Cells["frecuenciaObservada"].Value);

                while (sumaEsperada < 5 || verificarProximos(i))
                {
                    if (i == dgvTabla.Rows.Count - 1)
                        break;
                    i++;
                    sumaEsperada += (float)Convert.ToDouble(dgvTabla.Rows[i].Cells["frecuenciaEsperada"].Value);
                    sumaObservada += Convert.ToInt32(dgvTabla.Rows[i].Cells["frecuenciaObservada"].Value);
                    valor += ";" + dgvTabla.Rows[i].Cells["valor"].Value.ToString();

                }
                float c = (float)Math.Pow(((float)sumaEsperada - (float)sumaObservada), 2) / sumaEsperada;
                cAcum += c;
                dgvChiCuadrado.Rows.Add(valor, sumaObservada, sumaEsperada, Math.Truncate(10000 * c) / 10000, Math.Truncate(10000 * cAcum) / 10000);
            }
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
            int gradosLibertad = dgvChiCuadrado.Rows.Count - 1 - distribucion.getDatosEmpiricos();
            if (gradosLibertad < 1) gradosLibertad = 1;
            return (float)Math.Round(ChiSquared.InvCDF(gradosLibertad, 0.95), 4);
        }

        public void conclusion()
        {
            string txt;
            if (getAcumulado() < tablaChiCuadrado())
                txt = "Conclusión: La hipótesis se acepta, los datos se aproximan a una distribución " + distribucion.getNombre() + "." ;
            else
                txt = "Conclusión: La hipótesis no se acepta, los datos no se aproximan a una distribución " + distribucion.getNombre() + ".";

            lblConclusion.Text = txt;
            lblConclusion.Visible = true;
        }
    }
}
