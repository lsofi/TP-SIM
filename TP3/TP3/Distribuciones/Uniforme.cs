using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.Distribuciones
{
    public class Uniforme : IDistribucion
    {
        private double a;
        private double b;
        private Random random = new Random();
        public Uniforme(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public double getRandomVar()
        {
            double x = a + random.NextDouble() * (b - a);
            return x;
        }

        public float calcularProbabilidad(double mc, double desde, double hasta)
        {
            float probabilidad = (float) ((hasta-desde)/(b-a));

            return (float) Math.Round(probabilidad,4);
        }

        public int getDatosEmpiricos()
        {
            return 0;
        }
    }

}
