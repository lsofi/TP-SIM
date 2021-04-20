using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace TP3.Distribuciones
{
    public class Normal
    {
        private double media;
        private double desviacionEstandar;
        private Random random = new Random();
        public Normal(double media, double desviacionEstandar)
        {
            this.media = media;
            this.desviacionEstandar = desviacionEstandar;
        }

        public double[] getRandomVarBoxMuller()
        {
            double[] vector = new double[2];
            double RND1 = random.NextDouble();
            double RND2 = random.NextDouble();
            double x = Sqrt(-2*Log(RND1)) * Cos(2*PI*RND2);
            double y = Sqrt(-2 * Log(RND1)) * Sin(2 * PI * RND2);
            vector[0] = x * desviacionEstandar + media;
            vector[1] = y * desviacionEstandar + media;
            return vector;
        }

        public double getRandomVarConvolucion()
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
    }
}
