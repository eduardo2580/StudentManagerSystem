﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void labelUser_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            // Coloca a imagem user.png na picture box da janela.
            pictureBox1.Image = Image.FromFile("../../imagens/user.png");
        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            MEU_BD bancoDeDados = new MEU_BD();

            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            DataTable tabela = new DataTable();
            MySqlCommand comando = new MySqlCommand("SELECT * FROM `usuarios` WHERE `username` = @usn AND `password` = @psw", bancoDeDados.getConexao);

            // Atualiza o valor do parâmetro @usn e @psw, do comando acima.
            comando.Parameters.Add("@usn", MySqlDbType.VarChar).Value = txtUsuario.Text;
            comando.Parameters.Add("@psw", MySqlDbType.VarChar).Value = txtSenha.Text;

            adaptador.SelectCommand = comando;

            try {
                adaptador.Fill(tabela);

                if(tabela.Rows.Count > 0)
                {
                    //MessageBox.Show("YES");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Não consegui conectar ao banco de dados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
