namespace GeneracionDeNumerosAleatorios
{
    partial class frmGraficoChiCuadrado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIntervalos = new System.Windows.Forms.Label();
            this.btn5 = new System.Windows.Forms.RadioButton();
            this.btn10 = new System.Windows.Forms.RadioButton();
            this.btn15 = new System.Windows.Forms.RadioButton();
            this.btn20 = new System.Windows.Forms.RadioButton();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaClase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecuenciaObservada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probabilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecuenciaEsperada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIntervalos
            // 
            this.txtIntervalos.AutoSize = true;
            this.txtIntervalos.Location = new System.Drawing.Point(13, 13);
            this.txtIntervalos.Name = "txtIntervalos";
            this.txtIntervalos.Size = new System.Drawing.Size(128, 15);
            this.txtIntervalos.TabIndex = 0;
            this.txtIntervalos.Text = "Cantidad de Intervalos:";
            // 
            // btn5
            // 
            this.btn5.AutoSize = true;
            this.btn5.Location = new System.Drawing.Point(174, 13);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(85, 19);
            this.btn5.TabIndex = 1;
            this.btn5.TabStop = true;
            this.btn5.Text = "5 Intervalos";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.CheckedChanged += new System.EventHandler(this.btn5_CheckedChanged);
            // 
            // btn10
            // 
            this.btn10.AutoSize = true;
            this.btn10.Location = new System.Drawing.Point(295, 13);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(91, 19);
            this.btn10.TabIndex = 2;
            this.btn10.TabStop = true;
            this.btn10.Text = "10 Intervalos";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.CheckedChanged += new System.EventHandler(this.btn10_CheckedChanged);
            // 
            // btn15
            // 
            this.btn15.AutoSize = true;
            this.btn15.Location = new System.Drawing.Point(423, 13);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(91, 19);
            this.btn15.TabIndex = 3;
            this.btn15.TabStop = true;
            this.btn15.Text = "15 Intervalos";
            this.btn15.UseVisualStyleBackColor = true;
            this.btn15.CheckedChanged += new System.EventHandler(this.btn15_CheckedChanged);
            // 
            // btn20
            // 
            this.btn20.AutoSize = true;
            this.btn20.Location = new System.Drawing.Point(563, 13);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(91, 19);
            this.btn20.TabIndex = 4;
            this.btn20.TabStop = true;
            this.btn20.Text = "20 Intervalos";
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.CheckedChanged += new System.EventHandler(this.btn20_CheckedChanged);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(336, 38);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(128, 35);
            this.btnGenerar.TabIndex = 5;
            this.btnGenerar.Text = "Generar Informe";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowUserToAddRows = false;
            this.dgvTabla.AllowUserToDeleteRows = false;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.desde,
            this.hasta,
            this.marcaClase,
            this.frecuenciaObservada,
            this.probabilidad,
            this.frecuenciaEsperada});
            this.dgvTabla.Location = new System.Drawing.Point(45, 125);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.RowTemplate.Height = 25;
            this.dgvTabla.Size = new System.Drawing.Size(646, 279);
            this.dgvTabla.TabIndex = 6;
            // 
            // desde
            // 
            this.desde.HeaderText = "Desde";
            this.desde.Name = "desde";
            this.desde.ReadOnly = true;
            // 
            // hasta
            // 
            this.hasta.HeaderText = "Hasta";
            this.hasta.Name = "hasta";
            this.hasta.ReadOnly = true;
            // 
            // marcaClase
            // 
            this.marcaClase.HeaderText = "Marca de Clase";
            this.marcaClase.Name = "marcaClase";
            this.marcaClase.ReadOnly = true;
            // 
            // frecuenciaObservada
            // 
            this.frecuenciaObservada.HeaderText = "FrecuenciaObservada";
            this.frecuenciaObservada.Name = "frecuenciaObservada";
            this.frecuenciaObservada.ReadOnly = true;
            // 
            // probabilidad
            // 
            this.probabilidad.HeaderText = "Probabilidad";
            this.probabilidad.Name = "probabilidad";
            this.probabilidad.ReadOnly = true;
            // 
            // frecuenciaEsperada
            // 
            this.frecuenciaEsperada.HeaderText = "Frecuencia Esperada";
            this.frecuenciaEsperada.Name = "frecuenciaEsperada";
            this.frecuenciaEsperada.ReadOnly = true;
            // 
            // frmGraficoChiCuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn15);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.txtIntervalos);
            this.Name = "frmGraficoChiCuadrado";
            this.Text = "frmGraficoChiCuadrado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtIntervalos;
        private System.Windows.Forms.RadioButton btn5;
        private System.Windows.Forms.RadioButton btn10;
        private System.Windows.Forms.RadioButton btn15;
        private System.Windows.Forms.RadioButton btn20;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn frecuenciaObservada;
        private System.Windows.Forms.DataGridViewTextBoxColumn probabilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn frecuenciaEsperada;
    }
}