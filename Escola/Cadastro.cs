using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(43, 43, 43);
            grpAcesso.ForeColor = Color.White;
            grpDadosPessoais.ForeColor = Color.White;

            this.btnCadastrar.FlatAppearance.BorderSize = 1;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dtpNascimento.Value.ToString("dd-MM-yyyy");
        }
    }
}
