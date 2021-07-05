
namespace TP7
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
            this.numeroMayorEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.e = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eh2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tk1h2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zl1h2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eh2k2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tk2h2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zl2h2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tk3h = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zl3h = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRungeKutta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRungeKutta
            // 
            this.dgvRungeKutta.AllowUserToAddRows = false;
            this.dgvRungeKutta.AllowUserToDeleteRows = false;
            this.dgvRungeKutta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRungeKutta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroMayorEdad,
            this.e,
            this.t,
            this.z,
            this.k1,
            this.l1,
            this.eh2,
            this.tk1h2,
            this.zl1h2,
            this.k2,
            this.l2,
            this.eh2k2,
            this.tk2h2,
            this.zl2h2,
            this.k3,
            this.l3,
            this.eh,
            this.tk3h,
            this.zl3h,
            this.k4,
            this.l4});
            this.dgvRungeKutta.Location = new System.Drawing.Point(12, 12);
            this.dgvRungeKutta.Name = "dgvRungeKutta";
            this.dgvRungeKutta.ReadOnly = true;
            this.dgvRungeKutta.Size = new System.Drawing.Size(1460, 637);
            this.dgvRungeKutta.TabIndex = 0;
            // 
            // numeroMayorEdad
            // 
            this.numeroMayorEdad.HeaderText = "N° Mayor Edad";
            this.numeroMayorEdad.Name = "numeroMayorEdad";
            this.numeroMayorEdad.ReadOnly = true;
            // 
            // e
            // 
            this.e.HeaderText = "e";
            this.e.Name = "e";
            this.e.ReadOnly = true;
            // 
            // t
            // 
            this.t.HeaderText = "T";
            this.t.Name = "t";
            this.t.ReadOnly = true;
            // 
            // z
            // 
            this.z.HeaderText = "Z";
            this.z.Name = "z";
            this.z.ReadOnly = true;
            // 
            // k1
            // 
            this.k1.HeaderText = "K1";
            this.k1.Name = "k1";
            this.k1.ReadOnly = true;
            // 
            // l1
            // 
            this.l1.HeaderText = "L1";
            this.l1.Name = "l1";
            this.l1.ReadOnly = true;
            // 
            // eh2
            // 
            this.eh2.HeaderText = "e + h/2";
            this.eh2.Name = "eh2";
            this.eh2.ReadOnly = true;
            // 
            // tk1h2
            // 
            this.tk1h2.HeaderText = "T + k1*h/2";
            this.tk1h2.Name = "tk1h2";
            this.tk1h2.ReadOnly = true;
            // 
            // zl1h2
            // 
            this.zl1h2.HeaderText = "Z + L1*h/2";
            this.zl1h2.Name = "zl1h2";
            this.zl1h2.ReadOnly = true;
            // 
            // k2
            // 
            this.k2.HeaderText = "K2";
            this.k2.Name = "k2";
            this.k2.ReadOnly = true;
            // 
            // l2
            // 
            this.l2.HeaderText = "L2";
            this.l2.Name = "l2";
            this.l2.ReadOnly = true;
            // 
            // eh2k2
            // 
            this.eh2k2.HeaderText = "e + h/2";
            this.eh2k2.Name = "eh2k2";
            this.eh2k2.ReadOnly = true;
            // 
            // tk2h2
            // 
            this.tk2h2.HeaderText = "T + k2*h/2";
            this.tk2h2.Name = "tk2h2";
            this.tk2h2.ReadOnly = true;
            // 
            // zl2h2
            // 
            this.zl2h2.HeaderText = "Z + L2*h/2";
            this.zl2h2.Name = "zl2h2";
            this.zl2h2.ReadOnly = true;
            // 
            // k3
            // 
            this.k3.HeaderText = "K3";
            this.k3.Name = "k3";
            this.k3.ReadOnly = true;
            // 
            // l3
            // 
            this.l3.HeaderText = "L3";
            this.l3.Name = "l3";
            this.l3.ReadOnly = true;
            // 
            // eh
            // 
            this.eh.HeaderText = "e + h";
            this.eh.Name = "eh";
            this.eh.ReadOnly = true;
            // 
            // tk3h
            // 
            this.tk3h.HeaderText = "T + K3 * h";
            this.tk3h.Name = "tk3h";
            this.tk3h.ReadOnly = true;
            // 
            // zl3h
            // 
            this.zl3h.HeaderText = "Z + L3 * h";
            this.zl3h.Name = "zl3h";
            this.zl3h.ReadOnly = true;
            // 
            // k4
            // 
            this.k4.HeaderText = "K4";
            this.k4.Name = "k4";
            this.k4.ReadOnly = true;
            // 
            // l4
            // 
            this.l4.HeaderText = "L4";
            this.l4.Name = "l4";
            this.l4.ReadOnly = true;
            // 
            // frmRungeKutta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 661);
            this.Controls.Add(this.dgvRungeKutta);
            this.Name = "frmRungeKutta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRungeKutta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRungeKutta_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRungeKutta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRungeKutta;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroMayorEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn e;
        private System.Windows.Forms.DataGridViewTextBoxColumn t;
        private System.Windows.Forms.DataGridViewTextBoxColumn z;
        private System.Windows.Forms.DataGridViewTextBoxColumn k1;
        private System.Windows.Forms.DataGridViewTextBoxColumn l1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eh2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tk1h2;
        private System.Windows.Forms.DataGridViewTextBoxColumn zl1h2;
        private System.Windows.Forms.DataGridViewTextBoxColumn k2;
        private System.Windows.Forms.DataGridViewTextBoxColumn l2;
        private System.Windows.Forms.DataGridViewTextBoxColumn eh2k2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tk2h2;
        private System.Windows.Forms.DataGridViewTextBoxColumn zl2h2;
        private System.Windows.Forms.DataGridViewTextBoxColumn k3;
        private System.Windows.Forms.DataGridViewTextBoxColumn l3;
        private System.Windows.Forms.DataGridViewTextBoxColumn eh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tk3h;
        private System.Windows.Forms.DataGridViewTextBoxColumn zl3h;
        private System.Windows.Forms.DataGridViewTextBoxColumn k4;
        private System.Windows.Forms.DataGridViewTextBoxColumn l4;
    }
}