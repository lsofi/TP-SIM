using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace TP3.Distribuciones
{
    public class ExponencialNegativa : IDistribucion
    {
        private double lambda;
        private Random random = new Random();

        public ExponencialNegativa(double lambda)
        {
            this.lambda = lambda;
        }

        public double getRandomVar()
        {
            double x1 = -(1 / lambda) * Log(1.0 - random.NextDouble());
            return x1;
        }

        public float calcularProbabilidad(double mc, double desde, double hasta)
        {
            float probabilidad = (float) ((lambda * Math.Exp(-lambda * mc)) * (hasta - desde));

            return probabilidad;
        }

        public int getDatosEmpiricos()
        {
            return 1;
        }
    }

}
