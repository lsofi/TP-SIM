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
        private Boolean atendido = false;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Edad { get => edad; set => edad = value; }
        public double HoraEntradaCola { get => horaEntradaCola; set => horaEntradaCola = value; }
        public bool Atendido { get => atendido; set => atendido = value; }

        public Cliente(int edad)
        {
            this.edad = edad;
        }
    }
}
