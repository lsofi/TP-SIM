
namespace TP5
{
    partial class frmRungeKutta
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
            this.dgvRungeKutta = new System.Windows.Forms.DataGridView();
            this.interrupcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.th2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xk1h2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.th2k2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xk2h2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.th = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xk3h = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRungeKutta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRungeKutta
            // 
            this.dgvRungeKutta.AllowUserToAddRows = false;
            this.dgvRungeKutta.AllowUserToDeleteRows = false;
            this.dgvRungeKutta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRungeKutta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.interrupcion,
            this.t,
            this.x,
            this.k1,
            this.th2,
            this.xk1h2,
            this.k2,
            this.th2k2,
            this.xk2h2,
            this.k3,
            this.th,
            this.xk3h,
            this.k4});
            this.dgvRungeKutta.Location = new System.Drawing.Point(12, 12);
            this.dgvRungeKutta.Name = "dgvRungeKutta";
            this.dgvRungeKutta.ReadOnly = true;
            this.dgvRungeKutta.Size = new System.Drawing.Size(1273, 638);
            this.dgvRungeKutta.TabIndex = 4;
            // 
            // interrupcion
            // 
            this.interrupcion.HeaderText = "N Interrupción";
            this.interrupcion.Name = "interrupcion";
            this.interrupcion.ReadOnly = true;
            // 
            // t
            // 
            this.t.HeaderText = "t";
            this.t.Name = "t";
            this.t.ReadOnly = true;
            // 
            // x
            // 
            this.x.HeaderText = "x";
            this.x.Name = "x";
            this.x.ReadOnly = true;
            // 
            // k1
            // 
            this.k1.HeaderText = "k1";
            this.k1.Name = "k1";
            this.k1.ReadOnly = true;
            // 
            // th2
            // 
            this.th2.HeaderText = "t + h/2";
            this.th2.Name = "th2";
            this.th2.ReadOnly = true;
            // 
            // xk1h2
            // 
            this.xk1h2.HeaderText = "x + k1*h/2";
            this.xk1h2.Name = "xk1h2";
            this.xk1h2.ReadOnly = true;
            // 
            // k2
            // 
            this.k2.HeaderText = "k2";
            this.k2.Name = "k2";
            this.k2.ReadOnly = true;
            // 
            // th2k2
            // 
            this.th2k2.HeaderText = "t + h/2";
            this.th2k2.Name = "th2k2";
            this.th2k2.ReadOnly = true;
            // 
            // xk2h2
            // 
            this.xk2h2.HeaderText = "x + k2*h/2";
            this.xk2h2.Name = "xk2h2";
            this.xk2h2.ReadOnly = true;
            // 
            // k3
            // 
            this.k3.HeaderText = "k3";
            this.k3.Name = "k3";
            this.k3.ReadOnly = true;
            // 
            // th
            // 
            this.th.HeaderText = "t + h";
            this.th.Name = "th";
            this.th.ReadOnly = true;
            // 
            // xk3h
            // 
            this.xk3h.HeaderText = "x + k3*h";
            this.xk3h.Name = "xk3h";
            this.xk3h.ReadOnly = true;
            // 
            // k4
            // 
            this.k4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.k4.HeaderText = "k4";
            this.k4.Name = "k4";
            this.k4.ReadOnly = true;
            // 
            // frmRungeKutta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 662);
            this.Controls.Add(this.dgvRungeKutta);
            this.Name = "frmRungeKutta";
            this.Text = "RungeKuta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRungeKutta_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRungeKutta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRungeKutta;
        private System.Windows.Forms.DataGridViewTextBoxColumn interrupcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn t;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn k1;
        private System.Windows.Forms.DataGridViewTextBoxColumn th2;
        private System.Windows.Forms.DataGridViewTextBoxColumn xk1h2;
        private System.Windows.Forms.DataGridViewTextBoxColumn k2;
        private System.Windows.Forms.DataGridViewTextBoxColumn th2k2;
        private System.Windows.Forms.DataGridViewTextBoxColumn xk2h2;
        private System.Windows.Forms.DataGridViewTextBoxColumn k3;
        private System.Windows.Forms.DataGridViewTextBoxColumn th;
        private System.Windows.Forms.DataGridViewTextBoxColumn xk3h;
        private System.Windows.Forms.DataGridViewTextBoxColumn k4;
    }
}