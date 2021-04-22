
namespace GeneracionDeNumerosAleatorios
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
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtK = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblG = new System.Windows.Forms.Label();
            this.lblK = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.lblX0 = new System.Windows.Forms.Label();
            this.btnMultiplicativo = new System.Windows.Forms.RadioButton();
            this.btnMixto = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenerarGrafico = new System.Windows.Forms.Button();
            this.btnProximo = new FontAwesome.Sharp.IconButton();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numAleatorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.titulo.Size = new System.Drawing.Size(645, 49);
            this.titulo.TabIndex = 0;
            // 
            // titulo1
            // 
            this.titulo1.AutoSize = true;
            this.titulo1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.titulo1.Location = new System.Drawing.Point(20, 9);
            this.titulo1.Name = "titulo1";
            this.titulo1.Size = new System.Drawing.Size(489, 40);
            this.titulo1.TabIndex = 0;
            this.titulo1.Text = "Generador de Números Aleatorios";
            this.titulo1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ingresoDeNumeros
            // 
            this.ingresoDeNumeros.Controls.Add(this.txtG);
            this.ingresoDeNumeros.Controls.Add(this.txtK);
            this.ingresoDeNumeros.Controls.Add(this.btnGenerar);
            this.ingresoDeNumeros.Controls.Add(this.txtM);
            this.ingresoDeNumeros.Controls.Add(this.txtC);
            this.ingresoDeNumeros.Controls.Add(this.txtA);
            this.ingresoDeNumeros.Controls.Add(this.lblG);
            this.ingresoDeNumeros.Controls.Add(this.lblK);
            this.ingresoDeNumeros.Controls.Add(this.lblM);
            this.ingresoDeNumeros.Controls.Add(this.lblC);
            this.ingresoDeNumeros.Controls.Add(this.lblA);
            this.ingresoDeNumeros.Controls.Add(this.txtX0);
            this.ingresoDeNumeros.Controls.Add(this.lblX0);
            this.ingresoDeNumeros.Controls.Add(this.btnMultiplicativo);
            this.ingresoDeNumeros.Controls.Add(this.btnMixto);
            this.ingresoDeNumeros.Dock = System.Windows.Forms.DockStyle.Top;
            this.ingresoDeNumeros.Location = new System.Drawing.Point(0, 49);
            this.ingresoDeNumeros.Name = "ingresoDeNumeros";
            this.ingresoDeNumeros.Size = new System.Drawing.Size(645, 202);
            this.ingresoDeNumeros.TabIndex = 1;
            // 
            // txtG
            // 
            this.txtG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtG.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtG.Location = new System.Drawing.Point(283, 69);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(86, 29);
            this.txtG.TabIndex = 3;
            this.txtG.Leave += new System.EventHandler(this.txtG_Leave);
            // 
            // txtK
            // 
            this.txtK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtK.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtK.Location = new System.Drawing.Point(499, 69);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(86, 29);
            this.txtK.TabIndex = 4;
            this.txtK.Leave += new System.EventHandler(this.txtK_Leave);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnGenerar.Location = new System.Drawing.Point(267, 155);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(110, 33);
            this.btnGenerar.TabIndex = 6;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtM
            // 
            this.txtM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtM.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtM.Location = new System.Drawing.Point(283, 111);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(86, 29);
            this.txtM.TabIndex = 12;
            this.txtM.Leave += new System.EventHandler(this.txtM_Leave);
            // 
            // txtC
            // 
            this.txtC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtC.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtC.Location = new System.Drawing.Point(499, 113);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(86, 29);
            this.txtC.TabIndex = 5;
            this.txtC.Leave += new System.EventHandler(this.txtC_Leave);
            // 
            // txtA
            // 
            this.txtA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtA.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtA.Location = new System.Drawing.Point(91, 111);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(86, 29);
            this.txtA.TabIndex = 4;
            this.txtA.Leave += new System.EventHandler(this.txtA_Leave);
            // 
            // lblG
            // 
            this.lblG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblG.AutoSize = true;
            this.lblG.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblG.Location = new System.Drawing.Point(259, 72);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(22, 21);
            this.lblG.TabIndex = 9;
            this.lblG.Text = "g:";
            // 
            // lblK
            // 
            this.lblK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblK.AutoSize = true;
            this.lblK.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblK.Location = new System.Drawing.Point(480, 72);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(21, 21);
            this.lblK.TabIndex = 8;
            this.lblK.Text = "k:";
            // 
            // lblM
            // 
            this.lblM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblM.AutoSize = true;
            this.lblM.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblM.Location = new System.Drawing.Point(259, 113);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(27, 21);
            this.lblM.TabIndex = 7;
            this.lblM.Text = "m:";
            // 
            // lblC
            // 
            this.lblC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblC.Location = new System.Drawing.Point(477, 116);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(20, 21);
            this.lblC.TabIndex = 6;
            this.lblC.Text = "c:";
            // 
            // lblA
            // 
            this.lblA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblA.Location = new System.Drawing.Point(66, 116);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(21, 21);
            this.lblA.TabIndex = 5;
            this.lblA.Text = "a:";
            // 
            // txtX0
            // 
            this.txtX0.AcceptsTab = true;
            this.txtX0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtX0.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtX0.Location = new System.Drawing.Point(91, 69);
            this.txtX0.Name = "txtX0";
            this.txtX0.Size = new System.Drawing.Size(86, 29);
            this.txtX0.TabIndex = 2;
            this.txtX0.Leave += new System.EventHandler(this.txtX0_Leave);
            // 
            // lblX0
            // 
            this.lblX0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblX0.AutoSize = true;
            this.lblX0.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblX0.Location = new System.Drawing.Point(59, 72);
            this.lblX0.Name = "lblX0";
            this.lblX0.Size = new System.Drawing.Size(31, 21);
            this.lblX0.TabIndex = 2;
            this.lblX0.Text = "Xo:";
            // 
            // btnMultiplicativo
            // 
            this.btnMultiplicativo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMultiplicativo.AutoSize = true;
            this.btnMultiplicativo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMultiplicativo.Location = new System.Drawing.Point(359, 23);
            this.btnMultiplicativo.Name = "btnMultiplicativo";
            this.btnMultiplicativo.Size = new System.Drawing.Size(122, 25);
            this.btnMultiplicativo.TabIndex = 1;
            this.btnMultiplicativo.TabStop = true;
            this.btnMultiplicativo.Text = "Multiplicativo";
            this.btnMultiplicativo.UseVisualStyleBackColor = true;
            this.btnMultiplicativo.CheckedChanged += new System.EventHandler(this.btnMultiplicativo_CheckedChanged);
            // 
            // btnMixto
            // 
            this.btnMixto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMixto.AutoSize = true;
            this.btnMixto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMixto.Location = new System.Drawing.Point(164, 23);
            this.btnMixto.Name = "btnMixto";
            this.btnMixto.Size = new System.Drawing.Size(67, 25);
            this.btnMixto.TabIndex = 0;
            this.btnMixto.TabStop = true;
            this.btnMixto.Text = "Mixto";
            this.btnMixto.UseVisualStyleBackColor = true;
            this.btnMixto.CheckedChanged += new System.EventHandler(this.btnLineal_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGenerarGrafico);
            this.panel1.Controls.Add(this.btnProximo);
            this.panel1.Controls.Add(this.dgvTabla);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 257);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 368);
            this.panel1.TabIndex = 2;
            // 
            // btnGenerarGrafico
            // 
            this.btnGenerarGrafico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerarGrafico.Enabled = false;
            this.btnGenerarGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarGrafico.Location = new System.Drawing.Point(478, 206);
            this.btnGenerarGrafico.Name = "btnGenerarGrafico";
            this.btnGenerarGrafico.Size = new System.Drawing.Size(140, 49);
            this.btnGenerarGrafico.TabIndex = 1;
            this.btnGenerarGrafico.Text = "Generar Gráfico";
            this.btnGenerarGrafico.UseVisualStyleBackColor = true;
            this.btnGenerarGrafico.Click += new System.EventHandler(this.btnGenerarGrafico_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProximo.Enabled = false;
            this.btnProximo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnProximo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnProximo.IconColor = System.Drawing.Color.Black;
            this.btnProximo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProximo.Location = new System.Drawing.Point(478, 125);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(140, 49);
            this.btnProximo.TabIndex = 0;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowUserToAddRows = false;
            this.dgvTabla.AllowUserToDeleteRows = false;
            this.dgvTabla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iteracion,
            this.numAleatorio});
            this.dgvTabla.Location = new System.Drawing.Point(27, 12);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.Size = new System.Drawing.Size(401, 344);
            this.dgvTabla.TabIndex = 2;
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
            this.numAleatorio.HeaderText = "N° Aleatorio (RND)";
            this.numAleatorio.Name = "numAleatorio";
            this.numAleatorio.ReadOnly = true;
            this.numAleatorio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // frmNumAleatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 625);
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
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtX0;
        private System.Windows.Forms.Label lblX0;
        private System.Windows.Forms.RadioButton btnMultiplicativo;
        private System.Windows.Forms.RadioButton btnMixto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn numAleatorio;
        private FontAwesome.Sharp.IconButton btnProximo;
        private System.Windows.Forms.Button btnGenerarGrafico;
    }
}

