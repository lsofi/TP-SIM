
namespace TP5
{
    partial class RungeKutta
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
            this.lblH = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.dgvRungeKutta = new System.Windows.Forms.DataGridView();
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
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblH.Location = new System.Drawing.Point(65, 33);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(25, 20);
            this.lblH.TabIndex = 0;
            this.lblH.Text = "H:";
            // 
            // txtH
            // 
            this.txtH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtH.Location = new System.Drawing.Point(96, 30);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(100, 26);
            this.txtH.TabIndex = 1;
            // 
            // dgvRungeKutta
            // 
            this.dgvRungeKutta.AllowUserToAddRows = false;
            this.dgvRungeKutta.AllowUserToDeleteRows = false;
            this.dgvRungeKutta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRungeKutta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvRungeKutta.Location = new System.Drawing.Point(12, 85);
            this.dgvRungeKutta.Name = "dgvRungeKutta";
            this.dgvRungeKutta.ReadOnly = true;
            this.dgvRungeKutta.Size = new System.Drawing.Size(1273, 565);
            this.dgvRungeKutta.TabIndex = 4;
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
            // RungeKutta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 662);
            this.Controls.Add(this.dgvRungeKutta);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.lblH);
            this.Name = "RungeKutta";
            this.Text = "RungeKuta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRungeKutta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.DataGridView dgvRungeKutta;
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