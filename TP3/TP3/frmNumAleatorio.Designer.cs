
namespace TP3
{
    partial class frmNumAleatorio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNumAleatorio));
            this.titulo = new System.Windows.Forms.Panel();
            this.titulo1 = new System.Windows.Forms.Label();
            this.ingresoDeNumeros = new System.Windows.Forms.Panel();
            this.btnNormalConvolucion = new System.Windows.Forms.RadioButton();
            this.txtN = new System.Windows.Forms.TextBox();
            this.lblN = new System.Windows.Forms.Label();
            this.btnPoisson = new System.Windows.Forms.RadioButton();
            this.btnExponencial = new System.Windows.Forms.RadioButton();
            this.txtDE = new System.Windows.Forms.TextBox();
            this.txtLambda = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblDE = new System.Windows.Forms.Label();
            this.lblLambda = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.lblMedia = new System.Windows.Forms.Label();
            this.btnUniforme = new System.Windows.Forms.RadioButton();
            this.btnNormalMuller = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenerarGrafico = new System.Windows.Forms.Button();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numAleatorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDistribuciones = new System.Windows.Forms.Label();
            this.titulo.SuspendLayout();
            this.ingresoDeNumeros.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.Controls.Add(this.titulo1);
            this.titulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.titulo.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.titulo.Location = new System.Drawing.Point(0, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(654, 49);
            this.titulo.TabIndex = 0;
            // 
            // titulo1
            // 
            this.titulo1.AutoSize = true;
            this.titulo1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.titulo1.Location = new System.Drawing.Point(10, 8);
            this.titulo1.Name = "titulo1";
            this.titulo1.Size = new System.Drawing.Size(489, 40);
            this.titulo1.TabIndex = 0;
            this.titulo1.Text = "Generador de Números Aleatorios";
            this.titulo1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ingresoDeNumeros
            // 
            this.ingresoDeNumeros.Controls.Add(this.lblDistribuciones);
            this.ingresoDeNumeros.Controls.Add(this.btnNormalConvolucion);
            this.ingresoDeNumeros.Controls.Add(this.txtN);
            this.ingresoDeNumeros.Controls.Add(this.lblN);
            this.ingresoDeNumeros.Controls.Add(this.btnPoisson);
            this.ingresoDeNumeros.Controls.Add(this.btnExponencial);
            this.ingresoDeNumeros.Controls.Add(this.txtDE);
            this.ingresoDeNumeros.Controls.Add(this.txtLambda);
            this.ingresoDeNumeros.Controls.Add(this.btnGenerar);
            this.ingresoDeNumeros.Controls.Add(this.txtB);
            this.ingresoDeNumeros.Controls.Add(this.txtA);
            this.ingresoDeNumeros.Controls.Add(this.lblDE);
            this.ingresoDeNumeros.Controls.Add(this.lblLambda);
            this.ingresoDeNumeros.Controls.Add(this.lblB);
            this.ingresoDeNumeros.Controls.Add(this.lblA);
            this.ingresoDeNumeros.Controls.Add(this.txtMedia);
            this.ingresoDeNumeros.Controls.Add(this.lblMedia);
            this.ingresoDeNumeros.Controls.Add(this.btnUniforme);
            this.ingresoDeNumeros.Controls.Add(this.btnNormalMuller);
            this.ingresoDeNumeros.Dock = System.Windows.Forms.DockStyle.Top;
            this.ingresoDeNumeros.Location = new System.Drawing.Point(0, 49);
            this.ingresoDeNumeros.Name = "ingresoDeNumeros";
            this.ingresoDeNumeros.Size = new System.Drawing.Size(654, 237);
            this.ingresoDeNumeros.TabIndex = 1;
            // 
            // btnNormalConvolucion
            // 
            this.btnNormalConvolucion.AutoSize = true;
            this.btnNormalConvolucion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnNormalConvolucion.Location = new System.Drawing.Point(37, 54);
            this.btnNormalConvolucion.Name = "btnNormalConvolucion";
            this.btnNormalConvolucion.Size = new System.Drawing.Size(130, 25);
            this.btnNormalConvolucion.TabIndex = 17;
            this.btnNormalConvolucion.TabStop = true;
            this.btnNormalConvolucion.Text = "N.Convolución";
            this.btnNormalConvolucion.UseVisualStyleBackColor = true;
            this.btnNormalConvolucion.CheckedChanged += new System.EventHandler(this.btnNormalConvolucion_CheckedChanged);
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtN.Location = new System.Drawing.Point(495, 144);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(86, 29);
            this.txtN.TabIndex = 4;
            this.txtN.Leave += new System.EventHandler(this.txtN_Leave);
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblN.Location = new System.Drawing.Point(471, 148);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(22, 21);
            this.lblN.TabIndex = 15;
            this.lblN.Text = "n:";
            // 
            // btnPoisson
            // 
            this.btnPoisson.AutoSize = true;
            this.btnPoisson.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPoisson.Location = new System.Drawing.Point(534, 54);
            this.btnPoisson.Name = "btnPoisson";
            this.btnPoisson.Size = new System.Drawing.Size(81, 25);
            this.btnPoisson.TabIndex = 14;
            this.btnPoisson.TabStop = true;
            this.btnPoisson.Text = "Poisson";
            this.btnPoisson.UseVisualStyleBackColor = true;
            this.btnPoisson.CheckedChanged += new System.EventHandler(this.btnPoisson_CheckedChanged);
            // 
            // btnExponencial
            // 
            this.btnExponencial.AutoSize = true;
            this.btnExponencial.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnExponencial.Location = new System.Drawing.Point(406, 54);
            this.btnExponencial.Name = "btnExponencial";
            this.btnExponencial.Size = new System.Drawing.Size(110, 25);
            this.btnExponencial.TabIndex = 13;
            this.btnExponencial.TabStop = true;
            this.btnExponencial.Text = "Exponencial";
            this.btnExponencial.UseVisualStyleBackColor = true;
            this.btnExponencial.CheckedChanged += new System.EventHandler(this.btnExponencial_CheckedChanged);
            // 
            // txtDE
            // 
            this.txtDE.Enabled = false;
            this.txtDE.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDE.Location = new System.Drawing.Point(315, 100);
            this.txtDE.Name = "txtDE";
            this.txtDE.Size = new System.Drawing.Size(86, 29);
            this.txtDE.TabIndex = 1;
            // 
            // txtLambda
            // 
            this.txtLambda.Enabled = false;
            this.txtLambda.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtLambda.Location = new System.Drawing.Point(495, 100);
            this.txtLambda.Name = "txtLambda";
            this.txtLambda.Size = new System.Drawing.Size(86, 29);
            this.txtLambda.TabIndex = 2;
            this.txtLambda.Leave += new System.EventHandler(this.txtLambda_Leave);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnGenerar.Location = new System.Drawing.Point(255, 186);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(117, 37);
            this.btnGenerar.TabIndex = 5;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtB
            // 
            this.txtB.Enabled = false;
            this.txtB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtB.Location = new System.Drawing.Point(315, 144);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(86, 29);
            this.txtB.TabIndex = 12;
            // 
            // txtA
            // 
            this.txtA.Enabled = false;
            this.txtA.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtA.Location = new System.Drawing.Point(87, 144);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(86, 29);
            this.txtA.TabIndex = 3;
            // 
            // lblDE
            // 
            this.lblDE.AutoSize = true;
            this.lblDE.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDE.Location = new System.Drawing.Point(198, 104);
            this.lblDE.Name = "lblDE";
            this.lblDE.Size = new System.Drawing.Size(111, 21);
            this.lblDE.TabIndex = 9;
            this.lblDE.Text = "Desv Estandar:";
            // 
            // lblLambda
            // 
            this.lblLambda.AutoSize = true;
            this.lblLambda.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblLambda.Location = new System.Drawing.Point(428, 104);
            this.lblLambda.Name = "lblLambda";
            this.lblLambda.Size = new System.Drawing.Size(73, 21);
            this.lblLambda.TabIndex = 8;
            this.lblLambda.Text = "Lambda: ";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblB.Location = new System.Drawing.Point(287, 148);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(22, 21);
            this.lblB.TabIndex = 7;
            this.lblB.Text = "b:";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblA.Location = new System.Drawing.Point(62, 148);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(21, 21);
            this.lblA.TabIndex = 5;
            this.lblA.Text = "a:";
            // 
            // txtMedia
            // 
            this.txtMedia.AcceptsTab = true;
            this.txtMedia.Enabled = false;
            this.txtMedia.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMedia.Location = new System.Drawing.Point(87, 100);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(86, 29);
            this.txtMedia.TabIndex = 0;
            this.txtMedia.Leave += new System.EventHandler(this.txtMedia_Leave);
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMedia.Location = new System.Drawing.Point(33, 104);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(56, 21);
            this.lblMedia.TabIndex = 2;
            this.lblMedia.Text = "Media:";
            // 
            // btnUniforme
            // 
            this.btnUniforme.AutoSize = true;
            this.btnUniforme.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUniforme.Location = new System.Drawing.Point(296, 54);
            this.btnUniforme.Name = "btnUniforme";
            this.btnUniforme.Size = new System.Drawing.Size(94, 25);
            this.btnUniforme.TabIndex = 1;
            this.btnUniforme.TabStop = true;
            this.btnUniforme.Text = "Uniforme";
            this.btnUniforme.UseVisualStyleBackColor = true;
            this.btnUniforme.CheckedChanged += new System.EventHandler(this.btnUniforme_CheckedChanged);
            // 
            // btnNormalMuller
            // 
            this.btnNormalMuller.AutoSize = true;
            this.btnNormalMuller.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnNormalMuller.Location = new System.Drawing.Point(184, 54);
            this.btnNormalMuller.Name = "btnNormalMuller";
            this.btnNormalMuller.Size = new System.Drawing.Size(88, 25);
            this.btnNormalMuller.TabIndex = 0;
            this.btnNormalMuller.TabStop = true;
            this.btnNormalMuller.Text = "N.Muller";
            this.btnNormalMuller.UseVisualStyleBackColor = true;
            this.btnNormalMuller.CheckedChanged += new System.EventHandler(this.btnNormalMuller_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGenerarGrafico);
            this.panel1.Controls.Add(this.dgvTabla);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 423);
            this.panel1.TabIndex = 2;
            // 
            // btnGenerarGrafico
            // 
            this.btnGenerarGrafico.Enabled = false;
            this.btnGenerarGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarGrafico.Location = new System.Drawing.Point(475, 168);
            this.btnGenerarGrafico.Name = "btnGenerarGrafico";
            this.btnGenerarGrafico.Size = new System.Drawing.Size(124, 63);
            this.btnGenerarGrafico.TabIndex = 0;
            this.btnGenerarGrafico.Text = "Generar Gráfico";
            this.btnGenerarGrafico.UseVisualStyleBackColor = true;
            this.btnGenerarGrafico.Click += new System.EventHandler(this.btnGenerarGrafico_Click);
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowUserToAddRows = false;
            this.dgvTabla.AllowUserToDeleteRows = false;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iteracion,
            this.numAleatorio});
            this.dgvTabla.Location = new System.Drawing.Point(37, 6);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.Size = new System.Drawing.Size(405, 404);
            this.dgvTabla.TabIndex = 0;
            this.dgvTabla.Text = "dataGridView1";
            // 
            // iteracion
            // 
            this.iteracion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iteracion.HeaderText = "Iteración (i)";
            this.iteracion.Name = "iteracion";
            this.iteracion.ReadOnly = true;
            this.iteracion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // numAleatorio
            // 
            this.numAleatorio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numAleatorio.HeaderText = "N° Aleatorio";
            this.numAleatorio.Name = "numAleatorio";
            this.numAleatorio.ReadOnly = true;
            this.numAleatorio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // lblDistribuciones
            // 
            this.lblDistribuciones.AutoSize = true;
            this.lblDistribuciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistribuciones.Location = new System.Drawing.Point(33, 16);
            this.lblDistribuciones.Name = "lblDistribuciones";
            this.lblDistribuciones.Size = new System.Drawing.Size(128, 20);
            this.lblDistribuciones.TabIndex = 29;
            this.lblDistribuciones.Text = "Distribuciones:";
            // 
            // frmNumAleatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 708);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ingresoDeNumeros);
            this.Controls.Add(this.titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNumAleatorio";
            this.Text = " Números Aleatorios";
            this.titulo.ResumeLayout(false);
            this.titulo.PerformLayout();
            this.ingresoDeNumeros.ResumeLayout(false);
            this.ingresoDeNumeros.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titulo;
        private System.Windows.Forms.Label titulo1;
        private System.Windows.Forms.Panel ingresoDeNumeros;
        private System.Windows.Forms.TextBox txtDE;
        private System.Windows.Forms.TextBox txtLambda;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblDE;
        private System.Windows.Forms.Label lblLambda;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.RadioButton btnUniforme;
        private System.Windows.Forms.RadioButton btnNormalMuller;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.Button btnGenerarGrafico;
        private System.Windows.Forms.RadioButton btnPoisson;
        private System.Windows.Forms.RadioButton btnExponencial;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.RadioButton btnNormalConvolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn numAleatorio;
        private System.Windows.Forms.Label lblDistribuciones;
    }
}

