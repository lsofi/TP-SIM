using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP5
{
    public partial class frmSimulacion : Form
    {
        int numSim, simMostrar, tamSala, minAperturaSala, minLlegadaAnticipada, minHastaComienzoFuncion,
            desdeEntradasComprar, hastaEntradasComprar, desdeEntradasAnticipadas, hastaEntradasAnticipadas,
            desdeTiempoCompra, hastaTiempoCompra, desdeTiempoEntradaSala, hastaTiempoEntradaSala,
            desdeTiempoLlegadaCompra, hastaTiempoLlegadaCompra, desdeTiempoLlegadaAnticipada, hastaTiempoLlegadaAnticipada;
        VectorEstado anterior;
        VectorEstado actual;
        VectorEstado aux;
        Random random = new Random();
        

        public frmSimulacion()
        {
            InitializeComponent();
            
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                for (int i = 0; i < numSim; i++)
                {
                    anterior = new VectorEstado();
                    actual = new VectorEstado();
                    actual.Reloj = 0;
                    actual.Evento = "inicio_simulacion";
                    Cliente clienteAtendido = new Cliente(0, false);
                    Boolean empezoPelicula = false;


                    while (actual.ButacasOcupadas <= tamSala)
                    {
                        aux = anterior;
                        anterior = actual;
                        actual = aux;
                        
                        if (actual.Evento != "inicio_simulacion")
                            buscarEvento();
                        switch (actual.Evento)
                        {
                            case "inicio_simulacion":
                                actual.ButacasOcupadas = 0;
                                actual.Evento = "inicio_simulacion";
                                actual.Reloj = 0;
                                actual.NumeroSimulacion = i + 1;
                                //actual.RndNumeroCompra = random.NextDouble();
                                //actual.NumeroCompra = aleatorioInt(desdeEntradasComprar, hastaEntradasComprar, anterior.RndNumeroCompra);
                                //actual.RndLlegadaEntrada = random.NextDouble();
                                //actual.LlegadaEntrada = aleatorioU(desdeTiempoLlegadaAnticipada, hastaTiempoLlegadaAnticipada, anterior.RndLlegadaEntrada);
                                //actual.ProximaLlegadaEntrada = (minHastaComienzoFuncion - minLlegadaAnticipada) * 60 + anterior.LlegadaEntrada;
                                //actual.RndNumeroEntrada = random.NextDouble();
                                //actual.NumeroEntrada = aleatorioInt(desdeEntradasAnticipadas, hastaEntradasAnticipadas, anterior.RndNumeroEntrada);
                                actual.Boletero = new Boletero();
                                actual.Boleteria = new Queue<Cliente>();
                                actual.PersonasEnColaSala = 0;
                                actual.TiempoOcupacionBoletero = 0;
                                break;

                            case "llegada_compra":
                                resetearCampos();
                                if (empezoPelicula)
                                {
                                    break;
                                }
                                actual.RndLlegadaCompra = random.NextDouble();
                                actual.LlegadaCompra = aleatorioU(desdeTiempoLlegadaCompra, hastaTiempoLlegadaCompra, actual.RndLlegadaCompra);
                                actual.ProximaLlegadaCompra = actual.Reloj + actual.LlegadaCompra;

                                actual.RndNumeroCompra = random.NextDouble();
                                actual.NumeroCompra = aleatorioInt(desdeEntradasComprar, hastaEntradasComprar, actual.RndNumeroCompra);
                                Cliente nuevo = new Cliente(actual.NumeroCompra, false);
                                if (actual.Boletero.Estado == "ocupado")
                                {
                                    actual.Boleteria.Enqueue(nuevo);
                                }
                                    
                                else
                                {
                                    clienteAtendido = nuevo;
                                    clienteAtendido.Estado = "comprando";
                                    actual.Boletero.Estado = "ocupado";
                                    actual.Boletero.InicioOcupacion = actual.Reloj;
                                    actual.RndFinCompra = random.NextDouble();
                                    actual.FinCompra = aleatorioU(desdeTiempoCompra, hastaTiempoCompra, actual.RndFinCompra);
                                    actual.ProximoFinCompra = actual.Reloj + actual.FinCompra;
                                }

                                break;

                            case "llegada_entrada_anticipada":
                                resetearCampos();
                                if (empezoPelicula)
                                {
                                    break;
                                }
                                actual.RndLlegadaEntrada = random.NextDouble();
                                actual.LlegadaEntrada = aleatorioU(desdeTiempoLlegadaAnticipada, hastaTiempoLlegadaAnticipada, actual.RndLlegadaEntrada);
                                actual.ProximaLlegadaEntrada = actual.Reloj + actual.LlegadaEntrada;

                                actual.RndNumeroEntrada = random.NextDouble();
                                actual.NumeroEntrada = aleatorioInt(desdeEntradasAnticipadas, hastaEntradasAnticipadas, actual.RndNumeroEntrada);
                                actual.PersonasEnColaSala += actual.NumeroEntrada;

                                break;

                            case "fin_compra":
                                resetearCampos();
                                actual.PersonasEnColaSala += clienteAtendido.NumeroEntradas;
                                if (actual.Boleteria.Count != 0)
                                {
                                    clienteAtendido = actual.Boleteria.Dequeue();
                                    actual.RndFinCompra = random.NextDouble();
                                    actual.FinCompra = aleatorioU(desdeTiempoCompra, hastaTiempoCompra, actual.RndFinCompra);
                                    actual.ProximoFinCompra = actual.Reloj + actual.FinCompra;
                                    actual.Boletero.InicioOcupacion = actual.Reloj;
                                }
                                else
                                {
                                    actual.Boletero.Estado = "libre";
                                    actual.TiempoOcupacionBoletero += actual.Reloj - actual.Boletero.InicioOcupacion;
                                }
                                break;

                            case "fin_entrada":
                                resetearCampos();
                                if (actual.ButacasOcupadas < tamSala && actual.PersonasEnColaSala > 0)
                                {
                                    actual.ButacasOcupadas += 1;
                                    actual.PersonasEnColaSala -= 1;
                                    actual.RndFinEntrada = random.NextDouble();
                                    actual.FinEntrada = aleatorioU(desdeTiempoEntradaSala, hastaTiempoEntradaSala, actual.RndFinEntrada);
                                    actual.ProximoFinEntrada = actual.Reloj + actual.FinEntrada;
                                }
                                break;

                            case "inicio_llegada_con_entrada":

                                break;

                            case "inicio_ingreso_sala":

                                break;
                        }

                    }

                }

            }
        }

        private void resetearCampos()
        {
            actual.RndLlegadaCompra = -1;
            actual.LlegadaCompra = -1;
            actual.RndNumeroCompra = -1;
            actual.NumeroCompra = -1;
            actual.RndFinCompra = -1;
            actual.FinCompra = -1;
            actual.RndFinEntrada = -1;
            actual.FinEntrada = -1;
            actual.RndLlegadaEntrada = -1;
            actual.LlegadaEntrada = -1;
            actual.RndNumeroEntrada = -1;
            actual.NumeroEntrada = -1;
        }

        private bool validarCampos()
        {
            if(!(int.TryParse(txtN.Text, out numSim) && numSim > 0))
            {
                MessageBox.Show("La cantidad de simulaciones debe ser un número positivo mayor que 0", "Cantidad de simulaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(int.TryParse(txtSimAMostrar.Text, out simMostrar) && simMostrar >= 1 && simMostrar <= numSim))
            {
                MessageBox.Show("Debe elegir una simulación para mostrar dentro del rango", "Simulación a mostrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(int.TryParse(txtTamSala.Text, out tamSala) && tamSala >0))
            {
                MessageBox.Show("El tamaño de sala debe ser un número entero mayor a 0", "Tamaño de sala", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }            
            if (!(int.TryParse(txtHorarioComienzoPelicula.Text, out minHastaComienzoFuncion) && minHastaComienzoFuncion > 0))
            {
                MessageBox.Show("Los minutos hasta que comience la pelicula deben ser un número positivo mayor a 0 ", "Horario comienzo pelicula", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(int.TryParse(txtHorarioAperturaSala.Text, out minAperturaSala) && minAperturaSala > 0 && minAperturaSala <= minHastaComienzoFuncion))
            {
                MessageBox.Show("El horario de apertura de la sala debe ser un número positivo mayor a 0 y menor al tiempo hasta que comience la función", "Horario apertura sala", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(int.TryParse(txtHorarioLlegadaAnticipada.Text, out minLlegadaAnticipada) && minLlegadaAnticipada > 0 && minLlegadaAnticipada <= minHastaComienzoFuncion))
            {
                MessageBox.Show("El horario de llegada anticipada debe ser un número positivo mayor a 0 y menor al tiempo hasta que comience la función", "Horario llegada anticipada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(int.TryParse(txtEntrCompDesde.Text, out desdeEntradasComprar) && desdeEntradasComprar > 0))
            {
                MessageBox.Show("El valor mínimo del rango de entradas a comprar debe ser un número entero positivo mayor a 0", "Rango de entradas a comprar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(int.TryParse(txtEntrCompHasta.Text, out hastaEntradasComprar) && hastaEntradasComprar > desdeEntradasComprar))
            {
                MessageBox.Show("El valor máximo del rango de entradas a comprar debe ser un número entero positivo mayor al mínimo", "Rango de entradas a comprar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(int.TryParse(txtEntrAntDesde.Text, out desdeEntradasAnticipadas) && desdeEntradasAnticipadas > 0))
            {
                MessageBox.Show("El valor mínimo del rango de entradas anticipadas con las que llegan los clientes debe ser un número entero positivo mayor a 0", "Rango de entradas anticipadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(int.TryParse(txtEntrAntHasta.Text, out hastaEntradasAnticipadas) && hastaEntradasAnticipadas > desdeEntradasAnticipadas))
            {
                MessageBox.Show("El valor máximo del rango de entradas anticipadas con las que llegan los clientes debe ser un número entero positivo mayor al mínimo", "Rango de entradas anticipadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(int.TryParse(txtTiempoCompraDesde.Text, out desdeTiempoCompra) && desdeTiempoCompra > 0))
            {
                MessageBox.Show("El valor mínimo del rango de tiempo que demoran los clientes en realizar la compra de entradas debe ser un número entero positivo mayor a 0", "Rango de tiempo de compra de entradas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(int.TryParse(txtTiempoCompraHasta.Text, out hastaTiempoCompra) && hastaTiempoCompra > desdeTiempoCompra))
            {
                MessageBox.Show("El valor máximo del rango de tiempo que demoran los clientes en realizar la compra de entradas debe ser un número entero positivo mayor al mínimo", "Rango de tiempo de compra de entradas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(int.TryParse(txtTiempoEntradaDesde.Text, out desdeTiempoEntradaSala) && desdeTiempoEntradaSala > 0))
            {
                MessageBox.Show("El valor mínimo del rango de tiempo que demoran los clientes entrar a la sala debe ser un número entero positivo mayor a 0", "Rango de tiempo de entrada a la sala", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(int.TryParse(txtTiempoEntradaHasta.Text, out hastaTiempoEntradaSala) && hastaTiempoEntradaSala > desdeTiempoEntradaSala))
            {
                MessageBox.Show("El valor máximo del rango de tiempo que demoran los clientes entrar a la sala debe ser un número entero positivo mayor al mínimo", "Rango de tiempo de entrada a la sala", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(int.TryParse(txtTiempoLlegCompDesde.Text, out desdeTiempoLlegadaCompra) && desdeTiempoLlegadaCompra > 0))
            {
                MessageBox.Show("El valor mínimo del rango de tiempo en el que llegan clientes a comprar entradas debe ser un número entero positivo mayor a 0", "Rango de tiempo llegada de clientes a comprar entradas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(int.TryParse(txtTiempoLlegCompHasta.Text, out hastaTiempoLlegadaCompra) && hastaTiempoLlegadaCompra > desdeTiempoLlegadaCompra))
            {
                MessageBox.Show("El valor máximo del rango de tiempo en el que llegan clientes a comprar entradas debe ser un número entero positivo mayor al mínimo", "Rango de tiempo llegada de clientes a comprar entradas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(int.TryParse(txtTiempoLlegAntDesde.Text, out desdeTiempoLlegadaAnticipada) && desdeTiempoLlegadaAnticipada > 0))
            {
                MessageBox.Show("El valor mínimo del rango de tiempo en el que llegan clientes con entradas anticipadas debe ser un número entero positivo mayor a 0", "Rango de tiempo llegada de clientes con entradas anticipadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(int.TryParse(txtTiempoLlegAntHasta.Text, out hastaTiempoLlegadaAnticipada) && hastaTiempoLlegadaAnticipada > desdeTiempoLlegadaAnticipada))
            {
                MessageBox.Show("El valor máximo del rango de tiempo en el que llegan clientes con entradas anticipadas debe ser un número entero positivo mayor al mínimo", "Rango de tiempo llegada de clientes con entradas anticipadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private double aleatorioU(int desde, int hasta, double aleatorio)
        {
            return desde + aleatorio * (hasta - desde);
        }
        private int aleatorioInt(int desde, int hasta, double aleatorio)
        {
            return (int) (desde + (aleatorio * 1000) % (hasta - desde + 1));
        }
        
        private void buscarEvento()
        {
            string evento = "llegada_compra";
            double minimo = anterior.ProximaLlegadaCompra;

            if (minimo >= anterior.ProximaLlegadaEntrada)
            {
                evento = "llegada_entrada_anticipada";
                minimo = anterior.ProximaLlegadaEntrada;
            }
            if (minimo >= anterior.ProximoFinCompra)
            {
                evento = "fin_compra";
                minimo = anterior.ProximoFinCompra;
            }
            if (minimo >= anterior.ProximoFinEntrada)
            {
                evento = "fin_entrada";
                minimo = anterior.ProximoFinEntrada;
            }
            if (minimo >= (minHastaComienzoFuncion - minLlegadaAnticipada)*60)
            {
                evento = "inicio_llegada_con_entrada";
                minimo = (minHastaComienzoFuncion - minLlegadaAnticipada) * 60;
            }
            if (minimo >= (minHastaComienzoFuncion - minAperturaSala)* 60)
            {
                evento = "inicio_ingreso_sala";
                minimo = (minHastaComienzoFuncion - minAperturaSala) * 60;
            }
            actual.Reloj = minimo;
            actual.Evento = evento;

        }
        
    }
}
