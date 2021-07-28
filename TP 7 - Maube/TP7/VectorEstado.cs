using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7
{
    class VectorEstado
    {
        private String evento;
        private double reloj;
        private double rndLlegadaCliente;
        private double tiempoLlegadaCliente;
        private double proximaLlegadaCliente;
        private double rndServir;
        private double tiempoServir;
        private double proximoFinServir;
        private double tiempoLavado;
        private double tiempoRestanteLavado;
        private double proximoFinLavado;
        private double rndCantVasos;
        private int cantVasos;
        private double tiempoRecoger;
        private double tiempoRestanteRecoger;
        private double proximoFinRecoger;
        private double tiempoConsumo;
        private Cantinero cantinero;
        private Queue<Cliente> clientes;
        private int cantVasosLimpios;
        private int cantVasosSucios;
        private int cantClientesSeVanSinConsumir;
        private double esperaMaximaCliente;
        private int cantClientesConsumieron;

        public string Evento { get => evento; set => evento = value; }
        public double Reloj { get => reloj; set => reloj = value; }
        public double RndLlegadaCliente { get => rndLlegadaCliente; set => rndLlegadaCliente = value; }
        public double TiempoLlegadaCliente { get => tiempoLlegadaCliente; set => tiempoLlegadaCliente = value; }
        public double ProximaLlegadaCliente { get => proximaLlegadaCliente; set => proximaLlegadaCliente = value; }
        public double RndServir { get => rndServir; set => rndServir = value; }
        public double TiempoServir { get => tiempoServir; set => tiempoServir = value; }
        public double ProximoFinServir { get => proximoFinServir; set => proximoFinServir = value; }
        public double TiempoLavado { get => tiempoLavado; set => tiempoLavado = value; }
        public double ProximoFinLavado { get => proximoFinLavado; set => proximoFinLavado = value; }
        public double RndCantVasos { get => rndCantVasos; set => rndCantVasos = value; }
        public int CantVasos { get => cantVasos; set => cantVasos = value; }
        public double TiempoRecoger { get => tiempoRecoger; set => tiempoRecoger = value; }
        public double ProximoFinRecoger { get => proximoFinRecoger; set => proximoFinRecoger = value; }
        public double TiempoConsumo { get => tiempoConsumo; set => tiempoConsumo = value; }
        public int CantVasosLimpios { get => cantVasosLimpios; set => cantVasosLimpios = value; }
        public int CantVasosSucios { get => cantVasosSucios; set => cantVasosSucios = value; }
        public int CantClientesSeVanSinConsumir { get => cantClientesSeVanSinConsumir; set => cantClientesSeVanSinConsumir = value; }
        public double EsperaMaximaCliente { get => esperaMaximaCliente; set => esperaMaximaCliente = value; }
        public int CantClientesConsumieron { get => cantClientesConsumieron; set => cantClientesConsumieron = value; }
        public double TiempoRestanteLavado { get => tiempoRestanteLavado; set => tiempoRestanteLavado = value; }
        public double TiempoRestanteRecoger { get => tiempoRestanteRecoger; set => tiempoRestanteRecoger = value; }
        internal Cantinero Cantinero { get => cantinero; set => cantinero = value; }
        internal Queue<Cliente> Clientes { get => clientes; set => clientes = value; }
    }
}
