using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.Distribuciones
{
    public class Poisson : IDistribucion
    {
        private double lambda;
        private Random random = new Random();
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
    }
}
