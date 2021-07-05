
namespace TP7
{
    partial class frmOficinaAnses
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
            this.lblLineas1 = new System.Windows.Forms.Label();
            this.txtLineas = new System.Windows.Forms.TextBox();
            this.gbxSimulacion = new System.Windows.Forms.GroupBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.lblN = new System.Windows.Forms.Label();
            this.txtMostrarDesde = new System.Windows.Forms.TextBox();
            this.lblLineas2 = new System.Windows.Forms.Label();
            this.rbtAlgunas = new System.Windows.Forms.RadioButton();
            this.rbtTodas = new System.Windows.Forms.RadioButton();
            this.gbxParametros = new System.Windows.Forms.GroupBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.lblH = new System.Windows.Forms.Label();
            this.btnRungeKutta = new System.Windows.Forms.Button();
            this.txtRangoTareaHasta = new System.Windows.Forms.TextBox();
            this.txtRangoTareaDesde = new System.Windows.Forms.TextBox();
            this.lblRangoTarea = new System.Windows.Forms.Label();
            this.txtTiempoOtraTarea = new System.Windows.Forms.TextBox();
            this.lblTiempoOtraTarea = new System.Windows.Forms.Label();
            this.txtZo = new System.Windows.Forms.TextBox();
            this.lblZo = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.txtRangoEntenderHasta = new System.Windows.Forms.TextBox();
            this.txtRangoEntenderDesde = new System.Windows.Forms.TextBox();
            this.lblRangoEntender = new System.Windows.Forms.Label();
            this.txtTasaLlegada = new System.Windows.Forms.TextBox();
            this.lblTasaLlegada = new System.Windows.Forms.Label();
            this.txtRangoEdadesHasta = new System.Windows.Forms.TextBox();
            this.txtRangoEdadesDesde = new System.Windows.Forms.TextBox();
            this.lblRangoEdades = new System.Windows.Forms.Label();
            this.txtProbMayorEdad = new System.Windows.Forms.TextBox();
            this.lblProbMayorEdad = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.linea2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSimular = new System.Windows.Forms.Button();
            this.txtAlfa = new System.Windows.Forms.TextBox();
            this.lblAlfa = new System.Windows.Forms.Label();
            this.txtBeta = new System.Windows.Forms.TextBox();
            this.lblBeta = new System.Windows.Forms.Label();
            this.linea1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndLlegadaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoLlegadaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximaLlegadaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndMayorEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esMayorEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndFinHacerEntender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoFinHacerEntender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximoFinHacerEntender1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximoFinHacerEntender2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximoFinHacerEntender3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoProximaTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximaTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndDependienteTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dependienteTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tareasHacerDependiente1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tareasHacerDependiente2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tareasHacerDependiente3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndFinOtraTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoFinOtraTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximoFinOtraTarea1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximoFinOtraTarea2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximoFinOtraTarea3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDependiente1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaComienzoOcupacion1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDependiente2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaComienzoOcupacion2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDependiente3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaComienzoOcupacion3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colaAtencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradoOcupacionDependiente1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradoOcupacionDependiente2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradoOcupacionDependiente3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esperaPromedioCola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadPersonasAtendidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajeClientesAtendidosMayoresEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajeOcupacionIrrelevante1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajeOcupacionIrrelevante2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajeOcupacionIrrelevante3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoMaximoPermanenciaSistemaMayorEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acTiempoOcupacion1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acTiempoOcupacion2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acTiempoOcupacion3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acTiempoEspera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acClientesCola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acPersonasAtendidasMayoresEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acTiempoOcupacionIrrelevante1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acTiempoOcupacionIrrelevante2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acTiempoOcupacionIrrelevante3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncion)).BeginInit();
            this.gbxSimulacion.SuspendLayout();
            this.gbxParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFuncion
            // 
            this.dgvFuncion.AllowUserToAddRows = false;
            this.dgvFuncion.AllowUserToDeleteRows = false;
            this.dgvFuncion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.linea1,
            this.evento,
            this.reloj,
            this.rndLlegadaCliente,
            this.tiempoLlegadaCliente,
            this.proximaLlegadaCliente,
            this.rndMayorEdad,
            this.esMayorEdad,
            this.rndEdad,
            this.edad,
            this.rndFinHacerEntender,
            this.tiempoFinHacerEntender,
            this.proximoFinHacerEntender1,
            this.proximoFinHacerEntender2,
            this.proximoFinHacerEntender3,
            this.tiempoProximaTarea,
            this.proximaTarea,
            this.rndDependienteTarea,
            this.dependienteTarea,
            this.tareasHacerDependiente1,
            this.tareasHacerDependiente2,
            this.tareasHacerDependiente3,
            this.rndFinOtraTarea,
            this.tiempoFinOtraTarea,
            this.proximoFinOtraTarea1,
            this.proximoFinOtraTarea2,
            this.proximoFinOtraTarea3,
            this.estadoDependiente1,
            this.horaComienzoOcupacion1,
            this.estadoDependiente2,
            this.horaComienzoOcupacion2,
            this.estadoDependiente3,
            this.horaComienzoOcupacion3,
            this.colaAtencion,
            this.gradoOcupacionDependiente1,
            this.gradoOcupacionDependiente2,
            this.gradoOcupacionDependiente3,
            this.esperaPromedioCola,
            this.cantidadPersonasAtendidas,
            this.porcentajeClientesAtendidosMayoresEdad,
            this.porcentajeOcupacionIrrelevante1,
            this.porcentajeOcupacionIrrelevante2,
            this.porcentajeOcupacionIrrelevante3,
            this.tiempoMaximoPermanenciaSistemaMayorEdad,
            this.acTiempoOcupacion1,
            this.acTiempoOcupacion2,
            this.acTiempoOcupacion3,
            this.acTiempoEspera,
            this.acClientesCola,
            this.acPersonasAtendidasMayoresEdad,
            this.acTiempoOcupacionIrrelevante1,
            this.acTiempoOcupacionIrrelevante2,
            this.acTiempoOcupacionIrrelevante3});
            this.dgvFuncion.Location = new System.Drawing.Point(12, 274);
            this.dgvFuncion.Name = "dgvFuncion";
            this.dgvFuncion.ReadOnly = true;
            this.dgvFuncion.Size = new System.Drawing.Size(1880, 320);
            this.dgvFuncion.TabIndex = 0;
            this.dgvFuncion.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvFuncion_Scroll);
            // 
            // lblLineas1
            // 
            this.lblLineas1.AutoSize = true;
            this.lblLineas1.Location = new System.Drawing.Point(93, 71);
            this.lblLineas1.Name = "lblLineas1";
            this.lblLineas1.Size = new System.Drawing.Size(42, 13);
            this.lblLineas1.TabIndex = 1;
            this.lblLineas1.Text = "Mostrar";
            // 
            // txtLineas
            // 
            this.txtLineas.Location = new System.Drawing.Point(141, 68);
            this.txtLineas.Name = "txtLineas";
            this.txtLineas.Size = new System.Drawing.Size(100, 20);
            this.txtLineas.TabIndex = 2;
            this.txtLineas.Text = "100";
            // 
            // gbxSimulacion
            // 
            this.gbxSimulacion.Controls.Add(this.txtN);
            this.gbxSimulacion.Controls.Add(this.txtMostrarDesde);
            this.gbxSimulacion.Controls.Add(this.lblN);
            this.gbxSimulacion.Controls.Add(this.lblLineas2);
            this.gbxSimulacion.Controls.Add(this.rbtAlgunas);
            this.gbxSimulacion.Controls.Add(this.rbtTodas);
            this.gbxSimulacion.Controls.Add(this.lblLineas1);
            this.gbxSimulacion.Controls.Add(this.txtLineas);
            this.gbxSimulacion.Location = new System.Drawing.Point(666, 12);
            this.gbxSimulacion.Name = "gbxSimulacion";
            this.gbxSimulacion.Size = new System.Drawing.Size(573, 109);
            this.gbxSimulacion.TabIndex = 3;
            this.gbxSimulacion.TabStop = false;
            this.gbxSimulacion.Text = "Simulación";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(307, 19);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 8;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(163, 22);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(138, 13);
            this.lblN.TabIndex = 7;
            this.lblN.Text = "Número de líneas a simular:";
            // 
            // txtMostrarDesde
            // 
            this.txtMostrarDesde.Location = new System.Drawing.Point(377, 68);
            this.txtMostrarDesde.Name = "txtMostrarDesde";
            this.txtMostrarDesde.Size = new System.Drawing.Size(100, 20);
            this.txtMostrarDesde.TabIndex = 6;
            this.txtMostrarDesde.Text = "1";
            // 
            // lblLineas2
            // 
            this.lblLineas2.AutoSize = true;
            this.lblLineas2.Location = new System.Drawing.Point(247, 71);
            this.lblLineas2.Name = "lblLineas2";
            this.lblLineas2.Size = new System.Drawing.Size(124, 13);
            this.lblLineas2.TabIndex = 5;
            this.lblLineas2.Text = "líneas a partir de la línea";
            // 
            // rbtAlgunas
            // 
            this.rbtAlgunas.AutoSize = true;
            this.rbtAlgunas.Location = new System.Drawing.Point(271, 45);
            this.rbtAlgunas.Name = "rbtAlgunas";
            this.rbtAlgunas.Size = new System.Drawing.Size(171, 17);
            this.rbtAlgunas.TabIndex = 4;
            this.rbtAlgunas.Text = "Mostrar un intervalo específico";
            this.rbtAlgunas.UseVisualStyleBackColor = true;
            // 
            // rbtTodas
            // 
            this.rbtTodas.AutoSize = true;
            this.rbtTodas.Checked = true;
            this.rbtTodas.Location = new System.Drawing.Point(128, 45);
            this.rbtTodas.Name = "rbtTodas";
            this.rbtTodas.Size = new System.Drawing.Size(137, 17);
            this.rbtTodas.TabIndex = 3;
            this.rbtTodas.TabStop = true;
            this.rbtTodas.Text = "Mostrar todas las líneas";
            this.rbtTodas.UseVisualStyleBackColor = true;
            // 
            // gbxParametros
            // 
            this.gbxParametros.Controls.Add(this.txtBeta);
            this.gbxParametros.Controls.Add(this.lblBeta);
            this.gbxParametros.Controls.Add(this.txtAlfa);
            this.gbxParametros.Controls.Add(this.lblAlfa);
            this.gbxParametros.Controls.Add(this.txtH);
            this.gbxParametros.Controls.Add(this.lblH);
            this.gbxParametros.Controls.Add(this.btnRungeKutta);
            this.gbxParametros.Controls.Add(this.txtRangoTareaHasta);
            this.gbxParametros.Controls.Add(this.txtRangoTareaDesde);
            this.gbxParametros.Controls.Add(this.lblRangoTarea);
            this.gbxParametros.Controls.Add(this.txtTiempoOtraTarea);
            this.gbxParametros.Controls.Add(this.lblTiempoOtraTarea);
            this.gbxParametros.Controls.Add(this.txtZo);
            this.gbxParametros.Controls.Add(this.lblZo);
            this.gbxParametros.Controls.Add(this.txtTo);
            this.gbxParametros.Controls.Add(this.lblTo);
            this.gbxParametros.Controls.Add(this.txtRangoEntenderHasta);
            this.gbxParametros.Controls.Add(this.txtRangoEntenderDesde);
            this.gbxParametros.Controls.Add(this.lblRangoEntender);
            this.gbxParametros.Controls.Add(this.txtTasaLlegada);
            this.gbxParametros.Controls.Add(this.lblTasaLlegada);
            this.gbxParametros.Controls.Add(this.txtRangoEdadesHasta);
            this.gbxParametros.Controls.Add(this.txtRangoEdadesDesde);
            this.gbxParametros.Controls.Add(this.lblRangoEdades);
            this.gbxParametros.Controls.Add(this.txtProbMayorEdad);
            this.gbxParametros.Controls.Add(this.lblProbMayorEdad);
            this.gbxParametros.Location = new System.Drawing.Point(104, 127);
            this.gbxParametros.Name = "gbxParametros";
            this.gbxParametros.Size = new System.Drawing.Size(1697, 86);
            this.gbxParametros.TabIndex = 4;
            this.gbxParametros.TabStop = false;
            this.gbxParametros.Text = "Parámetros";
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(1425, 23);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(51, 20);
            this.txtH.TabIndex = 21;
            this.txtH.Text = "1";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Location = new System.Drawing.Point(1403, 26);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(16, 13);
            this.lblH.TabIndex = 20;
            this.lblH.Text = "h:";
            // 
            // btnRungeKutta
            // 
            this.btnRungeKutta.Enabled = false;
            this.btnRungeKutta.Location = new System.Drawing.Point(1587, 23);
            this.btnRungeKutta.Name = "btnRungeKutta";
            this.btnRungeKutta.Size = new System.Drawing.Size(77, 46);
            this.btnRungeKutta.TabIndex = 19;
            this.btnRungeKutta.Text = "Mostrar Runge Kutta";
            this.btnRungeKutta.UseVisualStyleBackColor = true;
            this.btnRungeKutta.Click += new System.EventHandler(this.btnRungeKutta_Click);
            // 
            // txtRangoTareaHasta
            // 
            this.txtRangoTareaHasta.Location = new System.Drawing.Point(1220, 49);
            this.txtRangoTareaHasta.Name = "txtRangoTareaHasta";
            this.txtRangoTareaHasta.Size = new System.Drawing.Size(51, 20);
            this.txtRangoTareaHasta.TabIndex = 18;
            this.txtRangoTareaHasta.Text = "8";
            // 
            // txtRangoTareaDesde
            // 
            this.txtRangoTareaDesde.Location = new System.Drawing.Point(1163, 49);
            this.txtRangoTareaDesde.Name = "txtRangoTareaDesde";
            this.txtRangoTareaDesde.Size = new System.Drawing.Size(51, 20);
            this.txtRangoTareaDesde.TabIndex = 17;
            this.txtRangoTareaDesde.Text = "5";
            // 
            // lblRangoTarea
            // 
            this.lblRangoTarea.AutoSize = true;
            this.lblRangoTarea.Location = new System.Drawing.Point(827, 52);
            this.lblRangoTarea.Name = "lblRangoTarea";
            this.lblRangoTarea.Size = new System.Drawing.Size(330, 13);
            this.lblRangoTarea.TabIndex = 16;
            this.lblRangoTarea.Text = "Intervalo de tiempo para realizar otra tarea de dependiente (minutos):";
            // 
            // txtTiempoOtraTarea
            // 
            this.txtTiempoOtraTarea.Location = new System.Drawing.Point(1163, 23);
            this.txtTiempoOtraTarea.Name = "txtTiempoOtraTarea";
            this.txtTiempoOtraTarea.Size = new System.Drawing.Size(51, 20);
            this.txtTiempoOtraTarea.TabIndex = 15;
            this.txtTiempoOtraTarea.Text = "20";
            // 
            // lblTiempoOtraTarea
            // 
            this.lblTiempoOtraTarea.AutoSize = true;
            this.lblTiempoOtraTarea.Location = new System.Drawing.Point(1025, 26);
            this.lblTiempoOtraTarea.Name = "lblTiempoOtraTarea";
            this.lblTiempoOtraTarea.Size = new System.Drawing.Size(132, 13);
            this.lblTiempoOtraTarea.TabIndex = 14;
            this.lblTiempoOtraTarea.Text = "Minutos entre otras tareas:";
            // 
            // txtZo
            // 
            this.txtZo.Location = new System.Drawing.Point(1332, 49);
            this.txtZo.Name = "txtZo";
            this.txtZo.Size = new System.Drawing.Size(51, 20);
            this.txtZo.TabIndex = 13;
            this.txtZo.Text = "0,04";
            // 
            // lblZo
            // 
            this.lblZo.AutoSize = true;
            this.lblZo.Location = new System.Drawing.Point(1303, 52);
            this.lblZo.Name = "lblZo";
            this.lblZo.Size = new System.Drawing.Size(23, 13);
            this.lblZo.TabIndex = 12;
            this.lblZo.Text = "Zo:";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(1332, 23);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(51, 20);
            this.txtTo.TabIndex = 11;
            this.txtTo.Text = "1";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(1303, 26);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(23, 13);
            this.lblTo.TabIndex = 10;
            this.lblTo.Text = "To:";
            // 
            // txtRangoEntenderHasta
            // 
            this.txtRangoEntenderHasta.Location = new System.Drawing.Point(757, 49);
            this.txtRangoEntenderHasta.Name = "txtRangoEntenderHasta";
            this.txtRangoEntenderHasta.Size = new System.Drawing.Size(51, 20);
            this.txtRangoEntenderHasta.TabIndex = 9;
            this.txtRangoEntenderHasta.Text = "2";
            // 
            // txtRangoEntenderDesde
            // 
            this.txtRangoEntenderDesde.Location = new System.Drawing.Point(700, 49);
            this.txtRangoEntenderDesde.Name = "txtRangoEntenderDesde";
            this.txtRangoEntenderDesde.Size = new System.Drawing.Size(51, 20);
            this.txtRangoEntenderDesde.TabIndex = 8;
            this.txtRangoEntenderDesde.Text = "1";
            // 
            // lblRangoEntender
            // 
            this.lblRangoEntender.AutoSize = true;
            this.lblRangoEntender.Location = new System.Drawing.Point(366, 52);
            this.lblRangoEntender.Name = "lblRangoEntender";
            this.lblRangoEntender.Size = new System.Drawing.Size(328, 13);
            this.lblRangoEntender.TabIndex = 7;
            this.lblRangoEntender.Text = "Intervalo de tiempo de entender para no mayores de edad (minutos):";
            // 
            // txtTasaLlegada
            // 
            this.txtTasaLlegada.Location = new System.Drawing.Point(700, 23);
            this.txtTasaLlegada.Name = "txtTasaLlegada";
            this.txtTasaLlegada.Size = new System.Drawing.Size(51, 20);
            this.txtTasaLlegada.TabIndex = 6;
            this.txtTasaLlegada.Text = "65";
            // 
            // lblTasaLlegada
            // 
            this.lblTasaLlegada.AutoSize = true;
            this.lblTasaLlegada.Location = new System.Drawing.Point(468, 26);
            this.lblTasaLlegada.Name = "lblTasaLlegada";
            this.lblTasaLlegada.Size = new System.Drawing.Size(226, 13);
            this.lblTasaLlegada.TabIndex = 5;
            this.lblTasaLlegada.Text = "Tasa de llegada de clientes (en clientes/hora):";
            // 
            // txtRangoEdadesHasta
            // 
            this.txtRangoEdadesHasta.Location = new System.Drawing.Point(298, 49);
            this.txtRangoEdadesHasta.Name = "txtRangoEdadesHasta";
            this.txtRangoEdadesHasta.Size = new System.Drawing.Size(51, 20);
            this.txtRangoEdadesHasta.TabIndex = 4;
            this.txtRangoEdadesHasta.Text = "90";
            // 
            // txtRangoEdadesDesde
            // 
            this.txtRangoEdadesDesde.Location = new System.Drawing.Point(241, 49);
            this.txtRangoEdadesDesde.Name = "txtRangoEdadesDesde";
            this.txtRangoEdadesDesde.Size = new System.Drawing.Size(51, 20);
            this.txtRangoEdadesDesde.TabIndex = 3;
            this.txtRangoEdadesDesde.Text = "70";
            // 
            // lblRangoEdades
            // 
            this.lblRangoEdades.AutoSize = true;
            this.lblRangoEdades.Location = new System.Drawing.Point(32, 52);
            this.lblRangoEdades.Name = "lblRangoEdades";
            this.lblRangoEdades.Size = new System.Drawing.Size(203, 13);
            this.lblRangoEdades.TabIndex = 2;
            this.lblRangoEdades.Text = "Rango de edades para mayores de edad:";
            // 
            // txtProbMayorEdad
            // 
            this.txtProbMayorEdad.Location = new System.Drawing.Point(241, 23);
            this.txtProbMayorEdad.Name = "txtProbMayorEdad";
            this.txtProbMayorEdad.Size = new System.Drawing.Size(51, 20);
            this.txtProbMayorEdad.TabIndex = 1;
            this.txtProbMayorEdad.Text = "0,35";
            // 
            // lblProbMayorEdad
            // 
            this.lblProbMayorEdad.AutoSize = true;
            this.lblProbMayorEdad.Location = new System.Drawing.Point(45, 26);
            this.lblProbMayorEdad.Name = "lblProbMayorEdad";
            this.lblProbMayorEdad.Size = new System.Drawing.Size(190, 13);
            this.lblProbMayorEdad.TabIndex = 0;
            this.lblProbMayorEdad.Text = "Probabilidad de cliente mayor de edad:";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.linea2});
            this.dgvClientes.Location = new System.Drawing.Point(12, 629);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(1880, 320);
            this.dgvClientes.TabIndex = 5;
            this.dgvClientes.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvClientes_Scroll);
            // 
            // linea2
            // 
            this.linea2.HeaderText = "Línea";
            this.linea2.Name = "linea2";
            this.linea2.ReadOnly = true;
            this.linea2.Width = 50;
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(917, 219);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(75, 49);
            this.btnSimular.TabIndex = 20;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // txtAlfa
            // 
            this.txtAlfa.Location = new System.Drawing.Point(1530, 23);
            this.txtAlfa.Name = "txtAlfa";
            this.txtAlfa.Size = new System.Drawing.Size(51, 20);
            this.txtAlfa.TabIndex = 23;
            this.txtAlfa.Text = "0,0219";
            // 
            // lblAlfa
            // 
            this.lblAlfa.AutoSize = true;
            this.lblAlfa.Location = new System.Drawing.Point(1496, 26);
            this.lblAlfa.Name = "lblAlfa";
            this.lblAlfa.Size = new System.Drawing.Size(28, 13);
            this.lblAlfa.TabIndex = 22;
            this.lblAlfa.Text = "Alfa:";
            // 
            // txtBeta
            // 
            this.txtBeta.Location = new System.Drawing.Point(1530, 49);
            this.txtBeta.Name = "txtBeta";
            this.txtBeta.Size = new System.Drawing.Size(51, 20);
            this.txtBeta.TabIndex = 25;
            this.txtBeta.Text = "0,102";
            // 
            // lblBeta
            // 
            this.lblBeta.AutoSize = true;
            this.lblBeta.Location = new System.Drawing.Point(1496, 52);
            this.lblBeta.Name = "lblBeta";
            this.lblBeta.Size = new System.Drawing.Size(32, 13);
            this.lblBeta.TabIndex = 24;
            this.lblBeta.Text = "Beta:";
            // 
            // linea1
            // 
            this.linea1.HeaderText = "Línea";
            this.linea1.Name = "linea1";
            this.linea1.ReadOnly = true;
            this.linea1.Width = 50;
            // 
            // evento
            // 
            this.evento.HeaderText = "Evento";
            this.evento.Name = "evento";
            this.evento.ReadOnly = true;
            this.evento.Width = 120;
            // 
            // reloj
            // 
            this.reloj.HeaderText = "Reloj (minutos)";
            this.reloj.Name = "reloj";
            this.reloj.ReadOnly = true;
            this.reloj.Width = 80;
            // 
            // rndLlegadaCliente
            // 
            this.rndLlegadaCliente.HeaderText = "RND Llegada Cliente";
            this.rndLlegadaCliente.Name = "rndLlegadaCliente";
            this.rndLlegadaCliente.ReadOnly = true;
            this.rndLlegadaCliente.Width = 50;
            // 
            // tiempoLlegadaCliente
            // 
            this.tiempoLlegadaCliente.HeaderText = "Tiempo Llegada Cliente";
            this.tiempoLlegadaCliente.Name = "tiempoLlegadaCliente";
            this.tiempoLlegadaCliente.ReadOnly = true;
            this.tiempoLlegadaCliente.Width = 50;
            // 
            // proximaLlegadaCliente
            // 
            this.proximaLlegadaCliente.HeaderText = "Próxima Llegada Cliente";
            this.proximaLlegadaCliente.Name = "proximaLlegadaCliente";
            this.proximaLlegadaCliente.ReadOnly = true;
            this.proximaLlegadaCliente.Width = 50;
            // 
            // rndMayorEdad
            // 
            this.rndMayorEdad.HeaderText = "RND es Mayor de Edad";
            this.rndMayorEdad.Name = "rndMayorEdad";
            this.rndMayorEdad.ReadOnly = true;
            this.rndMayorEdad.Width = 50;
            // 
            // esMayorEdad
            // 
            this.esMayorEdad.HeaderText = "Es Mayor de Edad";
            this.esMayorEdad.Name = "esMayorEdad";
            this.esMayorEdad.ReadOnly = true;
            this.esMayorEdad.Width = 50;
            // 
            // rndEdad
            // 
            this.rndEdad.HeaderText = "RND Edad";
            this.rndEdad.Name = "rndEdad";
            this.rndEdad.ReadOnly = true;
            this.rndEdad.Width = 50;
            // 
            // edad
            // 
            this.edad.HeaderText = "Edad";
            this.edad.Name = "edad";
            this.edad.ReadOnly = true;
            this.edad.Width = 50;
            // 
            // rndFinHacerEntender
            // 
            this.rndFinHacerEntender.HeaderText = "RND Fin Hacer Entender";
            this.rndFinHacerEntender.Name = "rndFinHacerEntender";
            this.rndFinHacerEntender.ReadOnly = true;
            this.rndFinHacerEntender.Width = 50;
            // 
            // tiempoFinHacerEntender
            // 
            this.tiempoFinHacerEntender.HeaderText = "Tiempo Fin Hacer Entender";
            this.tiempoFinHacerEntender.Name = "tiempoFinHacerEntender";
            this.tiempoFinHacerEntender.ReadOnly = true;
            this.tiempoFinHacerEntender.Width = 80;
            // 
            // proximoFinHacerEntender1
            // 
            this.proximoFinHacerEntender1.HeaderText = "Próximo fin hacer entender 1";
            this.proximoFinHacerEntender1.Name = "proximoFinHacerEntender1";
            this.proximoFinHacerEntender1.ReadOnly = true;
            this.proximoFinHacerEntender1.Width = 80;
            // 
            // proximoFinHacerEntender2
            // 
            this.proximoFinHacerEntender2.HeaderText = "Próximo fin hacer entender 2";
            this.proximoFinHacerEntender2.Name = "proximoFinHacerEntender2";
            this.proximoFinHacerEntender2.ReadOnly = true;
            this.proximoFinHacerEntender2.Width = 80;
            // 
            // proximoFinHacerEntender3
            // 
            this.proximoFinHacerEntender3.HeaderText = "Próximo fin hacer entender 3";
            this.proximoFinHacerEntender3.Name = "proximoFinHacerEntender3";
            this.proximoFinHacerEntender3.ReadOnly = true;
            this.proximoFinHacerEntender3.Width = 80;
            // 
            // tiempoProximaTarea
            // 
            this.tiempoProximaTarea.HeaderText = "Tiempo Próxima Tarea";
            this.tiempoProximaTarea.Name = "tiempoProximaTarea";
            this.tiempoProximaTarea.ReadOnly = true;
            this.tiempoProximaTarea.Width = 80;
            // 
            // proximaTarea
            // 
            this.proximaTarea.HeaderText = "Próxima tarea";
            this.proximaTarea.Name = "proximaTarea";
            this.proximaTarea.ReadOnly = true;
            this.proximaTarea.Width = 80;
            // 
            // rndDependienteTarea
            // 
            this.rndDependienteTarea.HeaderText = "RND dependiente tarea";
            this.rndDependienteTarea.Name = "rndDependienteTarea";
            this.rndDependienteTarea.ReadOnly = true;
            this.rndDependienteTarea.Width = 50;
            // 
            // dependienteTarea
            // 
            this.dependienteTarea.HeaderText = "Dependiente tarea";
            this.dependienteTarea.Name = "dependienteTarea";
            this.dependienteTarea.ReadOnly = true;
            this.dependienteTarea.Width = 50;
            // 
            // tareasHacerDependiente1
            // 
            this.tareasHacerDependiente1.HeaderText = "Tareas a hacer Dependiente 1";
            this.tareasHacerDependiente1.Name = "tareasHacerDependiente1";
            this.tareasHacerDependiente1.ReadOnly = true;
            this.tareasHacerDependiente1.Width = 50;
            // 
            // tareasHacerDependiente2
            // 
            this.tareasHacerDependiente2.HeaderText = "Tareas a hacer Dependiente 2";
            this.tareasHacerDependiente2.Name = "tareasHacerDependiente2";
            this.tareasHacerDependiente2.ReadOnly = true;
            this.tareasHacerDependiente2.Width = 50;
            // 
            // tareasHacerDependiente3
            // 
            this.tareasHacerDependiente3.HeaderText = "Tareas a hacer Dependiente 3";
            this.tareasHacerDependiente3.Name = "tareasHacerDependiente3";
            this.tareasHacerDependiente3.ReadOnly = true;
            this.tareasHacerDependiente3.Width = 50;
            // 
            // rndFinOtraTarea
            // 
            this.rndFinOtraTarea.HeaderText = "RND fin otra tarea";
            this.rndFinOtraTarea.Name = "rndFinOtraTarea";
            this.rndFinOtraTarea.ReadOnly = true;
            this.rndFinOtraTarea.Width = 50;
            // 
            // tiempoFinOtraTarea
            // 
            this.tiempoFinOtraTarea.HeaderText = "Tiempo fin otra tarea";
            this.tiempoFinOtraTarea.Name = "tiempoFinOtraTarea";
            this.tiempoFinOtraTarea.ReadOnly = true;
            this.tiempoFinOtraTarea.Width = 80;
            // 
            // proximoFinOtraTarea1
            // 
            this.proximoFinOtraTarea1.HeaderText = "Próximo fin otra tarea 1";
            this.proximoFinOtraTarea1.Name = "proximoFinOtraTarea1";
            this.proximoFinOtraTarea1.ReadOnly = true;
            this.proximoFinOtraTarea1.Width = 80;
            // 
            // proximoFinOtraTarea2
            // 
            this.proximoFinOtraTarea2.HeaderText = "Próximo fin otra tarea 2";
            this.proximoFinOtraTarea2.Name = "proximoFinOtraTarea2";
            this.proximoFinOtraTarea2.ReadOnly = true;
            this.proximoFinOtraTarea2.Width = 80;
            // 
            // proximoFinOtraTarea3
            // 
            this.proximoFinOtraTarea3.HeaderText = "Próximo fin otra tarea 3";
            this.proximoFinOtraTarea3.Name = "proximoFinOtraTarea3";
            this.proximoFinOtraTarea3.ReadOnly = true;
            this.proximoFinOtraTarea3.Width = 80;
            // 
            // estadoDependiente1
            // 
            this.estadoDependiente1.HeaderText = "Estado dependiente 1";
            this.estadoDependiente1.Name = "estadoDependiente1";
            this.estadoDependiente1.ReadOnly = true;
            this.estadoDependiente1.Width = 80;
            // 
            // horaComienzoOcupacion1
            // 
            this.horaComienzoOcupacion1.HeaderText = "Hora comienzo ocupación 1";
            this.horaComienzoOcupacion1.Name = "horaComienzoOcupacion1";
            this.horaComienzoOcupacion1.ReadOnly = true;
            this.horaComienzoOcupacion1.Width = 80;
            // 
            // estadoDependiente2
            // 
            this.estadoDependiente2.HeaderText = "Estado dependiente 2";
            this.estadoDependiente2.Name = "estadoDependiente2";
            this.estadoDependiente2.ReadOnly = true;
            this.estadoDependiente2.Width = 80;
            // 
            // horaComienzoOcupacion2
            // 
            this.horaComienzoOcupacion2.HeaderText = "Hora comienzo ocupación 2";
            this.horaComienzoOcupacion2.Name = "horaComienzoOcupacion2";
            this.horaComienzoOcupacion2.ReadOnly = true;
            this.horaComienzoOcupacion2.Width = 80;
            // 
            // estadoDependiente3
            // 
            this.estadoDependiente3.HeaderText = "Estado dependiente 3";
            this.estadoDependiente3.Name = "estadoDependiente3";
            this.estadoDependiente3.ReadOnly = true;
            this.estadoDependiente3.Width = 80;
            // 
            // horaComienzoOcupacion3
            // 
            this.horaComienzoOcupacion3.HeaderText = "Hora comienzo ocupación 3";
            this.horaComienzoOcupacion3.Name = "horaComienzoOcupacion3";
            this.horaComienzoOcupacion3.ReadOnly = true;
            this.horaComienzoOcupacion3.Width = 80;
            // 
            // colaAtencion
            // 
            this.colaAtencion.HeaderText = "Cola atención";
            this.colaAtencion.Name = "colaAtencion";
            this.colaAtencion.ReadOnly = true;
            this.colaAtencion.Width = 50;
            // 
            // gradoOcupacionDependiente1
            // 
            this.gradoOcupacionDependiente1.HeaderText = "Grado de ocupación dependiente 1";
            this.gradoOcupacionDependiente1.Name = "gradoOcupacionDependiente1";
            this.gradoOcupacionDependiente1.ReadOnly = true;
            this.gradoOcupacionDependiente1.Width = 80;
            // 
            // gradoOcupacionDependiente2
            // 
            this.gradoOcupacionDependiente2.HeaderText = "Grado de ocupación Dependiente 2";
            this.gradoOcupacionDependiente2.Name = "gradoOcupacionDependiente2";
            this.gradoOcupacionDependiente2.ReadOnly = true;
            this.gradoOcupacionDependiente2.Width = 80;
            // 
            // gradoOcupacionDependiente3
            // 
            this.gradoOcupacionDependiente3.HeaderText = "Grado de ocupación Dependiente 3";
            this.gradoOcupacionDependiente3.Name = "gradoOcupacionDependiente3";
            this.gradoOcupacionDependiente3.ReadOnly = true;
            this.gradoOcupacionDependiente3.Width = 80;
            // 
            // esperaPromedioCola
            // 
            this.esperaPromedioCola.HeaderText = "Espera promedio en cola";
            this.esperaPromedioCola.Name = "esperaPromedioCola";
            this.esperaPromedioCola.ReadOnly = true;
            this.esperaPromedioCola.Width = 80;
            // 
            // cantidadPersonasAtendidas
            // 
            this.cantidadPersonasAtendidas.HeaderText = "Cantidad de personas atendidas";
            this.cantidadPersonasAtendidas.Name = "cantidadPersonasAtendidas";
            this.cantidadPersonasAtendidas.ReadOnly = true;
            this.cantidadPersonasAtendidas.Width = 60;
            // 
            // porcentajeClientesAtendidosMayoresEdad
            // 
            this.porcentajeClientesAtendidosMayoresEdad.HeaderText = "Porcentaje clientes atendidos mayores de edad";
            this.porcentajeClientesAtendidosMayoresEdad.Name = "porcentajeClientesAtendidosMayoresEdad";
            this.porcentajeClientesAtendidosMayoresEdad.ReadOnly = true;
            this.porcentajeClientesAtendidosMayoresEdad.Width = 80;
            // 
            // porcentajeOcupacionIrrelevante1
            // 
            this.porcentajeOcupacionIrrelevante1.HeaderText = "Porcentaje Ocupación Irrelevante 1";
            this.porcentajeOcupacionIrrelevante1.Name = "porcentajeOcupacionIrrelevante1";
            this.porcentajeOcupacionIrrelevante1.ReadOnly = true;
            this.porcentajeOcupacionIrrelevante1.Width = 80;
            // 
            // porcentajeOcupacionIrrelevante2
            // 
            this.porcentajeOcupacionIrrelevante2.HeaderText = "Porcentaje Ocupación Irrelevante 2";
            this.porcentajeOcupacionIrrelevante2.Name = "porcentajeOcupacionIrrelevante2";
            this.porcentajeOcupacionIrrelevante2.ReadOnly = true;
            this.porcentajeOcupacionIrrelevante2.Width = 80;
            // 
            // porcentajeOcupacionIrrelevante3
            // 
            this.porcentajeOcupacionIrrelevante3.HeaderText = "Porcentaje Ocupación Irrelevante 3";
            this.porcentajeOcupacionIrrelevante3.Name = "porcentajeOcupacionIrrelevante3";
            this.porcentajeOcupacionIrrelevante3.ReadOnly = true;
            this.porcentajeOcupacionIrrelevante3.Width = 80;
            // 
            // tiempoMaximoPermanenciaSistemaMayorEdad
            // 
            this.tiempoMaximoPermanenciaSistemaMayorEdad.HeaderText = "Tiempo máximo de permanencia en sistema de Mayor de edad";
            this.tiempoMaximoPermanenciaSistemaMayorEdad.Name = "tiempoMaximoPermanenciaSistemaMayorEdad";
            this.tiempoMaximoPermanenciaSistemaMayorEdad.ReadOnly = true;
            this.tiempoMaximoPermanenciaSistemaMayorEdad.Width = 80;
            // 
            // acTiempoOcupacion1
            // 
            this.acTiempoOcupacion1.HeaderText = "AC tiempo de ocupación 1";
            this.acTiempoOcupacion1.Name = "acTiempoOcupacion1";
            this.acTiempoOcupacion1.ReadOnly = true;
            // 
            // acTiempoOcupacion2
            // 
            this.acTiempoOcupacion2.HeaderText = "AC tiempo de ocupación 2";
            this.acTiempoOcupacion2.Name = "acTiempoOcupacion2";
            this.acTiempoOcupacion2.ReadOnly = true;
            // 
            // acTiempoOcupacion3
            // 
            this.acTiempoOcupacion3.HeaderText = "AC tiempo de ocupación 3";
            this.acTiempoOcupacion3.Name = "acTiempoOcupacion3";
            this.acTiempoOcupacion3.ReadOnly = true;
            // 
            // acTiempoEspera
            // 
            this.acTiempoEspera.HeaderText = "AC tiempo de espera en cola";
            this.acTiempoEspera.Name = "acTiempoEspera";
            this.acTiempoEspera.ReadOnly = true;
            // 
            // acClientesCola
            // 
            this.acClientesCola.HeaderText = "AC clientes en cola";
            this.acClientesCola.Name = "acClientesCola";
            this.acClientesCola.ReadOnly = true;
            this.acClientesCola.Width = 80;
            // 
            // acPersonasAtendidasMayoresEdad
            // 
            this.acPersonasAtendidasMayoresEdad.HeaderText = "AC personas atendidas mayores de edad";
            this.acPersonasAtendidasMayoresEdad.Name = "acPersonasAtendidasMayoresEdad";
            this.acPersonasAtendidasMayoresEdad.ReadOnly = true;
            this.acPersonasAtendidasMayoresEdad.Width = 80;
            // 
            // acTiempoOcupacionIrrelevante1
            // 
            this.acTiempoOcupacionIrrelevante1.HeaderText = "AC tiempo ocupación irrelevante 1";
            this.acTiempoOcupacionIrrelevante1.Name = "acTiempoOcupacionIrrelevante1";
            this.acTiempoOcupacionIrrelevante1.ReadOnly = true;
            // 
            // acTiempoOcupacionIrrelevante2
            // 
            this.acTiempoOcupacionIrrelevante2.HeaderText = "AC tiempo ocupación irrelevante 2";
            this.acTiempoOcupacionIrrelevante2.Name = "acTiempoOcupacionIrrelevante2";
            this.acTiempoOcupacionIrrelevante2.ReadOnly = true;
            // 
            // acTiempoOcupacionIrrelevante3
            // 
            this.acTiempoOcupacionIrrelevante3.HeaderText = "AC tiempo de ocupación irrelevante 3";
            this.acTiempoOcupacionIrrelevante3.Name = "acTiempoOcupacionIrrelevante3";
            this.acTiempoOcupacionIrrelevante3.ReadOnly = true;
            // 
            // frmOficinaAnses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 961);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.gbxParametros);
            this.Controls.Add(this.gbxSimulacion);
            this.Controls.Add(this.dgvFuncion);
            this.Name = "frmOficinaAnses";
            this.Text = "Oficina ANSES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncion)).EndInit();
            this.gbxSimulacion.ResumeLayout(false);
            this.gbxSimulacion.PerformLayout();
            this.gbxParametros.ResumeLayout(false);
            this.gbxParametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFuncion;
        private System.Windows.Forms.Label lblLineas1;
        private System.Windows.Forms.TextBox txtLineas;
        private System.Windows.Forms.GroupBox gbxSimulacion;
        private System.Windows.Forms.TextBox txtMostrarDesde;
        private System.Windows.Forms.Label lblLineas2;
        private System.Windows.Forms.RadioButton rbtAlgunas;
        private System.Windows.Forms.RadioButton rbtTodas;
        private System.Windows.Forms.GroupBox gbxParametros;
        private System.Windows.Forms.TextBox txtProbMayorEdad;
        private System.Windows.Forms.Label lblProbMayorEdad;
        private System.Windows.Forms.TextBox txtTiempoOtraTarea;
        private System.Windows.Forms.Label lblTiempoOtraTarea;
        private System.Windows.Forms.TextBox txtZo;
        private System.Windows.Forms.Label lblZo;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtRangoEntenderHasta;
        private System.Windows.Forms.TextBox txtRangoEntenderDesde;
        private System.Windows.Forms.Label lblRangoEntender;
        private System.Windows.Forms.TextBox txtTasaLlegada;
        private System.Windows.Forms.Label lblTasaLlegada;
        private System.Windows.Forms.TextBox txtRangoEdadesHasta;
        private System.Windows.Forms.TextBox txtRangoEdadesDesde;
        private System.Windows.Forms.Label lblRangoEdades;
        private System.Windows.Forms.TextBox txtRangoTareaHasta;
        private System.Windows.Forms.TextBox txtRangoTareaDesde;
        private System.Windows.Forms.Label lblRangoTarea;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnRungeKutta;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.DataGridViewTextBoxColumn linea2;
        private System.Windows.Forms.TextBox txtBeta;
        private System.Windows.Forms.Label lblBeta;
        private System.Windows.Forms.TextBox txtAlfa;
        private System.Windows.Forms.Label lblAlfa;
        private System.Windows.Forms.DataGridViewTextBoxColumn linea1;
        private System.Windows.Forms.DataGridViewTextBoxColumn evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn reloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndLlegadaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoLlegadaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximaLlegadaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndMayorEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn esMayorEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndFinHacerEntender;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoFinHacerEntender;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximoFinHacerEntender1;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximoFinHacerEntender2;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximoFinHacerEntender3;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoProximaTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximaTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndDependienteTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn dependienteTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn tareasHacerDependiente1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tareasHacerDependiente2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tareasHacerDependiente3;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndFinOtraTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoFinOtraTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximoFinOtraTarea1;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximoFinOtraTarea2;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximoFinOtraTarea3;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDependiente1;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaComienzoOcupacion1;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDependiente2;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaComienzoOcupacion2;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDependiente3;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaComienzoOcupacion3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colaAtencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradoOcupacionDependiente1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradoOcupacionDependiente2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradoOcupacionDependiente3;
        private System.Windows.Forms.DataGridViewTextBoxColumn esperaPromedioCola;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadPersonasAtendidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentajeClientesAtendidosMayoresEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentajeOcupacionIrrelevante1;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentajeOcupacionIrrelevante2;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentajeOcupacionIrrelevante3;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoMaximoPermanenciaSistemaMayorEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn acTiempoOcupacion1;
        private System.Windows.Forms.DataGridViewTextBoxColumn acTiempoOcupacion2;
        private System.Windows.Forms.DataGridViewTextBoxColumn acTiempoOcupacion3;
        private System.Windows.Forms.DataGridViewTextBoxColumn acTiempoEspera;
        private System.Windows.Forms.DataGridViewTextBoxColumn acClientesCola;
        private System.Windows.Forms.DataGridViewTextBoxColumn acPersonasAtendidasMayoresEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn acTiempoOcupacionIrrelevante1;
        private System.Windows.Forms.DataGridViewTextBoxColumn acTiempoOcupacionIrrelevante2;
        private System.Windows.Forms.DataGridViewTextBoxColumn acTiempoOcupacionIrrelevante3;
    }
}

