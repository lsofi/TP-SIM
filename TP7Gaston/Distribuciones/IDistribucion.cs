using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7.Distribuciones
{
    public interface IDistribucion
    {
        double getRandomVar();

        float calcularProbabilidad(double mc, double desde, double hasta);

        int getDatosEmpiricos();

        string getNombre();
    }

}
