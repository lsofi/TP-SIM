using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP7
{
    public partial class frmHavanaClub : Form
    {
        int minutosDesdeAbrio, minutosASimular, cantidadMinutosAMostrar, mostrarDesdeMinuto, demoraServirDesde, demoraServirHasta,
            capacidadVaso;

        double cantMediaClientes, demoraLavar, demora1A3, demora4A6, demoraMasDe6, pasoH;

        frmRungeKutta frmRKConsumo;

        VectorEstado anterior;
        VectorEstado actual;
        Random random = new Random();
        List<Cliente> clientes;
        Cliente menorFinConsumo;

        public frmHavanaClub()
        {
            InitializeComponent();
        }
        private void btnSimular_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                btnRungeKutta.Enabled = true;
                dgvTabla.Rows.Clear();
                limpiarClientes();
                clientes = new List<Cliente>();


                anterior = new VectorEstado();
                actual = new VectorEstado();
                if (frmRKConsumo != null) frmRKConsumo.Close();

                frmRKConsumo = new frmRungeKutta(pasoH, capacidadVaso);
                double tiempoConsumo = frmRKConsumo.rungeKuttaConsumoCargaDGV(0);

                Cliente atendido = new Cliente("","",-1);

                actual.Evento = "inicializacion";
                actual.Reloj = minutosDesdeAbrio;
                actual.Cantinero = new Cantinero();
                actual.Clientes = new Queue<Cliente>();
                actual.CantVasosLimpios = 4;
                actual.RndLlegadaCliente = random.NextDouble();
                actual.TiempoLlegadaCliente = aleatorioExpN(cantMediaClientes, actual.RndLlegadaCliente);
                actual.ProximaLlegadaCliente = actual.Reloj + actual.TiempoLlegadaCliente;
                actual.RndCantVasos = random.NextDouble();
                actual.CantVasos = aleatorioInt2(1, 10, actual.RndCantVasos);
                actual.TiempoRecoger = tiempoRecoger(actual.CantVasos);
                actual.ProximoFinRecoger = actual.Reloj + actual.TiempoRecoger;
                actual.Cantinero.Estado = "Recogiendo";

                if (actual.Reloj >= mostrarDesdeMinuto && actual.Reloj <= mostrarDesdeMinuto + cantidadMinutosAMostrar)
                {
                    agregarDatosDGV(actual);
                }
               
                do
                {
                    anterior = actual;
                    actual = new VectorEstado();
                    copiarAnterior();

                    buscarEvento();
                    switch (actual.Evento)
                    {
                        case "llegada_cliente":
                            resetearCampos();
                            calcularTiemposYPorcentajes(actual.Cantinero);
                            actual.RndLlegadaCliente = random.NextDouble();
                            actual.TiempoLlegadaCliente = aleatorioExpN(cantMediaClientes, actual.RndLlegadaCliente);
                            actual.ProximaLlegadaCliente = actual.Reloj + actual.TiempoLlegadaCliente;

                            if (actual.Clientes.Count == 0)
                            {
                                int numeroCliente = clientes.Count + 1;
                                Cliente cliente = new Cliente("Cliente " + numeroCliente, "EA", actual.Reloj);
                                clientes.Add(cliente);
                                actual.Clientes.Enqueue(cliente);

                                if (anterior.Cantinero.Estado != "Sirviendo")
                                {
                                    if (actual.CantVasosLimpios >= 1)
                                    {
                                        if (anterior.Cantinero.Estado == "Lavando")
                                        {
                                            actual.TiempoRestanteLavado = anterior.ProximoFinLavado - actual.Reloj;
                                            actual.ProximoFinLavado = -1;
                                        }
                                        if (anterior.Cantinero.Estado == "Recogiendo")
                                        {
                                            actual.TiempoRestanteRecoger = anterior.ProximoFinRecoger - actual.Reloj;
                                            actual.ProximoFinRecoger = -1;
                                        }
                                        atendido = actual.Clientes.Dequeue();
                                        atendido.Estado = "SA";

                                        actual.Cantinero.Estado = "Sirviendo";
                                        actual.CantVasosLimpios = anterior.CantVasosLimpios - 1;
                                        actual.RndServir = random.NextDouble();
                                        actual.TiempoServir = aleatorioU(demoraServirDesde, demoraServirHasta, actual.RndServir);
                                        actual.ProximoFinServir = actual.Reloj + actual.TiempoServir;
                                    }
                                    else
                                    {
                                        if (actual.CantVasosSucios >= 1)
                                        {
                                            if (anterior.Cantinero.Estado == "Lavando")
                                            {
                                                break;
                                            }
                                            actual.TiempoLavado = demoraLavar;
                                            actual.ProximoFinLavado = actual.Reloj + actual.TiempoLavado;
                                            actual.Cantinero.Estado = "Lavando";
                                        }
                                        else
                                        {
                                            if (anterior.Cantinero.Estado == "Recogiendo")
                                            {
                                                break;
                                            }
                                            actual.RndCantVasos = random.NextDouble();
                                            actual.CantVasos = aleatorioInt2(1, 10, actual.RndCantVasos);
                                            actual.TiempoRecoger = tiempoRecoger(actual.CantVasos);
                                            actual.ProximoFinRecoger = actual.Reloj + actual.TiempoRecoger;
                                            actual.Cantinero.Estado = "Recogiendo";
                                        }
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                            else
                            {
                                actual.CantClientesSeVanSinConsumir = anterior.CantClientesSeVanSinConsumir + 1;
                                break;
                            }
                            
                            break;

                        case "fin_servir":
                            resetearCampos();
                            calcularTiemposYPorcentajes(actual.Cantinero);
                            actual.TiempoConsumo = tiempoConsumo;
                            actual.ProximoFinServir = -1;
                            atendido.HoraLlegada = -1;
                            atendido.Estado = "Cons";
                            atendido.FinConsumo = actual.Reloj + actual.TiempoConsumo;
                            
                            if (actual.Clientes.Count > 0)
                            {
                                if (actual.CantVasosLimpios >= 1)
                                {
                                    atendido = actual.Clientes.Dequeue();
                                    atendido.Estado = "SA";

                                    double espera = actual.Reloj - atendido.HoraLlegada;
                                    if (espera > anterior.EsperaMaximaCliente)
                                    {
                                        actual.EsperaMaximaCliente = espera;
                                    }
                                    atendido.HoraLlegada = -1;

                                    actual.Cantinero.Estado = "Sirviendo";
                                    actual.CantVasosLimpios = anterior.CantVasosLimpios - 1;
                                    actual.RndServir = random.NextDouble();
                                    actual.TiempoServir = aleatorioU(demoraServirDesde, demoraServirHasta, actual.RndServir);
                                    actual.ProximoFinServir = actual.Reloj + actual.TiempoServir;
                                }
                                else
                                {
                                    if (actual.CantVasosSucios >= 1)
                                    {
                                        if (anterior.TiempoRestanteLavado > 0)
                                        {
                                            actual.ProximoFinLavado = actual.Reloj + anterior.TiempoRestanteLavado;
                                            actual.Cantinero.Estado = "Lavando";
                                            actual.TiempoRestanteLavado = -1;
                                            break;
                                        }
                                        actual.TiempoLavado = demoraLavar;
                                        actual.ProximoFinLavado = actual.Reloj + actual.TiempoLavado;
                                        actual.Cantinero.Estado = "Lavando";
                                    }
                                    else
                                    {
                                        if (anterior.TiempoRestanteRecoger > 0)
                                        {
                                            actual.ProximoFinRecoger = actual.Reloj + anterior.TiempoRestanteRecoger;
                                            actual.Cantinero.Estado = "Recogiendo";
                                            actual.TiempoRestanteRecoger = -1;
                                            break;
                                        }
                                        actual.RndCantVasos = random.NextDouble();
                                        actual.CantVasos = aleatorioInt2(1, 10, actual.RndCantVasos);
                                        actual.TiempoRecoger = tiempoRecoger(actual.CantVasos);
                                        actual.ProximoFinRecoger = actual.Reloj + actual.TiempoRecoger;
                                        actual.Cantinero.Estado = "Recogiendo";
                                    }
                                }
                            }
                            else
                            {
                                if (actual.CantVasosSucios >= 1)
                                {
                                    if (anterior.TiempoRestanteLavado > 0)
                                    {
                                        actual.ProximoFinLavado = actual.Reloj + anterior.TiempoRestanteLavado;
                                        actual.Cantinero.Estado = "Lavando";
                                        actual.TiempoRestanteLavado = -1;
                                        break;
                                    }
                                    actual.TiempoLavado = demoraLavar;
                                    actual.ProximoFinLavado = actual.Reloj + actual.TiempoLavado;
                                    actual.Cantinero.Estado = "Lavando";
                                }
                                else
                                {
                                    if (anterior.TiempoRestanteRecoger > 0)
                                    {
                                        actual.ProximoFinRecoger = actual.Reloj + anterior.TiempoRestanteRecoger;
                                        actual.Cantinero.Estado = "Recogiendo";
                                        actual.TiempoRestanteRecoger = -1;
                                        break;
                                    }
                                    actual.RndCantVasos = random.NextDouble();
                                    actual.CantVasos = aleatorioInt2(1, 10, actual.RndCantVasos);
                                    actual.TiempoRecoger = tiempoRecoger(actual.CantVasos);
                                    actual.ProximoFinRecoger = actual.Reloj + actual.TiempoRecoger;
                                    actual.Cantinero.Estado = "Recogiendo";
                                }
                            }
                            break;

                        case "fin_lavado":
                            resetearCampos();
                            calcularTiemposYPorcentajes(actual.Cantinero);
                            actual.ProximoFinLavado = -1;
                            actual.CantVasosLimpios = anterior.CantVasosLimpios + 1;
                            actual.CantVasosSucios = anterior.CantVasosSucios - 1;
                            if (actual.Clientes.Count > 0)
                            {
                                atendido = actual.Clientes.Dequeue();
                                atendido.Estado = "SA";

                                double espera = actual.Reloj - atendido.HoraLlegada;
                                if (espera > anterior.EsperaMaximaCliente)
                                {
                                    actual.EsperaMaximaCliente = espera;
                                }
                                atendido.HoraLlegada = -1;

                                actual.Cantinero.Estado = "Sirviendo";
                                actual.CantVasosLimpios = actual.CantVasosLimpios - 1;
                                actual.RndServir = random.NextDouble();
                                actual.TiempoServir = aleatorioU(demoraServirDesde, demoraServirHasta, actual.RndServir);
                                actual.ProximoFinServir = actual.Reloj + actual.TiempoServir;
                            }
                            else
                            {
                                if (actual.CantVasosSucios >= 1)
                                {
                                    actual.TiempoLavado = demoraLavar;
                                    actual.ProximoFinLavado = actual.Reloj + actual.TiempoLavado;
                                    actual.Cantinero.Estado = "Lavando";
                                }
                                else
                                {
                                    actual.RndCantVasos = random.NextDouble();
                                    actual.CantVasos = aleatorioInt2(1, 10, actual.RndCantVasos);
                                    actual.TiempoRecoger = tiempoRecoger(actual.CantVasos);
                                    actual.ProximoFinRecoger = actual.Reloj + actual.TiempoRecoger;
                                    actual.Cantinero.Estado = "Recogiendo";
                                }
                            }
                            break;

                        case "fin_recoger":
                            resetearCampos();
                            calcularTiemposYPorcentajes(actual.Cantinero);
                            actual.CantVasosSucios = anterior.CantVasosSucios + anterior.CantVasos;
                            actual.CantVasos = -1;
                            actual.ProximoFinRecoger = -1;
                            if (actual.Clientes.Count > 0)
                            {
                                if (actual.CantVasosLimpios >= 1)
                                {
                                    atendido = actual.Clientes.Dequeue();
                                    atendido.Estado = "SA";

                                    double espera = actual.Reloj - atendido.HoraLlegada;
                                    if (espera > anterior.EsperaMaximaCliente)
                                    {
                                        actual.EsperaMaximaCliente = espera;
                                    }
                                    atendido.HoraLlegada = -1;

                                    actual.Cantinero.Estado = "Sirviendo";
                                    actual.CantVasosLimpios = anterior.CantVasosLimpios - 1;
                                    actual.RndServir = random.NextDouble();
                                    actual.TiempoServir = aleatorioU(demoraServirDesde, demoraServirHasta, actual.RndServir);
                                    actual.ProximoFinServir = actual.Reloj + actual.TiempoServir;
                                }
                                else
                                {
                                    actual.TiempoLavado = demoraLavar;
                                    actual.ProximoFinLavado = actual.Reloj + actual.TiempoLavado;
                                    actual.Cantinero.Estado = "Lavando";
                                }
                            }
                            else
                            {
                                actual.TiempoLavado = demoraLavar;
                                actual.ProximoFinLavado = actual.Reloj + actual.TiempoLavado;
                                actual.Cantinero.Estado = "Lavando";
                            }
                            break;

                        case "fin_consumo":
                            resetearCampos();
                            calcularTiemposYPorcentajes(actual.Cantinero);
                            actual.CantClientesConsumieron = anterior.CantClientesConsumieron + 1;
                            menorFinConsumo.Estado = "";
                            menorFinConsumo.HoraLlegada = -1;
                            menorFinConsumo.FinConsumo = -1;
                            break;
                    }

                    if (actual.Reloj >= mostrarDesdeMinuto && actual.Reloj <= mostrarDesdeMinuto + cantidadMinutosAMostrar)
                    {
                        agregarDatosDGV(actual);

                        agregarClientesDGV(clientes);
                    }
                } while (actual.Reloj <= minutosDesdeAbrio + minutosASimular);

                if (cantidadMinutosAMostrar + mostrarDesdeMinuto < minutosASimular)
                {
                    agregarDatosDGV(actual);

                    agregarClientesDGV(clientes);
                }
            }
        }
        private void calcularTiemposYPorcentajes(Cantinero cantinero)
        {
            cantinero.TiempoTrabajando += actual.Reloj - anterior.Reloj;
            if (anterior.Cantinero.Estado == "Sirviendo") cantinero.TiempoSirviendo += actual.Reloj - anterior.Reloj;
            if (anterior.Cantinero.Estado == "Lavando") cantinero.TiempoLavando += actual.Reloj - anterior.Reloj;
            if (anterior.Cantinero.Estado == "Recogiendo") cantinero.TiempoRecogiendo += actual.Reloj - anterior.Reloj;
        }
        private void agregarClientesDGV(List<Cliente> clientes)
        {
            for (int k = 0; k < clientes.Count; k++)
            {
                Cliente c = clientes.ElementAt(k);
                if (dgvTabla.Columns.Contains(c.Nombre))
                {
                    dgvTabla.Rows[dgvTabla.Rows.Count - 1].Cells[c.Nombre].Value = c.Estado;
                    if (c.HoraLlegada > 0)
                    {
                        dgvTabla.Rows[dgvTabla.Rows.Count - 1].Cells[c.Nombre + "Hora"].Value = Math.Round(c.HoraLlegada,2);
                    }
                    else
                    {
                        dgvTabla.Rows[dgvTabla.Rows.Count - 1].Cells[c.Nombre + "Hora"].Value = "";
                    }
                    if (c.FinConsumo > 0)
                    {
                        dgvTabla.Rows[dgvTabla.Rows.Count - 1].Cells[c.Nombre + "Fin Consumo"].Value = Math.Round(c.FinConsumo,2);
                    }
                    else
                    {
                        dgvTabla.Rows[dgvTabla.Rows.Count - 1].Cells[c.Nombre + "Fin Consumo"].Value = "";
                    }
                }
                else
                {
                    DataGridViewTextBoxColumn columnaEstado = new DataGridViewTextBoxColumn();
                    columnaEstado.HeaderText = "Estado " + c.Nombre;
                    columnaEstado.Name = c.Nombre;
                    columnaEstado.Width = 50;
                    dgvTabla.Columns.Add(columnaEstado);
                    dgvTabla.Rows[dgvTabla.Rows.Count - 1].Cells[c.Nombre].Value = c.Estado;

                    DataGridViewTextBoxColumn columnaHora = new DataGridViewTextBoxColumn();
                    columnaHora.HeaderText = "Hora " + c.Nombre;
                    columnaHora.Name = c.Nombre + "Hora";
                    columnaHora.Width = 50;
                    dgvTabla.Columns.Add(columnaHora);
                    dgvTabla.Rows[dgvTabla.Rows.Count - 1].Cells[c.Nombre + "Hora"].Value = Math.Round(c.HoraLlegada,2);

                    DataGridViewTextBoxColumn columnaFinConsumo = new DataGridViewTextBoxColumn();
                    columnaFinConsumo.HeaderText = "Fin Consumo " + c.Nombre;
                    columnaFinConsumo.Name = c.Nombre + "Fin Consumo";
                    columnaFinConsumo.Width = 55;
                    dgvTabla.Columns.Add(columnaFinConsumo);
                    //dgvTabla.Rows[dgvTabla.Rows.Count - 1].Cells[c.Nombre + "Fin Consumo"].Value = c.FinConsumo;
                    dgvTabla.Rows[dgvTabla.Rows.Count - 1].Cells[c.Nombre + "Fin Consumo"].Value = "";
                }
            }
        }
        private void agregarDatosDGV(VectorEstado actual)
        {
            String rndLlegadaCliente, tiempoLlegadaCliente, proximaLlegadaCliente, rndServir, tiempoServir, proximoFinServir, tiempoLavado, tiempoRestanteLavado,
                proximoFinLavado, rndCantVasos, cantVasos, tiempoRecoger, tiempoRestanteRecoger, proximoFinRecoger, tiempoConsumo;

            rndLlegadaCliente = tiempoLlegadaCliente = proximaLlegadaCliente = rndServir = tiempoServir = proximoFinServir = tiempoLavado = tiempoRestanteLavado =
                proximoFinLavado = rndCantVasos = cantVasos = tiempoRecoger = tiempoRestanteRecoger = proximoFinRecoger = tiempoConsumo = "";

            if (actual.RndLlegadaCliente > 0) rndLlegadaCliente = Math.Round(actual.RndLlegadaCliente, 2).ToString();
            if (actual.TiempoLlegadaCliente > 0) tiempoLlegadaCliente = Math.Round(actual.TiempoLlegadaCliente, 2).ToString();
            if (actual.ProximaLlegadaCliente > 0) proximaLlegadaCliente = Math.Round(actual.ProximaLlegadaCliente, 2).ToString();
            if (actual.RndServir > 0) rndServir = Math.Round(actual.RndServir, 2).ToString();
            if (actual.TiempoServir > 0) tiempoServir = Math.Round(actual.TiempoServir, 2).ToString();
            if (actual.ProximoFinServir > 0) proximoFinServir = Math.Round(actual.ProximoFinServir, 2).ToString();
            if (actual.TiempoLavado > 0) tiempoLavado = Math.Round(actual.TiempoLavado, 2).ToString();
            if (actual.TiempoRestanteLavado > 0) tiempoRestanteLavado = Math.Round(actual.TiempoRestanteLavado, 2).ToString();
            if (actual.ProximoFinLavado > 0) proximoFinLavado = Math.Round(actual.ProximoFinLavado, 2).ToString();
            if (actual.RndCantVasos > 0) rndCantVasos = Math.Round(actual.RndCantVasos, 2).ToString();
            if (actual.CantVasos > 0) cantVasos = actual.CantVasos.ToString();
            if (actual.TiempoRecoger > 0) tiempoRecoger = Math.Round(actual.TiempoRecoger, 2).ToString();
            if (actual.TiempoRestanteRecoger > 0) tiempoRestanteRecoger = Math.Round(actual.TiempoRestanteRecoger, 2).ToString();
            if (actual.ProximoFinRecoger > 0) proximoFinRecoger = Math.Round(actual.ProximoFinRecoger, 2).ToString();
            if (actual.TiempoConsumo > 0) tiempoConsumo = Math.Round(actual.TiempoConsumo, 2).ToString();

            dgvTabla.Rows.Add(actual.Evento, Math.Round(actual.Reloj,2), rndLlegadaCliente, tiempoLlegadaCliente, proximaLlegadaCliente, rndServir, tiempoServir,
                proximoFinServir,tiempoLavado,tiempoRestanteLavado,proximoFinLavado,rndCantVasos,cantVasos,tiempoRecoger, tiempoRestanteRecoger,proximoFinRecoger,tiempoConsumo,
                actual.Cantinero.Estado,actual.Clientes.Count, actual.CantVasosLimpios, actual.CantVasosSucios, actual.CantClientesSeVanSinConsumir,
                Math.Round(actual.EsperaMaximaCliente,2), actual.CantClientesConsumieron, Math.Round(actual.Cantinero.TiempoTrabajando,2), Math.Round(actual.Cantinero.TiempoSirviendo,2),
                Math.Round(actual.Cantinero.TiempoLavando,2), Math.Round(actual.Cantinero.TiempoRecogiendo,2), actual.Cantinero.getPorcentajeTiempoSirviendo(), actual.Cantinero.getPorcentajeTiempoLavando(),
                actual.Cantinero.getPorcentajeTiempoRecogiendo());
        }
        private void btnRungeKutta_Click(object sender, EventArgs e)
        {
            frmRKConsumo.Show();
        }
        private void resetearCampos()
        {
            actual.RndLlegadaCliente = -1;
            actual.TiempoLlegadaCliente = -1;
            actual.RndServir = -1;
            actual.TiempoServir = -1;
            actual.TiempoLavado = -1;
            actual.RndCantVasos = -1;
            actual.TiempoRecoger = -1;
            actual.TiempoConsumo = -1;
        }
        private void copiarAnterior()
        {
            actual.Evento = anterior.Evento;
            actual.Reloj = anterior.Reloj;
            actual.RndLlegadaCliente = anterior.RndLlegadaCliente;
            actual.TiempoLlegadaCliente = anterior.TiempoLlegadaCliente;
            actual.ProximaLlegadaCliente = anterior.ProximaLlegadaCliente;
            actual.RndServir = anterior.RndServir;
            actual.TiempoServir = anterior.TiempoServir;
            actual.ProximoFinServir = anterior.ProximoFinServir;
            actual.TiempoLavado = anterior.TiempoLavado;
            actual.TiempoRestanteLavado = anterior.TiempoRestanteLavado;
            actual.ProximoFinLavado = anterior.ProximoFinLavado;
            actual.RndCantVasos = anterior.RndCantVasos;
            actual.CantVasos = anterior.CantVasos;
            actual.TiempoRecoger = anterior.TiempoRecoger;
            actual.TiempoRestanteRecoger = anterior.TiempoRestanteRecoger;
            actual.ProximoFinRecoger = anterior.ProximoFinRecoger;
            actual.TiempoConsumo = anterior.TiempoConsumo;
            actual.Cantinero = anterior.Cantinero;
            actual.Clientes = anterior.Clientes;
            actual.CantVasosLimpios = anterior.CantVasosLimpios;
            actual.CantVasosSucios = anterior.CantVasosSucios;
            actual.CantClientesSeVanSinConsumir = anterior.CantClientesSeVanSinConsumir;
            actual.EsperaMaximaCliente = anterior.EsperaMaximaCliente;
            actual.CantClientesConsumieron = anterior.CantClientesConsumieron;
        }
        private void buscarEvento()
        {
            String evento = "";
            double menor = minutosDesdeAbrio + minutosASimular + 1;

            if (clientes.Count > 0) buscarMenorFinConsumo(clientes);

            if (anterior.ProximaLlegadaCliente <= menor)
            {
                evento = "llegada_cliente";
                menor = anterior.ProximaLlegadaCliente;
            }

            if (anterior.ProximoFinServir <= menor && anterior.ProximoFinServir > 0)
            {
                evento = "fin_servir";
                menor = anterior.ProximoFinServir;
            }

            if (anterior.ProximoFinLavado <= menor && anterior.ProximoFinLavado > 0)
            {
                evento = "fin_lavado";
                menor = anterior.ProximoFinLavado;
            }

            if (anterior.ProximoFinRecoger <= menor && anterior.ProximoFinRecoger > 0)
            {
                evento = "fin_recoger";
                menor = anterior.ProximoFinRecoger;
            }

            if (menorFinConsumo != null && menorFinConsumo.FinConsumo <= menor && menorFinConsumo.FinConsumo > 0)
            {
                evento = "fin_consumo";
                menor = menorFinConsumo.FinConsumo;
            }

            actual.Reloj = menor;
            actual.Evento = evento;
        }
        private double aleatorioU(int desde, int hasta, double aleatorio)
        {
            return desde + aleatorio * (hasta - desde);
        }
        private int aleatorioInt(int desde, int hasta, double aleatorio)
        {
            return (int)(desde + (aleatorio * 1000) % (hasta - desde + 1));
        }
        private int aleatorioInt2(int desde, int hasta, double aleatorio)
        {
            return (int) Math.Truncate(desde + aleatorio * (hasta - desde + 1));
        }
        private double aleatorioExpN(double media, double aleatorio)
        {
            return -media * Math.Log(1 - aleatorio);
        }
        private double tiempoRecoger(int cantVasos)
        {
            if (cantVasos <= 3) return demora1A3;
            if (cantVasos <= 6) return demora4A6;
            return demoraMasDe6;
        }
        private void buscarMenorFinConsumo(List<Cliente> clientes)
        {
            menorFinConsumo = clientes.ElementAt(0);
            for (int i = 1; i < clientes.Count; i++)
            {
                Cliente posible = clientes.ElementAt(i);
                if (posible.FinConsumo <= 0) continue;
                if (menorFinConsumo.FinConsumo <= 0) menorFinConsumo = posible;
                if (posible.FinConsumo < menorFinConsumo.FinConsumo)
                {
                    menorFinConsumo = posible;
                }
            }
        }
        private void limpiarClientes()
        {
            int columnas = dgvTabla.Columns.Count;
            for (int i = 31; i < columnas; i++)
            {
                dgvTabla.Columns.RemoveAt(31);
            }
        }
        private bool validarCampos()
        {
            if (!(int.TryParse(txtMinutosComienzo.Text, out minutosDesdeAbrio) && minutosDesdeAbrio >= 0))
            {
                MessageBox.Show("Los minutos desde que abrió debe ser un mayor o igual que 0", "Error al validar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!(int.TryParse(txtMinutosASimular.Text, out minutosASimular) && minutosASimular > 0))
            {
                MessageBox.Show("La cantidad de minutos a simular debe ser un número positivo mayor que 0", "Error al validar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!(int.TryParse(txtMostrarMinutos.Text, out cantidadMinutosAMostrar) && minutosASimular >= cantidadMinutosAMostrar))
            {
                MessageBox.Show("La cantidad de minutos a mostrar debe ser menos o igual a la cantidad de minutos simulados", "Error al validar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!(int.TryParse(txtMostrarDesde.Text, out mostrarDesdeMinuto) && mostrarDesdeMinuto <= minutosDesdeAbrio+minutosASimular && mostrarDesdeMinuto >= minutosDesdeAbrio))
            {
                MessageBox.Show("El minuto a partir del cual desea mostrar no es valido", "Error al validar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!(double.TryParse(txtMediaClientes.Text, out cantMediaClientes) && cantMediaClientes > 0))
            {
                MessageBox.Show("La cantidad media de clientes debe ser un número positivo mayor que 0", "Error al validar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!(double.TryParse(txtDemoraLavar.Text, out demoraLavar) && demoraLavar > 0))
            {
                MessageBox.Show("La cantidad media de clientes debe ser un número positivo mayor que 0", "Error al validar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!(int.TryParse(txtDemoraServirDesde.Text, out demoraServirDesde) && demoraServirDesde > 0))
            {
                MessageBox.Show("La cantidad de minutos que demora en servir debe ser un número positivo mayor que 0", "Error al validar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!(int.TryParse(txtDemoraServirHasta.Text, out demoraServirHasta) && demoraServirHasta > demoraServirDesde ))
            {
                MessageBox.Show("La cantidad de minutos que demora en servir debe ser un número positivo mayor que 0", "Error al validar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!(int.TryParse(txtCapacidadVaso.Text, out capacidadVaso) && capacidadVaso > 0))
            {
                MessageBox.Show("La capacidad del vaso debe ser un número positivo mayor que 0", "Error al validar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!(double.TryParse(txt1a3.Text, out demora1A3) && demora1A3 > 0))
            {
                MessageBox.Show("La cantidad de minutos que demora en recoger 1 a 3 vasos debe ser un número positivo mayor que 0", "Error al validar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!(double.TryParse(txt4a6.Text, out demora4A6) && demora4A6 > demora1A3))
            {
                MessageBox.Show("La cantidad de minutos que demora en recoger 4 a 6 vasos debe ser mayor a la demora de 1 a 3 vasos", "Error al validar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!(double.TryParse(txtMasDe6.Text, out demoraMasDe6) && demoraMasDe6 > demora4A6))
            {
                MessageBox.Show("La cantidad de minutos que demora en recoger mas de 6 vasos debe ser mayor a la demora de 4 a 6 vasos", "Error al validar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!(double.TryParse(txtH.Text, out pasoH) && pasoH > 0))
            {
                MessageBox.Show("El paso H debe ser mayor a 0", "Error al validar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
