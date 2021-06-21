using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    public class VectorEstado
    {
        private int numeroSimulacion;
        private String evento;
        private double reloj;
        private double rndLlegadaCompra;
        private double llegadaCompra;
        private double proximaLlegadaCompra;
        private double rndNumeroCompra;
        private int numeroCompra;
        private double rndLlegadaEntrada;
        private double llegadaEntrada;
        private double proximaLlegadaEntrada;
        private double rndNumeroEntrada;
        private int numeroEntrada;
        private Boletero boletero;
        private double rndFinCompra;
        private double finCompra;
        private double proximoFinCompra;
        private Queue<Cliente> boleteria;
        private Queue<Cliente> entrada;
        private double rndFinEntrada;
        private double finEntrada;
        private double proximoFinEntrada;
        private double rndInterrupcion;
        private double tiempoInterrupcion;
        private double proximaInterrupcion;
        private double tiempoFinInterrupcion;
        private double proximoFinInterrupcion;
        private double tiempoRestanteEntrada;
        private String estadoPortero;
        private int personasEnColaSala;
        private int butacasOcupadas;
        private double tiempoOcupacionBoletero;
        private int entradasVendidas;
        private int entradasAnticipadas;

        public string Evento { get => evento; set => evento = value; }
        public double Reloj { get => reloj; set => reloj = value; }
        public double RndLlegadaCompra { get => rndLlegadaCompra; set => rndLlegadaCompra = value; }
        public double LlegadaCompra { get => llegadaCompra; set => llegadaCompra = value; }
        public double ProximaLlegadaCompra { get => proximaLlegadaCompra; set => proximaLlegadaCompra = value; }
        public double RndNumeroCompra { get => rndNumeroCompra; set => rndNumeroCompra = value; }
        public int NumeroCompra { get => numeroCompra; set => numeroCompra = value; }
        public double RndLlegadaEntrada { get => rndLlegadaEntrada; set => rndLlegadaEntrada = value; }
        public double LlegadaEntrada { get => llegadaEntrada; set => llegadaEntrada = value; }
        public double ProximaLlegadaEntrada { get => proximaLlegadaEntrada; set => proximaLlegadaEntrada = value; }
        public double RndNumeroEntrada { get => rndNumeroEntrada; set => rndNumeroEntrada = value; }
        public int NumeroEntrada { get => numeroEntrada; set => numeroEntrada = value; }
        public Boletero Boletero { get => boletero; set => boletero = value; }
        public double RndFinCompra { get => rndFinCompra; set => rndFinCompra = value; }
        public double FinCompra { get => finCompra; set => finCompra = value; }
        public double ProximoFinCompra { get => proximoFinCompra; set => proximoFinCompra = value; }
        public Queue<Cliente> Boleteria { get => boleteria; set => boleteria = value; }
        public double RndFinEntrada { get => rndFinEntrada; set => rndFinEntrada = value; }
        public double FinEntrada { get => finEntrada; set => finEntrada = value; }
        public double ProximoFinEntrada { get => proximoFinEntrada; set => proximoFinEntrada = value; }
        public double RndInterrupcion { get => rndInterrupcion; set => rndInterrupcion = value; }
        public double TiempoInterrupcion { get => tiempoInterrupcion; set => tiempoInterrupcion = value; }
        public double ProximaInterrupcion { get => proximaInterrupcion; set => proximaInterrupcion = value; }
        public double TiempoFinInterrupcion { get => tiempoFinInterrupcion; set => tiempoFinInterrupcion = value; }
        public double ProximoFinInterrupcion { get => proximoFinInterrupcion; set => proximoFinInterrupcion = value; }
        public double TiempoRestanteEntrada { get => tiempoRestanteEntrada; set => tiempoRestanteEntrada = value; }
        public string EstadoPortero { get => estadoPortero; set => estadoPortero = value; }
        public int PersonasEnColaSala { get => personasEnColaSala; set => personasEnColaSala = value; }
        public int ButacasOcupadas { get => butacasOcupadas; set => butacasOcupadas = value; }
        public int NumeroSimulacion { get => numeroSimulacion; set => numeroSimulacion = value; }
        public double TiempoOcupacionBoletero { get => tiempoOcupacionBoletero; set => tiempoOcupacionBoletero = value; }
        public int EntradasVendidas { get => entradasVendidas; set => entradasVendidas = value; }
        public Queue<Cliente> Entrada { get => entrada; set => entrada = value; }
        public int EntradasAnticipadas { get => entradasAnticipadas; set => entradasAnticipadas = value; }
        
    }
}
