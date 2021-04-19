using System;
using System.Collections.Generic;
using System.Text;

namespace GeneracionDeNumerosAleatorios.EstrategiasGraficoCantIntervalos
{
    class Estrategia15Intervalos : IEstrategiaGraficoCantIntervalos
    {

        public override List<int> frecuenciaObservada(List<float> valoresAleatorios)
        {
            List<int> fo = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < valoresAleatorios.Count; i++)
            {
                int posicion = (int)Math.Truncate((float)valoresAleatorios[i] / (float)0.06666666667);
                fo[posicion] = fo[posicion] + 1;
            }

            return fo;
        }

        public override float[,] calcularIntervalos()
        {
            float[,] intervalos = new float[15, 2];
            for (int i = 0; i < 15; i++)
            {
                intervalos[i, 0] = (float)0.06666666667 * i;
                intervalos[i, 1] = (float)(0.06666666667 * i + 0.06666666666);
            }
            return intervalos;
        }

        public override int cantInt()
        {
            return 15;
        }
    }
}
