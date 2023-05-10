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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(43, 43, 43);

            this.btnLogin.FlatStyle = FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 1;

            this.btnCadastro.FlatStyle = FlatStyle.Flat;
            this.btnCadastro.FlatAppearance.BorderSize = 1;     
        }
    }
}
