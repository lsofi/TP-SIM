using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayaEstacionamiento
{
    public partial class frmPlayaEstacionamiento : Form
    {
        private Playa actual;
        private Playa anterior;
        private Sector proximoSector;
        private Vehiculo abonando;
        Random random = new Random();

        private int llegadasDesde, llegadasHasta, cobro, lugPequenos, lugGrandes, lugUtilitarios, horasSim, lineasSim, lineasDesde, posGrandes, posUtil;

        private float probPequeno, probGrande, probUtilitario, probUnaHora, probDosHoras, probTresHoras, probCuatroHoras, tarifaPeq, tarifaGran, tarifaUtil;

        bool empezoSimulación;
        bool noHayLugar;

        private void dgvPlaya_Scroll(object sender, ScrollEventArgs e)
        {
             this.dgvVehiculos.FirstDisplayedScrollingRowIndex = this.dgvSectores.FirstDisplayedScrollingRowIndex = this.dgvPlaya.FirstDisplayedScrollingRowIndex;
        }

        private void cbxTodas_CheckedChanged(object sender, EventArgs e)
        {
            txtLineasDesde.Enabled = !txtLineasDesde.Enabled;
            txtLineasSim.Enabled = !txtLineasSim.Enabled;
        }

        private void dgvSectores_Scroll(object sender, ScrollEventArgs e)
        {
            this.dgvPlaya.FirstDisplayedScrollingRowIndex = this.dgvVehiculos.FirstDisplayedScrollingRowIndex = this.dgvSectores.FirstDisplayedScrollingRowIndex;
        }

        private void dgvPlaya_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPlaya.SelectedRows.Count > 0 && dgvSectores.Rows.Count > dgvPlaya.SelectedRows[0].Index)
            {
                dgvSectores.Rows[dgvPlaya.SelectedRows[0].Index].Selected = true;
                dgvVehiculos.Rows[dgvPlaya.SelectedRows[0].Index].Selected = true;
            }
        }

        private void dgvSectores_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSectores.SelectedRows.Count > 0 && dgvVehiculos.Rows.Count > dgvSectores.SelectedRows[0].Index)
            {
                dgvPlaya.Rows[dgvSectores.SelectedRows[0].Index].Selected = true;
                dgvVehiculos.Rows[dgvSectores.SelectedRows[0].Index].Selected = true;
            }
        }

        private void dgvVehiculos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVehiculos.SelectedRows.Count > 0 && dgvSectores.Rows.Count > dgvVehiculos.SelectedRows[0].Index)
            {
                dgvSectores.Rows[dgvVehiculos.SelectedRows[0].Index].Selected = true;
                dgvPlaya.Rows[dgvVehiculos.SelectedRows[0].Index].Selected = true;
            }
        }

        private void dgvVehiculos_Scroll(object sender, ScrollEventArgs e)
        {
            this.dgvPlaya.FirstDisplayedScrollingRowIndex = this.dgvSectores.FirstDisplayedScrollingRowIndex = this.dgvVehiculos.FirstDisplayedScrollingRowIndex;
        }

        public frmPlayaEstacionamiento()
        {
            InitializeComponent();
        }
        private void btnSimular_Click(object sender, EventArgs e)
        {
            if(validarCampos())
            {
                dgvPlaya.Enabled = dgvSectores.Enabled = dgvVehiculos.Enabled = true;
                empezoSimulación = false;
                limpiarSectoresYVehiculos();
                dgvPlaya.Rows.Clear();
                dgvSectores.Rows.Clear();
                dgvVehiculos.Rows.Clear();

                actual = new Playa();
                crearSectores();
                posGrandes = lugPequenos;
                posUtil = posGrandes + lugGrandes;
                actual.Caja = new Caja();
                actual.Vehiculos = new List<Vehiculo>();
                actual.Reloj = 0;
                actual.Linea = 0;
                actual.Evento = "inicio_simulacion";
                actual.LugaresPeqDisponibles = lugPequenos;
                actual.LugaresGrandDisponibles = lugGrandes;
                actual.LugaresUtilDisponibles = lugUtilitarios;


                while (actual.Reloj < horasSim*60)
                {
                    actual.Linea++;
                    noHayLugar = false;

                    anterior = actual;
                    actual = anterior.clone();

                    if (empezoSimulación) proximoEvento();
                    
                    switch (actual.Evento)
                    {
                        case "inicio_simulacion":
                            actual.resetearCampos();

                            actual.RndLlegadaVehiculo = random.NextDouble();
                            actual.LlegadaVehiculo = aleatorioU(llegadasDesde, llegadasHasta, actual.RndLlegadaVehiculo);
                            actual.ProximaLlegadaVehiculo = actual.Reloj + actual.LlegadaVehiculo;

                            empezoSimulación = true;
                            break;

                        case "llegada_vehiculo":
                            actual.resetearCampos();

                            actual.RndLlegadaVehiculo = random.NextDouble();
                            actual.LlegadaVehiculo = aleatorioU(llegadasDesde, llegadasHasta, actual.RndLlegadaVehiculo);
                            actual.ProximaLlegadaVehiculo = actual.Reloj + actual.LlegadaVehiculo;

                            actual.RndTipoVehiculo = random.NextDouble();
                            actual.TipoVehiculo = tipoVehiculo(actual.RndTipoVehiculo);
                            int posSector = buscarSector(actual.TipoVehiculo);
                            if (posSector != -1)
                            {
                                actual.RndTiempoVehiculo = random.NextDouble();
                                actual.TiempoVehiculo = cantHoras(actual.RndTiempoVehiculo);
                                Vehiculo nuevoVehiculo;
                                int posVehiculo = actual.buscarVehiculoNulo();
                                if (posVehiculo != -1)
                                {
                                    nuevoVehiculo = actual.Vehiculos[posVehiculo];
                                    nuevoVehiculo.setParametros(actual.TipoVehiculo, actual.TiempoVehiculo, "Estacionado");
                                }
                                else
                                {
                                    nuevoVehiculo = new Vehiculo(actual.TipoVehiculo, actual.TiempoVehiculo, "Estacionado");
                                    actual.Vehiculos.Add(nuevoVehiculo);
                                }
                                actual.Sectores[posSector].Vehiculo = nuevoVehiculo;
                                actual.Sectores[posSector].Fin_estacionamiento = actual.Reloj + (actual.TiempoVehiculo * 60);
                                actual.Sectores[posSector].Estado = "Ocupado";
                                actual.descontarLugar(actual.TipoVehiculo);
                            }
                            else
                                noHayLugar = true;
                            break;

                        case "fin_estacionamiento":
                            actual.resetearCampos();

                            Vehiculo saliente = proximoSector.Vehiculo;
                            if(actual.Caja.Estado == "Libre")
                            {
                                abonando = saliente;
                                actual.Caja.Fin_cobro = actual.Reloj + cobro;
                                actual.Caja.Estado = "Ocupado";
                                abonando.Estado = "Abonando";
                            }
                            else
                            {
                                actual.Caja.Cola.Enqueue(saliente);
                                saliente.Estado = "Cola Caja";
                            }

                            actual.sumarLugar(saliente.Tipo);

                            proximoSector.Estado = "Libre";
                            proximoSector.Fin_estacionamiento = 0;
                            proximoSector.Vehiculo = null;

                            break;

                        case "fin_cobro":
                            actual.resetearCampos();

                            sumarRecaudacion(abonando.Tipo, abonando.Horas_estacionamiento);
                            abonando.Estado = "";
                            abonando.Abonado = true;

                            if(actual.Caja.Cola.Count == 0)
                            {
                                actual.Caja.Estado = "Libre";
                                actual.Caja.Fin_cobro = 0;
                                abonando = null;
                            }
                            else
                            {
                                abonando = actual.Caja.Cola.Dequeue();
                                actual.Caja.Fin_cobro = actual.Reloj + cobro;
                                abonando.Estado = "Abonando";
                            }

                            break;

                        case "fin_simulación":
                            break;

                    }
                    if (actual.Linea >= lineasDesde && actual.Linea < lineasDesde + lineasSim || cbxTodas.Checked)
                    {
                        agregarDatosDgv();
                        agregarDatosSectores();
                        agregarDatosVehiculos();
                    }
                    else
                        cargarVehiculos();

                }
                if (!cbxTodas.Checked)
                {
                    agregarDatosDgv();
                    agregarDatosSectores();
                    agregarDatosVehiculos();
                }
            }
        }

        private bool validarCampos()
        {
            if (!(int.TryParse(txtHorasSim.Text, out horasSim) && horasSim > 0))
            {
                MessageBox.Show("La cantidad de horas de simulación debe ser un número positivo mayor que 0", "Horas de simulación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(int.TryParse(txtLineasSim.Text, out lineasSim) && lineasSim > 0))
            {
                MessageBox.Show("La cantidad de lineas a mostrar debe ser un número positivo mayor que 0", "Lineas a mostrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(int.TryParse(txtLineasDesde.Text, out lineasDesde) && lineasDesde > 0))
            {
                MessageBox.Show("La primera linea a mostrar debe ser un número positivo mayor que 0", "Lineas a mostrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(int.TryParse(txtLlegadasDesde.Text, out llegadasDesde) && llegadasDesde > 0))
            {
                MessageBox.Show("La cantidad mínima de minutos entre llegadas debe ser un número positivo mayor que 0", "Tiempo entre llegadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(int.TryParse(txtLlegadasHasta.Text, out llegadasHasta) && llegadasHasta > llegadasDesde))
            {
                MessageBox.Show("La cantidad máxima de minutos entre llegadas debe ser un número positivo mayor que la mínima", "Lineas a mostrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(int.TryParse(txtCobroDesde.Text, out cobro) && cobro > 0))
            {
                MessageBox.Show("La cantidad de minutos para cobrar debe ser un número positivo mayor que 0", "Tiempo de cobro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(int.TryParse(txtPequeños.Text, out lugPequenos) && lugPequenos > 0))
            {
                MessageBox.Show("La cantidad sectores para autos pequeños debe ser un número positivo mayor que 0", "Sectores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(int.TryParse(txtGrandes.Text, out lugGrandes) && lugGrandes > 0))
            {
                MessageBox.Show("La cantidad sectores para autos grandes debe ser un número positivo mayor que 0", "Sectores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(int.TryParse(txtUtilitarios.Text, out lugUtilitarios) && lugUtilitarios > 0))
            {
                MessageBox.Show("La cantidad sectores para vehiculos utilitarios debe ser un número positivo mayor que 0", "Sectores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(float.TryParse(txtProbPequeno.Text, out probPequeno) && probPequeno >= 0 && probPequeno < 1))
            {
                MessageBox.Show("La probabilidad de que un vehículo sea un auto pequeño debe ser un número positivo mayor o igual que 0 y menor que 1", "Probabilidad tipo de vehiculo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(float.TryParse(txtProbGrande.Text, out probGrande) && probGrande >= 0 && probGrande < 1))
            {
                MessageBox.Show("La probabilidad de que un vehículo sea un auto Grande debe ser un número positivo mayor o igual que 0 y menor que 1", "Probabilidad tipo de vehiculo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(float.TryParse(txtProbUtilitario.Text, out probUtilitario) && probUtilitario >= 0 && probUtilitario < 1))
            {
                MessageBox.Show("La probabilidad de que un vehículo sea utilitario debe ser un número positivo mayor o igual que 0 y menor que 1", "Probabilidad tipo de vehiculo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(probPequeno + probGrande + probUtilitario == 1))
            {
                MessageBox.Show("La suma de las probabilidades debe ser igual a 1", "Probabilidad tipo de vehiculo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(float.TryParse(txtUnaHora.Text, out probUnaHora) && probUnaHora >= 0 && probUnaHora < 1))
            {
                MessageBox.Show("La probabilidad de que un vehículo se estacione por una hora debe ser un número positivo mayor o igual que 0 y menor que 1", "Probabilidad tiempo estacionamiento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(float.TryParse(txtDosHoras.Text, out probDosHoras) && probDosHoras >= 0 && probDosHoras < 1))
            {
                MessageBox.Show("La probabilidad de que un vehículo se estacione por dos horas debe ser un número positivo mayor o igual que 0 y menor que 1", "Probabilidad tiempo estacionamiento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(float.TryParse(txtTresHoras.Text, out probTresHoras) && probTresHoras >= 0 && probTresHoras < 1))
            {
                MessageBox.Show("La probabilidad de que un vehículo se estacione por tres horas debe ser un número positivo mayor o igual que 0 y menor que 1", "Probabilidad tiempo estacionamiento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(float.TryParse(txtCuatroHoras.Text, out probCuatroHoras) && probCuatroHoras >= 0 && probCuatroHoras < 1))
            {
                MessageBox.Show("La probabilidad de que un vehículo se estacione por cuatro horas debe ser un número positivo mayor o igual que 0 y menor que 1", "Probabilidad tiempo estacionamiento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(probUnaHora + probDosHoras + probTresHoras + probCuatroHoras == 1))
            {
                MessageBox.Show("La suma de las probabilidades debe ser igual a 1", "Probabilidad tiempo estacionamiento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!(float.TryParse(txtTarifaPeq.Text, out tarifaPeq) && tarifaPeq >= 0))
            {
                MessageBox.Show("La tarifa para autos pequeños debe ser un número positivo mayor o igual que 0", "Tarifas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(float.TryParse(txtTarifaGran.Text, out tarifaGran) && tarifaGran >= 0))
            {
                MessageBox.Show("La tarifa para autos grandes debe ser un número positivo mayor o igual que 0", "Tarifas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(float.TryParse(txtTarifaUtil.Text, out tarifaUtil) && tarifaUtil >= 0))
            {
                MessageBox.Show("La tarifa para vehiculos utilitarios debe ser un número positivo mayor o igual que 0", "Tarifas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            probGrande += probPequeno;
            probUtilitario += probGrande;

            probDosHoras += probUnaHora;
            probTresHoras += probDosHoras;
            probCuatroHoras += probTresHoras;

            return true;
        }

        private double aleatorioU(int desde, int hasta, double aleatorio)
        {
            return desde + aleatorio * (hasta - desde);
        }

        private string tipoVehiculo(double random)
        {
            if (random < probPequeno)
                return "Pequeño";
            if (random < probGrande)
                return "Grande";
            return "Utilitario";
        }

        private int cantHoras(double random)
        {
            if (random < probUnaHora)
                return 1;
            if (random < probDosHoras)
                return 2;
            if (random < probTresHoras)
                return 3;
            return 4;
        }

        private void crearSectores()
        {
            actual.Sectores = new Sector[lugPequenos + lugGrandes + lugUtilitarios];

            for (int i = 0; i < lugPequenos; i++)
            {
                actual.Sectores[i] = new Sector("Pequeño", i);
            }
            for (int i = 0; i < lugGrandes; i++)
            {
                actual.Sectores[lugPequenos + i] = new Sector("Grande", i);
            }
            for (int i = 0; i < lugUtilitarios; i++)
            {
                actual.Sectores[lugPequenos + lugGrandes + i] = new Sector("Utilitario", i);
            }

            foreach(Sector sec in actual.Sectores)
            {
                DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
                columna.Name = sec.Tipo_vehiculo + sec.IdSector;
                columna.HeaderText = sec.Tipo_vehiculo + " " + sec.IdSector;
                columna.Width = 150;
                dgvSectores.Columns.Add(columna);
            }
        }

        private int buscarSector(string tipo)
        {
            int res = -1;
            switch (tipo)
            {
                case "Pequeño":
                    for (int i = 0; i < lugPequenos; i++)
                    {
                        if (actual.Sectores[i].Estado == "Libre")
                        {
                            res = i;
                            break;
                        }
                    }
                    break;
                case "Grande":
                    for (int i = posGrandes; i < posUtil; i++)
                    {
                        if (actual.Sectores[i].Estado == "Libre")
                        {
                            res = i;
                            break;
                        }
                    }
                    break;
                case "Utilitario":
                    for (int i = posUtil; i < actual.Sectores.Length; i++)
                    {
                        if (actual.Sectores[i].Estado == "Libre")
                        {
                            res = i;
                            break;
                        }
                    }
                        break;
            }
            return res;
        }

        private void sumarRecaudacion(string tipo, int horas)
        {
            switch (tipo)
            {
                case "Pequeño":
                    actual.Recaudacion += tarifaPeq * horas;
                    break;
                case "Grande":
                    actual.Recaudacion += tarifaGran * horas;
                    break;
                case "Utilitario":
                    actual.Recaudacion += tarifaUtil * horas;
                    break;
            }
        }

        private void agregarDatosDgv() 
        {
            int linea = actual.Linea;
            string evento = actual.Evento;
            double reloj = Math.Round(actual.Reloj,2);
            string rndLlegadaVehiculo = (actual.RndLlegadaVehiculo > 0) ? Math.Round(actual.RndLlegadaVehiculo,2).ToString() : "";
            string llegadaVehiculo = (actual.LlegadaVehiculo > 0) ? Math.Round(actual.LlegadaVehiculo, 2).ToString() : "";
            string proximaLlegadaVehiculo = (actual.ProximaLlegadaVehiculo > 0) ? Math.Round(actual.ProximaLlegadaVehiculo, 2).ToString() : "";
            string rndTipoVehiculo = (actual.RndTipoVehiculo > 0) ? Math.Round(actual.RndTipoVehiculo, 2).ToString() : "";
            string tipoVehiculo = actual.TipoVehiculo;
            string rndTiempoVehiculo = (actual.RndTiempoVehiculo > 0) ? Math.Round(actual.RndTiempoVehiculo, 2).ToString() : "";
            string tiempoVehiculo = (actual.TiempoVehiculo > 0) ? actual.TiempoVehiculo.ToString() : "";
            string estadoCaja = actual.Caja.Estado;
            string colaCaja = actual.Caja.Cola.Count.ToString();
            string proximoFinCobro = (actual.Caja.Fin_cobro > 0) ? Math.Round(actual.Caja.Fin_cobro, 2).ToString() : "";
            int lugaresPeqDisponibles = actual.LugaresPeqDisponibles;
            int lugaresGrandDisponibles = actual.LugaresGrandDisponibles;
            int lugaresUtilDisponibles = actual.LugaresUtilDisponibles;
            double recaudacion = Math.Round(actual.Recaudacion,2);

            dgvPlaya.Rows.Add(linea, evento, reloj, rndLlegadaVehiculo, llegadaVehiculo, proximaLlegadaVehiculo, rndTipoVehiculo, tipoVehiculo,
                              rndTiempoVehiculo, tiempoVehiculo, estadoCaja, colaCaja, proximoFinCobro, lugaresPeqDisponibles, lugaresGrandDisponibles,
                              lugaresUtilDisponibles, recaudacion);
        }

        private void agregarDatosSectores()
        {
            dgvSectores.Rows.Add(1);
            dgvSectores.Rows[dgvSectores.Rows.Count - 1].Cells[0].Value = actual.Linea;
            for (int i = 0; i < actual.Sectores.Length; i++)
            {
                Sector sector = actual.Sectores[i];

                StringBuilder sb = new StringBuilder();
                sb.Append(sector.Estado);
                if (sector.Estado == "Ocupado")
                {
                    sb.Append(" | ");
                    sb.Append(Math.Round(sector.Fin_estacionamiento, 2));
                }
                dgvSectores.Rows[dgvSectores.Rows.Count - 1].Cells[i+1].Value = sb.ToString();
            }
        }

        private void agregarDatosVehiculos()
        {
            dgvVehiculos.Rows.Add(1);
            dgvVehiculos.Rows[dgvVehiculos.Rows.Count - 1].Cells[0].Value = actual.Linea;
            for (int i = 0; i < actual.Vehiculos.Count; i++)
            {
                Vehiculo vehiculo = actual.Vehiculos.ElementAt(i);
                if (vehiculo.Estado != "")
                {
                    
                    if (i + 1 <= dgvVehiculos.Columns.Count - 1)
                        dgvVehiculos.Rows[dgvVehiculos.Rows.Count - 1].Cells[i+1].Value = vehiculo.Estado;
                    else
                    {
                        DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
                        columna.Name = vehiculo.Nombre;
                        columna.HeaderText = vehiculo.Nombre;
                        dgvVehiculos.Columns.Add(columna);
                        dgvVehiculos.Rows[dgvVehiculos.Rows.Count - 1].Cells[dgvVehiculos.Columns.Count - 1].Value = vehiculo.Estado;
                    }
                }
                else
                {
                    if (vehiculo.Abonado && actual.Evento != "fin_simulación")
                    {
                        dgvVehiculos.Rows[dgvVehiculos.Rows.Count - 1].Cells[i+1].Style.BackColor = Color.FromArgb(56, 176, 0);
                        vehiculo.Abonado = false;
                        continue;
                    }
                    if (noHayLugar && actual.Evento != "fin_simulación")
                    {
                        dgvVehiculos.Rows[dgvVehiculos.Rows.Count - 1].Cells[i+1].Style.BackColor = Color.FromArgb(249, 65, 68);
                        noHayLugar = false;
                        continue;
                    }
                    continue;
                }
            }
        }

        private void cargarVehiculos()
        {
            for (int i = 0; i < actual.Vehiculos.Count; i++)
            {
                Vehiculo vehiculo = actual.Vehiculos.ElementAt(i);

                if (!(i + 1 <= dgvVehiculos.Columns.Count - 1))
                {
                    DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
                    columna.Name = vehiculo.Nombre;
                    columna.HeaderText = vehiculo.Nombre;
                    dgvVehiculos.Columns.Add(columna);
                }
            }
        }

        private void proximoEvento()
        {
            double minimo = horasSim * 60;
            string evento = "fin_simulación";

            if(minimo > anterior.ProximaLlegadaVehiculo && anterior.ProximaLlegadaVehiculo > 0)
            {
                evento = "llegada_vehiculo";
                minimo = anterior.ProximaLlegadaVehiculo;
            }

            foreach (Sector sec in anterior.Sectores)
            {
                if(minimo > sec.Fin_estacionamiento && sec.Fin_estacionamiento > 0)
                {
                    evento = "fin_estacionamiento";
                    minimo = sec.Fin_estacionamiento;
                    proximoSector = sec;
                }
            }

            if(minimo > anterior.Caja.Fin_cobro && anterior.Caja.Fin_cobro > 0)
            {
                evento = "fin_cobro";
                minimo = anterior.Caja.Fin_cobro;
            }

            actual.Evento = evento;
            actual.Reloj = minimo;
        }

        private void limpiarSectoresYVehiculos()
        {
            for (int i = 1; i < dgvSectores.Columns.Count;)
            {
                dgvSectores.Columns.RemoveAt(i);
            }
            for (int i = 1; i < dgvVehiculos.Columns.Count;)
            {
                dgvVehiculos.Columns.RemoveAt(i);
            }
            dgvSectores.Rows.Clear();
            dgvVehiculos.Rows.Clear();
            Vehiculo.cantVeh = 0;
        }
    }
}
