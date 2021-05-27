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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.dgvFuncion.Location = new System.Drawing.Point(22, 19);
            this.dgvFuncion.Name = "dgvFuncion";
            this.dgvFuncion.ReadOnly = true;
            this.dgvFuncion.Size = new System.Drawing.Size(1441, 285);
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
            this.txtN.Location = new System.Drawing.Point(254, 38);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(52, 26);
            this.txtN.TabIndex = 1;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(62, 41);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(186, 20);
            this.lblN.TabIndex = 2;
            this.lblN.Text = "Número de simulaciones:";
            // 
            // lblSimulacionMostrar
            // 
            this.lblSimulacionMostrar.AutoSize = true;
            this.lblSimulacionMostrar.Location = new System.Drawing.Point(339, 41);
            this.lblSimulacionMostrar.Name = "lblSimulacionMostrar";
            this.lblSimulacionMostrar.Size = new System.Drawing.Size(240, 20);
            this.lblSimulacionMostrar.TabIndex = 4;
            this.lblSimulacionMostrar.Text = "Número de simulación a mostrar:";
            // 
            // txtSimAMostrar
            // 
            this.txtSimAMostrar.Location = new System.Drawing.Point(585, 38);
            this.txtSimAMostrar.Name = "txtSimAMostrar";
            this.txtSimAMostrar.Size = new System.Drawing.Size(52, 26);
            this.txtSimAMostrar.TabIndex = 3;
            // 
            // lblTamSala
            // 
            this.lblTamSala.AutoSize = true;
            this.lblTamSala.Location = new System.Drawing.Point(60, 46);
            this.lblTamSala.Name = "lblTamSala";
            this.lblTamSala.Size = new System.Drawing.Size(103, 20);
            this.lblTamSala.TabIndex = 12;
            this.lblTamSala.Text = "Tamaño Sala";
            // 
            // txtTamSala
            // 
            this.txtTamSala.Location = new System.Drawing.Point(169, 43);
            this.txtTamSala.Name = "txtTamSala";
            this.txtTamSala.Size = new System.Drawing.Size(47, 26);
            this.txtTamSala.TabIndex = 11;
            this.txtTamSala.Text = "100";
            // 
            // lblAperturaSala
            // 
            this.lblAperturaSala.AutoSize = true;
            this.lblAperturaSala.Location = new System.Drawing.Point(281, 46);
            this.lblAperturaSala.Name = "lblAperturaSala";
            this.lblAperturaSala.Size = new System.Drawing.Size(216, 20);
            this.lblAperturaSala.TabIndex = 14;
            this.lblAperturaSala.Text = "Minutos previos apertura sala";
            // 
            // txtHorarioAperturaSala
            // 
            this.txtHorarioAperturaSala.Location = new System.Drawing.Point(503, 43);
            this.txtHorarioAperturaSala.Name = "txtHorarioAperturaSala";
            this.txtHorarioAperturaSala.Size = new System.Drawing.Size(47, 26);
            this.txtHorarioAperturaSala.TabIndex = 13;
            this.txtHorarioAperturaSala.Text = "4";
            // 
            // lblRangoEntradas
            // 
            this.lblRangoEntradas.AutoSize = true;
            this.lblRangoEntradas.Location = new System.Drawing.Point(38, 94);
            this.lblRangoEntradas.Name = "lblRangoEntradas";
            this.lblRangoEntradas.Size = new System.Drawing.Size(223, 20);
            this.lblRangoEntradas.TabIndex = 16;
            this.lblRangoEntradas.Text = "Rango de Entradas a comprar";
            // 
            // txtEntrCompDesde
            // 
            this.txtEntrCompDesde.Location = new System.Drawing.Point(277, 91);
            this.txtEntrCompDesde.Name = "txtEntrCompDesde";
            this.txtEntrCompDesde.Size = new System.Drawing.Size(47, 26);
            this.txtEntrCompDesde.TabIndex = 15;
            this.txtEntrCompDesde.Text = "1";
            // 
            // txtEntrCompHasta
            // 
            this.txtEntrCompHasta.Location = new System.Drawing.Point(355, 91);
            this.txtEntrCompHasta.Name = "txtEntrCompHasta";
            this.txtEntrCompHasta.Size = new System.Drawing.Size(47, 26);
            this.txtEntrCompHasta.TabIndex = 17;
            this.txtEntrCompHasta.Text = "4";
            // 
            // txtEntrAntHasta
            // 
            this.txtEntrAntHasta.Location = new System.Drawing.Point(354, 125);
            this.txtEntrAntHasta.Name = "txtEntrAntHasta";
            this.txtEntrAntHasta.Size = new System.Drawing.Size(47, 26);
            this.txtEntrAntHasta.TabIndex = 20;
            this.txtEntrAntHasta.Text = "3";
            // 
            // lblRangoEntradasAnticipadas
            // 
            this.lblRangoEntradasAnticipadas.AutoSize = true;
            this.lblRangoEntradasAnticipadas.Location = new System.Drawing.Point(38, 128);
            this.lblRangoEntradasAnticipadas.Name = "lblRangoEntradasAnticipadas";
            this.lblRangoEntradasAnticipadas.Size = new System.Drawing.Size(233, 20);
            this.lblRangoEntradasAnticipadas.TabIndex = 19;
            this.lblRangoEntradasAnticipadas.Text = "Rango de Entradas anticipadas";
            // 
            // txtEntrAntDesde
            // 
            this.txtEntrAntDesde.Location = new System.Drawing.Point(277, 125);
            this.txtEntrAntDesde.Name = "txtEntrAntDesde";
            this.txtEntrAntDesde.Size = new System.Drawing.Size(47, 26);
            this.txtEntrAntDesde.TabIndex = 18;
            this.txtEntrAntDesde.Text = "1";
            // 
            // txtTiempoEntradaHasta
            // 
            this.txtTiempoEntradaHasta.Location = new System.Drawing.Point(792, 125);
            this.txtTiempoEntradaHasta.Name = "txtTiempoEntradaHasta";
            this.txtTiempoEntradaHasta.Size = new System.Drawing.Size(47, 26);
            this.txtTiempoEntradaHasta.TabIndex = 26;
            this.txtTiempoEntradaHasta.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Rango de tiempo de entrada";
            // 
            // txtTiempoEntradaDesde
            // 
            this.txtTiempoEntradaDesde.Location = new System.Drawing.Point(715, 125);
            this.txtTiempoEntradaDesde.Name = "txtTiempoEntradaDesde";
            this.txtTiempoEntradaDesde.Size = new System.Drawing.Size(47, 26);
            this.txtTiempoEntradaDesde.TabIndex = 24;
            this.txtTiempoEntradaDesde.Text = "1";
            // 
            // txtTiempoCompraHasta
            // 
            this.txtTiempoCompraHasta.Location = new System.Drawing.Point(792, 91);
            this.txtTiempoCompraHasta.Name = "txtTiempoCompraHasta";
            this.txtTiempoCompraHasta.Size = new System.Drawing.Size(47, 26);
            this.txtTiempoCompraHasta.TabIndex = 23;
            this.txtTiempoCompraHasta.Text = "15";
            // 
            // lblRangoTiempoCompra
            // 
            this.lblRangoTiempoCompra.AutoSize = true;
            this.lblRangoTiempoCompra.Location = new System.Drawing.Point(499, 94);
            this.lblRangoTiempoCompra.Name = "lblRangoTiempoCompra";
            this.lblRangoTiempoCompra.Size = new System.Drawing.Size(210, 20);
            this.lblRangoTiempoCompra.TabIndex = 22;
            this.lblRangoTiempoCompra.Text = "Rango de tiempo de compra";
            // 
            // txtTiempoCompraDesde
            // 
            this.txtTiempoCompraDesde.Location = new System.Drawing.Point(715, 91);
            this.txtTiempoCompraDesde.Name = "txtTiempoCompraDesde";
            this.txtTiempoCompraDesde.Size = new System.Drawing.Size(47, 26);
            this.txtTiempoCompraDesde.TabIndex = 21;
            this.txtTiempoCompraDesde.Text = "10";
            // 
            // txtTiempoLlegAntHasta
            // 
            this.txtTiempoLlegAntHasta.Location = new System.Drawing.Point(1300, 125);
            this.txtTiempoLlegAntHasta.Name = "txtTiempoLlegAntHasta";
            this.txtTiempoLlegAntHasta.Size = new System.Drawing.Size(47, 26);
            this.txtTiempoLlegAntHasta.TabIndex = 32;
            this.txtTiempoLlegAntHasta.Text = "23";
            // 
            // lblDemoraAnticipada
            // 
            this.lblDemoraAnticipada.AutoSize = true;
            this.lblDemoraAnticipada.Location = new System.Drawing.Point(895, 128);
            this.lblDemoraAnticipada.Name = "lblDemoraAnticipada";
            this.lblDemoraAnticipada.Size = new System.Drawing.Size(315, 20);
            this.lblDemoraAnticipada.TabIndex = 31;
            this.lblDemoraAnticipada.Text = "Rango de tiempo de llegada con anticipada";
            // 
            // txtTiempoLlegAntDesde
            // 
            this.txtTiempoLlegAntDesde.Location = new System.Drawing.Point(1223, 125);
            this.txtTiempoLlegAntDesde.Name = "txtTiempoLlegAntDesde";
            this.txtTiempoLlegAntDesde.Size = new System.Drawing.Size(47, 26);
            this.txtTiempoLlegAntDesde.TabIndex = 30;
            this.txtTiempoLlegAntDesde.Text = "17";
            // 
            // txtTiempoLlegCompHasta
            // 
            this.txtTiempoLlegCompHasta.Location = new System.Drawing.Point(1300, 91);
            this.txtTiempoLlegCompHasta.Name = "txtTiempoLlegCompHasta";
            this.txtTiempoLlegCompHasta.Size = new System.Drawing.Size(47, 26);
            this.txtTiempoLlegCompHasta.TabIndex = 29;
            this.txtTiempoLlegCompHasta.Text = "30";
            // 
            // lblDemoraLlegadaCompra
            // 
            this.lblDemoraLlegadaCompra.AutoSize = true;
            this.lblDemoraLlegadaCompra.Location = new System.Drawing.Point(895, 94);
            this.lblDemoraLlegadaCompra.Name = "lblDemoraLlegadaCompra";
            this.lblDemoraLlegadaCompra.Size = new System.Drawing.Size(306, 20);
            this.lblDemoraLlegadaCompra.TabIndex = 28;
            this.lblDemoraLlegadaCompra.Text = "Rango de tiempo de llegada para comprar";
            // 
            // txtTiempoLlegCompDesde
            // 
            this.txtTiempoLlegCompDesde.Location = new System.Drawing.Point(1223, 91);
            this.txtTiempoLlegCompDesde.Name = "txtTiempoLlegCompDesde";
            this.txtTiempoLlegCompDesde.Size = new System.Drawing.Size(47, 26);
            this.txtTiempoLlegCompDesde.TabIndex = 27;
            this.txtTiempoLlegCompDesde.Text = "20";
            // 
            // lblHorarioConEntrada
            // 
            this.lblHorarioConEntrada.AutoSize = true;
            this.lblHorarioConEntrada.Location = new System.Drawing.Point(603, 46);
            this.lblHorarioConEntrada.Name = "lblHorarioConEntrada";
            this.lblHorarioConEntrada.Size = new System.Drawing.Size(281, 20);
            this.lblHorarioConEntrada.TabIndex = 34;
            this.lblHorarioConEntrada.Text = "Minutos previos llegada con anticipada";
            // 
            // txtHorarioLlegadaAnticipada
            // 
            this.txtHorarioLlegadaAnticipada.Location = new System.Drawing.Point(890, 43);
            this.txtHorarioLlegadaAnticipada.Name = "txtHorarioLlegadaAnticipada";
            this.txtHorarioLlegadaAnticipada.Size = new System.Drawing.Size(47, 26);
            this.txtHorarioLlegadaAnticipada.TabIndex = 33;
            this.txtHorarioLlegadaAnticipada.Text = "8";
            // 
            // lblHorarioComienzoPelicula
            // 
            this.lblHorarioComienzoPelicula.AutoSize = true;
            this.lblHorarioComienzoPelicula.Location = new System.Drawing.Point(1021, 46);
            this.lblHorarioComienzoPelicula.Name = "lblHorarioComienzoPelicula";
            this.lblHorarioComienzoPelicula.Size = new System.Drawing.Size(285, 20);
            this.lblHorarioComienzoPelicula.TabIndex = 36;
            this.lblHorarioComienzoPelicula.Text = "Minutos hasta que comience la pelicula";
            // 
            // txtHorarioComienzoPelicula
            // 
            this.txtHorarioComienzoPelicula.Location = new System.Drawing.Point(1312, 43);
            this.txtHorarioComienzoPelicula.Name = "txtHorarioComienzoPelicula";
            this.txtHorarioComienzoPelicula.Size = new System.Drawing.Size(47, 26);
            this.txtHorarioComienzoPelicula.TabIndex = 35;
            this.txtHorarioComienzoPelicula.Text = "20";
            // 
            // btnSimular
            // 
            this.btnSimular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimular.Location = new System.Drawing.Point(710, 298);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(84, 37);
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
            this.dgvFunciones.Location = new System.Drawing.Point(17, 20);
            this.dgvFunciones.Name = "dgvFunciones";
            this.dgvFunciones.ReadOnly = true;
            this.dgvFunciones.Size = new System.Drawing.Size(452, 276);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtN);
            this.groupBox1.Controls.Add(this.lblN);
            this.groupBox1.Controls.Add(this.txtSimAMostrar);
            this.groupBox1.Controls.Add(this.lblSimulacionMostrar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(404, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 81);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simulación";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtTamSala);
            this.groupBox2.Controls.Add(this.lblTamSala);
            this.groupBox2.Controls.Add(this.txtHorarioAperturaSala);
            this.groupBox2.Controls.Add(this.lblAperturaSala);
            this.groupBox2.Controls.Add(this.lblHorarioComienzoPelicula);
            this.groupBox2.Controls.Add(this.txtEntrCompDesde);
            this.groupBox2.Controls.Add(this.txtHorarioComienzoPelicula);
            this.groupBox2.Controls.Add(this.lblRangoEntradas);
            this.groupBox2.Controls.Add(this.lblHorarioConEntrada);
            this.groupBox2.Controls.Add(this.txtEntrCompHasta);
            this.groupBox2.Controls.Add(this.txtHorarioLlegadaAnticipada);
            this.groupBox2.Controls.Add(this.txtEntrAntDesde);
            this.groupBox2.Controls.Add(this.txtTiempoLlegAntHasta);
            this.groupBox2.Controls.Add(this.lblRangoEntradasAnticipadas);
            this.groupBox2.Controls.Add(this.lblDemoraAnticipada);
            this.groupBox2.Controls.Add(this.txtEntrAntHasta);
            this.groupBox2.Controls.Add(this.txtTiempoLlegAntDesde);
            this.groupBox2.Controls.Add(this.txtTiempoCompraDesde);
            this.groupBox2.Controls.Add(this.txtTiempoLlegCompHasta);
            this.groupBox2.Controls.Add(this.lblRangoTiempoCompra);
            this.groupBox2.Controls.Add(this.lblDemoraLlegadaCompra);
            this.groupBox2.Controls.Add(this.txtTiempoCompraHasta);
            this.groupBox2.Controls.Add(this.txtTiempoLlegCompDesde);
            this.groupBox2.Controls.Add(this.txtTiempoEntradaDesde);
            this.groupBox2.Controls.Add(this.txtTiempoEntradaHasta);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(53, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1398, 170);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parámetros";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(768, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "a";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(768, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "a";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1276, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "a";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1276, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "a";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvFuncion);
            this.groupBox3.Location = new System.Drawing.Point(12, 341);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1480, 320);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Simulaciones";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvFunciones);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(539, 667);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(481, 304);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resultados";
            // 
            // frmSimulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 975);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSimular);
            this.Name = "frmSimulacion";
            this.Text = "Simulacion Sala Cine";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

