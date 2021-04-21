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
    public partial class frmGraficoChiCuadrado : Form
    {
        private double[] numeros;
        private IDistribucion distribucion;
        private int cantIntervalos;
        Series Series2 = new Series();

        public frmGraficoChiCuadrado(double[] numeros, IDistribucion distribucion)
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

            double[,] intervalos = calcularIntervalos();
            double[] frecuenciaObservada = calcularFrecuenciaObservada(intervalos);
            

            for (int i = 0; i < frecuenciaObservada.Length; i++)
            {
                float marcaClase = (float)(intervalos[i, 0] + intervalos[i, 1]) / 2;
                float probabilidad = distribucion.calcularProbabilidad(marcaClase, intervalos[i, 0], intervalos[i, 1]);

                dgvTabla.Rows.Add(Math.Truncate(10000 * intervalos[i, 0]) / 10000, Math.Truncate(10000 * intervalos[i, 1]) / 10000, marcaClase, frecuenciaObservada[i], probabilidad, calcularFrecuenciaEsperada(probabilidad, numeros.Length));
            }

            generarGrafico(intervalos, frecuenciaObservada);
            chiCuadrado();
            lblCalculadoRes.Text = getAcumulado().ToString();
            lblCalculadoRes.Visible = true;
            lblTablaRes.Text = tablaChiCuadrado().ToString();
            lblTablaRes.Visible = true;
            conclusion();


        }

        private double[,] calcularIntervalos()
        {
            double max = numeros[0];
            double min = numeros[0];
            int n = numeros.Length;
            int cantIntervalos = Convert.ToInt32(txtCantInter.Text);

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > max) max = numeros[i];
                if (numeros[i] < min) min = numeros[i];
            }

            double diferencia = max - min;
            double ancho = diferencia / cantIntervalos;

            double[,] intervalos = new double[cantIntervalos,2];

            for (int i = 0; i < cantIntervalos; i++)
            {
                intervalos[i, 0] = min + (i * ancho) ;
                intervalos[i, 1] = min + ((i + 1) * ancho);
            }

            return intervalos;

        }

        private double[] calcularFrecuenciaObservada(double [,] intervalos)
        {
            double[] frecuencias = new double[cantIntervalos];

            for (int i = 0; i < numeros.Length ; i++)
            {
                for (int j = 0; j < cantIntervalos; j++)
                {
                    if(numeros[i] >= intervalos[j,0] && numeros[i] < intervalos[j,1])
                    {
                        frecuencias[j] += 1;
                        break;
                    }
                }
                    
            }

            return frecuencias;
        }

        private void txtCantInter_Leave(object sender, EventArgs e)
        {
            if(!(txtCantInter.Text == String.Empty))
            {
                if (!(int.TryParse(txtCantInter.Text, out cantIntervalos) && cantIntervalos > 0))
                {
                    MessageBox.Show("Datos ingresados no válidos. La cantidad de intervalos debe ser un número entero positivo.", "Cantidad intervalos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCantInter.Clear();
                    txtCantInter.Focus();
                }
            }
        }

        public float calcularFrecuenciaEsperada(float prob, int n)
        {
            return prob * n;
        }

        public void generarGrafico(double[,] intervalos, double[] frecuencia)
        {
            chrtDistribucion.Series["Series1"].Points.Clear();
            chrtDistribucion.Series["Series2"].Points.Clear();
            chrtDistribucion.Series["Series1"].LegendText = "Frecuencia observada";
            chrtDistribucion.Series["Series2"].LegendText = "Frecuencia esperada";

            Dictionary<string, double> dic = new Dictionary<string, double>();
            Dictionary<string, float> dic2 = new Dictionary<string, float>();

            for (int i = 0; i < frecuencia.Length; i++)
            {
                float marcaClase = (float)(intervalos[i, 0] + intervalos[i, 1]) / 2;
                dic.Add(intervalos[i, 0] + " - " + intervalos[i, 1], frecuencia[i]);
                dic2.Add(intervalos[i, 0] + " - " + intervalos[i, 1], calcularFrecuenciaEsperada(distribucion.calcularProbabilidad(marcaClase, intervalos[i, 0], intervalos[i, 1]), numeros.Length));
            }

            foreach (KeyValuePair<string, double> d in dic)
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
                string desde = dgvTabla.Rows[i].Cells["desde"].Value.ToString();
                string hasta = dgvTabla.Rows[i].Cells["hasta"].Value.ToString();
                float sumaEsperada = (float)Convert.ToDouble(dgvTabla.Rows[i].Cells["frecuenciaEsperada"].Value);
                int sumaObservada = Convert.ToInt32(dgvTabla.Rows[i].Cells["frecuenciaObservada"].Value);

                while (sumaEsperada < 5 || verificarProximos(i))
                {
                    if (i == dgvTabla.Rows.Count - 1)
                        break;
                    i++;
                    sumaEsperada += (float)Convert.ToDouble(dgvTabla.Rows[i].Cells["frecuenciaEsperada"].Value);
                    sumaObservada += Convert.ToInt32(dgvTabla.Rows[i].Cells["frecuenciaObservada"].Value);
                    hasta = dgvTabla.Rows[i].Cells["hasta"].Value.ToString();

                }
                float c = (float)Math.Pow(((float)sumaEsperada - (float)sumaObservada), 2) / sumaEsperada;
                cAcum += c;
                dgvChiCuadrado.Rows.Add(desde, hasta, sumaObservada, sumaEsperada, Math.Truncate(10000 * c) / 10000, Math.Truncate(10000 * cAcum) / 10000);
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
                txt = "Conclusión: La hipótesis se acepta, los datos se aproximan a una distribución uniforme.";
            else
                txt = "Conclusión: La hipótesis no se acepta, los datos no se aproximan a una distribución uniforme.";

            lblConclusion.Text = txt;
            lblConclusion.Visible = true;
        }

    }
}
