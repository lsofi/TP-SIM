using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    public class VectorEstado
    {
        private long reloj;
        private double aleatorioDemanda;
        private int demanda;
        private int pedido;
        private int stock;
        private double costoPeriodicos;
        private double costoFaltante;
        private double costoMantenimiento;
        private double costoTotal;
        private double acumuladorCostos;

        public long Reloj { get => reloj; set => reloj = value; }
        public double AleatorioDemanda { get => aleatorioDemanda; set => aleatorioDemanda = value; }
        public int Demanda { get => demanda; set => demanda = value; }
        public int Pedido { get => pedido; set => pedido = value; }
        public int Stock { get => stock; set => stock = value; }
        public double CostoPeriodicos { get => costoPeriodicos; set => costoPeriodicos = value; }
        public double CostoFaltante { get => costoFaltante; set => costoFaltante = value; }
        public double CostoMantenimiento { get => costoMantenimiento; set => costoMantenimiento = value; }
        public double CostoTotal { get => costoTotal; set => costoTotal = value; }
        public double AcumuladorCostos { get => acumuladorCostos; set => acumuladorCostos = value; }
    }
}
