namespace StudentManager
{
    partial class FormInserirEstudante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInserirEstudante));
            this.dateTimePickerNascimento = new System.Windows.Forms.DateTimePicker();
            this.radioButtonFemenino = new System.Windows.Forms.RadioButton();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelSobrenome = new System.Windows.Forms.Label();
            this.textBoxSobrenome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelFoto = new System.Windows.Forms.Label();
            this.buttonEnviarFoto = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerNascimento
            // 
            this.dateTimePickerNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNascimento.Location = new System.Drawing.Point(190, 88);
            this.dateTimePickerNascimento.Name = "dateTimePickerNascimento";
            this.dateTimePickerNascimento.Size = new System.Drawing.Size(229, 26);
            this.dateTimePickerNascimento.TabIndex = 0;
            // 
            // radioButtonFemenino
            // 
            this.radioButtonFemenino.AutoSize = true;
            this.radioButtonFemenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemenino.Location = new System.Drawing.Point(125, 9);
            this.radioButtonFemenino.Name = "radioButtonFemenino";
            this.radioButtonFemenino.Size = new System.Drawing.Size(98, 24);
            this.radioButtonFemenino.TabIndex = 1;
            this.radioButtonFemenino.TabStop = true;
            this.radioButtonFemenino.Text = "Femenino";
            this.radioButtonFemenino.UseVisualStyleBackColor = true;
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMasculino.Location = new System.Drawing.Point(6, 9);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(98, 24);
            this.radioButtonMasculino.TabIndex = 2;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(190, 11);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(229, 26);
            this.textBoxNome.TabIndex = 3;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(62, 14);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(55, 20);
            this.labelNome.TabIndex = 4;
            this.labelNome.Text = "Nome";
            this.labelNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelSobrenome
            // 
            this.labelSobrenome.AutoSize = true;
            this.labelSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSobrenome.Location = new System.Drawing.Point(48, 53);
            this.labelSobrenome.Name = "labelSobrenome";
            this.labelSobrenome.Size = new System.Drawing.Size(101, 20);
            this.labelSobrenome.TabIndex = 5;
            this.labelSobrenome.Text = "Sobrenome";
            this.labelSobrenome.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxSobrenome
            // 
            this.textBoxSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSobrenome.Location = new System.Drawing.Point(190, 50);
            this.textBoxSobrenome.Name = "textBoxSobrenome";
            this.textBoxSobrenome.Size = new System.Drawing.Size(229, 26);
            this.textBoxSobrenome.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data de Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gênero";
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFoto.TabIndex = 9;
            this.pictureBoxFoto.TabStop = false;
            this.pictureBoxFoto.Click += new System.EventHandler(this.pictureBoxFoto_Click);
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(190, 194);
            this.textBoxEndereco.Multiline = true;
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(229, 56);
            this.textBoxEndereco.TabIndex = 10;
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefone.Location = new System.Drawing.Point(48, 162);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(79, 20);
            this.labelTelefone.TabIndex = 11;
            this.labelTelefone.Text = "Telefone";
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelefone.Location = new System.Drawing.Point(190, 162);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(229, 26);
            this.textBoxTelefone.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Endereço";
            // 
            // labelFoto
            // 
            this.labelFoto.AutoSize = true;
            this.labelFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFoto.Location = new System.Drawing.Point(48, 256);
            this.labelFoto.Name = "labelFoto";
            this.labelFoto.Size = new System.Drawing.Size(46, 20);
            this.labelFoto.TabIndex = 14;
            this.labelFoto.Text = "Foto";
            this.labelFoto.Click += new System.EventHandler(this.label7_Click);
            // 
            // buttonEnviarFoto
            // 
            this.buttonEnviarFoto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonEnviarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnviarFoto.Location = new System.Drawing.Point(246, 382);
            this.buttonEnviarFoto.Name = "buttonEnviarFoto";
            this.buttonEnviarFoto.Size = new System.Drawing.Size(120, 31);
            this.buttonEnviarFoto.TabIndex = 15;
            this.buttonEnviarFoto.Text = "Enviar Foto";
            this.buttonEnviarFoto.UseVisualStyleBackColor = false;
            this.buttonEnviarFoto.Click += new System.EventHandler(this.buttonEnviarFoto_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.BackColor = System.Drawing.Color.Green;
            this.buttonCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrar.Location = new System.Drawing.Point(52, 442);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(136, 50);
            this.buttonCadastrar.TabIndex = 16;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.Red;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(231, 442);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(135, 50);
            this.buttonCancelar.TabIndex = 17;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonMasculino);
            this.groupBox1.Controls.Add(this.radioButtonFemenino);
            this.groupBox1.Location = new System.Drawing.Point(190, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 42);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBoxFoto);
            this.groupBox2.Location = new System.Drawing.Point(246, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 120);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // FormInserirEstudante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(437, 504);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonCadastrar);
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
            this.Name = "FormInserirEstudante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGA - Formulário para cadastrar estudante";
            this.Load += new System.EventHandler(this.FormInserirEstudante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerNascimento;
        private System.Windows.Forms.RadioButton radioButtonFemenino;
        private System.Windows.Forms.RadioButton radioButtonMasculino;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelSobrenome;
        private System.Windows.Forms.TextBox textBoxSobrenome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelFoto;
        private System.Windows.Forms.Button buttonEnviarFoto;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}