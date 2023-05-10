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
            this.chkTecnólogo = new System.Windows.Forms.CheckBox();
            this.lblTitulacao = new System.Windows.Forms.Label();
            this.chkLicenciatura = new System.Windows.Forms.CheckBox();
            this.chkBacharelado = new System.Windows.Forms.CheckBox();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
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
            this.chkMestrado = new System.Windows.Forms.CheckBox();
            this.chkMba = new System.Windows.Forms.CheckBox();
            this.chkEspecializacao = new System.Windows.Forms.CheckBox();
            this.chkDoutorado = new System.Windows.Forms.CheckBox();
            this.chkPosDoutorado = new System.Windows.Forms.CheckBox();
            this.lblFormacao = new System.Windows.Forms.Label();
            this.txtFormacao = new System.Windows.Forms.TextBox();
            this.grpDadosPessoais.SuspendLayout();
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
            this.grpDadosPessoais.Controls.Add(this.chkPosDoutorado);
            this.grpDadosPessoais.Controls.Add(this.chkDoutorado);
            this.grpDadosPessoais.Controls.Add(this.chkMestrado);
            this.grpDadosPessoais.Controls.Add(this.chkMba);
            this.grpDadosPessoais.Controls.Add(this.chkEspecializacao);
            this.grpDadosPessoais.Controls.Add(this.chkTecnólogo);
            this.grpDadosPessoais.Controls.Add(this.lblTitulacao);
            this.grpDadosPessoais.Controls.Add(this.chkLicenciatura);
            this.grpDadosPessoais.Controls.Add(this.chkBacharelado);
            this.grpDadosPessoais.Controls.Add(this.dtpNascimento);
            this.grpDadosPessoais.Controls.Add(this.label1);
            this.grpDadosPessoais.Controls.Add(this.lblNome);
            this.grpDadosPessoais.Controls.Add(this.txtNome);
            this.grpDadosPessoais.Location = new System.Drawing.Point(12, 165);
            this.grpDadosPessoais.Name = "grpDadosPessoais";
            this.grpDadosPessoais.Size = new System.Drawing.Size(1023, 215);
            this.grpDadosPessoais.TabIndex = 14;
            this.grpDadosPessoais.TabStop = false;
            this.grpDadosPessoais.Text = "Dados Pessoais:";
            // 
            // chkTecnólogo
            // 
            this.chkTecnólogo.AutoSize = true;
            this.chkTecnólogo.Location = new System.Drawing.Point(270, 141);
            this.chkTecnólogo.Name = "chkTecnólogo";
            this.chkTecnólogo.Size = new System.Drawing.Size(98, 22);
            this.chkTecnólogo.TabIndex = 14;
            this.chkTecnólogo.Text = "Tecnólogo";
            this.chkTecnólogo.UseVisualStyleBackColor = true;
            // 
            // lblTitulacao
            // 
            this.lblTitulacao.AutoSize = true;
            this.lblTitulacao.Location = new System.Drawing.Point(31, 111);
            this.lblTitulacao.Name = "lblTitulacao";
            this.lblTitulacao.Size = new System.Drawing.Size(74, 18);
            this.lblTitulacao.TabIndex = 13;
            this.lblTitulacao.Text = "Titulação:";
            // 
            // chkLicenciatura
            // 
            this.chkLicenciatura.AutoSize = true;
            this.chkLicenciatura.Location = new System.Drawing.Point(152, 141);
            this.chkLicenciatura.Name = "chkLicenciatura";
            this.chkLicenciatura.Size = new System.Drawing.Size(112, 22);
            this.chkLicenciatura.TabIndex = 12;
            this.chkLicenciatura.Text = "Licenciatura";
            this.chkLicenciatura.UseVisualStyleBackColor = true;
            // 
            // chkBacharelado
            // 
            this.chkBacharelado.AutoSize = true;
            this.chkBacharelado.Location = new System.Drawing.Point(34, 141);
            this.chkBacharelado.Name = "chkBacharelado";
            this.chkBacharelado.Size = new System.Drawing.Size(116, 22);
            this.chkBacharelado.TabIndex = 11;
            this.chkBacharelado.Text = "Bacharelado";
            this.chkBacharelado.UseVisualStyleBackColor = true;
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
            // chkMestrado
            // 
            this.chkMestrado.AutoSize = true;
            this.chkMestrado.Location = new System.Drawing.Point(152, 169);
            this.chkMestrado.Name = "chkMestrado";
            this.chkMestrado.Size = new System.Drawing.Size(93, 22);
            this.chkMestrado.TabIndex = 17;
            this.chkMestrado.Text = "Mestrado";
            this.chkMestrado.UseVisualStyleBackColor = true;
            // 
            // chkMba
            // 
            this.chkMba.AutoSize = true;
            this.chkMba.Location = new System.Drawing.Point(34, 169);
            this.chkMba.Name = "chkMba";
            this.chkMba.Size = new System.Drawing.Size(62, 22);
            this.chkMba.TabIndex = 16;
            this.chkMba.Text = "MBA";
            this.chkMba.UseVisualStyleBackColor = true;
            // 
            // chkEspecializacao
            // 
            this.chkEspecializacao.AutoSize = true;
            this.chkEspecializacao.Location = new System.Drawing.Point(380, 141);
            this.chkEspecializacao.Name = "chkEspecializacao";
            this.chkEspecializacao.Size = new System.Drawing.Size(134, 22);
            this.chkEspecializacao.TabIndex = 15;
            this.chkEspecializacao.Text = "Especialização";
            this.chkEspecializacao.UseVisualStyleBackColor = true;
            // 
            // chkDoutorado
            // 
            this.chkDoutorado.AutoSize = true;
            this.chkDoutorado.Location = new System.Drawing.Point(270, 169);
            this.chkDoutorado.Name = "chkDoutorado";
            this.chkDoutorado.Size = new System.Drawing.Size(101, 22);
            this.chkDoutorado.TabIndex = 18;
            this.chkDoutorado.Text = "Doutorado";
            this.chkDoutorado.UseVisualStyleBackColor = true;
            // 
            // chkPosDoutorado
            // 
            this.chkPosDoutorado.AutoSize = true;
            this.chkPosDoutorado.Location = new System.Drawing.Point(380, 169);
            this.chkPosDoutorado.Name = "chkPosDoutorado";
            this.chkPosDoutorado.Size = new System.Drawing.Size(134, 22);
            this.chkPosDoutorado.TabIndex = 19;
            this.chkPosDoutorado.Text = "Pós-Doutorado";
            this.chkPosDoutorado.UseVisualStyleBackColor = true;
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCadastroProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Professores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Encerrar);
            this.grpDadosPessoais.ResumeLayout(false);
            this.grpDadosPessoais.PerformLayout();
            this.grpAcesso.ResumeLayout(false);
            this.grpAcesso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox grpDadosPessoais;
        private System.Windows.Forms.CheckBox chkTecnólogo;
        private System.Windows.Forms.Label lblTitulacao;
        private System.Windows.Forms.CheckBox chkLicenciatura;
        private System.Windows.Forms.CheckBox chkBacharelado;
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
        private System.Windows.Forms.CheckBox chkPosDoutorado;
        private System.Windows.Forms.CheckBox chkDoutorado;
        private System.Windows.Forms.CheckBox chkMestrado;
        private System.Windows.Forms.CheckBox chkMba;
        private System.Windows.Forms.CheckBox chkEspecializacao;
    }
}