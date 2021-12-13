using System;
using System.Collections.Generic;
using System.Text;

namespace PlayaEstacionamiento
{
    class Vehiculo
    {
        public static int cantVeh;
        private string nombre;
        private string tipo;
        private int horas_estacionamiento;
        private string estado;
        private bool abonado;

        public Vehiculo(string tipo, int horas_estacionamiento, string estado)
        {
            cantVeh++;
            this.nombre = "Vehículo " +cantVeh;
            this.Tipo = tipo;
            this.Horas_estacionamiento = horas_estacionamiento;
            this.estado = estado;
            this.Abonado = false;
        }

        

        public string Tipo { get => tipo; set => tipo = value; }
        public int Horas_estacionamiento { get => horas_estacionamiento; set => horas_estacionamiento = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public bool Abonado { get => abonado; set => abonado = value; }

        public void setParametros(string tipo, int horas, string estado)
        {
            this.tipo = tipo;
            this.Horas_estacionamiento = horas;
            this.estado = estado;
            this.Abonado = false;
        }


    }
}
