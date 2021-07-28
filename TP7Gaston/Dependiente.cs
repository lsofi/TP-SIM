using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7
{
    class Dependiente
    {
        private String estado;
        private double horaInicioOcupacion;
        private Cliente clienteAtendido;
        private double proximoFinHacerEntender;
        private int tareasDependiente;
        private double proximoFinOtraTarea;

        public string Estado { get => estado; set => estado = value; }
        public double HoraInicioOcupacion { get => horaInicioOcupacion; set => horaInicioOcupacion = value; }
        public Cliente ClienteAtendido { get => clienteAtendido; set => clienteAtendido = value; }
        public double ProximoFinHacerEntender { get => proximoFinHacerEntender; set => proximoFinHacerEntender = value; }
        public int TareasDependiente { get => tareasDependiente; set => tareasDependiente = value; }
        public double ProximoFinOtraTarea { get => proximoFinOtraTarea; set => proximoFinOtraTarea = value; }

        public Dependiente()
        {
            estado = "Libre";
            horaInicioOcupacion = 0;
            clienteAtendido = null;
            tareasDependiente = 0;
            proximoFinOtraTarea = -1;
        }

        public bool estaLibre()
        {
            return estado == "Libre";
        }
    }
}
