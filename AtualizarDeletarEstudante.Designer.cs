namespace StudentManager
{
    partial class AtualizarDeletarEstudante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtualizarDeletarEstudante));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.radioButtonFemenino = new System.Windows.Forms.RadioButton();
            this.buttonDeletar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonEnviarFoto = new System.Windows.Forms.Button();
            this.labelFoto = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSobrenome = new System.Windows.Forms.TextBox();
            this.labelSobrenome = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.dateTimePickerNascimento = new System.Windows.Forms.DateTimePicker();
            this.labelid = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonProcurar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBoxFoto);
            this.groupBox2.Location = new System.Drawing.Point(245, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 120);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFoto.TabIndex = 9;
            this.pictureBoxFoto.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonMasculino);
            this.groupBox1.Controls.Add(this.radioButtonFemenino);
            this.groupBox1.Location = new System.Drawing.Point(189, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 42);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Checked = true;
            this.radioButtonMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMasculino.Location = new System.Drawing.Point(6, 9);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(98, 24);
            this.radioButtonMasculino.TabIndex = 2;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemenino
            // 
            this.radioButtonFemenino.AutoSize = true;
            this.radioButtonFemenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemenino.Location = new System.Drawing.Point(125, 9);
            this.radioButtonFemenino.Name = "radioButtonFemenino";
            this.radioButtonFemenino.Size = new System.Drawing.Size(98, 24);
            this.radioButtonFemenino.TabIndex = 1;
            this.radioButtonFemenino.Text = "Femenino";
            this.radioButtonFemenino.UseVisualStyleBackColor = true;
            // 
            // buttonDeletar
            // 
            this.buttonDeletar.BackColor = System.Drawing.Color.Red;
            this.buttonDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletar.Location = new System.Drawing.Point(230, 507);
            this.buttonDeletar.Name = "buttonDeletar";
            this.buttonDeletar.Size = new System.Drawing.Size(135, 50);
            this.buttonDeletar.TabIndex = 34;
            this.buttonDeletar.Text = "Deletar";
            this.buttonDeletar.UseVisualStyleBackColor = false;
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.Green;
            this.buttonEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.Location = new System.Drawing.Point(51, 507);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(136, 50);
            this.buttonEditar.TabIndex = 33;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonEnviarFoto
            // 
            this.buttonEnviarFoto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonEnviarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnviarFoto.Location = new System.Drawing.Point(245, 447);
            this.buttonEnviarFoto.Name = "buttonEnviarFoto";
            this.buttonEnviarFoto.Size = new System.Drawing.Size(120, 31);
            this.buttonEnviarFoto.TabIndex = 32;
            this.buttonEnviarFoto.Text = "Enviar Foto";
            this.buttonEnviarFoto.UseVisualStyleBackColor = false;
            this.buttonEnviarFoto.Click += new System.EventHandler(this.buttonEnviarFoto_Click);
            // 
            // labelFoto
            // 
            this.labelFoto.AutoSize = true;
            this.labelFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFoto.Location = new System.Drawing.Point(47, 321);
            this.labelFoto.Name = "labelFoto";
            this.labelFoto.Size = new System.Drawing.Size(46, 20);
            this.labelFoto.TabIndex = 31;
            this.labelFoto.Text = "Foto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Endereço";
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelefone.Location = new System.Drawing.Point(189, 227);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(229, 26);
            this.textBoxTelefone.TabIndex = 29;
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefone.Location = new System.Drawing.Point(47, 227);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(79, 20);
            this.labelTelefone.TabIndex = 28;
            this.labelTelefone.Text = "Telefone";
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(189, 259);
            this.textBoxEndereco.Multiline = true;
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(229, 56);
            this.textBoxEndereco.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Gênero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Data de Nascimento";
            // 
            // textBoxSobrenome
            // 
            this.textBoxSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSobrenome.Location = new System.Drawing.Point(189, 115);
            this.textBoxSobrenome.Name = "textBoxSobrenome";
            this.textBoxSobrenome.Size = new System.Drawing.Size(229, 26);
            this.textBoxSobrenome.TabIndex = 24;
            // 
            // labelSobrenome
            // 
            this.labelSobrenome.AutoSize = true;
            this.labelSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSobrenome.Location = new System.Drawing.Point(47, 118);
            this.labelSobrenome.Name = "labelSobrenome";
            this.labelSobrenome.Size = new System.Drawing.Size(101, 20);
            this.labelSobrenome.TabIndex = 23;
            this.labelSobrenome.Text = "Sobrenome";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(61, 79);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(55, 20);
            this.labelNome.TabIndex = 22;
            this.labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(189, 76);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(229, 26);
            this.textBoxNome.TabIndex = 21;
            // 
            // dateTimePickerNascimento
            // 
            this.dateTimePickerNascimento.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNascimento.Location = new System.Drawing.Point(189, 153);
            this.dateTimePickerNascimento.Name = "dateTimePickerNascimento";
            this.dateTimePickerNascimento.Size = new System.Drawing.Size(229, 26);
            this.dateTimePickerNascimento.TabIndex = 20;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid.Location = new System.Drawing.Point(17, 12);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(28, 20);
            this.labelid.TabIndex = 37;
            this.labelid.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(51, 12);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(229, 26);
            this.textBoxID.TabIndex = 38;
            // 
            // buttonProcurar
            // 
            this.buttonProcurar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProcurar.Location = new System.Drawing.Point(298, 10);
            this.buttonProcurar.Name = "buttonProcurar";
            this.buttonProcurar.Size = new System.Drawing.Size(120, 31);
            this.buttonProcurar.TabIndex = 39;
            this.buttonProcurar.Text = "Procurar";
            this.buttonProcurar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.MaximumSize = new System.Drawing.Size(419, 2);
            this.label1.MinimumSize = new System.Drawing.Size(419, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 2);
            this.label1.TabIndex = 40;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AtualizarDeletarEstudante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(437, 569);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonProcurar);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonDeletar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonEnviarFoto);
            this.Controls.Add(this.labelFoto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.textBoxEndereco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSobrenome);
            this.Controls.Add(this.labelSobrenome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.dateTimePickerNascimento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AtualizarDeletarEstudante";
            this.Text = "SGA - Editar ou Deletar Estudante";
            this.Load += new System.EventHandler(this.AtualizarDeletarEstudante_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDeletar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonEnviarFoto;
        private System.Windows.Forms.Label labelFoto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSobrenome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Button buttonProcurar;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.RadioButton radioButtonMasculino;
        internal System.Windows.Forms.RadioButton radioButtonFemenino;
        internal System.Windows.Forms.TextBox textBoxTelefone;
        internal System.Windows.Forms.TextBox textBoxEndereco;
        internal System.Windows.Forms.TextBox textBoxSobrenome;
        internal System.Windows.Forms.TextBox textBoxNome;
        internal System.Windows.Forms.DateTimePicker dateTimePickerNascimento;
        internal System.Windows.Forms.TextBox textBoxID;
        internal System.Windows.Forms.PictureBox pictureBoxFoto;
    }
}