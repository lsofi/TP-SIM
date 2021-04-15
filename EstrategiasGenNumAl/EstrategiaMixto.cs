using System;
using System.Collections.Generic;
using System.Text;

namespace GeneracionDeNumerosAleatorios
{
    class EstrategiaMixto : IEstrategiaNumAleatorio
    {
        
        public override bool validarK(int k)
        {
            return k > 0;
        }
        public override string stringVerk()
        {
            return "Datos ingresados no válidos. La variable K debe ser un número entero positivo.";
        }

        public override int calcularA(int k)
        {
            return 1 + 4 * k;
        }

        public bool sonPrimos(int a, int b)
        {
            int mayor = Math.Max(a, b);
            int menor = Math.Min(a, b);
            int res;
            do
            {
                res = menor;
                menor = mayor % menor;
                mayor = res;
            } while (menor != 0);

            if (res == 1)
                return true;

            return false;
        }

        public override bool verificarMyCPrimos(double m, int c)
        {
            return sonPrimos((int)m, c);
        }

        public override double[] calcularSiguiente(int xi, int a, int c, double m)
        {
            double[] vector = new double[2];
            vector[1] = (a * xi + c) % m;
            vector[0] = vector[1] / (m);
            return vector;
            
        }
    }
}
