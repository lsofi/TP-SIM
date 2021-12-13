using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PlayaEstacionamiento
{
    class Playa
    {
        private int linea;
        private string evento;
        private double reloj;
        private double rndLlegadaVehiculo;
        private double llegadaVehiculo;
        private double proximaLlegadaVehiculo;
        private double rndTipoVehiculo;
        private string tipoVehiculo;
        private double rndTiempoVehiculo;
        private int tiempoVehiculo;
        private Sector[] sectores;
        private List<Vehiculo> vehiculos;
        private Caja caja;
        private int lugaresPeqDisponibles;
        private int lugaresGrandDisponibles;
        private int lugaresUtilDisponibles;
        private double recaudacion;


        public int Linea { get => linea; set => linea = value; }
        public string Evento { get => evento; set => evento = value; }
        public double Reloj { get => reloj; set => reloj = value; }
        public double RndLlegadaVehiculo { get => rndLlegadaVehiculo; set => rndLlegadaVehiculo = value; }
        public double LlegadaVehiculo { get => llegadaVehiculo; set => llegadaVehiculo = value; }
        public double ProximaLlegadaVehiculo { get => proximaLlegadaVehiculo; set => proximaLlegadaVehiculo = value; }
        public double RndTipoVehiculo { get => rndTipoVehiculo; set => rndTipoVehiculo = value; }
        public string TipoVehiculo { get => tipoVehiculo; set => tipoVehiculo = value; }
        public double RndTiempoVehiculo { get => rndTiempoVehiculo; set => rndTiempoVehiculo = value; }
        public int TiempoVehiculo { get => tiempoVehiculo; set => tiempoVehiculo = value; }
        public int LugaresPeqDisponibles { get => lugaresPeqDisponibles; set => lugaresPeqDisponibles = value; }
        public int LugaresGrandDisponibles { get => lugaresGrandDisponibles; set => lugaresGrandDisponibles = value; }
        public int LugaresUtilDisponibles { get => lugaresUtilDisponibles; set => lugaresUtilDisponibles = value; }
        public double Recaudacion { get => recaudacion; set => recaudacion = value; }
        internal Sector[] Sectores { get => sectores; set => sectores = value; }
        internal List<Vehiculo> Vehiculos { get => vehiculos; set => vehiculos = value; }
        internal Caja Caja { get => caja; set => caja = value; }

        public Playa clone()
        {
            return (Playa) this.MemberwiseClone();
        }

        public int buscarVehiculoNulo()
        {
            int res = -1;
            for (int i = 0; i < vehiculos.Count; i++)
            {
                Vehiculo v = vehiculos.ElementAt(i);
                if (v.Estado == "")
                {
                    res = i;
                    break;
                }
            }
            return res;
        }

        public void resetearCampos()
        {
            this.LlegadaVehiculo = 0;
            this.RndLlegadaVehiculo = 0;
            this.RndTipoVehiculo = 0;
            this.TipoVehiculo = "";
            this.TiempoVehiculo = 0;
            this.RndTiempoVehiculo = 0;
        }

        public void descontarLugar(string tipo)
        {
            switch (tipo)
            {
                case "Pequeño":
                    this.LugaresPeqDisponibles -= 1;
                    break;
                case "Grande":
                    this.LugaresGrandDisponibles -= 1;
                    break;
                case "Utilitario":
                    this.LugaresUtilDisponibles -= 1;
                    break;
            }
        }

        public void sumarLugar(string tipo)
        {
            switch (tipo)
            {
                case "Pequeño":
                    this.LugaresPeqDisponibles += 1;
                    break;
                case "Grande":
                    this.LugaresGrandDisponibles += 1;
                    break;
                case "Utilitario":
                    this.LugaresUtilDisponibles += 1;
                    break;
            }
        }

    }
}
