namespace TP3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGraficoChiCuadrado));
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaClase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecuenciaObservada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probabilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecuenciaEsperada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIntervalos = new System.Windows.Forms.Label();
            this.lblConclusion = new System.Windows.Forms.Label();
            this.lblTablaRes = new System.Windows.Forms.Label();
            this.lblCalculadoRes = new System.Windows.Forms.Label();
            this.lblCalculado = new System.Windows.Forms.Label();
            this.lblTabla = new System.Windows.Forms.Label();
            this.dgvChiCuadrado = new System.Windows.Forms.DataGridView();
            this.desde2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasta2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecuenciaO2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecuenciaE2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAcumulativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.chrtDistribucion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtCantInter = new System.Windows.Forms.TextBox();
            this.chrtChi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiCuadrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtDistribucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtChi)).BeginInit();
            this.SuspendLayout();
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
            this.dgvTabla.Location = new System.Drawing.Point(34, 69);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.RowTemplate.Height = 25;
            this.dgvTabla.Size = new System.Drawing.Size(510, 220);
            this.dgvTabla.TabIndex = 9;
            // 
            // desde
            // 
            this.desde.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.desde.HeaderText = "Desde";
            this.desde.Name = "desde";
            this.desde.ReadOnly = true;
            // 
            // hasta
            // 
            this.hasta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hasta.HeaderText = "Hasta";
            this.hasta.Name = "hasta";
            this.hasta.ReadOnly = true;
            // 
            // marcaClase
            // 
            this.marcaClase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.marcaClase.HeaderText = "Marca de Clase";
            this.marcaClase.Name = "marcaClase";
            this.marcaClase.ReadOnly = true;
            // 
            // frecuenciaObservada
            // 
            this.frecuenciaObservada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.frecuenciaObservada.HeaderText = "Frecuencia Observada";
            this.frecuenciaObservada.Name = "frecuenciaObservada";
            this.frecuenciaObservada.ReadOnly = true;
            // 
            // probabilidad
            // 
            this.probabilidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.probabilidad.HeaderText = "Probabilidad";
            this.probabilidad.Name = "probabilidad";
            this.probabilidad.ReadOnly = true;
            // 
            // frecuenciaEsperada
            // 
            this.frecuenciaEsperada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.frecuenciaEsperada.HeaderText = "Frecuencia Esperada";
            this.frecuenciaEsperada.Name = "frecuenciaEsperada";
            this.frecuenciaEsperada.ReadOnly = true;
            // 
            // txtIntervalos
            // 
            this.txtIntervalos.AutoSize = true;
            this.txtIntervalos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntervalos.Location = new System.Drawing.Point(280, 20);
            this.txtIntervalos.Name = "txtIntervalos";
            this.txtIntervalos.Size = new System.Drawing.Size(157, 18);
            this.txtIntervalos.TabIndex = 7;
            this.txtIntervalos.Text = "Cantidad de Intervalos:";
            // 
            // lblConclusion
            // 
            this.lblConclusion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConclusion.Location = new System.Drawing.Point(622, 378);
            this.lblConclusion.Name = "lblConclusion";
            this.lblConclusion.Size = new System.Drawing.Size(347, 89);
            this.lblConclusion.TabIndex = 19;
            this.lblConclusion.Text = "Conclusión: ";
            this.lblConclusion.Visible = false;
            // 
            // lblTablaRes
            // 
            this.lblTablaRes.AutoSize = true;
            this.lblTablaRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablaRes.Location = new System.Drawing.Point(776, 348);
            this.lblTablaRes.Name = "lblTablaRes";
            this.lblTablaRes.Size = new System.Drawing.Size(28, 18);
            this.lblTablaRes.TabIndex = 18;
            this.lblTablaRes.Text = "0.0";
            this.lblTablaRes.Visible = false;
            // 
            // lblCalculadoRes
            // 
            this.lblCalculadoRes.AutoSize = true;
            this.lblCalculadoRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculadoRes.Location = new System.Drawing.Point(776, 317);
            this.lblCalculadoRes.Name = "lblCalculadoRes";
            this.lblCalculadoRes.Size = new System.Drawing.Size(28, 18);
            this.lblCalculadoRes.TabIndex = 17;
            this.lblCalculadoRes.Text = "0.0";
            this.lblCalculadoRes.Visible = false;
            // 
            // lblCalculado
            // 
            this.lblCalculado.AutoSize = true;
            this.lblCalculado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculado.Location = new System.Drawing.Point(622, 317);
            this.lblCalculado.Name = "lblCalculado";
            this.lblCalculado.Size = new System.Drawing.Size(113, 18);
            this.lblCalculado.TabIndex = 16;
            this.lblCalculado.Text = "Valor calculado:";
            // 
            // lblTabla
            // 
            this.lblTabla.AutoSize = true;
            this.lblTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabla.Location = new System.Drawing.Point(622, 348);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(81, 18);
            this.lblTabla.TabIndex = 15;
            this.lblTabla.Text = "Valor tabla:";
            // 
            // dgvChiCuadrado
            // 
            this.dgvChiCuadrado.AllowUserToAddRows = false;
            this.dgvChiCuadrado.AllowUserToDeleteRows = false;
            this.dgvChiCuadrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiCuadrado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.desde2,
            this.hasta2,
            this.frecuenciaO2,
            this.frecuenciaE2,
            this.c,
            this.cAcumulativo});
            this.dgvChiCuadrado.Location = new System.Drawing.Point(573, 69);
            this.dgvChiCuadrado.Name = "dgvChiCuadrado";
            this.dgvChiCuadrado.ReadOnly = true;
            this.dgvChiCuadrado.Size = new System.Drawing.Size(462, 220);
            this.dgvChiCuadrado.TabIndex = 21;
            // 
            // desde2
            // 
            this.desde2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.desde2.HeaderText = "Desde";
            this.desde2.Name = "desde2";
            this.desde2.ReadOnly = true;
            // 
            // hasta2
            // 
            this.hasta2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hasta2.HeaderText = "Hasta";
            this.hasta2.Name = "hasta2";
            this.hasta2.ReadOnly = true;
            // 
            // frecuenciaO2
            // 
            this.frecuenciaO2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.frecuenciaO2.HeaderText = "Frecuencia Observada";
            this.frecuenciaO2.Name = "frecuenciaO2";
            this.frecuenciaO2.ReadOnly = true;
            // 
            // frecuenciaE2
            // 
            this.frecuenciaE2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.frecuenciaE2.HeaderText = "Frecuencia Esperada";
            this.frecuenciaE2.Name = "frecuenciaE2";
            this.frecuenciaE2.ReadOnly = true;
            // 
            // c
            // 
            this.c.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c.HeaderText = "C()";
            this.c.Name = "c";
            this.c.ReadOnly = true;
            // 
            // cAcumulativo
            // 
            this.cAcumulativo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cAcumulativo.HeaderText = "C() Acum";
            this.cAcumulativo.Name = "cAcumulativo";
            this.cAcumulativo.ReadOnly = true;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(607, 12);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(128, 34);
            this.btnGenerar.TabIndex = 20;
            this.btnGenerar.Text = "Generar Informe";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click_1);
            // 
            // chrtDistribucion
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtDistribucion.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtDistribucion.Legends.Add(legend1);
            this.chrtDistribucion.Location = new System.Drawing.Point(25, 307);
            this.chrtDistribucion.Name = "chrtDistribucion";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrtDistribucion.Series.Add(series1);
            this.chrtDistribucion.Size = new System.Drawing.Size(566, 305);
            this.chrtDistribucion.TabIndex = 22;
            this.chrtDistribucion.Text = "chart1";
            // 
            // txtCantInter
            // 
            this.txtCantInter.Location = new System.Drawing.Point(444, 19);
            this.txtCantInter.Name = "txtCantInter";
            this.txtCantInter.Size = new System.Drawing.Size(100, 20);
            this.txtCantInter.TabIndex = 23;
            this.txtCantInter.Leave += new System.EventHandler(this.txtCantInter_Leave);
            // 
            // chrtChi
            // 
            chartArea2.Name = "ChartArea1";
            this.chrtChi.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrtChi.Legends.Add(legend2);
            this.chrtChi.Location = new System.Drawing.Point(625, 409);
            this.chrtChi.Name = "chrtChi";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chrtChi.Series.Add(series2);
            this.chrtChi.Size = new System.Drawing.Size(398, 203);
            this.chrtChi.TabIndex = 24;
            this.chrtChi.Text = "chart1";
            // 
            // frmGraficoChiCuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 627);
            this.Controls.Add(this.chrtChi);
            this.Controls.Add(this.txtCantInter);
            this.Controls.Add(this.chrtDistribucion);
            this.Controls.Add(this.dgvChiCuadrado);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblConclusion);
            this.Controls.Add(this.lblTablaRes);
            this.Controls.Add(this.lblCalculadoRes);
            this.Controls.Add(this.lblCalculado);
            this.Controls.Add(this.lblTabla);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.txtIntervalos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGraficoChiCuadrado";
            this.Text = "Grafico ChiCuadrado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiCuadrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtDistribucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtChi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.Label txtIntervalos;
        private System.Windows.Forms.Label lblConclusion;
        private System.Windows.Forms.Label lblTablaRes;
        private System.Windows.Forms.Label lblCalculadoRes;
        private System.Windows.Forms.Label lblCalculado;
        private System.Windows.Forms.Label lblTabla;
        private System.Windows.Forms.DataGridView dgvChiCuadrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn desde2;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasta2;
        private System.Windows.Forms.DataGridViewTextBoxColumn frecuenciaO2;
        private System.Windows.Forms.DataGridViewTextBoxColumn frecuenciaE2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAcumulativo;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtDistribucion;
        private System.Windows.Forms.TextBox txtCantInter;
        private System.Windows.Forms.DataGridViewTextBoxColumn desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn frecuenciaObservada;
        private System.Windows.Forms.DataGridViewTextBoxColumn probabilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn frecuenciaEsperada;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtChi;
    }
}