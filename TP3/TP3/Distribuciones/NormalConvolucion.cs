using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace TP3.Distribuciones
{
    public class NormalConvolucion : IDistribucion
    {
        private double media;
        private double desviacionEstandar;
        private Random random = new Random();
        public NormalConvolucion(double media, double desviacionEstandar)
        {
            this.media = media;
            this.desviacionEstandar = desviacionEstandar;
        }


        public double getRandomVar()
        {
            double ac = 0.0;
            for (int i = 0; i < 12; i++)
            {
                ac += random.NextDouble();
            }
            ac -= 6.0;
            
            double x = ac*desviacionEstandar + media;
            return x;
        }

        public float calcularProbabilidad(double mc, double desde, double hasta)
        {
            float probabilidad = (float)(((Math.Exp((-0.5) * Math.Pow(((mc - media) / desviacionEstandar), 2))) / (desviacionEstandar * Sqrt(2 * PI))) * (hasta - desde));

            return probabilidad;
        }

        public int getDatosEmpiricos()
        {
            return 2;
        }

        public string getNombre()
        {
            return "Normal";
        }

    }
}
