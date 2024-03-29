﻿using System;
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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void inserirEstudanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInserirEstudante inserirEstudante = new FormInserirEstudante();
            inserirEstudante.Show(this);
        }

        private void listarEstudantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListarEstudantes formListarEstudantes = new FormListarEstudantes();
            formListarEstudantes.Show(this);
        }

        private void editarRemoverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarDeletarEstudante formAtualizarDeletarEstudante = new AtualizarDeletarEstudante();
            formAtualizarDeletarEstudante.Show(this);
        }

        private void estatísticasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            StaticsForm formStaticsForm = new StaticsForm();
            formStaticsForm.Show(this);
        }
    }
}
