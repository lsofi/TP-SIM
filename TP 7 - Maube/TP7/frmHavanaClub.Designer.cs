namespace TP7
{
    partial class frmHavanaClub
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
            this.lblMinutosComienzo = new System.Windows.Forms.Label();
            this.txtMinutosComienzo = new System.Windows.Forms.TextBox();
            this.lblMinutosASimular = new System.Windows.Forms.Label();
            this.txtMinutosASimular = new System.Windows.Forms.TextBox();
            this.lblMostrarMinutos = new System.Windows.Forms.Label();
            this.txtMostrarMinutos = new System.Windows.Forms.TextBox();
            this.lblMinutoDesde = new System.Windows.Forms.Label();
            this.txtMostrarDesde = new System.Windows.Forms.TextBox();
            this.lblMediaClientes = new System.Windows.Forms.Label();
            this.txtMediaClientes = new System.Windows.Forms.TextBox();
            this.lblDemoraServir = new System.Windows.Forms.Label();
            this.txtDemoraServirDesde = new System.Windows.Forms.TextBox();
            this.lblDemoraServirY = new System.Windows.Forms.Label();
            this.txtDemoraServirHasta = new System.Windows.Forms.TextBox();
            this.lblDemoraServirMinutos = new System.Windows.Forms.Label();
            this.lblDemoraLavar = new System.Windows.Forms.Label();
            this.txtDemoraLavar = new System.Windows.Forms.TextBox();
            this.lblDemoraLavarMinutos = new System.Windows.Forms.Label();
            this.lblDemoraRecoger = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblDemora = new System.Windows.Forms.Label();
            this.lbl1a3 = new System.Windows.Forms.Label();
            this.lbl4a6 = new System.Windows.Forms.Label();
            this.lblMas6 = new System.Windows.Forms.Label();
            this.txt1a3 = new System.Windows.Forms.TextBox();
            this.txt4a6 = new System.Windows.Forms.TextBox();
            this.txtMasDe6 = new System.Windows.Forms.TextBox();
            this.lblMinutos1a3 = new System.Windows.Forms.Label();
            this.lbl4a6Minutos = new System.Windows.Forms.Label();
            this.lblMasDe6Minutos = new System.Windows.Forms.Label();
            this.lblCapacidadVaso = new System.Windows.Forms.Label();
            this.txtCapacidadVaso = new System.Windows.Forms.TextBox();
            this.lblMl = new System.Windows.Forms.Label();
            this.btnRungeKutta = new System.Windows.Forms.Button();
            this.btnSimular = new System.Windows.Forms.Button();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.h = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.Evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNDLlegadaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoLlegadaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProximaLlegadaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNDServir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoServir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProximoFinServir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoLavado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoRestanteLavado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProximoFinLavado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNDCantVasos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadVasos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoRecogerVasos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoRestanteRecoger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProximoFinRecoger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoConsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCantinero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColaClientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadVasosLimpios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadVasosSucios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadClientesSinConsumir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsperaMaximaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadClientesConsumieron = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACTiempoTrabajando = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACTiempoSirviendo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACTiempoLavando = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACTiempoRecogiendo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcentajeTiempoSirviendo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcentajeTiempoLavando = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcentajeTiempoRecogiendo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMinutosComienzo
            // 
            this.lblMinutosComienzo.AutoSize = true;
            this.lblMinutosComienzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutosComienzo.Location = new System.Drawing.Point(259, 18);
            this.lblMinutosComienzo.Name = "lblMinutosComienzo";
            this.lblMinutosComienzo.Size = new System.Drawing.Size(170, 18);
            this.lblMinutosComienzo.TabIndex = 0;
            this.lblMinutosComienzo.Text = "Minutos desde que abrió";
            // 
            // txtMinutosComienzo
            // 
            this.txtMinutosComienzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinutosComienzo.Location = new System.Drawing.Point(428, 15);
            this.txtMinutosComienzo.Name = "txtMinutosComienzo";
            this.txtMinutosComienzo.Size = new System.Drawing.Size(35, 24);
            this.txtMinutosComienzo.TabIndex = 1;
            this.txtMinutosComienzo.Text = "300";
            // 
            // lblMinutosASimular
            // 
            this.lblMinutosASimular.AutoSize = true;
            this.lblMinutosASimular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutosASimular.Location = new System.Drawing.Point(485, 18);
            this.lblMinutosASimular.Name = "lblMinutosASimular";
            this.lblMinutosASimular.Size = new System.Drawing.Size(125, 18);
            this.lblMinutosASimular.TabIndex = 2;
            this.lblMinutosASimular.Text = "Minutos a simular";
            // 
            // txtMinutosASimular
            // 
            this.txtMinutosASimular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinutosASimular.Location = new System.Drawing.Point(616, 15);
            this.txtMinutosASimular.Name = "txtMinutosASimular";
            this.txtMinutosASimular.Size = new System.Drawing.Size(50, 24);
            this.txtMinutosASimular.TabIndex = 3;
            // 
            // lblMostrarMinutos
            // 
            this.lblMostrarMinutos.AutoSize = true;
            this.lblMostrarMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarMinutos.Location = new System.Drawing.Point(712, 18);
            this.lblMostrarMinutos.Name = "lblMostrarMinutos";
            this.lblMostrarMinutos.Size = new System.Drawing.Size(64, 18);
            this.lblMostrarMinutos.TabIndex = 4;
            this.lblMostrarMinutos.Text = "Mostrar ";
            // 
            // txtMostrarMinutos
            // 
            this.txtMostrarMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMostrarMinutos.Location = new System.Drawing.Point(771, 15);
            this.txtMostrarMinutos.Name = "txtMostrarMinutos";
            this.txtMostrarMinutos.Size = new System.Drawing.Size(53, 24);
            this.txtMostrarMinutos.TabIndex = 5;
            // 
            // lblMinutoDesde
            // 
            this.lblMinutoDesde.AutoSize = true;
            this.lblMinutoDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutoDesde.Location = new System.Drawing.Point(830, 18);
            this.lblMinutoDesde.Name = "lblMinutoDesde";
            this.lblMinutoDesde.Size = new System.Drawing.Size(169, 18);
            this.lblMinutoDesde.TabIndex = 6;
            this.lblMinutoDesde.Text = "minutos desde el minuto";
            // 
            // txtMostrarDesde
            // 
            this.txtMostrarDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMostrarDesde.Location = new System.Drawing.Point(1005, 15);
            this.txtMostrarDesde.Name = "txtMostrarDesde";
            this.txtMostrarDesde.Size = new System.Drawing.Size(56, 24);
            this.txtMostrarDesde.TabIndex = 7;
            // 
            // lblMediaClientes
            // 
            this.lblMediaClientes.AutoSize = true;
            this.lblMediaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaClientes.Location = new System.Drawing.Point(170, 70);
            this.lblMediaClientes.Name = "lblMediaClientes";
            this.lblMediaClientes.Size = new System.Drawing.Size(250, 18);
            this.lblMediaClientes.TabIndex = 8;
            this.lblMediaClientes.Text = "Demora media de llegada de clientes";
            // 
            // txtMediaClientes
            // 
            this.txtMediaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediaClientes.Location = new System.Drawing.Point(435, 67);
            this.txtMediaClientes.Name = "txtMediaClientes";
            this.txtMediaClientes.Size = new System.Drawing.Size(47, 24);
            this.txtMediaClientes.TabIndex = 9;
            this.txtMediaClientes.Text = "0,58";
            // 
            // lblDemoraServir
            // 
            this.lblDemoraServir.AutoSize = true;
            this.lblDemoraServir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemoraServir.Location = new System.Drawing.Point(171, 135);
            this.lblDemoraServir.Name = "lblDemoraServir";
            this.lblDemoraServir.Size = new System.Drawing.Size(256, 18);
            this.lblDemoraServir.TabIndex = 10;
            this.lblDemoraServir.Text = "La demora de servir un vaso es entre ";
            // 
            // txtDemoraServirDesde
            // 
            this.txtDemoraServirDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDemoraServirDesde.Location = new System.Drawing.Point(427, 132);
            this.txtDemoraServirDesde.Name = "txtDemoraServirDesde";
            this.txtDemoraServirDesde.Size = new System.Drawing.Size(41, 24);
            this.txtDemoraServirDesde.TabIndex = 11;
            this.txtDemoraServirDesde.Text = "1";
            // 
            // lblDemoraServirY
            // 
            this.lblDemoraServirY.AutoSize = true;
            this.lblDemoraServirY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemoraServirY.Location = new System.Drawing.Point(483, 135);
            this.lblDemoraServirY.Name = "lblDemoraServirY";
            this.lblDemoraServirY.Size = new System.Drawing.Size(15, 18);
            this.lblDemoraServirY.TabIndex = 12;
            this.lblDemoraServirY.Text = "y";
            // 
            // txtDemoraServirHasta
            // 
            this.txtDemoraServirHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDemoraServirHasta.Location = new System.Drawing.Point(507, 132);
            this.txtDemoraServirHasta.Name = "txtDemoraServirHasta";
            this.txtDemoraServirHasta.Size = new System.Drawing.Size(42, 24);
            this.txtDemoraServirHasta.TabIndex = 13;
            this.txtDemoraServirHasta.Text = "2";
            // 
            // lblDemoraServirMinutos
            // 
            this.lblDemoraServirMinutos.AutoSize = true;
            this.lblDemoraServirMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemoraServirMinutos.Location = new System.Drawing.Point(555, 135);
            this.lblDemoraServirMinutos.Name = "lblDemoraServirMinutos";
            this.lblDemoraServirMinutos.Size = new System.Drawing.Size(61, 18);
            this.lblDemoraServirMinutos.TabIndex = 14;
            this.lblDemoraServirMinutos.Text = "minutos";
            // 
            // lblDemoraLavar
            // 
            this.lblDemoraLavar.AutoSize = true;
            this.lblDemoraLavar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemoraLavar.Location = new System.Drawing.Point(170, 100);
            this.lblDemoraLavar.Name = "lblDemoraLavar";
            this.lblDemoraLavar.Size = new System.Drawing.Size(230, 18);
            this.lblDemoraLavar.TabIndex = 15;
            this.lblDemoraLavar.Text = "La demora de lavar un vaso es de";
            // 
            // txtDemoraLavar
            // 
            this.txtDemoraLavar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDemoraLavar.Location = new System.Drawing.Point(406, 97);
            this.txtDemoraLavar.Name = "txtDemoraLavar";
            this.txtDemoraLavar.Size = new System.Drawing.Size(38, 24);
            this.txtDemoraLavar.TabIndex = 16;
            this.txtDemoraLavar.Text = "0,33";
            // 
            // lblDemoraLavarMinutos
            // 
            this.lblDemoraLavarMinutos.AutoSize = true;
            this.lblDemoraLavarMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemoraLavarMinutos.Location = new System.Drawing.Point(459, 100);
            this.lblDemoraLavarMinutos.Name = "lblDemoraLavarMinutos";
            this.lblDemoraLavarMinutos.Size = new System.Drawing.Size(61, 18);
            this.lblDemoraLavarMinutos.TabIndex = 17;
            this.lblDemoraLavarMinutos.Text = "minutos";
            // 
            // lblDemoraRecoger
            // 
            this.lblDemoraRecoger.AutoSize = true;
            this.lblDemoraRecoger.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemoraRecoger.Location = new System.Drawing.Point(901, 67);
            this.lblDemoraRecoger.Name = "lblDemoraRecoger";
            this.lblDemoraRecoger.Size = new System.Drawing.Size(181, 18);
            this.lblDemoraRecoger.TabIndex = 18;
            this.lblDemoraRecoger.Text = "Demora en recoger vasos";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(901, 86);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(66, 18);
            this.lblCantidad.TabIndex = 19;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblDemora
            // 
            this.lblDemora.AutoSize = true;
            this.lblDemora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemora.Location = new System.Drawing.Point(1020, 86);
            this.lblDemora.Name = "lblDemora";
            this.lblDemora.Size = new System.Drawing.Size(62, 18);
            this.lblDemora.TabIndex = 20;
            this.lblDemora.Text = "Demora";
            // 
            // lbl1a3
            // 
            this.lbl1a3.AutoSize = true;
            this.lbl1a3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1a3.Location = new System.Drawing.Point(911, 111);
            this.lbl1a3.Name = "lbl1a3";
            this.lbl1a3.Size = new System.Drawing.Size(40, 18);
            this.lbl1a3.TabIndex = 21;
            this.lbl1a3.Text = "1 a 3";
            // 
            // lbl4a6
            // 
            this.lbl4a6.AutoSize = true;
            this.lbl4a6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4a6.Location = new System.Drawing.Point(911, 138);
            this.lbl4a6.Name = "lbl4a6";
            this.lbl4a6.Size = new System.Drawing.Size(40, 18);
            this.lbl4a6.TabIndex = 22;
            this.lbl4a6.Text = "4 a 6";
            // 
            // lblMas6
            // 
            this.lblMas6.AutoSize = true;
            this.lblMas6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMas6.Location = new System.Drawing.Point(898, 165);
            this.lblMas6.Name = "lblMas6";
            this.lblMas6.Size = new System.Drawing.Size(69, 18);
            this.lblMas6.TabIndex = 23;
            this.lblMas6.Text = "Mas de 6";
            // 
            // txt1a3
            // 
            this.txt1a3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1a3.Location = new System.Drawing.Point(972, 108);
            this.txt1a3.Name = "txt1a3";
            this.txt1a3.Size = new System.Drawing.Size(41, 24);
            this.txt1a3.TabIndex = 24;
            this.txt1a3.Text = "0,66";
            // 
            // txt4a6
            // 
            this.txt4a6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt4a6.Location = new System.Drawing.Point(972, 135);
            this.txt4a6.Name = "txt4a6";
            this.txt4a6.Size = new System.Drawing.Size(41, 24);
            this.txt4a6.TabIndex = 25;
            this.txt4a6.Text = "1,33";
            // 
            // txtMasDe6
            // 
            this.txtMasDe6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMasDe6.Location = new System.Drawing.Point(972, 162);
            this.txtMasDe6.Name = "txtMasDe6";
            this.txtMasDe6.Size = new System.Drawing.Size(41, 24);
            this.txtMasDe6.TabIndex = 26;
            this.txtMasDe6.Text = "1,83";
            // 
            // lblMinutos1a3
            // 
            this.lblMinutos1a3.AutoSize = true;
            this.lblMinutos1a3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutos1a3.Location = new System.Drawing.Point(1019, 111);
            this.lblMinutos1a3.Name = "lblMinutos1a3";
            this.lblMinutos1a3.Size = new System.Drawing.Size(61, 18);
            this.lblMinutos1a3.TabIndex = 27;
            this.lblMinutos1a3.Text = "minutos";
            // 
            // lbl4a6Minutos
            // 
            this.lbl4a6Minutos.AutoSize = true;
            this.lbl4a6Minutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4a6Minutos.Location = new System.Drawing.Point(1019, 138);
            this.lbl4a6Minutos.Name = "lbl4a6Minutos";
            this.lbl4a6Minutos.Size = new System.Drawing.Size(61, 18);
            this.lbl4a6Minutos.TabIndex = 28;
            this.lbl4a6Minutos.Text = "minutos";
            // 
            // lblMasDe6Minutos
            // 
            this.lblMasDe6Minutos.AutoSize = true;
            this.lblMasDe6Minutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasDe6Minutos.Location = new System.Drawing.Point(1019, 165);
            this.lblMasDe6Minutos.Name = "lblMasDe6Minutos";
            this.lblMasDe6Minutos.Size = new System.Drawing.Size(61, 18);
            this.lblMasDe6Minutos.TabIndex = 29;
            this.lblMasDe6Minutos.Text = "minutos";
            // 
            // lblCapacidadVaso
            // 
            this.lblCapacidadVaso.AutoSize = true;
            this.lblCapacidadVaso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidadVaso.Location = new System.Drawing.Point(171, 165);
            this.lblCapacidadVaso.Name = "lblCapacidadVaso";
            this.lblCapacidadVaso.Size = new System.Drawing.Size(177, 18);
            this.lblCapacidadVaso.TabIndex = 30;
            this.lblCapacidadVaso.Text = "Capacidad inicial del vaso";
            // 
            // txtCapacidadVaso
            // 
            this.txtCapacidadVaso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacidadVaso.Location = new System.Drawing.Point(354, 161);
            this.txtCapacidadVaso.Name = "txtCapacidadVaso";
            this.txtCapacidadVaso.Size = new System.Drawing.Size(49, 24);
            this.txtCapacidadVaso.TabIndex = 31;
            this.txtCapacidadVaso.Text = "500";
            // 
            // lblMl
            // 
            this.lblMl.AutoSize = true;
            this.lblMl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMl.Location = new System.Drawing.Point(409, 165);
            this.lblMl.Name = "lblMl";
            this.lblMl.Size = new System.Drawing.Size(24, 18);
            this.lblMl.TabIndex = 32;
            this.lblMl.Text = "ml";
            // 
            // btnRungeKutta
            // 
            this.btnRungeKutta.Enabled = false;
            this.btnRungeKutta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRungeKutta.Location = new System.Drawing.Point(1255, 70);
            this.btnRungeKutta.Name = "btnRungeKutta";
            this.btnRungeKutta.Size = new System.Drawing.Size(92, 64);
            this.btnRungeKutta.TabIndex = 33;
            this.btnRungeKutta.Text = "Ver Runge Kutta Consumo";
            this.btnRungeKutta.UseVisualStyleBackColor = true;
            this.btnRungeKutta.Click += new System.EventHandler(this.btnRungeKutta_Click);
            // 
            // btnSimular
            // 
            this.btnSimular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimular.Location = new System.Drawing.Point(634, 196);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(90, 29);
            this.btnSimular.TabIndex = 34;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowUserToAddRows = false;
            this.dgvTabla.AllowUserToDeleteRows = false;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Evento,
            this.reloj,
            this.RNDLlegadaCliente,
            this.TiempoLlegadaCliente,
            this.ProximaLlegadaCliente,
            this.RNDServir,
            this.TiempoServir,
            this.ProximoFinServir,
            this.TiempoLavado,
            this.tiempoRestanteLavado,
            this.ProximoFinLavado,
            this.RNDCantVasos,
            this.CantidadVasos,
            this.TiempoRecogerVasos,
            this.tiempoRestanteRecoger,
            this.ProximoFinRecoger,
            this.TiempoConsumo,
            this.EstadoCantinero,
            this.ColaClientes,
            this.CantidadVasosLimpios,
            this.CantidadVasosSucios,
            this.CantidadClientesSinConsumir,
            this.EsperaMaximaCliente,
            this.CantidadClientesConsumieron,
            this.ACTiempoTrabajando,
            this.ACTiempoSirviendo,
            this.ACTiempoLavando,
            this.ACTiempoRecogiendo,
            this.PorcentajeTiempoSirviendo,
            this.PorcentajeTiempoLavando,
            this.PorcentajeTiempoRecogiendo});
            this.dgvTabla.Location = new System.Drawing.Point(12, 246);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.Size = new System.Drawing.Size(1335, 449);
            this.dgvTabla.TabIndex = 35;
            // 
            // h
            // 
            this.h.AutoSize = true;
            this.h.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h.Location = new System.Drawing.Point(1266, 153);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(16, 18);
            this.h.TabIndex = 36;
            this.h.Text = "h";
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(1288, 154);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(48, 20);
            this.txtH.TabIndex = 37;
            this.txtH.Text = "1";
            // 
            // Evento
            // 
            this.Evento.HeaderText = "Evento";
            this.Evento.Name = "Evento";
            this.Evento.ReadOnly = true;
            // 
            // reloj
            // 
            this.reloj.HeaderText = "Reloj (min)";
            this.reloj.Name = "reloj";
            this.reloj.ReadOnly = true;
            this.reloj.Width = 50;
            // 
            // RNDLlegadaCliente
            // 
            this.RNDLlegadaCliente.HeaderText = "RND Llegada Cliente";
            this.RNDLlegadaCliente.Name = "RNDLlegadaCliente";
            this.RNDLlegadaCliente.ReadOnly = true;
            this.RNDLlegadaCliente.Width = 50;
            // 
            // TiempoLlegadaCliente
            // 
            this.TiempoLlegadaCliente.HeaderText = "Tiempo Llegada Cliente";
            this.TiempoLlegadaCliente.Name = "TiempoLlegadaCliente";
            this.TiempoLlegadaCliente.ReadOnly = true;
            this.TiempoLlegadaCliente.Width = 50;
            // 
            // ProximaLlegadaCliente
            // 
            this.ProximaLlegadaCliente.HeaderText = "Proxima Llegada Cliente";
            this.ProximaLlegadaCliente.Name = "ProximaLlegadaCliente";
            this.ProximaLlegadaCliente.ReadOnly = true;
            this.ProximaLlegadaCliente.Width = 50;
            // 
            // RNDServir
            // 
            this.RNDServir.HeaderText = "RND Servir";
            this.RNDServir.Name = "RNDServir";
            this.RNDServir.ReadOnly = true;
            this.RNDServir.Width = 40;
            // 
            // TiempoServir
            // 
            this.TiempoServir.HeaderText = "Tiempo Servir";
            this.TiempoServir.Name = "TiempoServir";
            this.TiempoServir.ReadOnly = true;
            this.TiempoServir.Width = 45;
            // 
            // ProximoFinServir
            // 
            this.ProximoFinServir.HeaderText = "Proximo Fin Servir";
            this.ProximoFinServir.Name = "ProximoFinServir";
            this.ProximoFinServir.ReadOnly = true;
            this.ProximoFinServir.Width = 45;
            // 
            // TiempoLavado
            // 
            this.TiempoLavado.HeaderText = "Tiempo Lavado";
            this.TiempoLavado.Name = "TiempoLavado";
            this.TiempoLavado.ReadOnly = true;
            this.TiempoLavado.Width = 45;
            // 
            // tiempoRestanteLavado
            // 
            this.tiempoRestanteLavado.HeaderText = "Tiempo Restante Lavado";
            this.tiempoRestanteLavado.Name = "tiempoRestanteLavado";
            this.tiempoRestanteLavado.ReadOnly = true;
            this.tiempoRestanteLavado.Width = 65;
            // 
            // ProximoFinLavado
            // 
            this.ProximoFinLavado.HeaderText = "Proximo Fin Lavado";
            this.ProximoFinLavado.Name = "ProximoFinLavado";
            this.ProximoFinLavado.ReadOnly = true;
            this.ProximoFinLavado.Width = 45;
            // 
            // RNDCantVasos
            // 
            this.RNDCantVasos.HeaderText = "RND Cant Vasos";
            this.RNDCantVasos.Name = "RNDCantVasos";
            this.RNDCantVasos.ReadOnly = true;
            this.RNDCantVasos.Width = 40;
            // 
            // CantidadVasos
            // 
            this.CantidadVasos.HeaderText = "Cant Vasos";
            this.CantidadVasos.Name = "CantidadVasos";
            this.CantidadVasos.ReadOnly = true;
            this.CantidadVasos.Width = 40;
            // 
            // TiempoRecogerVasos
            // 
            this.TiempoRecogerVasos.HeaderText = "Tiempo Recoger";
            this.TiempoRecogerVasos.Name = "TiempoRecogerVasos";
            this.TiempoRecogerVasos.ReadOnly = true;
            this.TiempoRecogerVasos.Width = 50;
            // 
            // tiempoRestanteRecoger
            // 
            this.tiempoRestanteRecoger.HeaderText = "Tiempo Restante Recoger";
            this.tiempoRestanteRecoger.Name = "tiempoRestanteRecoger";
            this.tiempoRestanteRecoger.ReadOnly = true;
            this.tiempoRestanteRecoger.Width = 65;
            // 
            // ProximoFinRecoger
            // 
            this.ProximoFinRecoger.HeaderText = "Proximo Fin Recoger";
            this.ProximoFinRecoger.Name = "ProximoFinRecoger";
            this.ProximoFinRecoger.ReadOnly = true;
            this.ProximoFinRecoger.Width = 50;
            // 
            // TiempoConsumo
            // 
            this.TiempoConsumo.HeaderText = "Tiempo Consumo";
            this.TiempoConsumo.Name = "TiempoConsumo";
            this.TiempoConsumo.ReadOnly = true;
            this.TiempoConsumo.Width = 55;
            // 
            // EstadoCantinero
            // 
            this.EstadoCantinero.HeaderText = "Estado Cantinero";
            this.EstadoCantinero.Name = "EstadoCantinero";
            this.EstadoCantinero.ReadOnly = true;
            this.EstadoCantinero.Width = 70;
            // 
            // ColaClientes
            // 
            this.ColaClientes.HeaderText = "Cola Clientes";
            this.ColaClientes.Name = "ColaClientes";
            this.ColaClientes.ReadOnly = true;
            this.ColaClientes.Width = 50;
            // 
            // CantidadVasosLimpios
            // 
            this.CantidadVasosLimpios.HeaderText = "Cant Vasos Limpios";
            this.CantidadVasosLimpios.Name = "CantidadVasosLimpios";
            this.CantidadVasosLimpios.ReadOnly = true;
            this.CantidadVasosLimpios.Width = 45;
            // 
            // CantidadVasosSucios
            // 
            this.CantidadVasosSucios.HeaderText = "Cant Vasos Sucios";
            this.CantidadVasosSucios.Name = "CantidadVasosSucios";
            this.CantidadVasosSucios.ReadOnly = true;
            this.CantidadVasosSucios.Width = 45;
            // 
            // CantidadClientesSinConsumir
            // 
            this.CantidadClientesSinConsumir.HeaderText = "Cant Clientes Se Van Sin Consumir";
            this.CantidadClientesSinConsumir.Name = "CantidadClientesSinConsumir";
            this.CantidadClientesSinConsumir.ReadOnly = true;
            this.CantidadClientesSinConsumir.Width = 55;
            // 
            // EsperaMaximaCliente
            // 
            this.EsperaMaximaCliente.HeaderText = "Espera Maxima Cliente";
            this.EsperaMaximaCliente.Name = "EsperaMaximaCliente";
            this.EsperaMaximaCliente.ReadOnly = true;
            this.EsperaMaximaCliente.Width = 45;
            // 
            // CantidadClientesConsumieron
            // 
            this.CantidadClientesConsumieron.HeaderText = "Cant Clientes Terminaron De Consumir";
            this.CantidadClientesConsumieron.Name = "CantidadClientesConsumieron";
            this.CantidadClientesConsumieron.ReadOnly = true;
            this.CantidadClientesConsumieron.Width = 70;
            // 
            // ACTiempoTrabajando
            // 
            this.ACTiempoTrabajando.HeaderText = "AC Tiempo Trabajando";
            this.ACTiempoTrabajando.Name = "ACTiempoTrabajando";
            this.ACTiempoTrabajando.ReadOnly = true;
            this.ACTiempoTrabajando.Width = 65;
            // 
            // ACTiempoSirviendo
            // 
            this.ACTiempoSirviendo.HeaderText = "AC Tiempo Sirviendo";
            this.ACTiempoSirviendo.Name = "ACTiempoSirviendo";
            this.ACTiempoSirviendo.ReadOnly = true;
            this.ACTiempoSirviendo.Width = 55;
            // 
            // ACTiempoLavando
            // 
            this.ACTiempoLavando.HeaderText = "AC Tiempo Lavando";
            this.ACTiempoLavando.Name = "ACTiempoLavando";
            this.ACTiempoLavando.ReadOnly = true;
            this.ACTiempoLavando.Width = 55;
            // 
            // ACTiempoRecogiendo
            // 
            this.ACTiempoRecogiendo.HeaderText = "AC Tiempo Recogiendo";
            this.ACTiempoRecogiendo.Name = "ACTiempoRecogiendo";
            this.ACTiempoRecogiendo.ReadOnly = true;
            this.ACTiempoRecogiendo.Width = 70;
            // 
            // PorcentajeTiempoSirviendo
            // 
            this.PorcentajeTiempoSirviendo.HeaderText = "Porcentaje Tiempo Sirviendo";
            this.PorcentajeTiempoSirviendo.Name = "PorcentajeTiempoSirviendo";
            this.PorcentajeTiempoSirviendo.ReadOnly = true;
            this.PorcentajeTiempoSirviendo.Width = 60;
            // 
            // PorcentajeTiempoLavando
            // 
            this.PorcentajeTiempoLavando.HeaderText = "Porcentaje Tiempo Lavando";
            this.PorcentajeTiempoLavando.Name = "PorcentajeTiempoLavando";
            this.PorcentajeTiempoLavando.ReadOnly = true;
            this.PorcentajeTiempoLavando.Width = 60;
            // 
            // PorcentajeTiempoRecogiendo
            // 
            this.PorcentajeTiempoRecogiendo.HeaderText = "Porcentaje Tiempo Recogiendo";
            this.PorcentajeTiempoRecogiendo.Name = "PorcentajeTiempoRecogiendo";
            this.PorcentajeTiempoRecogiendo.ReadOnly = true;
            this.PorcentajeTiempoRecogiendo.Width = 70;
            // 
            // frmHavanaClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 707);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.h);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.btnRungeKutta);
            this.Controls.Add(this.lblMl);
            this.Controls.Add(this.txtCapacidadVaso);
            this.Controls.Add(this.lblCapacidadVaso);
            this.Controls.Add(this.lblMasDe6Minutos);
            this.Controls.Add(this.lbl4a6Minutos);
            this.Controls.Add(this.lblMinutos1a3);
            this.Controls.Add(this.txtMasDe6);
            this.Controls.Add(this.txt4a6);
            this.Controls.Add(this.txt1a3);
            this.Controls.Add(this.lblMas6);
            this.Controls.Add(this.lbl4a6);
            this.Controls.Add(this.lbl1a3);
            this.Controls.Add(this.lblDemora);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblDemoraRecoger);
            this.Controls.Add(this.lblDemoraLavarMinutos);
            this.Controls.Add(this.txtDemoraLavar);
            this.Controls.Add(this.lblDemoraLavar);
            this.Controls.Add(this.lblDemoraServirMinutos);
            this.Controls.Add(this.txtDemoraServirHasta);
            this.Controls.Add(this.lblDemoraServirY);
            this.Controls.Add(this.txtDemoraServirDesde);
            this.Controls.Add(this.lblDemoraServir);
            this.Controls.Add(this.txtMediaClientes);
            this.Controls.Add(this.lblMediaClientes);
            this.Controls.Add(this.txtMostrarDesde);
            this.Controls.Add(this.lblMinutoDesde);
            this.Controls.Add(this.txtMostrarMinutos);
            this.Controls.Add(this.lblMostrarMinutos);
            this.Controls.Add(this.txtMinutosASimular);
            this.Controls.Add(this.lblMinutosASimular);
            this.Controls.Add(this.txtMinutosComienzo);
            this.Controls.Add(this.lblMinutosComienzo);
            this.Name = "frmHavanaClub";
            this.Text = "Havana Club";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMinutosComienzo;
        private System.Windows.Forms.TextBox txtMinutosComienzo;
        private System.Windows.Forms.Label lblMinutosASimular;
        private System.Windows.Forms.TextBox txtMinutosASimular;
        private System.Windows.Forms.Label lblMostrarMinutos;
        private System.Windows.Forms.TextBox txtMostrarMinutos;
        private System.Windows.Forms.Label lblMinutoDesde;
        private System.Windows.Forms.TextBox txtMostrarDesde;
        private System.Windows.Forms.Label lblMediaClientes;
        private System.Windows.Forms.TextBox txtMediaClientes;
        private System.Windows.Forms.Label lblDemoraServir;
        private System.Windows.Forms.TextBox txtDemoraServirDesde;
        private System.Windows.Forms.Label lblDemoraServirY;
        private System.Windows.Forms.TextBox txtDemoraServirHasta;
        private System.Windows.Forms.Label lblDemoraServirMinutos;
        private System.Windows.Forms.Label lblDemoraLavar;
        private System.Windows.Forms.TextBox txtDemoraLavar;
        private System.Windows.Forms.Label lblDemoraLavarMinutos;
        private System.Windows.Forms.Label lblDemoraRecoger;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblDemora;
        private System.Windows.Forms.Label lbl1a3;
        private System.Windows.Forms.Label lbl4a6;
        private System.Windows.Forms.Label lblMas6;
        private System.Windows.Forms.TextBox txt1a3;
        private System.Windows.Forms.TextBox txt4a6;
        private System.Windows.Forms.TextBox txtMasDe6;
        private System.Windows.Forms.Label lblMinutos1a3;
        private System.Windows.Forms.Label lbl4a6Minutos;
        private System.Windows.Forms.Label lblMasDe6Minutos;
        private System.Windows.Forms.Label lblCapacidadVaso;
        private System.Windows.Forms.TextBox txtCapacidadVaso;
        private System.Windows.Forms.Label lblMl;
        private System.Windows.Forms.Button btnRungeKutta;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.Label h;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn reloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn RNDLlegadaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoLlegadaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProximaLlegadaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn RNDServir;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoServir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProximoFinServir;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoLavado;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoRestanteLavado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProximoFinLavado;
        private System.Windows.Forms.DataGridViewTextBoxColumn RNDCantVasos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadVasos;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoRecogerVasos;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoRestanteRecoger;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProximoFinRecoger;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoConsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCantinero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColaClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadVasosLimpios;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadVasosSucios;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadClientesSinConsumir;
        private System.Windows.Forms.DataGridViewTextBoxColumn EsperaMaximaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadClientesConsumieron;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACTiempoTrabajando;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACTiempoSirviendo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACTiempoLavando;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACTiempoRecogiendo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcentajeTiempoSirviendo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcentajeTiempoLavando;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcentajeTiempoRecogiendo;
    }
}

