using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace TP7.Distribuciones
{
    public class NormalMuller : IDistribucion
    {
        private double media;
        private double desviacionEstandar;
        private Random random = new Random();
        public NormalMuller(double media, double desviacionEstandar)
        {
            this.media = media;
            this.desviacionEstandar = desviacionEstandar;
        }

        public double getRandomVar()
        {
            double[] vector = new double[2];
            double RND1 = random.NextDouble();
            double RND2 = random.NextDouble();
            double x = Sqrt(-2*Log(RND1)) * Cos(2*PI*RND2);
            double y = Sqrt(-2 * Log(RND1)) * Sin(2 * PI * RND2);
            vector[0] = x * desviacionEstandar + media;
            vector[1] = y * desviacionEstandar + media;
            return vector[0];
        }

        public float calcularProbabilidad(double mc, double desde, double hasta)
        {
            float probabilidad = (float) (((Math.Exp((-0.5) * Math.Pow(((mc - media) / desviacionEstandar), 2))) / (desviacionEstandar * Sqrt(2 * PI)))*(hasta-desde));

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
