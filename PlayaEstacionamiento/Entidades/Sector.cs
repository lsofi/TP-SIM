using System;
using System.Collections.Generic;
using System.Text;

namespace PlayaEstacionamiento
{
    class Sector
    {
        private int idSector;
        private string estado;
        private double fin_estacionamiento;
        private string tipo_vehiculo;
        private Vehiculo vehiculo;

        public Sector(string tipo, int idSector)
        {
            this.IdSector = idSector;
            this.Tipo_vehiculo = tipo;
            this.Estado = "Libre";
            this.Fin_estacionamiento = 0;
        }

        public string Estado { get => estado; set => estado = value; }
        public double Fin_estacionamiento { get => fin_estacionamiento; set => fin_estacionamiento = value; }
        public string Tipo_vehiculo { get => tipo_vehiculo; set => tipo_vehiculo = value; }
        public int IdSector { get => idSector; set => idSector = value; }
        internal Vehiculo Vehiculo { get => vehiculo; set => vehiculo = value; }
    }
}
