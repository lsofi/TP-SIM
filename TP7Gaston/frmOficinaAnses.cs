using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP7.Distribuciones;

namespace TP7
{
    public partial class frmOficinaAnses : Form
    {
        // parámetros
        public Boolean todas;
        public int lineas, mostrarDesde, N;

        public double probMayorEdad;
        public int rangoEdadDesde, rangoEdadHasta;
        public double tasaClientes;
        public int rangoEntenderDesde, rangoEntenderHasta, minutosOtrasTareas, rangoTareaDesde, rangoTareaHasta;

        public double t0, z0, h, alfa, beta;
        double[] tiemposAtencion;

        VectorEstado anterior;
        VectorEstado actual;
        Random random = new Random();
        ExponencialNegativa expNeg;
        Uniforme unifHacerEntender, unifOtraTarea;

        frmRungeKutta frmRungeKutta;

        Boolean empezoSimulacion, terminoSimulacion;

        private void dgvClientes_Scroll(object sender, ScrollEventArgs e)
        {
            this.dgvFuncion.FirstDisplayedScrollingRowIndex = this.dgvClientes.FirstDisplayedScrollingRowIndex;
        }

        private void dgvFuncion_Scroll(object sender, ScrollEventArgs e)
        {
            this.dgvClientes.FirstDisplayedScrollingRowIndex = this.dgvFuncion.FirstDisplayedScrollingRowIndex;
        }

        public frmOficinaAnses()
        {
            InitializeComponent();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                btnRungeKutta.Enabled = true;
                dgvFuncion.Rows.Clear();
                limpiarClientes();
                if (frmRungeKutta != null) frmRungeKutta.Close();

                frmRungeKutta = new frmRungeKutta(h, rangoEdadDesde, t0, z0, rangoEdadHasta, alfa, beta);
                tiemposAtencion = frmRungeKutta.rungeKutta();

                //comienzo de la simulacion en sí
                tasaClientes = tasaClientes / 60; // se pasa la tasa de clientes a clientes/minuto
                expNeg = new ExponencialNegativa(1 / tasaClientes);
                unifHacerEntender = new Uniforme(rangoEntenderDesde, rangoEntenderHasta);
                unifOtraTarea = new Uniforme(rangoTareaDesde, rangoTareaHasta);

                anterior = new VectorEstado();
                actual = new VectorEstado();
                actual.Reloj = 0;
                actual.Evento = "inicio_simulacion";
                for (int i = 0; i < 3; i++)
                {
                    actual.Dependientes[i] = new Dependiente();
                }
                actual.ColaAtencion = new Queue<Cliente>();
                List<Cliente> clientes = new List<Cliente>();
                
                empezoSimulacion = terminoSimulacion = false;

                while (actual.Linea <= N && !terminoSimulacion)
                {
                    anterior = actual;
                    actual = new VectorEstado();

                    //se copian los datos del vector anterior en el siguiente
                    copiarAnterior();

                    //se busca el evento siguiente y se asigna el nombre del evento al vector actual
                    buscarEvento();

                    resetearCampos();
                    actual.Linea++;
                    switch (actual.Evento)
                    {
                        case "inicio_simulacion":
                            
                            actual.RndLlegadaCliente = random.NextDouble();
                            actual.TiempoLlegadaCliente = expNeg.getRandomVar(actual.RndLlegadaCliente);
                            actual.ProximaLlegadaCliente = actual.Reloj + actual.TiempoLlegadaCliente;

                            actual.TiempoProximaTarea = minutosOtrasTareas;
                            actual.ProximaTarea = actual.Reloj + actual.TiempoProximaTarea;

                            empezoSimulacion = true;
                            break;

                        case "llegada_cliente":
                            actual.RndLlegadaCliente = random.NextDouble();
                            actual.TiempoLlegadaCliente = expNeg.getRandomVar(actual.RndLlegadaCliente);
                            actual.ProximaLlegadaCliente = actual.Reloj + actual.TiempoLlegadaCliente;

                            actual.RndMayorEdad = random.NextDouble();
                            actual.EsMayorEdad = actual.RndMayorEdad < probMayorEdad ? 1 : 0;
                            if (actual.EsMayorEdad == 1)
                            {
                                actual.RndEdad = random.NextDouble();
                                actual.Edad = aleatorioInt(rangoEdadDesde, rangoEdadHasta, actual.RndEdad);
                            }
                            else
                            {
                                actual.Edad = 0;
                            }
                            // en el caso de que no sea mayor de edad, la edad queda como 0
                            int pos = buscarClienteNulo(clientes);
                            Cliente nuevo;
                            if (pos == -1)
                            {
                                nuevo = new Cliente(actual.Edad);
                                nuevo.HoraEntradaCola = actual.Reloj;

                                nuevo.Nombre = "Cliente" + (clientes.Count + 1);
                                clientes.Add(nuevo);
                            }
                            else
                            {
                                nuevo = clientes.ElementAt(pos);
                                nuevo.Edad = actual.Edad;
                                nuevo.HoraEntradaCola = actual.Reloj;
                                nuevo.Atendido = false;
                            }

                            bool encontro = false;

                            //se busca un dependiente libre para atender al cliente nuevo
                            foreach (Dependiente dependiente in actual.Dependientes)
                            {
                                if (dependiente.estaLibre())
                                {
                                    nuevo.Estado = "SA";

                                    // sumo los acumuladores para el tiempo de espera y los clientes que pasaron por la cola.
                                    actual.AcTiempoEspera += actual.Reloj - nuevo.HoraEntradaCola;
                                    actual.AcClientesCola++;

                                    dependiente.ClienteAtendido = nuevo;
                                    dependiente.Estado = "Atendiendo";
                                    encontro = true;

                                    // si es mayor de edad, calculo el tiempo para hacer entender con runge kutta
                                    if (nuevo.Edad > 0)
                                    {
                                        actual.TiempoFinHacerEntender = tiemposAtencion[nuevo.Edad - rangoEdadDesde];
                                    }
                                    else //si no es mayor de edad, el tiempo está en un intervalo uniforme
                                    {
                                        actual.RndFinHacerEntender = random.NextDouble();
                                        actual.TiempoFinHacerEntender = unifHacerEntender.getRandomVar(actual.RndFinHacerEntender);
                                    }

                                    dependiente.ProximoFinHacerEntender = actual.Reloj + actual.TiempoFinHacerEntender;
                                    dependiente.HoraInicioOcupacion = actual.Reloj;
                                    break;
                                }
                            }
                            // si no había dependiente libre, se manda al cliente nuevo a la cola de espera
                            if (!encontro)
                            {
                                nuevo.Estado = "EA";
                                actual.ColaAtencion.Enqueue(nuevo);
                            }
                            break;

                        case "fin_hacer_entender1":

                            // por defecto, se reinicia el proximo fin de hacer entender del dependiente
                            actual.Dependientes[0].ProximoFinHacerEntender = -1;

                            //se suman los acumuladores para las estadísticas
                            actual.CantidadPersonasAtendidas++;
                            actual.AcTiempoOcupacion1 += actual.Reloj - actual.Dependientes[0].HoraInicioOcupacion;
                            if (actual.Dependientes[0].ClienteAtendido.Edad > 0) //si el cliente que terminó de atender es mayor de edad
                            {
                                actual.AcPersonasAtendidasMayoresEdad++;
                            }

                            //se calculan las estadísticas
                            if (actual.TiempoMaximoPermanenciaSistemaMayorEdad < actual.Reloj - actual.Dependientes[0].ClienteAtendido.HoraEntradaCola)
                            {
                                actual.TiempoMaximoPermanenciaSistemaMayorEdad = actual.Reloj - actual.Dependientes[0].ClienteAtendido.HoraEntradaCola;
                            }

                            //le borro el estado al cliente, porque ya no va a estar en el sistema.
                            actual.Dependientes[0].ClienteAtendido.Estado = "";
                            actual.Dependientes[0].ClienteAtendido.HoraEntradaCola = -1;
                            actual.Dependientes[0].ClienteAtendido.Edad = -1;
                            actual.Dependientes[0].ClienteAtendido.Atendido = true;
                            actual.Dependientes[0].ClienteAtendido = null; // saco al cliente del sistema

                            // si el dependiente tiene tareas para hacer
                            if (actual.Dependientes[0].TareasDependiente > 0)
                            {
                                actual.RndFinOtraTarea = random.NextDouble();
                                actual.TiempoFinOtraTarea = unifOtraTarea.getRandomVar(actual.RndFinOtraTarea);
                                actual.Dependientes[0].ProximoFinOtraTarea = actual.Reloj + actual.TiempoFinOtraTarea;

                                actual.Dependientes[0].Estado = "Otra tarea";
                                actual.Dependientes[0].TareasDependiente--;
                                actual.Dependientes[0].HoraInicioOcupacion = actual.Reloj;

                            }
                            else // si no tiene tareas para hacer
                            {

                                if (actual.ColaAtencion.Count > 0) // si hay clientes para atender en la cola
                                {
                                    actual.Dependientes[0].ClienteAtendido = actual.ColaAtencion.Dequeue();
                                    actual.Dependientes[0].ClienteAtendido.Estado = "SA";
                                    actual.Dependientes[0].Estado = "Atendiendo";

                                    //sumo los acumuladores y calculo las estadísticas con el cliente que saco de la cola
                                    actual.AcTiempoEspera += actual.Reloj - actual.Dependientes[0].ClienteAtendido.HoraEntradaCola;
                                    actual.AcClientesCola++;

                                    // si es mayor de edad, calculo el tiempo para hacer entender con runge kutta
                                    if (actual.Dependientes[0].ClienteAtendido.Edad > 0)
                                    {
                                        actual.TiempoFinHacerEntender = tiemposAtencion[actual.Dependientes[0].ClienteAtendido.Edad - rangoEdadDesde];
                                    }
                                    else //si no es mayor de edad, el tiempo está en un intervalo uniforme
                                    {
                                        actual.RndFinHacerEntender = random.NextDouble();
                                        actual.TiempoFinHacerEntender = unifHacerEntender.getRandomVar(actual.RndFinHacerEntender);
                                    }

                                    actual.Dependientes[0].ProximoFinHacerEntender = actual.Reloj + actual.TiempoFinHacerEntender;
                                    actual.Dependientes[0].HoraInicioOcupacion = actual.Reloj;
                                }
                                else
                                {
                                    actual.Dependientes[0].Estado = "Libre";
                                    actual.Dependientes[0].HoraInicioOcupacion = -1;
                                }
                            }
                            break;

                        case "fin_hacer_entender2":

                            // por defecto, se reinicia el proximo fin de hacer entender del dependiente
                            actual.Dependientes[1].ProximoFinHacerEntender = -1;
                            
                            //se suman los acumuladores para las estadísticas
                            actual.CantidadPersonasAtendidas++;
                            actual.AcTiempoOcupacion2 += actual.Reloj - actual.Dependientes[1].HoraInicioOcupacion;
                            if (actual.Dependientes[1].ClienteAtendido.Edad > 0) //si el cliente que terminó de atender es mayor de edad
                            {
                                actual.AcPersonasAtendidasMayoresEdad++;
                            }

                            //se calculan las estadísticas
                           
                            if (actual.TiempoMaximoPermanenciaSistemaMayorEdad < actual.Reloj - actual.Dependientes[1].ClienteAtendido.HoraEntradaCola)
                            {
                                actual.TiempoMaximoPermanenciaSistemaMayorEdad = actual.Reloj - actual.Dependientes[1].ClienteAtendido.HoraEntradaCola;
                            }

                            //le borro el estado al cliente, porque ya no va a estar en el sistema.
                            actual.Dependientes[1].ClienteAtendido.Estado = "";
                            actual.Dependientes[1].ClienteAtendido.HoraEntradaCola = -1;
                            actual.Dependientes[1].ClienteAtendido.Edad = -1;
                            actual.Dependientes[1].ClienteAtendido.Atendido = true;
                            actual.Dependientes[1].ClienteAtendido = null; // saco al cliente del sistema

                            // si el dependiente tiene tareas para hacer
                            if (actual.Dependientes[1].TareasDependiente > 0)
                            {
                                actual.RndFinOtraTarea = random.NextDouble();
                                actual.TiempoFinOtraTarea = unifOtraTarea.getRandomVar(actual.RndFinOtraTarea);
                                actual.Dependientes[1].ProximoFinOtraTarea = actual.Reloj + actual.TiempoFinOtraTarea;

                                actual.Dependientes[1].Estado = "Otra tarea";
                                actual.Dependientes[1].TareasDependiente--;
                                actual.Dependientes[1].HoraInicioOcupacion = actual.Reloj;

                            }
                            else // si no tiene tareas para hacer
                            {

                                if (actual.ColaAtencion.Count > 0) // si hay clientes para atender en la cola
                                {
                                    actual.Dependientes[1].ClienteAtendido = actual.ColaAtencion.Dequeue();
                                    actual.Dependientes[1].ClienteAtendido.Estado = "SA";
                                    actual.Dependientes[1].Estado = "Atendiendo";

                                    //sumo los acumuladores y calculo las estadísticas con el cliente que saco de la cola
                                    actual.AcTiempoEspera += actual.Reloj - actual.Dependientes[1].ClienteAtendido.HoraEntradaCola;
                                    actual.AcClientesCola++;

                                    // si es mayor de edad, calculo el tiempo para hacer entender con runge kutta
                                    if (actual.Dependientes[1].ClienteAtendido.Edad > 0)
                                    {
                                        actual.TiempoFinHacerEntender = tiemposAtencion[actual.Dependientes[1].ClienteAtendido.Edad - rangoEdadDesde];
                                    }
                                    else //si no es mayor de edad, el tiempo está en un intervalo uniforme
                                    {
                                        actual.RndFinHacerEntender = random.NextDouble();
                                        actual.TiempoFinHacerEntender = unifHacerEntender.getRandomVar(actual.RndFinHacerEntender);
                                    }

                                    actual.Dependientes[1].ProximoFinHacerEntender = actual.Reloj + actual.TiempoFinHacerEntender;
                                    actual.Dependientes[1].HoraInicioOcupacion = actual.Reloj;
                                }
                                else
                                {
                                    actual.Dependientes[1].Estado = "Libre";
                                    actual.Dependientes[1].HoraInicioOcupacion = -1;
                                }
                            }
                            break;
                        case "fin_hacer_entender3":

                            // por defecto, se reinicia el proximo fin de hacer entender del dependiente
                            actual.Dependientes[2].ProximoFinHacerEntender = -1;

                            //se suman los acumuladores para las estadísticas
                            actual.CantidadPersonasAtendidas++;
                            actual.AcTiempoOcupacion3 += actual.Reloj - actual.Dependientes[2].HoraInicioOcupacion;
                            if (actual.Dependientes[2].ClienteAtendido.Edad > 0) //si el cliente que terminó de atender es mayor de edad
                            {
                                actual.AcPersonasAtendidasMayoresEdad++;
                            }

                            //se calculan las estadísticas
                            if (actual.TiempoMaximoPermanenciaSistemaMayorEdad < actual.Reloj - actual.Dependientes[2].ClienteAtendido.HoraEntradaCola)
                            {
                                actual.TiempoMaximoPermanenciaSistemaMayorEdad = actual.Reloj - actual.Dependientes[2].ClienteAtendido.HoraEntradaCola;
                            }

                            //le borro el estado al cliente, porque ya no va a estar en el sistema.
                            actual.Dependientes[2].ClienteAtendido.Estado = "";
                            actual.Dependientes[2].ClienteAtendido.HoraEntradaCola = -1;
                            actual.Dependientes[2].ClienteAtendido.Edad = -1;
                            actual.Dependientes[2].ClienteAtendido.Atendido = true;
                            actual.Dependientes[2].ClienteAtendido = null; // saco al cliente del sistema

                            // si el dependiente tiene tareas para hacer
                            if (actual.Dependientes[2].TareasDependiente > 0)
                            {
                                actual.RndFinOtraTarea = random.NextDouble();
                                actual.TiempoFinOtraTarea = unifOtraTarea.getRandomVar(actual.RndFinOtraTarea);
                                actual.Dependientes[2].ProximoFinOtraTarea = actual.Reloj + actual.TiempoFinOtraTarea;

                                actual.Dependientes[2].Estado = "Otra tarea";
                                actual.Dependientes[2].TareasDependiente--;
                                actual.Dependientes[2].HoraInicioOcupacion = actual.Reloj;

                            }
                            else // si no tiene tareas para hacer
                            {

                                if (actual.ColaAtencion.Count > 0) // si hay clientes para atender en la cola
                                {
                                    actual.Dependientes[2].ClienteAtendido = actual.ColaAtencion.Dequeue();
                                    actual.Dependientes[2].ClienteAtendido.Estado = "SA";
                                    actual.Dependientes[2].Estado = "Atendiendo";

                                    //sumo los acumuladores y calculo las estadísticas con el cliente que saco de la cola
                                    actual.AcTiempoEspera += actual.Reloj - actual.Dependientes[2].ClienteAtendido.HoraEntradaCola;
                                    actual.AcClientesCola++;

                                    // si es mayor de edad, calculo el tiempo para hacer entender con runge kutta
                                    if (actual.Dependientes[2].ClienteAtendido.Edad > 0)
                                    {
                                        actual.TiempoFinHacerEntender = tiemposAtencion[actual.Dependientes[2].ClienteAtendido.Edad - rangoEdadDesde];
                                    }
                                    else //si no es mayor de edad, el tiempo está en un intervalo uniforme
                                    {
                                        actual.RndFinHacerEntender = random.NextDouble();
                                        actual.TiempoFinHacerEntender = unifHacerEntender.getRandomVar(actual.RndFinHacerEntender);
                                    }

                                    actual.Dependientes[2].ProximoFinHacerEntender = actual.Reloj + actual.TiempoFinHacerEntender;
                                    actual.Dependientes[2].HoraInicioOcupacion = actual.Reloj;
                                }
                                else
                                {
                                    actual.Dependientes[2].Estado = "Libre";
                                    actual.Dependientes[2].HoraInicioOcupacion = -1;
                                }
                            }
                            break;

                        case "inicio_otra_tarea":

                            actual.TiempoProximaTarea = minutosOtrasTareas;
                            actual.ProximaTarea = actual.Reloj + actual.TiempoProximaTarea;
                            actual.RndDependienteTarea = random.NextDouble();
                            actual.DependienteTarea = aleatorioInt(1, 3, actual.RndDependienteTarea);

                            //le sumo una tarea al dependiente que le tocó
                            actual.Dependientes[actual.DependienteTarea - 1].TareasDependiente++;
                            if (actual.Dependientes[actual.DependienteTarea - 1].estaLibre()) // si está libre, lo pongo a hacer la tarea que tiene
                            {
                                actual.RndFinOtraTarea = random.NextDouble();
                                actual.TiempoFinOtraTarea = unifOtraTarea.getRandomVar(actual.RndFinOtraTarea);
                                actual.Dependientes[actual.DependienteTarea - 1].ProximoFinOtraTarea = actual.Reloj + actual.TiempoFinOtraTarea;

                                actual.Dependientes[actual.DependienteTarea - 1].Estado = "Otra tarea";
                                actual.Dependientes[actual.DependienteTarea - 1].TareasDependiente--;
                                actual.Dependientes[actual.DependienteTarea - 1].HoraInicioOcupacion = actual.Reloj;
                            }
                            break;

                        case "fin_otra_tarea1":
                            // por defecto se reinicia el proximo fin de otra tarea del dependiente
                            actual.Dependientes[0].ProximoFinOtraTarea = -1;

                            // se suman los acumuladores para las estadísticas
                            actual.AcTiempoOcupacion1 += actual.Reloj - actual.Dependientes[0].HoraInicioOcupacion;
                            actual.AcTiempoOcupacionIrrelevante1 += actual.Reloj - actual.Dependientes[0].HoraInicioOcupacion;

                            // si el dependiente tiene tareas para hacer
                            if (actual.Dependientes[0].TareasDependiente > 0)
                            {
                                actual.RndFinOtraTarea = random.NextDouble();
                                actual.TiempoFinOtraTarea = unifOtraTarea.getRandomVar(actual.RndFinOtraTarea);
                                actual.Dependientes[0].ProximoFinOtraTarea = actual.Reloj + actual.TiempoFinOtraTarea;

                                actual.Dependientes[0].Estado = "Otra tarea";
                                actual.Dependientes[0].TareasDependiente--;
                                actual.Dependientes[0].HoraInicioOcupacion = actual.Reloj;

                            }
                            else // si no tiene tareas para hacer
                            {

                                if (actual.ColaAtencion.Count > 0) // si hay clientes para atender en la cola
                                {
                                    actual.Dependientes[0].ClienteAtendido = actual.ColaAtencion.Dequeue();
                                    actual.Dependientes[0].ClienteAtendido.Estado = "SA";
                                    actual.Dependientes[0].Estado = "Atendiendo";

                                    //sumo los acumuladores y calculo las estadísticas con el cliente que saco de la cola
                                    actual.AcTiempoEspera += actual.Reloj - actual.Dependientes[0].ClienteAtendido.HoraEntradaCola;
                                    actual.AcClientesCola++;                                    

                                    // si es mayor de edad, calculo el tiempo para hacer entender con runge kutta
                                    if (actual.Dependientes[0].ClienteAtendido.Edad > 0)
                                    {
                                        actual.TiempoFinHacerEntender = tiemposAtencion[actual.Dependientes[0].ClienteAtendido.Edad - rangoEdadDesde];
                                    }
                                    else //si no es mayor de edad, el tiempo está en un intervalo uniforme
                                    {
                                        actual.RndFinHacerEntender = random.NextDouble();
                                        actual.TiempoFinHacerEntender = unifHacerEntender.getRandomVar(actual.RndFinHacerEntender);
                                    }

                                    actual.Dependientes[0].ProximoFinHacerEntender = actual.Reloj + actual.TiempoFinHacerEntender;
                                    actual.Dependientes[0].HoraInicioOcupacion = actual.Reloj;
                                }
                                else
                                {
                                    actual.Dependientes[0].Estado = "Libre";
                                    actual.Dependientes[0].HoraInicioOcupacion = -1;
                                }
                            }
                            break;

                        case "fin_otra_tarea2":

                            // por defecto se reinicia el proximo fin de otra tarea del dependiente
                            actual.Dependientes[1].ProximoFinOtraTarea = -1;

                            // se suman los acumuladores para las estadísticas
                            actual.AcTiempoOcupacion2 += actual.Reloj - actual.Dependientes[1].HoraInicioOcupacion;
                            actual.AcTiempoOcupacionIrrelevante2 += actual.Reloj - actual.Dependientes[1].HoraInicioOcupacion;

                            // si el dependiente tiene tareas para hacer
                            if (actual.Dependientes[1].TareasDependiente > 0)
                            {
                                actual.RndFinOtraTarea = random.NextDouble();
                                actual.TiempoFinOtraTarea = unifOtraTarea.getRandomVar(actual.RndFinOtraTarea);
                                actual.Dependientes[1].ProximoFinOtraTarea = actual.Reloj + actual.TiempoFinOtraTarea;

                                actual.Dependientes[1].Estado = "Otra tarea";
                                actual.Dependientes[1].TareasDependiente--;
                                actual.Dependientes[1].HoraInicioOcupacion = actual.Reloj;

                            }
                            else // si no tiene tareas para hacer
                            {

                                if (actual.ColaAtencion.Count > 0) // si hay clientes para atender en la cola
                                {
                                    actual.Dependientes[1].ClienteAtendido = actual.ColaAtencion.Dequeue();
                                    actual.Dependientes[1].ClienteAtendido.Estado = "SA";
                                    actual.Dependientes[1].Estado = "Atendiendo";

                                    //sumo los acumuladores y calculo las estadísticas con el cliente que saco de la cola
                                    actual.AcTiempoEspera += actual.Reloj - actual.Dependientes[1].ClienteAtendido.HoraEntradaCola;
                                    actual.AcClientesCola++;

                                    // si es mayor de edad, calculo el tiempo para hacer entender con runge kutta
                                    if (actual.Dependientes[1].ClienteAtendido.Edad > 0)
                                    {
                                        actual.TiempoFinHacerEntender = tiemposAtencion[actual.Dependientes[1].ClienteAtendido.Edad - rangoEdadDesde];
                                    }
                                    else //si no es mayor de edad, el tiempo está en un intervalo uniforme
                                    {
                                        actual.RndFinHacerEntender = random.NextDouble();
                                        actual.TiempoFinHacerEntender = unifHacerEntender.getRandomVar(actual.RndFinHacerEntender);
                                    }

                                    actual.Dependientes[1].ProximoFinHacerEntender = actual.Reloj + actual.TiempoFinHacerEntender;
                                    actual.Dependientes[1].HoraInicioOcupacion = actual.Reloj;
                                }
                                else
                                {
                                    actual.Dependientes[1].Estado = "Libre";
                                    actual.Dependientes[1].HoraInicioOcupacion = -1;
                                }
                            }
                            break;

                        case "fin_otra_tarea3":

                            // por defecto se reinicia el proximo fin de otra tarea del dependiente
                            actual.Dependientes[2].ProximoFinOtraTarea = -1;

                            // se suman los acumuladores para las estadísticas
                            actual.AcTiempoOcupacion3 += actual.Reloj - actual.Dependientes[2].HoraInicioOcupacion;
                            actual.AcTiempoOcupacionIrrelevante3 += actual.Reloj - actual.Dependientes[2].HoraInicioOcupacion;

                            // si el dependiente tiene tareas para hacer
                            if (actual.Dependientes[2].TareasDependiente > 0)
                            {
                                actual.RndFinOtraTarea = random.NextDouble();
                                actual.TiempoFinOtraTarea = unifOtraTarea.getRandomVar(actual.RndFinOtraTarea);
                                actual.Dependientes[2].ProximoFinOtraTarea = actual.Reloj + actual.TiempoFinOtraTarea;

                                actual.Dependientes[2].Estado = "Otra tarea";
                                actual.Dependientes[2].TareasDependiente--;
                                actual.Dependientes[2].HoraInicioOcupacion = actual.Reloj;

                            }
                            else // si no tiene tareas para hacer
                            {

                                if (actual.ColaAtencion.Count > 0) // si hay clientes para atender en la cola
                                {
                                    actual.Dependientes[2].ClienteAtendido = actual.ColaAtencion.Dequeue();
                                    actual.Dependientes[2].ClienteAtendido.Estado = "SA";
                                    actual.Dependientes[2].Estado = "Atendiendo";

                                    //sumo los acumuladores y calculo las estadísticas con el cliente que saco de la cola
                                    actual.AcTiempoEspera += actual.Reloj - actual.Dependientes[2].ClienteAtendido.HoraEntradaCola;
                                    actual.AcClientesCola++;

                                    // si es mayor de edad, calculo el tiempo para hacer entender con runge kutta
                                    if (actual.Dependientes[2].ClienteAtendido.Edad > 0)
                                    {
                                        actual.TiempoFinHacerEntender = tiemposAtencion[actual.Dependientes[2].ClienteAtendido.Edad - rangoEdadDesde];
                                    }
                                    else //si no es mayor de edad, el tiempo está en un intervalo uniforme
                                    {
                                        actual.RndFinHacerEntender = random.NextDouble();
                                        actual.TiempoFinHacerEntender = unifHacerEntender.getRandomVar(actual.RndFinHacerEntender);
                                    }

                                    actual.Dependientes[2].ProximoFinHacerEntender = actual.Reloj + actual.TiempoFinHacerEntender;
                                    actual.Dependientes[2].HoraInicioOcupacion = actual.Reloj;
                                }
                                else
                                {
                                    actual.Dependientes[2].Estado = "Libre";
                                    actual.Dependientes[2].HoraInicioOcupacion = -1;
                                }
                            }
                            break;

                        case "fin_simulacion":

                            //sumar acumuladores y calcular estadísticas de ocupación
                            if (!actual.Dependientes[0].estaLibre())
                            {
                                actual.AcTiempoOcupacion1 += actual.Reloj - actual.Dependientes[0].HoraInicioOcupacion;
                                if (actual.Dependientes[0].Estado == "Otra tarea")
                                {
                                    actual.AcTiempoOcupacionIrrelevante1 += actual.Reloj - actual.Dependientes[0].HoraInicioOcupacion;
                                }
                            }

                            if (!actual.Dependientes[1].estaLibre())
                            {
                                actual.AcTiempoOcupacion2 += actual.Reloj - actual.Dependientes[1].HoraInicioOcupacion;
                                if (actual.Dependientes[1].Estado == "Otra tarea")
                                {
                                    actual.AcTiempoOcupacionIrrelevante2 += actual.Reloj - actual.Dependientes[1].HoraInicioOcupacion;
                                }
                            }

                            if (!actual.Dependientes[2].estaLibre())
                            {
                                actual.AcTiempoOcupacion3 += actual.Reloj - actual.Dependientes[2].HoraInicioOcupacion;
                                if (actual.Dependientes[2].Estado == "Otra tarea")
                                {
                                    actual.AcTiempoOcupacionIrrelevante3 += actual.Reloj - actual.Dependientes[2].HoraInicioOcupacion;
                                }
                            }

                            terminoSimulacion = true;
                            break;
                    }
                    calcularEstadisticas(actual);
                    if (rbtTodas.Checked || (rbtAlgunas.Checked && actual.Linea >= mostrarDesde && actual.Linea < mostrarDesde + lineas) || terminoSimulacion)
                    {
                        agregarDatosDGV(actual);

                        agregarClientesDGV(actual, clientes);
                    }

                }
            }
        }

        private int buscarClienteNulo(List<Cliente> clientes)
        {
            int res = -1;
            for (int i = 0; i < clientes.Count; i++)
            {
                Cliente c = clientes.ElementAt(i);
                if (c.Estado == "")
                {
                    res = i;
                    break;
                }
            }
            return res;
        }
        private void calcularEstadisticas(VectorEstado actual)
        {
            actual.GradoOcupacionDependiente1 = actual.Reloj == 0 ? 0 : 100 * actual.AcTiempoOcupacion1 / actual.Reloj;
            actual.GradoOcupacionDependiente2 = actual.Reloj == 0 ? 0 : 100 * actual.AcTiempoOcupacion2 / actual.Reloj;
            actual.GradoOcupacionDependiente3 = actual.Reloj == 0 ? 0 : 100 * actual.AcTiempoOcupacion3 / actual.Reloj;

            actual.EsperaPromedioCola = actual.AcClientesCola == 0 ? 0 : actual.AcTiempoEspera / (double)actual.AcClientesCola;

            // la cantidad de personas atendidas se tiene que calcular en los fines de atención de clientes.

            actual.PorcentajeClientesAtendidosMayoresEdad = actual.CantidadPersonasAtendidas == 0 ? 0 : 100 * actual.AcPersonasAtendidasMayoresEdad / actual.CantidadPersonasAtendidas;
            actual.PorcentajeOcupacionIrrelevante1 = actual.AcTiempoOcupacion1 == 0 ? 0 : 100 * actual.AcTiempoOcupacionIrrelevante1 / actual.AcTiempoOcupacion1;
            actual.PorcentajeOcupacionIrrelevante2 = actual.AcTiempoOcupacion2 == 0 ? 0 : 100 * actual.AcTiempoOcupacionIrrelevante2 / actual.AcTiempoOcupacion2;
            actual.PorcentajeOcupacionIrrelevante3 = actual.AcTiempoOcupacion3 == 0 ? 0 : 100 * actual.AcTiempoOcupacionIrrelevante3 / actual.AcTiempoOcupacion3;

            // el tiempo máximo de permanencia en sistema para mayores de edad se tiene que calcular en los fines de atención.
        }
        private void agregarDatosDGV(VectorEstado actual)
        {
            String linea = actual.Linea.ToString();
            String evento = actual.Evento;
            double reloj = Math.Round(actual.Reloj, 2);
            String rndLlegadaCliente, tiempoLlegadaCliente, proximaLlegadaCliente, rndMayorEdad, esMayorEdad, rndEdad, edad, rndFinHacerEntender, tiempoFinHacerEntender, proximoFinHacerEntender1, 
                proximoFinHacerEntender2, proximoFinHacerEntender3, tiempoProximaTarea, proximaTarea, rndDependienteTarea, dependienteTarea, tareasDependiente1, tareasDependiente2, tareasDependiente3, 
                rndFinOtraTarea, tiempoFinOtraTarea, proximoFinOtraTarea1, proximoFinOtraTarea2, proximoFinOtraTarea3, estadoDependiente1, horaComienzoOcupacion1, estadoDependiente2, horaComienzoOcupacion2, 
                estadoDependiente3, horaComienzoOcupacion3, colaAtencion, gradoOcupacionDependiente1, gradoOcupacionDependiente2, gradoOcupacionDependiente3, esperaPromedioCola, cantidadPersonasAtendidas, 
                porcentajeClientesAtendidosMayoresEdad, porcentajeOcupacionIrrelevante1, porcentajeOcupacionIrrelevante2, porcentajeOcupacionIrrelevante3, tiempoMaximoPermanenciaSistemaMayorEdad, acTiempoOcupacion1, 
                acTiempoOcupacion2, acTiempoOcupacion3, acTiempoEspera, acClientesCola, acPersonasAtendidasMayoresEdad, acTiempoOcupacionIrrelevante1, acTiempoOcupacionIrrelevante2, acTiempoOcupacionIrrelevante3;

            rndLlegadaCliente = tiempoLlegadaCliente = proximaLlegadaCliente = rndMayorEdad = esMayorEdad = rndEdad = edad = rndFinHacerEntender = tiempoFinHacerEntender = proximoFinHacerEntender1 =
                proximoFinHacerEntender2 = proximoFinHacerEntender3 = tiempoProximaTarea = proximaTarea = rndDependienteTarea = dependienteTarea = tareasDependiente1 = tareasDependiente2 = tareasDependiente3 =
                rndFinOtraTarea = tiempoFinOtraTarea = proximoFinOtraTarea1 = proximoFinOtraTarea2 = proximoFinOtraTarea3 = estadoDependiente1 = horaComienzoOcupacion1 = estadoDependiente2 = horaComienzoOcupacion2 =
                estadoDependiente3 = horaComienzoOcupacion3 = colaAtencion = gradoOcupacionDependiente1 = gradoOcupacionDependiente2 = gradoOcupacionDependiente3 = esperaPromedioCola = cantidadPersonasAtendidas =
                porcentajeClientesAtendidosMayoresEdad = porcentajeOcupacionIrrelevante1 = porcentajeOcupacionIrrelevante2 = porcentajeOcupacionIrrelevante3 = tiempoMaximoPermanenciaSistemaMayorEdad = acTiempoOcupacion1 =
                acTiempoOcupacion2 = acTiempoOcupacion3 = acTiempoEspera = acClientesCola = acPersonasAtendidasMayoresEdad = acTiempoOcupacionIrrelevante1 = acTiempoOcupacionIrrelevante2 = acTiempoOcupacionIrrelevante3 = "";

            if (actual.RndLlegadaCliente > 0) rndLlegadaCliente = Math.Round(actual.RndLlegadaCliente, 2).ToString();
            if (actual.TiempoLlegadaCliente > 0) tiempoLlegadaCliente = Math.Round(actual.TiempoLlegadaCliente, 2).ToString();
            if (actual.ProximaLlegadaCliente > 0) proximaLlegadaCliente = Math.Round(actual.ProximaLlegadaCliente, 2).ToString();
            if (actual.RndMayorEdad > 0) rndMayorEdad = Math.Round(actual.RndMayorEdad, 2).ToString();
            esMayorEdad = actual.EsMayorEdad > 0 ? "Sí" : (actual.EsMayorEdad == 0 ? "No":"");
            if (actual.RndEdad > 0) rndEdad = Math.Round(actual.RndEdad, 2).ToString();
            edad = actual.Edad > 0 ? actual.Edad.ToString() : (actual.Edad == 0 ? "<70":"");
            if (actual.RndFinHacerEntender > 0) rndFinHacerEntender = Math.Round(actual.RndFinHacerEntender, 2).ToString();
            if (actual.TiempoFinHacerEntender > 0) tiempoFinHacerEntender = Math.Round(actual.TiempoFinHacerEntender, 2).ToString();
            if (actual.Dependientes[0].ProximoFinHacerEntender > 0) proximoFinHacerEntender1 = Math.Round(actual.Dependientes[0].ProximoFinHacerEntender, 2).ToString();
            if (actual.Dependientes[1].ProximoFinHacerEntender > 0) proximoFinHacerEntender2 = Math.Round(actual.Dependientes[1].ProximoFinHacerEntender, 2).ToString();
            if (actual.Dependientes[2].ProximoFinHacerEntender > 0) proximoFinHacerEntender3 = Math.Round(actual.Dependientes[2].ProximoFinHacerEntender, 2).ToString();
            if (actual.TiempoProximaTarea > 0) tiempoProximaTarea = Math.Round(actual.TiempoProximaTarea, 2).ToString();
            if (actual.ProximaTarea > 0) proximaTarea = Math.Round(actual.ProximaTarea, 2).ToString();
            if (actual.RndDependienteTarea > 0) rndDependienteTarea = Math.Round(actual.RndDependienteTarea, 2).ToString();
            if (actual.DependienteTarea > 0) dependienteTarea = actual.DependienteTarea.ToString();
            tareasDependiente1 = actual.Dependientes[0].TareasDependiente.ToString();
            tareasDependiente2 = actual.Dependientes[1].TareasDependiente.ToString();
            tareasDependiente3 = actual.Dependientes[2].TareasDependiente.ToString();
            if (actual.RndFinOtraTarea > 0) rndFinOtraTarea = Math.Round(actual.RndFinOtraTarea, 2).ToString();
            if (actual.TiempoFinOtraTarea > 0) tiempoFinOtraTarea = Math.Round(actual.TiempoFinOtraTarea, 2).ToString();
            if (actual.Dependientes[0].ProximoFinOtraTarea > 0) proximoFinOtraTarea1 = Math.Round(actual.Dependientes[0].ProximoFinOtraTarea, 2).ToString();
            if (actual.Dependientes[1].ProximoFinOtraTarea > 0) proximoFinOtraTarea2 = Math.Round(actual.Dependientes[1].ProximoFinOtraTarea, 2).ToString();
            if (actual.Dependientes[2].ProximoFinOtraTarea > 0) proximoFinOtraTarea3 = Math.Round(actual.Dependientes[2].ProximoFinOtraTarea, 2).ToString();
            estadoDependiente1 = actual.Dependientes[0].Estado;
            estadoDependiente2 = actual.Dependientes[1].Estado;
            estadoDependiente3 = actual.Dependientes[2].Estado;
            if (actual.Dependientes[0].HoraInicioOcupacion > 0) horaComienzoOcupacion1 = Math.Round(actual.Dependientes[0].HoraInicioOcupacion, 2).ToString();
            if (actual.Dependientes[1].HoraInicioOcupacion > 0) horaComienzoOcupacion2 = Math.Round(actual.Dependientes[1].HoraInicioOcupacion, 2).ToString();
            if (actual.Dependientes[2].HoraInicioOcupacion > 0) horaComienzoOcupacion3 = Math.Round(actual.Dependientes[2].HoraInicioOcupacion, 2).ToString();
            colaAtencion = actual.ColaAtencion.Count.ToString();
            gradoOcupacionDependiente1 = Math.Round(actual.GradoOcupacionDependiente1, 2).ToString() + "%";
            gradoOcupacionDependiente2 = Math.Round(actual.GradoOcupacionDependiente2, 2).ToString() + "%";
            gradoOcupacionDependiente3 = Math.Round(actual.GradoOcupacionDependiente3, 2).ToString() + "%";
            esperaPromedioCola = Math.Round(actual.EsperaPromedioCola, 2).ToString();
            cantidadPersonasAtendidas = actual.CantidadPersonasAtendidas.ToString();
            porcentajeClientesAtendidosMayoresEdad = Math.Round(actual.PorcentajeClientesAtendidosMayoresEdad, 2).ToString() + "%";
            porcentajeOcupacionIrrelevante1 = Math.Round(actual.PorcentajeOcupacionIrrelevante1, 2).ToString() + "%";
            porcentajeOcupacionIrrelevante2 = Math.Round(actual.PorcentajeOcupacionIrrelevante2, 2).ToString() + "%";
            porcentajeOcupacionIrrelevante3 = Math.Round(actual.PorcentajeOcupacionIrrelevante3, 2).ToString() + "%";
            tiempoMaximoPermanenciaSistemaMayorEdad = Math.Round(actual.TiempoMaximoPermanenciaSistemaMayorEdad, 2).ToString();
            acTiempoOcupacion1 = Math.Round(actual.AcTiempoOcupacion1, 2).ToString();
            acTiempoOcupacion2 = Math.Round(actual.AcTiempoOcupacion2, 2).ToString();
            acTiempoOcupacion3 = Math.Round(actual.AcTiempoOcupacion3, 2).ToString();
            acTiempoEspera = Math.Round(actual.AcTiempoEspera, 2).ToString();
            acClientesCola = actual.AcClientesCola.ToString();
            acPersonasAtendidasMayoresEdad = actual.AcPersonasAtendidasMayoresEdad.ToString();
            acTiempoOcupacionIrrelevante1 = Math.Round(actual.AcTiempoOcupacionIrrelevante1, 2).ToString();
            acTiempoOcupacionIrrelevante2 = Math.Round(actual.AcTiempoOcupacionIrrelevante2, 2).ToString();
            acTiempoOcupacionIrrelevante3 = Math.Round(actual.AcTiempoOcupacionIrrelevante3, 2).ToString();

            dgvFuncion.Rows.Add(linea, evento, reloj, rndLlegadaCliente, tiempoLlegadaCliente, proximaLlegadaCliente, rndMayorEdad, esMayorEdad, rndEdad, edad, rndFinHacerEntender, tiempoFinHacerEntender, proximoFinHacerEntender1,
                proximoFinHacerEntender2, proximoFinHacerEntender3, tiempoProximaTarea, proximaTarea, rndDependienteTarea, dependienteTarea, tareasDependiente1, tareasDependiente2, tareasDependiente3,
                rndFinOtraTarea, tiempoFinOtraTarea, proximoFinOtraTarea1, proximoFinOtraTarea2, proximoFinOtraTarea3, estadoDependiente1, horaComienzoOcupacion1, estadoDependiente2, horaComienzoOcupacion2,
                estadoDependiente3, horaComienzoOcupacion3, colaAtencion, gradoOcupacionDependiente1, gradoOcupacionDependiente2, gradoOcupacionDependiente3, esperaPromedioCola, cantidadPersonasAtendidas,
                porcentajeClientesAtendidosMayoresEdad, porcentajeOcupacionIrrelevante1, porcentajeOcupacionIrrelevante2, porcentajeOcupacionIrrelevante3, tiempoMaximoPermanenciaSistemaMayorEdad, acTiempoOcupacion1,
                acTiempoOcupacion2, acTiempoOcupacion3, acTiempoEspera, acClientesCola, acPersonasAtendidasMayoresEdad, acTiempoOcupacionIrrelevante1, acTiempoOcupacionIrrelevante2, acTiempoOcupacionIrrelevante3);

        }
        private void agregarClientesDGV(VectorEstado actual, List<Cliente> clientes)
        {
            /*dgvClientes.Rows.Add(actual.Linea.ToString());
            for (int k = 0; k < clientes.Count; k++)
            {
                Cliente c = clientes.ElementAt(k);
                if (dgvClientes.Columns.Contains("Estado " + c.Nombre))
                {
                    dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells["Estado " + c.Nombre].Value = c.Estado;
                    dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells["Hora Entrada Cola " + c.Nombre].Value = Math.Round(c.HoraEntradaCola, 2).ToString();
                    dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells["Edad " + c.Nombre].Value = c.Edad == -1 ? "" : (c.Edad > 0 ? c.Edad.ToString() : "<70");
                }
                else
                {
                    DataGridViewTextBoxColumn columnaEstado = new DataGridViewTextBoxColumn();
                    columnaEstado.HeaderText = "Estado " + c.Nombre;
                    columnaEstado.Name = "Estado " + c.Nombre;
                    columnaEstado.MinimumWidth = 20;
                    columnaEstado.Width = 30;
                    columnaEstado.FillWeight = 30;
                    dgvClientes.Columns.Add(columnaEstado);
                    dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells["Estado " + c.Nombre].Value = c.Estado;

                    DataGridViewTextBoxColumn columnaHoraEntradaCola = new DataGridViewTextBoxColumn();
                    columnaHoraEntradaCola.HeaderText = "Hora Entrada Cola " + c.Nombre;
                    columnaHoraEntradaCola.Name = "Hora Entrada Cola " + c.Nombre;
                    columnaHoraEntradaCola.MinimumWidth = 20;
                    columnaHoraEntradaCola.Width = 30;
                    columnaHoraEntradaCola.FillWeight = 30;
                    dgvClientes.Columns.Add(columnaHoraEntradaCola);
                    dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells["Hora Entrada Cola " + c.Nombre].Value = Math.Round(c.HoraEntradaCola, 2).ToString();

                    DataGridViewTextBoxColumn columnaEdad = new DataGridViewTextBoxColumn();
                    columnaEdad.HeaderText = "Edad " + c.Nombre;
                    columnaEdad.Name = "Edad " + c.Nombre;
                    columnaEdad.MinimumWidth = 20;
                    columnaEdad.Width = 30;
                    columnaEdad.FillWeight = 30;
                    dgvClientes.Columns.Add(columnaEdad);
                    dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells["Edad " + c.Nombre].Value = c.Edad == -1 ? "" : (c.Edad > 0 ? c.Edad.ToString() : "<70") ;
                }
            }*/
            /*dgvClientes.Rows.Add(actual.Linea.ToString());
            for (int k = 0; k < clientes.Count; k++)
            {
                bool clienteEncontrado = false;
                Cliente c = clientes.ElementAt(k);

                for (int i = 1; i < dgvClientes.Columns.Count; i += 3)
                {
                    if (dgvClientes.Columns[i].Name == "Estado " + c.Nombre)
                    {
                        clienteEncontrado = true;
                        dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[i].Value = c.Estado;
                        dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[i+1].Value = Math.Round(c.HoraEntradaCola, 2).ToString();
                        dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[i+2].Value = c.Edad == -1 ? "" : (c.Edad > 0 ? c.Edad.ToString() : "<70");
                        break;
                    }
                }
                if (!clienteEncontrado)
                {
                    DataGridViewTextBoxColumn columnaEstado = new DataGridViewTextBoxColumn();
                    columnaEstado.HeaderText = "Estado " + c.Nombre;
                    columnaEstado.Name = "Estado " + c.Nombre;
                    columnaEstado.MinimumWidth = 20;
                    columnaEstado.Width = 30;
                    columnaEstado.FillWeight = 30;
                    dgvClientes.Columns.Add(columnaEstado);
                    dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[dgvClientes.Columns.Count - 1].Value = c.Estado;

                    DataGridViewTextBoxColumn columnaHoraEntradaCola = new DataGridViewTextBoxColumn();
                    columnaHoraEntradaCola.HeaderText = "Hora Entrada Cola " + c.Nombre;
                    columnaHoraEntradaCola.Name = "Hora Entrada Cola " + c.Nombre;
                    columnaHoraEntradaCola.MinimumWidth = 20;
                    columnaHoraEntradaCola.Width = 30;
                    columnaHoraEntradaCola.FillWeight = 30;
                    dgvClientes.Columns.Add(columnaHoraEntradaCola);
                    dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[dgvClientes.Columns.Count - 1].Value = Math.Round(c.HoraEntradaCola, 2).ToString();

                    DataGridViewTextBoxColumn columnaEdad = new DataGridViewTextBoxColumn();
                    columnaEdad.HeaderText = "Edad " + c.Nombre;
                    columnaEdad.Name = "Edad " + c.Nombre;
                    columnaEdad.MinimumWidth = 20;
                    columnaEdad.Width = 30;
                    columnaEdad.FillWeight = 30;
                    dgvClientes.Columns.Add(columnaEdad);
                    dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[dgvClientes.Columns.Count - 1].Value = c.Edad == -1 ? "" : (c.Edad > 0 ? c.Edad.ToString() : "<70");
                }
            }*/
            /*dgvClientes.Rows.Add(actual.Linea.ToString());
            for (int k = 0; k < clientes.Count; k++)
            {
                bool clienteEncontrado = false;
                Cliente c = clientes.ElementAt(k);
                if (c.Estado == "")
                {
                    continue;
                }
                int pos = (k*3)+1 < dgvClientes.Columns.Count ? (k*3) + 1 : dgvClientes.Columns.Count;
                for (int i = pos; i < dgvClientes.Columns.Count; i += 3)
                {
                    if (dgvClientes.Columns[i].Name == "Estado " + c.Nombre)
                    {
                        clienteEncontrado = true;
                        dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[i].Value = c.Estado;
                        dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[i + 1].Value = c.HoraEntradaCola == -1 ? "" : Math.Round(c.HoraEntradaCola, 2).ToString(); 
                        dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[i + 2].Value = c.Edad == -1 ? "" : (c.Edad > 0 ? c.Edad.ToString() : "<70");
                        break;
                    }
                }
                if (!clienteEncontrado)
                {
                    DataGridViewTextBoxColumn columnaEstado = new DataGridViewTextBoxColumn();
                    columnaEstado.HeaderText = "Estado " + c.Nombre;
                    columnaEstado.Name = "Estado " + c.Nombre;
                    columnaEstado.MinimumWidth = 20;
                    columnaEstado.Width = 30;
                    columnaEstado.FillWeight = 30;
                    dgvClientes.Columns.Add(columnaEstado);
                    dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[dgvClientes.Columns.Count - 1].Value = c.Estado;

                    DataGridViewTextBoxColumn columnaHoraEntradaCola = new DataGridViewTextBoxColumn();
                    columnaHoraEntradaCola.HeaderText = "Hora Entrada Cola " + c.Nombre;
                    columnaHoraEntradaCola.Name = "Hora Entrada Cola " + c.Nombre;
                    columnaHoraEntradaCola.MinimumWidth = 20;
                    columnaHoraEntradaCola.Width = 30;
                    columnaHoraEntradaCola.FillWeight = 30;
                    dgvClientes.Columns.Add(columnaHoraEntradaCola);
                    dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[dgvClientes.Columns.Count - 1].Value = Math.Round(c.HoraEntradaCola, 2).ToString();

                    DataGridViewTextBoxColumn columnaEdad = new DataGridViewTextBoxColumn();
                    columnaEdad.HeaderText = "Edad " + c.Nombre;
                    columnaEdad.Name = "Edad " + c.Nombre;
                    columnaEdad.MinimumWidth = 20;
                    columnaEdad.Width = 30;
                    columnaEdad.FillWeight = 30;
                    dgvClientes.Columns.Add(columnaEdad);
                    dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[dgvClientes.Columns.Count - 1].Value = c.Edad == -1 ? "" : (c.Edad > 0 ? c.Edad.ToString() : "<70");
                }
            }*/
            dgvClientes.Rows.Add(actual.Linea.ToString());
            for (int k = 0; k < clientes.Count; k++)
            {
                Cliente c = clientes.ElementAt(k);
                if (c.Estado == "")
                {
                    if (c.Atendido && (rbtTodas.Checked))
                    {
                        dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[k + 1].Style.BackColor = Color.LightGreen;
                        c.Atendido = false;
                    }
                    continue;
                }
                StringBuilder sb = new StringBuilder();
                sb.Append(c.Estado);
                sb.Append(" | ");
                sb.Append(c.HoraEntradaCola == -1 ? "" : Math.Round(c.HoraEntradaCola, 2).ToString());
                sb.Append(" | ");
                sb.Append(c.Edad == -1 ? "" : (c.Edad > 0 ? c.Edad.ToString() : "<70"));

                int pos = k+1 < dgvClientes.Columns.Count ? k+1 : dgvClientes.Columns.Count - 1;
                if (dgvClientes.Columns[pos].Name == c.Nombre)
                {
                    dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[pos].Value = sb.ToString();
                }
                else
                {
                    DataGridViewTextBoxColumn columnaCliente = new DataGridViewTextBoxColumn();
                    columnaCliente.HeaderText = c.Nombre;
                    columnaCliente.Name = c.Nombre;
                    columnaCliente.MinimumWidth = 20;
                    columnaCliente.Width = 80;
                    columnaCliente.FillWeight = 1;
                    dgvClientes.Columns.Add(columnaCliente);
                    dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[dgvClientes.Columns.Count - 1].Value = sb.ToString();
                }
            }
        }

        private void buscarEvento()
        {
            String evento = "fin_simulacion";
            
            if (actual.Linea == N)
            {
                actual.Evento = evento;
                return;
            }
            double minimo = actual.ProximaLlegadaCliente;

            if (actual.Reloj == 0 && !empezoSimulacion)
            {
                evento = "inicio_simulacion";
                return;
            }
            if (minimo >= actual.ProximaLlegadaCliente && actual.ProximaLlegadaCliente > 0)
            {
                evento = "llegada_cliente";
                minimo = actual.ProximaLlegadaCliente;
            }
            for (int i = 0; i < actual.Dependientes.Length; i++)
            {
                if (minimo >= actual.Dependientes[i].ProximoFinHacerEntender && actual.Dependientes[i].ProximoFinHacerEntender > 0)
                {
                    evento = "fin_hacer_entender" + (i+1);
                    minimo = actual.Dependientes[i].ProximoFinHacerEntender;
                }
            }
            if (minimo >= actual.ProximaTarea && actual.ProximaTarea > 0)
            {
                evento = "inicio_otra_tarea";
                minimo = actual.ProximaTarea;
            }
            for (int i = 0; i < actual.Dependientes.Length; i++)
            {
                if (minimo >= actual.Dependientes[i].ProximoFinOtraTarea && actual.Dependientes[i].ProximoFinOtraTarea > 0)
                {
                    evento = "fin_otra_tarea" + (i + 1);
                    minimo = actual.Dependientes[i].ProximoFinOtraTarea;
                }
            }

            actual.Reloj = minimo;
            actual.Evento = evento;
        }

        private void copiarAnterior()
        {
            actual.Linea = anterior.Linea;
            actual.Evento = anterior.Evento;
            actual.Reloj = anterior.Reloj;
            actual.RndLlegadaCliente = anterior.RndLlegadaCliente;
            actual.TiempoLlegadaCliente = anterior.TiempoLlegadaCliente;
            actual.ProximaLlegadaCliente = anterior.ProximaLlegadaCliente;
            actual.RndMayorEdad = anterior.RndMayorEdad;
            actual.EsMayorEdad = anterior.EsMayorEdad;
            actual.RndEdad = anterior.RndEdad;
            actual.Edad = anterior.Edad;
            actual.RndFinHacerEntender = anterior.RndFinHacerEntender;
            actual.TiempoFinHacerEntender = anterior.TiempoFinHacerEntender;
            actual.TiempoProximaTarea = anterior.TiempoProximaTarea;
            actual.ProximaTarea = anterior.ProximaTarea;
            actual.RndDependienteTarea = anterior.RndDependienteTarea;
            actual.DependienteTarea = anterior.DependienteTarea;
            actual.RndFinOtraTarea = anterior.RndFinOtraTarea;
            actual.TiempoFinOtraTarea = anterior.TiempoFinOtraTarea;
            actual.Dependientes = anterior.Dependientes;
            actual.ColaAtencion = anterior.ColaAtencion;
            actual.GradoOcupacionDependiente1 = anterior.GradoOcupacionDependiente1;
            actual.GradoOcupacionDependiente2 = anterior.GradoOcupacionDependiente2;
            actual.GradoOcupacionDependiente3 = anterior.GradoOcupacionDependiente3;
            actual.EsperaPromedioCola = anterior.EsperaPromedioCola;
            actual.CantidadPersonasAtendidas = anterior.CantidadPersonasAtendidas;
            actual.PorcentajeClientesAtendidosMayoresEdad = anterior.PorcentajeClientesAtendidosMayoresEdad;
            actual.PorcentajeOcupacionIrrelevante1 = anterior.PorcentajeOcupacionIrrelevante1;
            actual.PorcentajeOcupacionIrrelevante2 = anterior.PorcentajeOcupacionIrrelevante2;
            actual.PorcentajeOcupacionIrrelevante3 = anterior.PorcentajeOcupacionIrrelevante3;
            actual.TiempoMaximoPermanenciaSistemaMayorEdad = anterior.TiempoMaximoPermanenciaSistemaMayorEdad;
            actual.AcTiempoOcupacion1 = anterior.AcTiempoOcupacion1;
            actual.AcTiempoOcupacion2 = anterior.AcTiempoOcupacion2;
            actual.AcTiempoOcupacion3 = anterior.AcTiempoOcupacion3;
            actual.AcTiempoEspera = anterior.AcTiempoEspera;
            actual.AcClientesCola = anterior.AcClientesCola;
            actual.AcPersonasAtendidasMayoresEdad = anterior.AcPersonasAtendidasMayoresEdad;
            actual.AcTiempoOcupacionIrrelevante1 = anterior.AcTiempoOcupacionIrrelevante1;
            actual.AcTiempoOcupacionIrrelevante2 = anterior.AcTiempoOcupacionIrrelevante2;
            actual.AcTiempoOcupacionIrrelevante3 = anterior.AcTiempoOcupacionIrrelevante3;

        }

        private void resetearCampos()
        {
            actual.RndLlegadaCliente = -1;
            actual.TiempoLlegadaCliente = -1;
            actual.RndMayorEdad = -1;
            actual.EsMayorEdad = -1;
            actual.RndEdad = -1;
            actual.Edad = -1;
            actual.RndFinHacerEntender = -1;
            actual.TiempoFinHacerEntender = -1;
            actual.TiempoProximaTarea = -1;
            actual.RndDependienteTarea = -1;
            actual.DependienteTarea = -1;
            actual.RndFinOtraTarea = -1;
            actual.TiempoFinOtraTarea = -1;
        }
        private int aleatorioInt(int desde, int hasta, double random)
        {
            return desde + (int)(random * (double)(hasta - desde + 1));
        }

        private void limpiarClientes()
        {
            for (int i = 1 /*la primera columna es la columna de línea, por eso no se borra */; i < dgvClientes.Columns.Count; )
            {
                dgvClientes.Columns.RemoveAt(1);
            }
            dgvClientes.Rows.Clear();
        }

        private bool validarCampos()
        {
            //falta validar h
            if (!(int.TryParse(txtLineas.Text, out lineas) && lineas > 0))
            {
                MessageBox.Show("La cantidad de líneas a mostrar debe ser un número positivo mayor que 0.", "Número de lineas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(int.TryParse(txtMostrarDesde.Text, out mostrarDesde) && mostrarDesde > 0))
            {
                MessageBox.Show("El número de lína desde dónde mostrar debe ser un número positivo mayor que 0", "Mostrar desde X línea", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(int.TryParse(txtN.Text, out N) && N > 0))
            {
                MessageBox.Show("El número de lineas a simular debe ser un número positivo mayor que 0", "Tiempo de simulación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(double.TryParse(txtProbMayorEdad.Text, out probMayorEdad) && 1 > probMayorEdad && probMayorEdad >= 0 ))
            {
                MessageBox.Show("La probabilidad de que sea un mayor de edad debe ser un número positivo mayor o igual que 0 y menor a 1", "Probabilidad de que sea mayor de edad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(int.TryParse(txtRangoEdadesDesde.Text, out rangoEdadDesde) && rangoEdadDesde > 0))
            {
                MessageBox.Show("El límite inferior del rango de edades de mayores de edad debe ser un número positivo mayor a 0", "Rango de edades", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(int.TryParse(txtRangoEdadesHasta.Text, out rangoEdadHasta) && rangoEdadHasta > rangoEdadDesde))
            {
                MessageBox.Show("El límite superior del rango de edades de mayores de edad debe ser mayor al límite inferior", "Rango de edades", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(double.TryParse(txtTasaLlegada.Text, out tasaClientes) && tasaClientes > 0))
            {
                MessageBox.Show("La tasa de llegadas de clientes debe ser un número positivo mayor a 0", "Tasa de llegada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(int.TryParse(txtRangoEntenderDesde.Text, out rangoEntenderDesde) && rangoEntenderDesde > 0))
            {
                MessageBox.Show("El límite inferior del rango de tiempo para entender debe ser un número positivo mayor a 0", "Rango de tiempo para entender", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(int.TryParse(txtRangoEntenderHasta.Text, out rangoEntenderHasta) && rangoEntenderHasta > rangoEntenderDesde))
            {
                MessageBox.Show("El límite superior del rango de tiempo para entender debe ser mayor al límite inferior", "Rango de tiempo para entender", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(int.TryParse(txtTiempoOtraTarea.Text, out minutosOtrasTareas) && minutosOtrasTareas > 0))
            {
                MessageBox.Show("El intervalo entre otras tareas debe ser un número positivo mayor a 0", "Intervalo de tiempo entre otras tareas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(int.TryParse(txtRangoTareaDesde.Text, out rangoTareaDesde) && rangoTareaDesde > 0))
            {
                MessageBox.Show("El límite inferior del rango de tiempo para las tareas debe ser un número positivo mayor a 0", "Rango de tiempo para tareas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(int.TryParse(txtRangoTareaHasta.Text, out rangoTareaHasta) && rangoTareaHasta > rangoTareaDesde))
            {
                MessageBox.Show("El límite superior del rango de tiempo para las tareas debe ser superior al límite inferior.", "Rango de tiempo para tareas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(double.TryParse(txtTo.Text, out t0) && t0 > 0))
            {
                MessageBox.Show("El valor de t0 ser un número positivo mayor a 0", "T0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(double.TryParse(txtZo.Text, out z0) && z0 > 0))
            {
                MessageBox.Show("El valor de z0 ser un número positivo mayor a 0", "T0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(double.TryParse(txtH.Text, out h) && h > 0 && 1%h == 0))
            {
                MessageBox.Show("El valor de h debe ser mayor a 0, y debe ser tal que 1/h dé como resultado un número entero.", "H", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(double.TryParse(txtAlfa.Text, out alfa) && alfa > 0))
            {
                MessageBox.Show("El valor de Alfa debe ser un número positivo mayor a 0", "Alfa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(double.TryParse(txtBeta.Text, out beta) && beta > 0))
            {
                MessageBox.Show("El valor de Beta debe ser un número positivo mayor a 0", "Beta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnRungeKutta_Click(object sender, EventArgs e)
        {
            frmRungeKutta.Show();
        }
    }
}
