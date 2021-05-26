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
        public frmSimulacion()
        {
            InitializeComponent();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                
            }
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
                return false;
            }
            if (!(int.TryParse(txtEntrCompDesde.Text, out desdeEntradasComprar) && desdeEntradasComprar > 0))
            {
                return false;
            }
            if (!(int.TryParse(txtEntrCompHasta.Text, out hastaEntradasComprar) && hastaEntradasComprar > desdeEntradasComprar))
            {
                return false;
            }
            if (!(int.TryParse(txtEntrAntDesde.Text, out desdeEntradasAnticipadas) && desdeEntradasAnticipadas > 0))
            {
                return false;
            }
            if (!(int.TryParse(txtEntrAntHasta.Text, out hastaEntradasAnticipadas) && hastaEntradasAnticipadas > desdeEntradasAnticipadas))
            {
                return false;
            }
            if (!(int.TryParse(txtTiempoCompraDesde.Text, out desdeTiempoCompra) && desdeTiempoCompra > 0))
            {
                return false;
            }
            if (!(int.TryParse(txtTiempoCompraHasta.Text, out hastaTiempoCompra) && hastaTiempoCompra > desdeTiempoCompra))
            {
                return false;
            }
            if (!(int.TryParse(txtTiempoEntradaDesde.Text, out desdeTiempoEntradaSala) && desdeTiempoEntradaSala > 0))
            {
                return false;
            }
            if (!(int.TryParse(txtTiempoEntradaHasta.Text, out hastaTiempoEntradaSala) && hastaTiempoEntradaSala > desdeTiempoEntradaSala))
            {
                return false;
            }
            if (!(int.TryParse(txtTiempoLlegCompDesde.Text, out desdeTiempoLlegadaCompra) && desdeTiempoLlegadaCompra > 0))
            {
                return false;
            }
            if (!(int.TryParse(txtTiempoLlegCompHasta.Text, out hastaTiempoLlegadaCompra) && hastaTiempoLlegadaCompra > desdeTiempoLlegadaCompra))
            {
                return false;
            }
            if (!(int.TryParse(txtTiempoLlegAntDesde.Text, out desdeTiempoLlegadaAnticipada) && desdeTiempoLlegadaAnticipada > 0))
            {
                return false;
            }
            if (!(int.TryParse(txtTiempoLlegAntHasta.Text, out hastaTiempoLlegadaAnticipada) && hastaTiempoLlegadaAnticipada > desdeTiempoLlegadaAnticipada))
            {
                return false;
            }

            return true;
        }
    }
}
