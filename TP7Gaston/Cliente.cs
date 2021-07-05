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
        private int edad;
        private double horaEntradaCola;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Edad { get => edad; set => edad = value; }
        public double HoraEntradaCola { get => horaEntradaCola; set => horaEntradaCola = value; }

        public Cliente(int edad)
        {
            this.edad = edad;
        }
    }
}
