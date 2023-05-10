namespace Escola
{
    partial class frmCadastroProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroProfessor));
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.grpDadosPessoais = new System.Windows.Forms.GroupBox();
            this.lblFormacao = new System.Windows.Forms.Label();
            this.txtFormacao = new System.Windows.Forms.TextBox();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.grpTitulacao = new System.Windows.Forms.GroupBox();
            this.rdoPosDoutorado = new System.Windows.Forms.RadioButton();
            this.rdoDoutorado = new System.Windows.Forms.RadioButton();
            this.rdoMestrado = new System.Windows.Forms.RadioButton();
            this.rdoMba = new System.Windows.Forms.RadioButton();
            this.rdoEspecializacao = new System.Windows.Forms.RadioButton();
            this.rdoTecnologo = new System.Windows.Forms.RadioButton();
            this.rdoLicenciatura = new System.Windows.Forms.RadioButton();
            this.rdoBacharelado = new System.Windows.Forms.RadioButton();
            this.grpAcesso = new System.Windows.Forms.GroupBox();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblConfirmarEmail = new System.Windows.Forms.Label();
            this.txtConfirmarEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.grpDadosPessoais.SuspendLayout();
            this.grpTitulacao.SuspendLayout();
            this.grpAcesso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrar.Image = global::Escola.Properties.Resources.retangulo;
            this.btnCadastrar.Location = new System.Drawing.Point(352, 437);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(338, 61);
            this.btnCadastrar.TabIndex = 17;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // grpDadosPessoais
            // 
            this.grpDadosPessoais.BackColor = System.Drawing.Color.Transparent;
            this.grpDadosPessoais.Controls.Add(this.lblFormacao);
            this.grpDadosPessoais.Controls.Add(this.txtFormacao);
            this.grpDadosPessoais.Controls.Add(this.dtpNascimento);
            this.grpDadosPessoais.Controls.Add(this.label1);
            this.grpDadosPessoais.Controls.Add(this.lblNome);
            this.grpDadosPessoais.Controls.Add(this.txtNome);
            this.grpDadosPessoais.Controls.Add(this.grpTitulacao);
            this.grpDadosPessoais.Location = new System.Drawing.Point(12, 165);
            this.grpDadosPessoais.Name = "grpDadosPessoais";
            this.grpDadosPessoais.Size = new System.Drawing.Size(1023, 215);
            this.grpDadosPessoais.TabIndex = 14;
            this.grpDadosPessoais.TabStop = false;
            this.grpDadosPessoais.Text = "Dados Pessoais:";
            // 
            // lblFormacao
            // 
            this.lblFormacao.AutoSize = true;
            this.lblFormacao.Location = new System.Drawing.Point(594, 111);
            this.lblFormacao.Name = "lblFormacao";
            this.lblFormacao.Size = new System.Drawing.Size(84, 18);
            this.lblFormacao.TabIndex = 21;
            this.lblFormacao.Text = "Formação:";
            // 
            // txtFormacao
            // 
            this.txtFormacao.Location = new System.Drawing.Point(597, 141);
            this.txtFormacao.Name = "txtFormacao";
            this.txtFormacao.Size = new System.Drawing.Size(394, 26);
            this.txtFormacao.TabIndex = 20;
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Location = new System.Drawing.Point(597, 63);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(394, 26);
            this.dtpNascimento.TabIndex = 8;
            this.dtpNascimento.Value = new System.DateTime(2023, 5, 10, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(594, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Data de nascimento:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(28, 42);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(122, 18);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome completo:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(31, 63);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(437, 26);
            this.txtNome.TabIndex = 0;
            // 
            // grpTitulacao
            // 
            this.grpTitulacao.BackColor = System.Drawing.Color.Transparent;
            this.grpTitulacao.Controls.Add(this.rdoPosDoutorado);
            this.grpTitulacao.Controls.Add(this.rdoDoutorado);
            this.grpTitulacao.Controls.Add(this.rdoMestrado);
            this.grpTitulacao.Controls.Add(this.rdoMba);
            this.grpTitulacao.Controls.Add(this.rdoEspecializacao);
            this.grpTitulacao.Controls.Add(this.rdoTecnologo);
            this.grpTitulacao.Controls.Add(this.rdoLicenciatura);
            this.grpTitulacao.Controls.Add(this.rdoBacharelado);
            this.grpTitulacao.Location = new System.Drawing.Point(20, 111);
            this.grpTitulacao.Name = "grpTitulacao";
            this.grpTitulacao.Size = new System.Drawing.Size(515, 86);
            this.grpTitulacao.TabIndex = 22;
            this.grpTitulacao.TabStop = false;
            this.grpTitulacao.Text = "Titulação";
            // 
            // rdoPosDoutorado
            // 
            this.rdoPosDoutorado.AutoSize = true;
            this.rdoPosDoutorado.Location = new System.Drawing.Point(363, 53);
            this.rdoPosDoutorado.Name = "rdoPosDoutorado";
            this.rdoPosDoutorado.Size = new System.Drawing.Size(133, 22);
            this.rdoPosDoutorado.TabIndex = 7;
            this.rdoPosDoutorado.TabStop = true;
            this.rdoPosDoutorado.Text = "Pós-Doutorado";
            this.rdoPosDoutorado.UseVisualStyleBackColor = true;
            // 
            // rdoDoutorado
            // 
            this.rdoDoutorado.AutoSize = true;
            this.rdoDoutorado.Location = new System.Drawing.Point(260, 53);
            this.rdoDoutorado.Name = "rdoDoutorado";
            this.rdoDoutorado.Size = new System.Drawing.Size(100, 22);
            this.rdoDoutorado.TabIndex = 6;
            this.rdoDoutorado.TabStop = true;
            this.rdoDoutorado.Text = "Doutorado";
            this.rdoDoutorado.UseVisualStyleBackColor = true;
            // 
            // rdoMestrado
            // 
            this.rdoMestrado.AutoSize = true;
            this.rdoMestrado.Location = new System.Drawing.Point(140, 53);
            this.rdoMestrado.Name = "rdoMestrado";
            this.rdoMestrado.Size = new System.Drawing.Size(92, 22);
            this.rdoMestrado.TabIndex = 5;
            this.rdoMestrado.TabStop = true;
            this.rdoMestrado.Text = "Mestrado";
            this.rdoMestrado.UseVisualStyleBackColor = true;
            // 
            // rdoMba
            // 
            this.rdoMba.AutoSize = true;
            this.rdoMba.Location = new System.Drawing.Point(15, 53);
            this.rdoMba.Name = "rdoMba";
            this.rdoMba.Size = new System.Drawing.Size(61, 22);
            this.rdoMba.TabIndex = 4;
            this.rdoMba.TabStop = true;
            this.rdoMba.Text = "MBA";
            this.rdoMba.UseVisualStyleBackColor = true;
            // 
            // rdoEspecializacao
            // 
            this.rdoEspecializacao.AutoSize = true;
            this.rdoEspecializacao.Location = new System.Drawing.Point(363, 25);
            this.rdoEspecializacao.Name = "rdoEspecializacao";
            this.rdoEspecializacao.Size = new System.Drawing.Size(133, 22);
            this.rdoEspecializacao.TabIndex = 3;
            this.rdoEspecializacao.TabStop = true;
            this.rdoEspecializacao.Text = "Especialização";
            this.rdoEspecializacao.UseVisualStyleBackColor = true;
            // 
            // rdoTecnologo
            // 
            this.rdoTecnologo.AutoSize = true;
            this.rdoTecnologo.Location = new System.Drawing.Point(260, 25);
            this.rdoTecnologo.Name = "rdoTecnologo";
            this.rdoTecnologo.Size = new System.Drawing.Size(97, 22);
            this.rdoTecnologo.TabIndex = 2;
            this.rdoTecnologo.TabStop = true;
            this.rdoTecnologo.Text = "Tecnólogo";
            this.rdoTecnologo.UseVisualStyleBackColor = true;
            // 
            // rdoLicenciatura
            // 
            this.rdoLicenciatura.AutoSize = true;
            this.rdoLicenciatura.Location = new System.Drawing.Point(140, 25);
            this.rdoLicenciatura.Name = "rdoLicenciatura";
            this.rdoLicenciatura.Size = new System.Drawing.Size(111, 22);
            this.rdoLicenciatura.TabIndex = 1;
            this.rdoLicenciatura.TabStop = true;
            this.rdoLicenciatura.Text = "Licenciatura";
            this.rdoLicenciatura.UseVisualStyleBackColor = true;
            // 
            // rdoBacharelado
            // 
            this.rdoBacharelado.AutoSize = true;
            this.rdoBacharelado.Location = new System.Drawing.Point(15, 25);
            this.rdoBacharelado.Name = "rdoBacharelado";
            this.rdoBacharelado.Size = new System.Drawing.Size(115, 22);
            this.rdoBacharelado.TabIndex = 0;
            this.rdoBacharelado.TabStop = true;
            this.rdoBacharelado.Text = "Bacharelado";
            this.rdoBacharelado.UseVisualStyleBackColor = true;
            // 
            // grpAcesso
            // 
            this.grpAcesso.BackColor = System.Drawing.Color.Transparent;
            this.grpAcesso.Controls.Add(this.lblConfirmarSenha);
            this.grpAcesso.Controls.Add(this.txtConfirmarSenha);
            this.grpAcesso.Controls.Add(this.lblSenha);
            this.grpAcesso.Controls.Add(this.txtSenha);
            this.grpAcesso.Controls.Add(this.lblConfirmarEmail);
            this.grpAcesso.Controls.Add(this.txtConfirmarEmail);
            this.grpAcesso.Controls.Add(this.lblEmail);
            this.grpAcesso.Controls.Add(this.txtEmail);
            this.grpAcesso.Location = new System.Drawing.Point(12, 20);
            this.grpAcesso.Name = "grpAcesso";
            this.grpAcesso.Size = new System.Drawing.Size(1023, 125);
            this.grpAcesso.TabIndex = 13;
            this.grpAcesso.TabStop = false;
            this.grpAcesso.Text = "Acesso";
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Location = new System.Drawing.Point(800, 42);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(151, 18);
            this.lblConfirmarSenha.TabIndex = 7;
            this.lblConfirmarSenha.Text = "Confirme sua senha:";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Location = new System.Drawing.Point(803, 63);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(188, 26);
            this.txtConfirmarSenha.TabIndex = 6;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(550, 42);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(57, 18);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(553, 63);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(188, 26);
            this.txtSenha.TabIndex = 4;
            // 
            // lblConfirmarEmail
            // 
            this.lblConfirmarEmail.AutoSize = true;
            this.lblConfirmarEmail.Location = new System.Drawing.Point(277, 42);
            this.lblConfirmarEmail.Name = "lblConfirmarEmail";
            this.lblConfirmarEmail.Size = new System.Drawing.Size(157, 18);
            this.lblConfirmarEmail.TabIndex = 3;
            this.lblConfirmarEmail.Text = "Confirmar seu e-mail:";
            // 
            // txtConfirmarEmail
            // 
            this.txtConfirmarEmail.Location = new System.Drawing.Point(280, 63);
            this.txtConfirmarEmail.Name = "txtConfirmarEmail";
            this.txtConfirmarEmail.Size = new System.Drawing.Size(188, 26);
            this.txtConfirmarEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(28, 42);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 18);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "E-mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(31, 63);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(188, 26);
            this.txtEmail.TabIndex = 0;
            // 
            // picBackground
            // 
            this.picBackground.Image = global::Escola.Properties.Resources.retangulo;
            this.picBackground.Location = new System.Drawing.Point(-1, 406);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(1048, 131);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackground.TabIndex = 16;
            this.picBackground.TabStop = false;
            // 
            // frmCadastroProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1047, 536);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.grpDadosPessoais);
            this.Controls.Add(this.grpAcesso);
            this.Controls.Add(this.picBackground);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCadastroProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Professores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Encerrar);
            this.grpDadosPessoais.ResumeLayout(false);
            this.grpDadosPessoais.PerformLayout();
            this.grpTitulacao.ResumeLayout(false);
            this.grpTitulacao.PerformLayout();
            this.grpAcesso.ResumeLayout(false);
            this.grpAcesso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox grpDadosPessoais;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox grpAcesso;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblConfirmarEmail;
        private System.Windows.Forms.TextBox txtConfirmarEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox picBackground;
        private System.Windows.Forms.Label lblFormacao;
        private System.Windows.Forms.TextBox txtFormacao;
        private System.Windows.Forms.GroupBox grpTitulacao;
        private System.Windows.Forms.RadioButton rdoLicenciatura;
        private System.Windows.Forms.RadioButton rdoBacharelado;
        private System.Windows.Forms.RadioButton rdoPosDoutorado;
        private System.Windows.Forms.RadioButton rdoDoutorado;
        private System.Windows.Forms.RadioButton rdoMestrado;
        private System.Windows.Forms.RadioButton rdoMba;
        private System.Windows.Forms.RadioButton rdoEspecializacao;
        private System.Windows.Forms.RadioButton rdoTecnologo;
    }
}