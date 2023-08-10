using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class FormInserirEstudante : Form
    {
        public FormInserirEstudante()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormInserirEstudante_Load(object sender, EventArgs e)
        {
            // Coloca a imagem user.png na picture box da janela.
            pictureBoxFoto.Image = Image.FromFile("../../imagens/user.png");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonEnviarFoto_Click(object sender, EventArgs e)
        {
            // Cria uma caixa de diálogo para enviar a foto do aluno.
            OpenFileDialog inserirFoto = new OpenFileDialog();
            // Filtrar os tipos de arquivo que podem ser enviados.
            inserirFoto.Filter = "Selecionar Imagem(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif;";
            if (inserirFoto.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.Image = Image.FromFile(inserirFoto.FileName);
            }

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            // CADASTRA UM ESTUDANTE.
            Estudante novoEstudante = new Estudante();
            string nomeDoEstudante = textBoxNome.Text;
            string sobrenomeDoEstudante = textBoxSobrenome.Text;
            DateTime dataDeNascimento = dateTimePickerNascimento.Value;
            string telefoneDoEstudante = textBoxTelefone.Text;
            string enderecoDoEstudante = textBoxEndereco.Text;
            string generoDoEstudante = "Masculino";

            if (radioButtonFemenino.Checked)
            {
                generoDoEstudante = "Feminino";
            }
          

            MemoryStream fotoDoEstudante = new MemoryStream();

            //Somente permitir o cadastro de alunos entre 10 e 100 anos de idade.
            int anoDeNascimento = dateTimePickerNascimento.Value.Year;
            int anoAtual = DateTime.Now.Year;
            int idadeAtual = anoAtual - anoDeNascimento;

            if (idadeAtual < 10 || idadeAtual > 100)
            {
                MessageBox.Show("O estudante precisa ter entre 10 e 100 anos.", "Erro - Data de nascimento inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (vericarDados())
            {
                pictureBoxFoto.Image.Save(fotoDoEstudante, pictureBoxFoto.Image.RawFormat);
                if (novoEstudante.inserirEstudante(nomeDoEstudante,sobrenomeDoEstudante,dataDeNascimento,generoDoEstudante,telefoneDoEstudante,enderecoDoEstudante,fotoDoEstudante))
                {
                    MessageBox.Show("Estudante cadastrado!", "Cadastrar Estudante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Estudante NÂO CADASTRADO!", "Erro ao cadastrar estudante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Campos em branco!", "Erro ao cadastrar estudante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool vericarDados()
        {
            if ((textBoxNome.Text.Trim() == "") || (textBoxSobrenome.Text.Trim() == "") || (textBoxTelefone.Text.Trim() == "") || (textBoxEndereco.Text.Trim() == "") || (pictureBoxFoto.Image == null))
            {
                MessageBox.Show("Algum campo não foi preenchido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void pictureBoxFoto_Click(object sender, EventArgs e)
        {

        }
    }
}
