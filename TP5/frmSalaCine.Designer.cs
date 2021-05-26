namespace TP5
{
    partial class frmSimulacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvFuncion = new System.Windows.Forms.DataGridView();
            this.numSimulacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndLlegadaCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.llegadaCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximaLlegadaCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndLlegadaEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximaLlegadaEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndNumeroEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoBoletero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndFinCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximoFinCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colaBoleteria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndFinEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximoFinEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acumEntradasVendidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaLlena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoOcupBoletero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcTiempoOcupBoletero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contEntradasAnticipadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcNoEntrar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtN = new System.Windows.Forms.TextBox();
            this.lblN = new System.Windows.Forms.Label();
            this.lblSimulacionMostrar = new System.Windows.Forms.Label();
            this.txtSimAMostrar = new System.Windows.Forms.TextBox();
            this.lblTamSala = new System.Windows.Forms.Label();
            this.txtTamSala = new System.Windows.Forms.TextBox();
            this.lblAperturaSala = new System.Windows.Forms.Label();
            this.txtHorarioAperturaSala = new System.Windows.Forms.TextBox();
            this.lblRangoEntradas = new System.Windows.Forms.Label();
            this.txtEntrCompDesde = new System.Windows.Forms.TextBox();
            this.txtEntrCompHasta = new System.Windows.Forms.TextBox();
            this.txtEntrAntHasta = new System.Windows.Forms.TextBox();
            this.lblRangoEntradasAnticipadas = new System.Windows.Forms.Label();
            this.txtEntrAntDesde = new System.Windows.Forms.TextBox();
            this.txtTiempoEntradaHasta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTiempoEntradaDesde = new System.Windows.Forms.TextBox();
            this.txtTiempoCompraHasta = new System.Windows.Forms.TextBox();
            this.lblRangoTiempoCompra = new System.Windows.Forms.Label();
            this.txtTiempoCompraDesde = new System.Windows.Forms.TextBox();
            this.txtTiempoLlegAntHasta = new System.Windows.Forms.TextBox();
            this.lblDemoraAnticipada = new System.Windows.Forms.Label();
            this.txtTiempoLlegAntDesde = new System.Windows.Forms.TextBox();
            this.txtTiempoLlegCompHasta = new System.Windows.Forms.TextBox();
            this.lblDemoraLlegadaCompra = new System.Windows.Forms.Label();
            this.txtTiempoLlegCompDesde = new System.Windows.Forms.TextBox();
            this.lblHorarioConEntrada = new System.Windows.Forms.Label();
            this.txtHorarioLlegadaAnticipada = new System.Windows.Forms.TextBox();
            this.lblHorarioComienzoPelicula = new System.Windows.Forms.Label();
            this.txtHorarioComienzoPelicula = new System.Windows.Forms.TextBox();
            this.btnSimular = new System.Windows.Forms.Button();
            this.dgvFunciones = new System.Windows.Forms.DataGridView();
            this.evento2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numSimulacion2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reloj2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colaBoleteria2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFuncion
            // 
            this.dgvFuncion.AllowUserToAddRows = false;
            this.dgvFuncion.AllowUserToDeleteRows = false;
            this.dgvFuncion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numSimulacion,
            this.evento,
            this.reloj,
            this.rndLlegadaCompra,
            this.llegadaCompra,
            this.proximaLlegadaCompra,
            this.numeroCompra,
            this.rndLlegadaEntrada,
            this.proximaLlegadaEntrada,
            this.rndNumeroEntrada,
            this.estadoBoletero,
            this.rndFinCompra,
            this.finCompra,
            this.proximoFinCompra,
            this.colaBoleteria,
            this.rndFinEntrada,
            this.finEntrada,
            this.proximoFinEntrada,
            this.acumEntradasVendidas,
            this.salaLlena,
            this.tiempoOcupBoletero,
            this.porcTiempoOcupBoletero,
            this.contEntradasAnticipadas,
            this.porcNoEntrar});
            this.dgvFuncion.Location = new System.Drawing.Point(45, 304);
            this.dgvFuncion.Name = "dgvFuncion";
            this.dgvFuncion.ReadOnly = true;
            this.dgvFuncion.Size = new System.Drawing.Size(943, 285);
            this.dgvFuncion.TabIndex = 0;
            // 
            // numSimulacion
            // 
            this.numSimulacion.HeaderText = "Numero de simulación";
            this.numSimulacion.Name = "numSimulacion";
            this.numSimulacion.ReadOnly = true;
            // 
            // evento
            // 
            this.evento.HeaderText = "Evento";
            this.evento.Name = "evento";
            this.evento.ReadOnly = true;
            // 
            // reloj
            // 
            this.reloj.HeaderText = "Reloj";
            this.reloj.Name = "reloj";
            this.reloj.ReadOnly = true;
            // 
            // rndLlegadaCompra
            // 
            this.rndLlegadaCompra.HeaderText = "RND Llegada compra";
            this.rndLlegadaCompra.Name = "rndLlegadaCompra";
            this.rndLlegadaCompra.ReadOnly = true;
            // 
            // llegadaCompra
            // 
            this.llegadaCompra.HeaderText = "Llegada Compra";
            this.llegadaCompra.Name = "llegadaCompra";
            this.llegadaCompra.ReadOnly = true;
            // 
            // proximaLlegadaCompra
            // 
            this.proximaLlegadaCompra.HeaderText = "Próxima llegada compra";
            this.proximaLlegadaCompra.Name = "proximaLlegadaCompra";
            this.proximaLlegadaCompra.ReadOnly = true;
            // 
            // numeroCompra
            // 
            this.numeroCompra.HeaderText = "Entradas compradas";
            this.numeroCompra.Name = "numeroCompra";
            this.numeroCompra.ReadOnly = true;
            // 
            // rndLlegadaEntrada
            // 
            this.rndLlegadaEntrada.HeaderText = "Llegada Entrada";
            this.rndLlegadaEntrada.Name = "rndLlegadaEntrada";
            this.rndLlegadaEntrada.ReadOnly = true;
            // 
            // proximaLlegadaEntrada
            // 
            this.proximaLlegadaEntrada.HeaderText = "Próxima llegada entrada";
            this.proximaLlegadaEntrada.Name = "proximaLlegadaEntrada";
            this.proximaLlegadaEntrada.ReadOnly = true;
            // 
            // rndNumeroEntrada
            // 
            this.rndNumeroEntrada.HeaderText = "Numero de entradas";
            this.rndNumeroEntrada.Name = "rndNumeroEntrada";
            this.rndNumeroEntrada.ReadOnly = true;
            // 
            // estadoBoletero
            // 
            this.estadoBoletero.HeaderText = "Estado boletero";
            this.estadoBoletero.Name = "estadoBoletero";
            this.estadoBoletero.ReadOnly = true;
            // 
            // rndFinCompra
            // 
            this.rndFinCompra.HeaderText = "RND fin compra";
            this.rndFinCompra.Name = "rndFinCompra";
            this.rndFinCompra.ReadOnly = true;
            // 
            // finCompra
            // 
            this.finCompra.HeaderText = "Fin compra";
            this.finCompra.Name = "finCompra";
            this.finCompra.ReadOnly = true;
            // 
            // proximoFinCompra
            // 
            this.proximoFinCompra.HeaderText = "Próximo fin compra";
            this.proximoFinCompra.Name = "proximoFinCompra";
            this.proximoFinCompra.ReadOnly = true;
            // 
            // colaBoleteria
            // 
            this.colaBoleteria.HeaderText = "Cantidad de Clientes en cola";
            this.colaBoleteria.Name = "colaBoleteria";
            this.colaBoleteria.ReadOnly = true;
            // 
            // rndFinEntrada
            // 
            this.rndFinEntrada.HeaderText = "RND fin entrada";
            this.rndFinEntrada.Name = "rndFinEntrada";
            this.rndFinEntrada.ReadOnly = true;
            // 
            // finEntrada
            // 
            this.finEntrada.HeaderText = "Fin de entrada";
            this.finEntrada.Name = "finEntrada";
            this.finEntrada.ReadOnly = true;
            // 
            // proximoFinEntrada
            // 
            this.proximoFinEntrada.HeaderText = "Próximo fin de entrada";
            this.proximoFinEntrada.Name = "proximoFinEntrada";
            this.proximoFinEntrada.ReadOnly = true;
            // 
            // acumEntradasVendidas
            // 
            this.acumEntradasVendidas.HeaderText = "Total Entradas Vendidas";
            this.acumEntradasVendidas.Name = "acumEntradasVendidas";
            this.acumEntradasVendidas.ReadOnly = true;
            // 
            // salaLlena
            // 
            this.salaLlena.HeaderText = "Sala llena";
            this.salaLlena.Name = "salaLlena";
            this.salaLlena.ReadOnly = true;
            // 
            // tiempoOcupBoletero
            // 
            this.tiempoOcupBoletero.HeaderText = "Total tiempo de ocupación del boletero";
            this.tiempoOcupBoletero.Name = "tiempoOcupBoletero";
            this.tiempoOcupBoletero.ReadOnly = true;
            // 
            // porcTiempoOcupBoletero
            // 
            this.porcTiempoOcupBoletero.HeaderText = "Porcentaje de tiempo de ocupación del boletero";
            this.porcTiempoOcupBoletero.Name = "porcTiempoOcupBoletero";
            this.porcTiempoOcupBoletero.ReadOnly = true;
            // 
            // contEntradasAnticipadas
            // 
            this.contEntradasAnticipadas.HeaderText = "Total entradas anticipadas";
            this.contEntradasAnticipadas.Name = "contEntradasAnticipadas";
            this.contEntradasAnticipadas.ReadOnly = true;
            // 
            // porcNoEntrar
            // 
            this.porcNoEntrar.HeaderText = "Porcentaje de entradas que no pudieron entrar";
            this.porcNoEntrar.Name = "porcNoEntrar";
            this.porcNoEntrar.ReadOnly = true;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(160, 15);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(46, 20);
            this.txtN.TabIndex = 1;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(29, 18);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(125, 13);
            this.lblN.TabIndex = 2;
            this.lblN.Text = "Número de simulaciones:";
            // 
            // lblSimulacionMostrar
            // 
            this.lblSimulacionMostrar.AutoSize = true;
            this.lblSimulacionMostrar.Location = new System.Drawing.Point(222, 18);
            this.lblSimulacionMostrar.Name = "lblSimulacionMostrar";
            this.lblSimulacionMostrar.Size = new System.Drawing.Size(160, 13);
            this.lblSimulacionMostrar.TabIndex = 4;
            this.lblSimulacionMostrar.Text = "Número de simulación a mostrar:";
            // 
            // txtSimAMostrar
            // 
            this.txtSimAMostrar.Location = new System.Drawing.Point(388, 15);
            this.txtSimAMostrar.Name = "txtSimAMostrar";
            this.txtSimAMostrar.Size = new System.Drawing.Size(52, 20);
            this.txtSimAMostrar.TabIndex = 3;
            // 
            // lblTamSala
            // 
            this.lblTamSala.AutoSize = true;
            this.lblTamSala.Location = new System.Drawing.Point(29, 102);
            this.lblTamSala.Name = "lblTamSala";
            this.lblTamSala.Size = new System.Drawing.Size(70, 13);
            this.lblTamSala.TabIndex = 12;
            this.lblTamSala.Text = "Tamaño Sala";
            // 
            // txtTamSala
            // 
            this.txtTamSala.Location = new System.Drawing.Point(105, 99);
            this.txtTamSala.Name = "txtTamSala";
            this.txtTamSala.Size = new System.Drawing.Size(48, 20);
            this.txtTamSala.TabIndex = 11;
            this.txtTamSala.Text = "100";
            // 
            // lblAperturaSala
            // 
            this.lblAperturaSala.AutoSize = true;
            this.lblAperturaSala.Location = new System.Drawing.Point(223, 102);
            this.lblAperturaSala.Name = "lblAperturaSala";
            this.lblAperturaSala.Size = new System.Drawing.Size(145, 13);
            this.lblAperturaSala.TabIndex = 14;
            this.lblAperturaSala.Text = "Minutos previos apertura sala";
            // 
            // txtHorarioAperturaSala
            // 
            this.txtHorarioAperturaSala.Location = new System.Drawing.Point(374, 99);
            this.txtHorarioAperturaSala.Name = "txtHorarioAperturaSala";
            this.txtHorarioAperturaSala.Size = new System.Drawing.Size(50, 20);
            this.txtHorarioAperturaSala.TabIndex = 13;
            this.txtHorarioAperturaSala.Text = "4";
            // 
            // lblRangoEntradas
            // 
            this.lblRangoEntradas.AutoSize = true;
            this.lblRangoEntradas.Location = new System.Drawing.Point(30, 146);
            this.lblRangoEntradas.Name = "lblRangoEntradas";
            this.lblRangoEntradas.Size = new System.Drawing.Size(149, 13);
            this.lblRangoEntradas.TabIndex = 16;
            this.lblRangoEntradas.Text = "Rango de Entradas a comprar";
            // 
            // txtEntrCompDesde
            // 
            this.txtEntrCompDesde.Location = new System.Drawing.Point(205, 143);
            this.txtEntrCompDesde.Name = "txtEntrCompDesde";
            this.txtEntrCompDesde.Size = new System.Drawing.Size(46, 20);
            this.txtEntrCompDesde.TabIndex = 15;
            this.txtEntrCompDesde.Text = "1";
            // 
            // txtEntrCompHasta
            // 
            this.txtEntrCompHasta.Location = new System.Drawing.Point(272, 143);
            this.txtEntrCompHasta.Name = "txtEntrCompHasta";
            this.txtEntrCompHasta.Size = new System.Drawing.Size(46, 20);
            this.txtEntrCompHasta.TabIndex = 17;
            this.txtEntrCompHasta.Text = "4";
            // 
            // txtEntrAntHasta
            // 
            this.txtEntrAntHasta.Location = new System.Drawing.Point(272, 177);
            this.txtEntrAntHasta.Name = "txtEntrAntHasta";
            this.txtEntrAntHasta.Size = new System.Drawing.Size(47, 20);
            this.txtEntrAntHasta.TabIndex = 20;
            this.txtEntrAntHasta.Text = "3";
            // 
            // lblRangoEntradasAnticipadas
            // 
            this.lblRangoEntradasAnticipadas.AutoSize = true;
            this.lblRangoEntradasAnticipadas.Location = new System.Drawing.Point(30, 180);
            this.lblRangoEntradasAnticipadas.Name = "lblRangoEntradasAnticipadas";
            this.lblRangoEntradasAnticipadas.Size = new System.Drawing.Size(156, 13);
            this.lblRangoEntradasAnticipadas.TabIndex = 19;
            this.lblRangoEntradasAnticipadas.Text = "Rango de Entradas anticipadas";
            // 
            // txtEntrAntDesde
            // 
            this.txtEntrAntDesde.Location = new System.Drawing.Point(205, 177);
            this.txtEntrAntDesde.Name = "txtEntrAntDesde";
            this.txtEntrAntDesde.Size = new System.Drawing.Size(46, 20);
            this.txtEntrAntDesde.TabIndex = 18;
            this.txtEntrAntDesde.Text = "1";
            // 
            // txtTiempoEntradaHasta
            // 
            this.txtTiempoEntradaHasta.Location = new System.Drawing.Point(575, 177);
            this.txtTiempoEntradaHasta.Name = "txtTiempoEntradaHasta";
            this.txtTiempoEntradaHasta.Size = new System.Drawing.Size(44, 20);
            this.txtTiempoEntradaHasta.TabIndex = 26;
            this.txtTiempoEntradaHasta.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Rango de tiempo de entrada";
            // 
            // txtTiempoEntradaDesde
            // 
            this.txtTiempoEntradaDesde.Location = new System.Drawing.Point(508, 177);
            this.txtTiempoEntradaDesde.Name = "txtTiempoEntradaDesde";
            this.txtTiempoEntradaDesde.Size = new System.Drawing.Size(44, 20);
            this.txtTiempoEntradaDesde.TabIndex = 24;
            this.txtTiempoEntradaDesde.Text = "1";
            // 
            // txtTiempoCompraHasta
            // 
            this.txtTiempoCompraHasta.Location = new System.Drawing.Point(575, 143);
            this.txtTiempoCompraHasta.Name = "txtTiempoCompraHasta";
            this.txtTiempoCompraHasta.Size = new System.Drawing.Size(44, 20);
            this.txtTiempoCompraHasta.TabIndex = 23;
            this.txtTiempoCompraHasta.Text = "15";
            // 
            // lblRangoTiempoCompra
            // 
            this.lblRangoTiempoCompra.AutoSize = true;
            this.lblRangoTiempoCompra.Location = new System.Drawing.Point(344, 146);
            this.lblRangoTiempoCompra.Name = "lblRangoTiempoCompra";
            this.lblRangoTiempoCompra.Size = new System.Drawing.Size(141, 13);
            this.lblRangoTiempoCompra.TabIndex = 22;
            this.lblRangoTiempoCompra.Text = "Rango de tiempo de compra";
            // 
            // txtTiempoCompraDesde
            // 
            this.txtTiempoCompraDesde.Location = new System.Drawing.Point(508, 143);
            this.txtTiempoCompraDesde.Name = "txtTiempoCompraDesde";
            this.txtTiempoCompraDesde.Size = new System.Drawing.Size(44, 20);
            this.txtTiempoCompraDesde.TabIndex = 21;
            this.txtTiempoCompraDesde.Text = "10";
            // 
            // txtTiempoLlegAntHasta
            // 
            this.txtTiempoLlegAntHasta.Location = new System.Drawing.Point(963, 180);
            this.txtTiempoLlegAntHasta.Name = "txtTiempoLlegAntHasta";
            this.txtTiempoLlegAntHasta.Size = new System.Drawing.Size(44, 20);
            this.txtTiempoLlegAntHasta.TabIndex = 32;
            this.txtTiempoLlegAntHasta.Text = "23";
            // 
            // lblDemoraAnticipada
            // 
            this.lblDemoraAnticipada.AutoSize = true;
            this.lblDemoraAnticipada.Location = new System.Drawing.Point(660, 184);
            this.lblDemoraAnticipada.Name = "lblDemoraAnticipada";
            this.lblDemoraAnticipada.Size = new System.Drawing.Size(213, 13);
            this.lblDemoraAnticipada.TabIndex = 31;
            this.lblDemoraAnticipada.Text = "Rango de tiempo de llegada con anticipada";
            // 
            // txtTiempoLlegAntDesde
            // 
            this.txtTiempoLlegAntDesde.Location = new System.Drawing.Point(899, 181);
            this.txtTiempoLlegAntDesde.Name = "txtTiempoLlegAntDesde";
            this.txtTiempoLlegAntDesde.Size = new System.Drawing.Size(44, 20);
            this.txtTiempoLlegAntDesde.TabIndex = 30;
            this.txtTiempoLlegAntDesde.Text = "17";
            // 
            // txtTiempoLlegCompHasta
            // 
            this.txtTiempoLlegCompHasta.Location = new System.Drawing.Point(963, 146);
            this.txtTiempoLlegCompHasta.Name = "txtTiempoLlegCompHasta";
            this.txtTiempoLlegCompHasta.Size = new System.Drawing.Size(44, 20);
            this.txtTiempoLlegCompHasta.TabIndex = 29;
            this.txtTiempoLlegCompHasta.Text = "30";
            // 
            // lblDemoraLlegadaCompra
            // 
            this.lblDemoraLlegadaCompra.AutoSize = true;
            this.lblDemoraLlegadaCompra.Location = new System.Drawing.Point(660, 150);
            this.lblDemoraLlegadaCompra.Name = "lblDemoraLlegadaCompra";
            this.lblDemoraLlegadaCompra.Size = new System.Drawing.Size(205, 13);
            this.lblDemoraLlegadaCompra.TabIndex = 28;
            this.lblDemoraLlegadaCompra.Text = "Rango de tiempo de llegada para comprar";
            // 
            // txtTiempoLlegCompDesde
            // 
            this.txtTiempoLlegCompDesde.Location = new System.Drawing.Point(899, 146);
            this.txtTiempoLlegCompDesde.Name = "txtTiempoLlegCompDesde";
            this.txtTiempoLlegCompDesde.Size = new System.Drawing.Size(44, 20);
            this.txtTiempoLlegCompDesde.TabIndex = 27;
            this.txtTiempoLlegCompDesde.Text = "20";
            // 
            // lblHorarioConEntrada
            // 
            this.lblHorarioConEntrada.AutoSize = true;
            this.lblHorarioConEntrada.Location = new System.Drawing.Point(466, 105);
            this.lblHorarioConEntrada.Name = "lblHorarioConEntrada";
            this.lblHorarioConEntrada.Size = new System.Drawing.Size(191, 13);
            this.lblHorarioConEntrada.TabIndex = 34;
            this.lblHorarioConEntrada.Text = "Minutos previos llegada con anticipada";
            // 
            // txtHorarioLlegadaAnticipada
            // 
            this.txtHorarioLlegadaAnticipada.Location = new System.Drawing.Point(663, 102);
            this.txtHorarioLlegadaAnticipada.Name = "txtHorarioLlegadaAnticipada";
            this.txtHorarioLlegadaAnticipada.Size = new System.Drawing.Size(46, 20);
            this.txtHorarioLlegadaAnticipada.TabIndex = 33;
            this.txtHorarioLlegadaAnticipada.Text = "8";
            // 
            // lblHorarioComienzoPelicula
            // 
            this.lblHorarioComienzoPelicula.AutoSize = true;
            this.lblHorarioComienzoPelicula.Location = new System.Drawing.Point(750, 106);
            this.lblHorarioComienzoPelicula.Name = "lblHorarioComienzoPelicula";
            this.lblHorarioComienzoPelicula.Size = new System.Drawing.Size(193, 13);
            this.lblHorarioComienzoPelicula.TabIndex = 36;
            this.lblHorarioComienzoPelicula.Text = "Minutos hasta que comience la pelicula";
            // 
            // txtHorarioComienzoPelicula
            // 
            this.txtHorarioComienzoPelicula.Location = new System.Drawing.Point(949, 103);
            this.txtHorarioComienzoPelicula.Name = "txtHorarioComienzoPelicula";
            this.txtHorarioComienzoPelicula.Size = new System.Drawing.Size(39, 20);
            this.txtHorarioComienzoPelicula.TabIndex = 35;
            this.txtHorarioComienzoPelicula.Text = "20";
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(1120, 150);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(75, 23);
            this.btnSimular.TabIndex = 37;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // dgvFunciones
            // 
            this.dgvFunciones.AllowUserToAddRows = false;
            this.dgvFunciones.AllowUserToDeleteRows = false;
            this.dgvFunciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.evento2,
            this.numSimulacion2,
            this.reloj2,
            this.colaBoleteria2});
            this.dgvFunciones.Location = new System.Drawing.Point(1013, 304);
            this.dgvFunciones.Name = "dgvFunciones";
            this.dgvFunciones.ReadOnly = true;
            this.dgvFunciones.Size = new System.Drawing.Size(443, 285);
            this.dgvFunciones.TabIndex = 38;
            // 
            // evento2
            // 
            this.evento2.HeaderText = "Evento";
            this.evento2.Name = "evento2";
            this.evento2.ReadOnly = true;
            // 
            // numSimulacion2
            // 
            this.numSimulacion2.HeaderText = "Numero de simulación";
            this.numSimulacion2.Name = "numSimulacion2";
            this.numSimulacion2.ReadOnly = true;
            // 
            // reloj2
            // 
            this.reloj2.HeaderText = "Reloj";
            this.reloj2.Name = "reloj2";
            this.reloj2.ReadOnly = true;
            // 
            // colaBoleteria2
            // 
            this.colaBoleteria2.HeaderText = "Cantidad de Clientes en cola";
            this.colaBoleteria2.Name = "colaBoleteria2";
            this.colaBoleteria2.ReadOnly = true;
            // 
            // frmSimulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 632);
            this.Controls.Add(this.dgvFunciones);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.lblHorarioComienzoPelicula);
            this.Controls.Add(this.txtHorarioComienzoPelicula);
            this.Controls.Add(this.lblHorarioConEntrada);
            this.Controls.Add(this.txtHorarioLlegadaAnticipada);
            this.Controls.Add(this.txtTiempoLlegAntHasta);
            this.Controls.Add(this.lblDemoraAnticipada);
            this.Controls.Add(this.txtTiempoLlegAntDesde);
            this.Controls.Add(this.txtTiempoLlegCompHasta);
            this.Controls.Add(this.lblDemoraLlegadaCompra);
            this.Controls.Add(this.txtTiempoLlegCompDesde);
            this.Controls.Add(this.txtTiempoEntradaHasta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTiempoEntradaDesde);
            this.Controls.Add(this.txtTiempoCompraHasta);
            this.Controls.Add(this.lblRangoTiempoCompra);
            this.Controls.Add(this.txtTiempoCompraDesde);
            this.Controls.Add(this.txtEntrAntHasta);
            this.Controls.Add(this.lblRangoEntradasAnticipadas);
            this.Controls.Add(this.txtEntrAntDesde);
            this.Controls.Add(this.txtEntrCompHasta);
            this.Controls.Add(this.lblRangoEntradas);
            this.Controls.Add(this.txtEntrCompDesde);
            this.Controls.Add(this.lblAperturaSala);
            this.Controls.Add(this.txtHorarioAperturaSala);
            this.Controls.Add(this.lblTamSala);
            this.Controls.Add(this.txtTamSala);
            this.Controls.Add(this.lblSimulacionMostrar);
            this.Controls.Add(this.txtSimAMostrar);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.dgvFuncion);
            this.Name = "frmSimulacion";
            this.Text = "Simulacion Sala Cine";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFuncion;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblSimulacionMostrar;
        private System.Windows.Forms.TextBox txtSimAMostrar;
        private System.Windows.Forms.Label lblTamSala;
        private System.Windows.Forms.TextBox txtTamSala;
        private System.Windows.Forms.Label lblAperturaSala;
        private System.Windows.Forms.TextBox txtHorarioAperturaSala;
        private System.Windows.Forms.Label lblRangoEntradas;
        private System.Windows.Forms.TextBox txtEntrCompDesde;
        private System.Windows.Forms.TextBox txtEntrCompHasta;
        private System.Windows.Forms.TextBox txtEntrAntHasta;
        private System.Windows.Forms.Label lblRangoEntradasAnticipadas;
        private System.Windows.Forms.TextBox txtEntrAntDesde;
        private System.Windows.Forms.TextBox txtTiempoEntradaHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTiempoEntradaDesde;
        private System.Windows.Forms.TextBox txtTiempoCompraHasta;
        private System.Windows.Forms.Label lblRangoTiempoCompra;
        private System.Windows.Forms.TextBox txtTiempoCompraDesde;
        private System.Windows.Forms.TextBox txtTiempoLlegAntHasta;
        private System.Windows.Forms.Label lblDemoraAnticipada;
        private System.Windows.Forms.TextBox txtTiempoLlegAntDesde;
        private System.Windows.Forms.TextBox txtTiempoLlegCompHasta;
        private System.Windows.Forms.Label lblDemoraLlegadaCompra;
        private System.Windows.Forms.TextBox txtTiempoLlegCompDesde;
        private System.Windows.Forms.Label lblHorarioConEntrada;
        private System.Windows.Forms.TextBox txtHorarioLlegadaAnticipada;
        private System.Windows.Forms.Label lblHorarioComienzoPelicula;
        private System.Windows.Forms.TextBox txtHorarioComienzoPelicula;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.DataGridViewTextBoxColumn numSimulacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn reloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndLlegadaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn llegadaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximaLlegadaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndLlegadaEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximaLlegadaEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndNumeroEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoBoletero;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndFinCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn finCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximoFinCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colaBoleteria;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndFinEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn finEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximoFinEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn acumEntradasVendidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaLlena;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoOcupBoletero;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcTiempoOcupBoletero;
        private System.Windows.Forms.DataGridViewTextBoxColumn contEntradasAnticipadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcNoEntrar;
        private System.Windows.Forms.DataGridView dgvFunciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn evento2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numSimulacion2;
        private System.Windows.Forms.DataGridViewTextBoxColumn reloj2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colaBoleteria2;
    }
}

