using System;
using System.Collections.Generic;
using System.Text;

namespace GeneracionDeNumerosAleatorios
{
    class EstrategiaMultiplicativo : IEstrategiaNumAleatorio
    {
        public override bool validarK(int k)
        {
            return k >= 0;
        }
        public override string stringVerk()
        {
            return "Datos ingresados no válidos. La variable k debe ser un número entero no negativo.";
        }

        public override int calcularA(int k)
        {
            return 3 + 8 * k;
        }

        public override bool validarX0impar(int x0)
        {
            return x0%2 != 0;
        }

        public override double[] calcularSiguiente(int xi, int a, int c, double m)
        {
            double[] vector = new double[2];
            vector[1] = (a * xi) % m;
            vector[0] = vector[1] / (m);
            return vector;

        }
    }
}
