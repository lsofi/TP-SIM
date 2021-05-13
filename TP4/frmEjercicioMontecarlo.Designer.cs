namespace TP4
{
    partial class frmEjercicioMontecarlo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEjercicioMontecarlo));
            this.dgvPeriodicos = new System.Windows.Forms.DataGridView();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblCantidadMostrar = new System.Windows.Forms.Label();
            this.txtCantidadMostrar = new System.Windows.Forms.TextBox();
            this.lblMostrarDesde = new System.Windows.Forms.Label();
            this.txtMostrarDesde = new System.Windows.Forms.TextBox();
            this.rbtEstrategia1 = new System.Windows.Forms.RadioButton();
            this.rbtEstrategia2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSimular = new System.Windows.Forms.Button();
            this.reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndDemanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasRealizadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VentasPerdidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoPeriodicos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoFaltante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gananciaReembolso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acumuladorCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodicos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPeriodicos
            // 
            this.dgvPeriodicos.AllowUserToAddRows = false;
            this.dgvPeriodicos.AllowUserToDeleteRows = false;
            this.dgvPeriodicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeriodicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reloj,
            this.rndDemanda,
            this.demanda,
            this.cantidadPedido,
            this.stock,
            this.ventasRealizadas,
            this.VentasPerdidas,
            this.costoPeriodicos,
            this.costoFaltante,
            this.gananciaReembolso,
            this.costoTotal,
            this.acumuladorCosto});
            this.dgvPeriodicos.Location = new System.Drawing.Point(12, 273);
            this.dgvPeriodicos.Name = "dgvPeriodicos";
            this.dgvPeriodicos.ReadOnly = true;
            this.dgvPeriodicos.Size = new System.Drawing.Size(1069, 330);
            this.dgvPeriodicos.TabIndex = 0;
            // 
            // txtDias
            // 
            this.txtDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDias.Location = new System.Drawing.Point(281, 74);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(100, 26);
            this.txtDias.TabIndex = 1;
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDias.Location = new System.Drawing.Point(68, 74);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(191, 20);
            this.lblDias.TabIndex = 2;
            this.lblDias.Text = "Número de días a simular:";
            // 
            // lblCantidadMostrar
            // 
            this.lblCantidadMostrar.AutoSize = true;
            this.lblCantidadMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadMostrar.Location = new System.Drawing.Point(26, 131);
            this.lblCantidadMostrar.Name = "lblCantidadMostrar";
            this.lblCantidadMostrar.Size = new System.Drawing.Size(63, 20);
            this.lblCantidadMostrar.TabIndex = 4;
            this.lblCantidadMostrar.Text = "Mostrar";
            // 
            // txtCantidadMostrar
            // 
            this.txtCantidadMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadMostrar.Location = new System.Drawing.Point(95, 131);
            this.txtCantidadMostrar.Name = "txtCantidadMostrar";
            this.txtCantidadMostrar.Size = new System.Drawing.Size(100, 26);
            this.txtCantidadMostrar.TabIndex = 3;
            // 
            // lblMostrarDesde
            // 
            this.lblMostrarDesde.AutoSize = true;
            this.lblMostrarDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarDesde.Location = new System.Drawing.Point(219, 131);
            this.lblMostrarDesde.Name = "lblMostrarDesde";
            this.lblMostrarDesde.Size = new System.Drawing.Size(141, 20);
            this.lblMostrarDesde.TabIndex = 5;
            this.lblMostrarDesde.Text = "días a partir del día";
            // 
            // txtMostrarDesde
            // 
            this.txtMostrarDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMostrarDesde.Location = new System.Drawing.Point(368, 131);
            this.txtMostrarDesde.Name = "txtMostrarDesde";
            this.txtMostrarDesde.Size = new System.Drawing.Size(100, 26);
            this.txtMostrarDesde.TabIndex = 6;
            // 
            // rbtEstrategia1
            // 
            this.rbtEstrategia1.AutoSize = true;
            this.rbtEstrategia1.Checked = true;
            this.rbtEstrategia1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtEstrategia1.Location = new System.Drawing.Point(73, 22);
            this.rbtEstrategia1.Name = "rbtEstrategia1";
            this.rbtEstrategia1.Size = new System.Drawing.Size(113, 24);
            this.rbtEstrategia1.TabIndex = 7;
            this.rbtEstrategia1.TabStop = true;
            this.rbtEstrategia1.Text = "Estrategia 1";
            this.rbtEstrategia1.UseVisualStyleBackColor = true;
            this.rbtEstrategia1.CheckedChanged += new System.EventHandler(this.rbtEstrategia1_CheckedChanged);
            // 
            // rbtEstrategia2
            // 
            this.rbtEstrategia2.AutoSize = true;
            this.rbtEstrategia2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtEstrategia2.Location = new System.Drawing.Point(309, 22);
            this.rbtEstrategia2.Name = "rbtEstrategia2";
            this.rbtEstrategia2.Size = new System.Drawing.Size(113, 24);
            this.rbtEstrategia2.TabIndex = 8;
            this.rbtEstrategia2.Text = "Estrategia 2";
            this.rbtEstrategia2.UseVisualStyleBackColor = true;
            this.rbtEstrategia2.CheckedChanged += new System.EventHandler(this.rbtEstrategia2_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSimular);
            this.panel1.Controls.Add(this.lblDias);
            this.panel1.Controls.Add(this.rbtEstrategia2);
            this.panel1.Controls.Add(this.txtDias);
            this.panel1.Controls.Add(this.rbtEstrategia1);
            this.panel1.Controls.Add(this.txtCantidadMostrar);
            this.panel1.Controls.Add(this.txtMostrarDesde);
            this.panel1.Controls.Add(this.lblCantidadMostrar);
            this.panel1.Controls.Add(this.lblMostrarDesde);
            this.panel1.Location = new System.Drawing.Point(299, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 234);
            this.panel1.TabIndex = 9;
            // 
            // btnSimular
            // 
            this.btnSimular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimular.Location = new System.Drawing.Point(202, 186);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(91, 32);
            this.btnSimular.TabIndex = 10;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // reloj
            // 
            this.reloj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.reloj.HeaderText = "Reloj (días)";
            this.reloj.Name = "reloj";
            this.reloj.ReadOnly = true;
            // 
            // rndDemanda
            // 
            this.rndDemanda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rndDemanda.HeaderText = "RND Demanda";
            this.rndDemanda.Name = "rndDemanda";
            this.rndDemanda.ReadOnly = true;
            // 
            // demanda
            // 
            this.demanda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.demanda.HeaderText = "Demanda";
            this.demanda.Name = "demanda";
            this.demanda.ReadOnly = true;
            // 
            // cantidadPedido
            // 
            this.cantidadPedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cantidadPedido.HeaderText = "Cantidad de pedido";
            this.cantidadPedido.Name = "cantidadPedido";
            this.cantidadPedido.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // ventasRealizadas
            // 
            this.ventasRealizadas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ventasRealizadas.HeaderText = "Ventas realizadas";
            this.ventasRealizadas.Name = "ventasRealizadas";
            this.ventasRealizadas.ReadOnly = true;
            // 
            // VentasPerdidas
            // 
            this.VentasPerdidas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VentasPerdidas.HeaderText = "Ventas perdidas";
            this.VentasPerdidas.Name = "VentasPerdidas";
            this.VentasPerdidas.ReadOnly = true;
            // 
            // costoPeriodicos
            // 
            this.costoPeriodicos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.costoPeriodicos.HeaderText = "Costo por periódicos";
            this.costoPeriodicos.Name = "costoPeriodicos";
            this.costoPeriodicos.ReadOnly = true;
            // 
            // costoFaltante
            // 
            this.costoFaltante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.costoFaltante.HeaderText = "Costo por faltante";
            this.costoFaltante.Name = "costoFaltante";
            this.costoFaltante.ReadOnly = true;
            // 
            // gananciaReembolso
            // 
            this.gananciaReembolso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gananciaReembolso.HeaderText = "Ganancia por Reembolsos";
            this.gananciaReembolso.Name = "gananciaReembolso";
            this.gananciaReembolso.ReadOnly = true;
            // 
            // costoTotal
            // 
            this.costoTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.costoTotal.HeaderText = "Costo total";
            this.costoTotal.Name = "costoTotal";
            this.costoTotal.ReadOnly = true;
            // 
            // acumuladorCosto
            // 
            this.acumuladorCosto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.acumuladorCosto.HeaderText = "Acumulador de costos";
            this.acumuladorCosto.Name = "acumuladorCosto";
            this.acumuladorCosto.ReadOnly = true;
            // 
            // frmEjercicioMontecarlo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPeriodicos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEjercicioMontecarlo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Montecarlo - Diarios y revistas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodicos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPeriodicos;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblCantidadMostrar;
        private System.Windows.Forms.TextBox txtCantidadMostrar;
        private System.Windows.Forms.Label lblMostrarDesde;
        private System.Windows.Forms.TextBox txtMostrarDesde;
        private System.Windows.Forms.RadioButton rbtEstrategia1;
        private System.Windows.Forms.RadioButton rbtEstrategia2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.DataGridViewTextBoxColumn reloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndDemanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn demanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasRealizadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentasPerdidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoPeriodicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoFaltante;
        private System.Windows.Forms.DataGridViewTextBoxColumn gananciaReembolso;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn acumuladorCosto;
    }
}

