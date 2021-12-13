using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7
{
    class Cliente
    {
        private String nombre;
        private String estado;
        private double horaLlegada;
        private double finConsumo;

        public Cliente(String nom, String est, double hora)
        {
            this.nombre = nom;
            this.Estado = est;
            this.horaLlegada = hora;
            this.finConsumo = -1;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public double HoraLlegada { get => horaLlegada; set => horaLlegada = value; }
        public double FinConsumo { get => finConsumo; set => finConsumo = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
