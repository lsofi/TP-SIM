using System;
using System.Collections.Generic;
using System.Text;

namespace GeneracionDeNumerosAleatorios.EstrategiasGraficoCantIntervalos
{
    class Estrategia10Intervalos : IEstrategiaGraficoCantIntervalos
    {

        public override List<int> frecuenciaObservada(List<float> valoresAleatorios)
        {
            List<int> fo = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            for (int i = 0; i < valoresAleatorios.Count; i++)
            {
                int posicion = (int)Math.Truncate((float)valoresAleatorios[i] / (float)0.1);
                fo[posicion] = fo[posicion] + 1;
            }

            return fo;
        }

        public override float[,] calcularIntervalos()
        {
            float[,] intervalos = new float[10, 2];
            for (int i = 0; i < 10; i++)
            {
                intervalos[i, 0] = (float)0.10 * i;
                intervalos[i, 1] = (float)(0.10 * i + 0.0999);
            }
            return intervalos;
        }
    }
}
