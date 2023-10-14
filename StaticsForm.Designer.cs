namespace StudentManager
{
    partial class StaticsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaticsForm));
            this.panelTotal = new System.Windows.Forms.Panel();
            this.panelMasculino = new System.Windows.Forms.Panel();
            this.panelFeminino = new System.Windows.Forms.Panel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelMasculino = new System.Windows.Forms.Label();
            this.labelFeminino = new System.Windows.Forms.Label();
            this.panelTotal.SuspendLayout();
            this.panelMasculino.SuspendLayout();
            this.panelFeminino.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTotal
            // 
            this.panelTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(69)))), ((int)(((byte)(173)))));
            this.panelTotal.Controls.Add(this.labelTotal);
            this.panelTotal.Controls.Add(this.panelFeminino);
            this.panelTotal.Location = new System.Drawing.Point(1, 0);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(1051, 633);
            this.panelTotal.TabIndex = 0;
            // 
            // panelMasculino
            // 
            this.panelMasculino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.panelMasculino.Controls.Add(this.labelMasculino);
            this.panelMasculino.Location = new System.Drawing.Point(1, 333);
            this.panelMasculino.Name = "panelMasculino";
            this.panelMasculino.Size = new System.Drawing.Size(522, 303);
            this.panelMasculino.TabIndex = 1;
            // 
            // panelFeminino
            // 
            this.panelFeminino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelFeminino.Controls.Add(this.labelFeminino);
            this.panelFeminino.Location = new System.Drawing.Point(515, 333);
            this.panelFeminino.Name = "panelFeminino";
            this.panelFeminino.Size = new System.Drawing.Size(533, 303);
            this.panelFeminino.TabIndex = 2;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.White;
            this.labelTotal.Location = new System.Drawing.Point(264, 159);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(524, 51);
            this.labelTotal.TabIndex = 3;
            this.labelTotal.Text = "Total de Estudantes: 100";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTotal.Click += new System.EventHandler(this.label1_Click);
            this.labelTotal.MouseEnter += new System.EventHandler(this.labelTotal_MouseEnter);
            this.labelTotal.MouseLeave += new System.EventHandler(this.labelTotal_MouseLeave);
            // 
            // labelMasculino
            // 
            this.labelMasculino.AutoSize = true;
            this.labelMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMasculino.ForeColor = System.Drawing.Color.White;
            this.labelMasculino.Location = new System.Drawing.Point(77, 122);
            this.labelMasculino.Name = "labelMasculino";
            this.labelMasculino.Size = new System.Drawing.Size(341, 51);
            this.labelMasculino.TabIndex = 4;
            this.labelMasculino.Text = "Masculino: 50%";
            this.labelMasculino.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMasculino.MouseEnter += new System.EventHandler(this.labelMasculino_MouseEnter);
            this.labelMasculino.MouseLeave += new System.EventHandler(this.labelMasculino_MouseLeave);
            // 
            // labelFeminino
            // 
            this.labelFeminino.AutoSize = true;
            this.labelFeminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFeminino.ForeColor = System.Drawing.Color.White;
            this.labelFeminino.Location = new System.Drawing.Point(98, 122);
            this.labelFeminino.Name = "labelFeminino";
            this.labelFeminino.Size = new System.Drawing.Size(322, 51);
            this.labelFeminino.TabIndex = 5;
            this.labelFeminino.Text = "Feminino: 50%";
            this.labelFeminino.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFeminino.MouseEnter += new System.EventHandler(this.labelFeminino_MouseEnter);
            this.labelFeminino.MouseLeave += new System.EventHandler(this.labelFeminino_MouseLeave);
            // 
            // StaticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1034, 633);
            this.Controls.Add(this.panelMasculino);
            this.Controls.Add(this.panelTotal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1060, 704);
            this.MinimumSize = new System.Drawing.Size(1060, 704);
            this.Name = "StaticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGA - Estatísticas";
            this.Load += new System.EventHandler(this.StaticsForm_Load);
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.panelMasculino.ResumeLayout(false);
            this.panelMasculino.PerformLayout();
            this.panelFeminino.ResumeLayout(false);
            this.panelFeminino.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Panel panelMasculino;
        private System.Windows.Forms.Panel panelFeminino;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelFeminino;
        private System.Windows.Forms.Label labelMasculino;
    }
}