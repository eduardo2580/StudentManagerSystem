using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class StaticsForm : Form
    {
        public StaticsForm()
        {
            InitializeComponent();
        }
        Color panTotalCor;
        Color panMasculinoCor;
        Color panFemininoCor;

        private void StaticsForm_Load(object sender, EventArgs e)
        {
            // Cor do panel.
            panTotalCor = panelTotal.BackColor;
            panMasculinoCor = panelMasculino.BackColor;
            panFemininoCor = panelFeminino.BackColor;

            // Mostra os valores.
            Estudante estudante = new Estudante();
            double totalEstudante = Convert.ToDouble(estudante.totalEstudante());
            double totalEstudanteMasculino = Convert.ToDouble(estudante.totalEstudanteMasculino());
            double totalEstudanteFeminino = Convert.ToDouble(estudante.totalEstudanteFeminino());

            // Conta a porcentagem.
            double masculinoPorcentagem = totalEstudanteMasculino * 100 / totalEstudante;
            double femininoPorcentagem = totalEstudanteFeminino * 100 / totalEstudante;

            labelTotal.Text = "Total de Estudantes: "+totalEstudante.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelTotal_MouseEnter(object sender, EventArgs e)
        {
            panelTotal.BackColor = Color.White;
            labelTotal.ForeColor = panTotalCor;
        }

        private void labelTotal_MouseLeave(object sender, EventArgs e)
        {
            panelTotal.BackColor = panTotalCor;
            labelTotal.ForeColor = Color.White;
        }

        private void labelMasculino_MouseEnter(object sender, EventArgs e)
        {
            panelMasculino.BackColor = Color.White;
            labelMasculino.ForeColor = panMasculinoCor;
        }

        private void labelMasculino_MouseLeave(object sender, EventArgs e)
        {
            panelMasculino.BackColor = panMasculinoCor;
            labelMasculino.ForeColor = Color.White;
        }

        private void labelFeminino_MouseEnter(object sender, EventArgs e)
        {
            panelFeminino.BackColor = Color.White;
            labelFeminino.ForeColor = panFemininoCor;
        }

        private void labelFeminino_MouseLeave(object sender, EventArgs e)
        {
            panelFeminino.BackColor = panFemininoCor;
            labelFeminino.ForeColor = Color.White;
        }
    }
}
