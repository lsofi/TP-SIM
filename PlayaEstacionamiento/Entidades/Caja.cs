using System;
using System.Collections.Generic;
using System.Text;

namespace PlayaEstacionamiento
{
    class Caja
    {
        private string estado;
        private Queue<Vehiculo> cola;
        private double fin_cobro;

        public Caja()
        {
            this.Estado = "Libre";
            this.Cola = new Queue<Vehiculo>();
            this.Fin_cobro = 0;
        }

        public string Estado { get => estado; set => estado = value; }
        public double Fin_cobro { get => fin_cobro; set => fin_cobro = value; }
        internal Queue<Vehiculo> Cola { get => cola; set => cola = value; }
    }
}
