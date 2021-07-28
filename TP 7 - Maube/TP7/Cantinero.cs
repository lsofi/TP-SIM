using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7
{
    class Cantinero
    {
        private String estado;
        private double tiempoTrabajando;
        private double tiempoSirviendo;
        private double tiempoLavando;
        private double tiempoRecogiendo;

        public Cantinero()
        {
            estado = "Libre";
            tiempoTrabajando = 0;
            tiempoSirviendo = 0;
            tiempoLavando = 0;
            tiempoRecogiendo = 0;
        }

        public string Estado { get => estado; set => estado = value; }
        public double TiempoTrabajando { get => tiempoTrabajando; set => tiempoTrabajando = value; }
        public double TiempoSirviendo { get => tiempoSirviendo; set => tiempoSirviendo = value; }
        public double TiempoLavando { get => tiempoLavando; set => tiempoLavando = value; }
        public double TiempoRecogiendo { get => tiempoRecogiendo; set => tiempoRecogiendo = value; }

        public double getPorcentajeTiempoSirviendo()
        {
            double porcentaje = (tiempoSirviendo / tiempoTrabajando) * 100;
            return Math.Round(porcentaje, 2);
        }
        public double getPorcentajeTiempoLavando()
        {
            double porcentaje = (tiempoLavando / tiempoTrabajando) * 100;
            return Math.Round(porcentaje, 2);
        }
        public double getPorcentajeTiempoRecogiendo()
        {
            double porcentaje = (tiempoRecogiendo / tiempoTrabajando) * 100;
            return Math.Round(porcentaje, 2);
        }

    }
}
