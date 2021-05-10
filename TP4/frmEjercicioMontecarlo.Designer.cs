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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblCantidadMostrar = new System.Windows.Forms.Label();
            this.txtCantidadMostrar = new System.Windows.Forms.TextBox();
            this.lblMostrarDesde = new System.Windows.Forms.Label();
            this.txtMostrarDesde = new System.Windows.Forms.TextBox();
            this.rbtEstrategia1 = new System.Windows.Forms.RadioButton();
            this.rbtEstrategia2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndDemanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoPeriodicos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoFaltante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoMantenimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acumuladorCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSimular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reloj,
            this.rndDemanda,
            this.demanda,
            this.cantidadPedido,
            this.stock,
            this.costoPeriodicos,
            this.costoFaltante,
            this.costoMantenimiento,
            this.costoTotal,
            this.acumuladorCosto});
            this.dataGridView1.Location = new System.Drawing.Point(29, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1017, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(163, 25);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(100, 20);
            this.txtDias.TabIndex = 1;
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(27, 32);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(130, 13);
            this.lblDias.TabIndex = 2;
            this.lblDias.Text = "Número de días a simular:";
            // 
            // lblCantidadMostrar
            // 
            this.lblCantidadMostrar.AutoSize = true;
            this.lblCantidadMostrar.Location = new System.Drawing.Point(27, 89);
            this.lblCantidadMostrar.Name = "lblCantidadMostrar";
            this.lblCantidadMostrar.Size = new System.Drawing.Size(42, 13);
            this.lblCantidadMostrar.TabIndex = 4;
            this.lblCantidadMostrar.Text = "Mostrar";
            // 
            // txtCantidadMostrar
            // 
            this.txtCantidadMostrar.Location = new System.Drawing.Point(75, 86);
            this.txtCantidadMostrar.Name = "txtCantidadMostrar";
            this.txtCantidadMostrar.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadMostrar.TabIndex = 3;
            // 
            // lblMostrarDesde
            // 
            this.lblMostrarDesde.AutoSize = true;
            this.lblMostrarDesde.Location = new System.Drawing.Point(193, 88);
            this.lblMostrarDesde.Name = "lblMostrarDesde";
            this.lblMostrarDesde.Size = new System.Drawing.Size(99, 13);
            this.lblMostrarDesde.TabIndex = 5;
            this.lblMostrarDesde.Text = "días a partir del día";
            // 
            // txtMostrarDesde
            // 
            this.txtMostrarDesde.Location = new System.Drawing.Point(298, 86);
            this.txtMostrarDesde.Name = "txtMostrarDesde";
            this.txtMostrarDesde.Size = new System.Drawing.Size(100, 20);
            this.txtMostrarDesde.TabIndex = 6;
            // 
            // rbtEstrategia1
            // 
            this.rbtEstrategia1.AutoSize = true;
            this.rbtEstrategia1.Location = new System.Drawing.Point(86, 140);
            this.rbtEstrategia1.Name = "rbtEstrategia1";
            this.rbtEstrategia1.Size = new System.Drawing.Size(81, 17);
            this.rbtEstrategia1.TabIndex = 7;
            this.rbtEstrategia1.TabStop = true;
            this.rbtEstrategia1.Text = "Estrategia 1";
            this.rbtEstrategia1.UseVisualStyleBackColor = true;
            // 
            // rbtEstrategia2
            // 
            this.rbtEstrategia2.AutoSize = true;
            this.rbtEstrategia2.Location = new System.Drawing.Point(177, 140);
            this.rbtEstrategia2.Name = "rbtEstrategia2";
            this.rbtEstrategia2.Size = new System.Drawing.Size(81, 17);
            this.rbtEstrategia2.TabIndex = 8;
            this.rbtEstrategia2.TabStop = true;
            this.rbtEstrategia2.Text = "Estrategia 2";
            this.rbtEstrategia2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDias);
            this.panel1.Controls.Add(this.rbtEstrategia2);
            this.panel1.Controls.Add(this.txtDias);
            this.panel1.Controls.Add(this.rbtEstrategia1);
            this.panel1.Controls.Add(this.txtCantidadMostrar);
            this.panel1.Controls.Add(this.txtMostrarDesde);
            this.panel1.Controls.Add(this.lblCantidadMostrar);
            this.panel1.Controls.Add(this.lblMostrarDesde);
            this.panel1.Location = new System.Drawing.Point(29, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 176);
            this.panel1.TabIndex = 9;
            // 
            // reloj
            // 
            this.reloj.HeaderText = "Reloj (días)";
            this.reloj.Name = "reloj";
            // 
            // rndDemanda
            // 
            this.rndDemanda.HeaderText = "RND Demanda";
            this.rndDemanda.Name = "rndDemanda";
            // 
            // demanda
            // 
            this.demanda.HeaderText = "Demanda";
            this.demanda.Name = "demanda";
            // 
            // cantidadPedido
            // 
            this.cantidadPedido.HeaderText = "Cantidad de pedido";
            this.cantidadPedido.Name = "cantidadPedido";
            // 
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            // 
            // costoPeriodicos
            // 
            this.costoPeriodicos.HeaderText = "Costo por periódicos";
            this.costoPeriodicos.Name = "costoPeriodicos";
            // 
            // costoFaltante
            // 
            this.costoFaltante.HeaderText = "Costo por faltante";
            this.costoFaltante.Name = "costoFaltante";
            // 
            // costoMantenimiento
            // 
            this.costoMantenimiento.HeaderText = "Costo por mantenimiento ";
            this.costoMantenimiento.Name = "costoMantenimiento";
            // 
            // costoTotal
            // 
            this.costoTotal.HeaderText = "Costo total";
            this.costoTotal.Name = "costoTotal";
            // 
            // acumuladorCosto
            // 
            this.acumuladorCosto.HeaderText = "Acumulador de costos";
            this.acumuladorCosto.Name = "acumuladorCosto";
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(511, 213);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(75, 23);
            this.btnSimular.TabIndex = 10;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // frmEjercicioMontecarlo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 450);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmEjercicioMontecarlo";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblCantidadMostrar;
        private System.Windows.Forms.TextBox txtCantidadMostrar;
        private System.Windows.Forms.Label lblMostrarDesde;
        private System.Windows.Forms.TextBox txtMostrarDesde;
        private System.Windows.Forms.RadioButton rbtEstrategia1;
        private System.Windows.Forms.RadioButton rbtEstrategia2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn reloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndDemanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn demanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoPeriodicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoFaltante;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoMantenimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn acumuladorCosto;
        private System.Windows.Forms.Button btnSimular;
    }
}

