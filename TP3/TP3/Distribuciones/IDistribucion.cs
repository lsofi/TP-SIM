using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.Distribuciones
{
    public interface IDistribucion
    {
        public abstract double getRandomVar();

        public abstract float calcularProbabilidad(double mc, double desde, double hasta);

        public abstract int getDatosEmpiricos();

        public abstract string getNombre();
    }

}
