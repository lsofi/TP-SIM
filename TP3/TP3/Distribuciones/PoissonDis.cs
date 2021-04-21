using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.Distribuciones
{
    public class PoissonDis : IDistribucion
    {
        private double lambda;
        private Random random = new Random();


        public PoissonDis(double lambda)
        {
            this.lambda = lambda;
        }
        public double getRandomVar()
        {
            double p = 1;
            double x = -1;
            double a = Math.Exp(-lambda);
            do
            {
                double u = random.NextDouble();
                p = p * u;
                x += 1;
            }
            while (p >= a);
            return x;
        }

        public float calcularProbabilidad(double mc, double desde, double hasta)
        {
            double factorial = 1;
            for (int i = 1; i <= mc; i++)
            {
                factorial *= i;
            }

            float probabilidad = (float) ((Math.Pow(lambda, mc) * Math.Exp(-lambda)) / factorial);

            return probabilidad;
        }

        public int getDatosEmpiricos()
        {
            return 1;
        }
    }
}
