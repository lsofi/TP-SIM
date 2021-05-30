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

        Boolean empezoPelicula;
        Boolean empezoSimulacion;
        Boolean ingresoLlegadaEntrada;
        Boolean ingresoASala;


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
                    actual.Boletero = new Boletero();
                    actual.Boleteria = new Queue<Cliente>();

                    Cliente clienteAtendido = new Cliente(0, false);
                    empezoPelicula = false;
                    empezoSimulacion = false;
                    ingresoLlegadaEntrada = false;
                    ingresoASala = false;

                    List<Cliente> clientes = new List<Cliente>();

                    while (actual.ButacasOcupadas < tamSala)
                    {
                        anterior = actual;
                        actual = new VectorEstado();
                        copiarAnterior();

                        if (actual.Reloj >= minHastaComienzoFuncion * 60) empezoPelicula = true;
                        buscarEvento();

                        switch (actual.Evento)
                        {
                            case "inicio_simulacion":
                                actual.ButacasOcupadas = 0;
                                actual.NumeroSimulacion = i + 1;
                                actual.PersonasEnColaSala = 0;
                                actual.TiempoOcupacionBoletero = 0;
                                actual.RndLlegadaCompra = random.NextDouble();
                                actual.LlegadaCompra = aleatorioU(desdeTiempoLlegadaCompra, hastaTiempoLlegadaCompra, actual.RndLlegadaCompra);
                                actual.ProximaLlegadaCompra = actual.Reloj + actual.LlegadaCompra;
                                empezoSimulacion = true;
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
                                actual.NumeroCompra = 1 + aleatorioInt(desdeEntradasComprar, hastaEntradasComprar, actual.RndNumeroCompra);
                                Cliente nuevo = new Cliente(actual.NumeroCompra, false);
                                nuevo.Nombre = "Cliente" + clientes.Count + 1;
                                clientes.Add(nuevo);

                                for (int m = 0; m < actual.NumeroCompra - 1; m++)
                                {
                                    Cliente nuevoAcompañante = new Cliente(actual.NumeroCompra, false);
                                    nuevoAcompañante.Nombre = "Cliente" + clientes.Count + 1;
                                    clientes.Add(nuevoAcompañante);
                                }

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
                                actual.NumeroEntrada = 1 + aleatorioInt(desdeEntradasAnticipadas, hastaEntradasAnticipadas, actual.RndNumeroEntrada);

                                if (actual.PersonasEnColaSala == 0 && ingresoASala)
                                {
                                    actual.RndFinEntrada = random.NextDouble();
                                    actual.FinEntrada = aleatorioU(desdeTiempoEntradaSala, hastaTiempoEntradaSala, actual.RndFinEntrada);
                                    actual.ProximoFinEntrada = actual.Reloj + actual.FinEntrada;
                                }
                                
                                actual.PersonasEnColaSala += actual.NumeroEntrada;

                                actual.EntradasVendidas += actual.NumeroEntrada;

                                for (int j = 0; j < actual.NumeroEntrada; j++)
                                {
                                    Cliente nuevoAnticipada = new Cliente(actual.NumeroCompra, true);
                                    nuevoAnticipada.Nombre = "Cliente" + clientes.Count + 1;
                                    clientes.Add(nuevoAnticipada);
                                }

                                

                                break;

                            case "fin_compra":
                                resetearCampos();
                                if (actual.PersonasEnColaSala == 0 && ingresoASala)
                                {
                                    actual.RndFinEntrada = random.NextDouble();
                                    actual.FinEntrada = aleatorioU(desdeTiempoEntradaSala, hastaTiempoEntradaSala, actual.RndFinEntrada);
                                    actual.ProximoFinEntrada = actual.Reloj + actual.FinEntrada;
                                }
                                actual.PersonasEnColaSala += clienteAtendido.NumeroEntradas;
                                actual.EntradasVendidas += clienteAtendido.NumeroEntradas;
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
                                    actual.ProximoFinCompra = -1;
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
                                else
                                {
                                    actual.ProximoFinEntrada = -1;
                                }
                                break;

                            case "inicio_llegada_con_entrada":
                                resetearCampos();
                                actual.RndLlegadaEntrada = random.NextDouble();
                                actual.LlegadaEntrada = aleatorioU(desdeTiempoLlegadaAnticipada, hastaTiempoLlegadaAnticipada, actual.RndLlegadaEntrada);
                                actual.ProximaLlegadaEntrada = actual.Reloj + actual.LlegadaEntrada;
                                ingresoLlegadaEntrada = true;
                                break;

                            case "inicio_ingreso_sala":
                                resetearCampos();
                                if(actual.PersonasEnColaSala > 0)
                                {
                                    actual.RndFinEntrada = random.NextDouble();
                                    actual.FinEntrada = aleatorioU(desdeTiempoEntradaSala, hastaTiempoEntradaSala, actual.RndFinEntrada);
                                    actual.ProximoFinEntrada = actual.Reloj + actual.FinEntrada;
                                }
                                ingresoASala = true;
                                break;

                            case "inicio_pelicula":
                                resetearCampos();
                                actual.ProximaLlegadaCompra = -1;
                                actual.ProximaLlegadaEntrada = -1;
                                actual.Boleteria.Clear();
                                break;
                        }

                        agregarDatosDGV(actual);

                        agregarClientesDGV(clientes);

                    }

                }

            }
        }

        private void copiarAnterior()
        {
            actual.NumeroSimulacion = anterior.NumeroSimulacion;
            actual.Evento = anterior.Evento;
            actual.Reloj = anterior.Reloj;
            actual.RndLlegadaCompra = anterior.RndLlegadaCompra;
            actual.LlegadaCompra = anterior.LlegadaCompra;
            actual.ProximaLlegadaCompra = anterior.ProximaLlegadaCompra;
            actual.RndNumeroCompra = anterior.RndNumeroCompra;
            actual.NumeroCompra = anterior.NumeroCompra;
            actual.RndLlegadaEntrada = anterior.RndLlegadaEntrada;
            actual.LlegadaEntrada = anterior.LlegadaEntrada;
            actual.ProximaLlegadaEntrada = anterior.ProximaLlegadaEntrada;
            actual.RndNumeroEntrada = anterior.RndNumeroEntrada;
            actual.NumeroEntrada = anterior.NumeroEntrada;
            actual.Boletero = anterior.Boletero;
            actual.RndFinCompra = anterior.RndFinCompra;
            actual.FinCompra = anterior.FinCompra;
            actual.ProximoFinCompra = anterior.ProximoFinCompra;
            actual.Boleteria = anterior.Boleteria;
            actual.RndFinEntrada = anterior.RndFinEntrada;
            actual.FinEntrada = anterior.FinEntrada;
            actual.ProximoFinEntrada = anterior.ProximoFinEntrada;
            actual.PersonasEnColaSala = anterior.PersonasEnColaSala;
            actual.ButacasOcupadas = anterior.ButacasOcupadas;
            actual.TiempoOcupacionBoletero = anterior.TiempoOcupacionBoletero;
            actual.EntradasVendidas = anterior.EntradasVendidas;
        }
        private void agregarDatosDGV(VectorEstado actual)
        {
            String numeroSim = actual.NumeroSimulacion.ToString();
            String reloj = actual.Reloj.ToString();
            String evento = actual.Evento;
            String proximaLlegadaCompra = actual.ProximaLlegadaCompra.ToString();
            String proximaLlegadaEntrada = actual.ProximaLlegadaEntrada.ToString();
            String proximoFinCompra = actual.ProximoFinCompra.ToString();
            String proximoFinEntrada = actual.ProximoFinEntrada.ToString();
            String personasEnColaBoletaria = actual.Boleteria.Count.ToString();
            String personasEnColaSala = actual.PersonasEnColaSala.ToString();
            String butacasOcupadas = actual.ButacasOcupadas.ToString();
            String tiempoOcupacionBoletero = actual.TiempoOcupacionBoletero.ToString();
            String estadoBoletero = actual.Boletero.Estado;
            String entradasVendidas = actual.EntradasVendidas.ToString();
            

            String rndLlegadaCompra, llegadaCompra, rndNumeroCompra, numeroCompra, rndLlegadaEntrada, llegadaEntrada, rndNumeroEntrada,
                numeroEntrada, rndFinCompra, finCompra, rndFinEntrada, finEntrada, salaLlena;

            rndLlegadaCompra = llegadaCompra = rndNumeroCompra = numeroCompra = rndLlegadaEntrada = llegadaEntrada = rndNumeroEntrada =
                numeroEntrada = rndFinCompra = finCompra = rndFinEntrada = finEntrada = "";

            if (actual.RndLlegadaCompra != -1) rndLlegadaCompra = actual.RndLlegadaCompra.ToString();
            if (actual.LlegadaCompra != -1) llegadaCompra = actual.RndLlegadaCompra.ToString();
            if (actual.RndNumeroCompra != -1) rndNumeroCompra = actual.RndNumeroCompra.ToString();
            if (actual.NumeroCompra != -1) numeroCompra = actual.NumeroCompra.ToString();
            if (actual.RndLlegadaEntrada != -1) rndLlegadaEntrada = actual.RndLlegadaEntrada.ToString();
            if (actual.LlegadaEntrada != -1) llegadaEntrada = actual.LlegadaEntrada.ToString();
            if (actual.RndNumeroEntrada != -1) rndNumeroEntrada = actual.RndNumeroEntrada.ToString();
            if (actual.NumeroEntrada != -1) numeroEntrada = actual.NumeroEntrada.ToString();
            if (actual.RndFinCompra != -1) rndFinCompra = actual.RndFinCompra.ToString();
            if (actual.FinCompra != -1) finCompra = actual.FinCompra.ToString();
            if (actual.RndFinEntrada != -1) rndFinEntrada = actual.RndFinEntrada.ToString();
            if (actual.FinEntrada != -1) finEntrada = actual.FinEntrada.ToString();

            if (actual.ButacasOcupadas == tamSala) salaLlena = "Si";
            else salaLlena = "No";

            dgvFuncion.Rows.Add(numeroSim, evento, reloj, rndLlegadaCompra, llegadaCompra, proximaLlegadaCompra, rndNumeroCompra,
                numeroCompra, rndLlegadaEntrada, llegadaEntrada, proximaLlegadaEntrada, rndNumeroEntrada, numeroEntrada, estadoBoletero,
                rndFinCompra, finCompra, proximoFinCompra, rndFinEntrada, finEntrada, proximoFinEntrada, personasEnColaBoletaria, personasEnColaSala,
                entradasVendidas, salaLlena, tiempoOcupacionBoletero);


        }
        private void agregarClientesDGV(List<Cliente> clientes)
        {
            for (int k = 0; k < clientes.Count; k++)
            {
                Cliente c = clientes.ElementAt(k);
                if (dgvFuncion.Columns.Contains(c.Nombre))
                {
                    dgvFuncion.Rows[dgvFuncion.Rows.Count - 1].Cells[c.Nombre].Value = c.Estado;
                }
                else
                {
                    DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
                    columna.HeaderText = "Estado " + c.Nombre;
                    columna.Name = c.Nombre;
                    dgvFuncion.Columns.Add(columna);
                    dgvFuncion.Rows[dgvFuncion.Rows.Count - 1].Cells[c.Nombre].Value = c.Estado;
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

        private double aleatorioU(int desde, int hasta, double aleatorio)
        {
            return desde + aleatorio * (hasta - desde);
        }
        private int aleatorioInt(int desde, int hasta, double aleatorio)
        {
            return (int)(desde + (aleatorio * 1000) % (hasta - desde + 1));
        }

        private void buscarEvento()
        {
            string evento = "fin_pelicula";
            double minimo = minHastaComienzoFuncion * 60 + 54000;

            if (minimo >= anterior.ProximaLlegadaCompra && anterior.ProximaLlegadaCompra > 0 && !empezoPelicula)
            {
                evento = "llegada_compra";
                minimo = anterior.ProximaLlegadaCompra;
            }

            if (actual.Reloj == 0 && !empezoSimulacion)
            {
                evento = "inicio_simulacion";
                return;
            }

            if (minimo >= anterior.ProximaLlegadaEntrada && anterior.ProximaLlegadaEntrada > 0 && !empezoPelicula)
            {
                evento = "llegada_entrada_anticipada";
                minimo = anterior.ProximaLlegadaEntrada;
            }

            if (minimo >= anterior.ProximoFinCompra && anterior.ProximoFinCompra > 0)
            {
                evento = "fin_compra";
                minimo = anterior.ProximoFinCompra;
            }

            if (minimo >= anterior.ProximoFinEntrada && anterior.ProximoFinEntrada > 0)
            {
                evento = "fin_entrada";
                minimo = anterior.ProximoFinEntrada;
            }

            if (minimo >= (minHastaComienzoFuncion - minLlegadaAnticipada) * 60 && !ingresoLlegadaEntrada)
            {
                evento = "inicio_llegada_con_entrada";
                minimo = (minHastaComienzoFuncion - minLlegadaAnticipada) * 60;
            }

            if (minimo >= (minHastaComienzoFuncion - minAperturaSala) * 60 && !ingresoASala)
            {
                evento = "inicio_ingreso_sala";
                minimo = (minHastaComienzoFuncion - minAperturaSala) * 60;
            }

            actual.Reloj = minimo;
            actual.Evento = evento;

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
        
    }
}
