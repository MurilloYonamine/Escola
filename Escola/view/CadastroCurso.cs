using Escola.Controller;
using Escola.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola.forms
{
    public partial class frmCadastroCurso : Form
    {
        public frmCadastroCurso()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(43, 43, 43);

            ModalidadeController mController = new ModalidadeController();
            ArrayList listaModalidade = mController.listar();
            foreach (Modalidade modalidade in listaModalidade)
            {
                cboModalidade.Items.Add(modalidade);
            }


            NivelController nController = new NivelController();
            ArrayList listaNivel = nController.listar();
            foreach (Nivel nivel in listaNivel)
            {
                cboNivel.Items.Add(nivel);
            }
        }


        private void Encerrar(object sender, FormClosedEventArgs e)
        {
            frmCursoAcesso telaAnterior = new frmCursoAcesso();
            telaAnterior.Show();
        }

        private void btnAdicionarCurso_Click(object sender, EventArgs e)
        {
            CursoController cController = new CursoController();
            Curso curso = new Curso();

            curso.Nome = txtNome.Text;
            curso.Carga = Convert.ToInt32(txtCarga.Text);

            curso.Nivel.Id = Convert.ToInt32(cboNivel.Text.Split('-')[0]);
            curso.Nivel.Nome = cboNivel.Text.Split('-')[1];

            curso.Modalidade.Id = Convert.ToInt32(cboModalidade.Text.Split('-')[0]);
            curso.Modalidade.Nome = cboModalidade.Text.Split('-')[1];
            cController.Salvar(curso);

            MessageBox.Show("Curso " + curso.Nome + " registrado com sucesso!");
            Close();
        }
    }
}
