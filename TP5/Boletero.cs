using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    public class Boletero
    {
        private String estado;
        private double inicioOcupacion;

        public string Estado { get => estado; set => estado = value; }
        public double InicioOcupacion { get => inicioOcupacion; set => inicioOcupacion = value; }

        public Boletero()
        {
            this.estado = "libre";
        }
    }
}
