
namespace Escola
{
    partial class frmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.grpAcesso = new System.Windows.Forms.GroupBox();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblConfirmarEmail = new System.Windows.Forms.Label();
            this.txtConfirmarEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.grpDadosPessoais = new System.Windows.Forms.GroupBox();
            this.rdoNaoBinario = new System.Windows.Forms.RadioButton();
            this.rdoFeminino = new System.Windows.Forms.RadioButton();
            this.rdoMasculino = new System.Windows.Forms.RadioButton();
            this.txtNaoBinario = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblNomeSocial = new System.Windows.Forms.Label();
            this.txtNomeSocial = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.chkPoliticas = new System.Windows.Forms.CheckBox();
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.grpAcesso.SuspendLayout();
            this.grpDadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.SuspendLayout();
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
            this.grpAcesso.Location = new System.Drawing.Point(12, 12);
            this.grpAcesso.Name = "grpAcesso";
            this.grpAcesso.Size = new System.Drawing.Size(1023, 125);
            this.grpAcesso.TabIndex = 0;
            this.grpAcesso.TabStop = false;
            this.grpAcesso.Text = "Acesso";
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Location = new System.Drawing.Point(800, 42);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(157, 18);
            this.lblConfirmarSenha.TabIndex = 7;
            this.lblConfirmarSenha.Text = "Confirme sua senha:*";
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
            this.lblSenha.Size = new System.Drawing.Size(63, 18);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha:*";
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
            this.lblConfirmarEmail.Size = new System.Drawing.Size(163, 18);
            this.lblConfirmarEmail.TabIndex = 3;
            this.lblConfirmarEmail.Text = "Confirmar seu e-mail:*";
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
            this.lblEmail.Size = new System.Drawing.Size(63, 18);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "E-mail:*";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(31, 63);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(188, 26);
            this.txtEmail.TabIndex = 0;
            // 
            // grpDadosPessoais
            // 
            this.grpDadosPessoais.BackColor = System.Drawing.Color.Transparent;
            this.grpDadosPessoais.Controls.Add(this.rdoNaoBinario);
            this.grpDadosPessoais.Controls.Add(this.rdoFeminino);
            this.grpDadosPessoais.Controls.Add(this.rdoMasculino);
            this.grpDadosPessoais.Controls.Add(this.txtNaoBinario);
            this.grpDadosPessoais.Controls.Add(this.lblGenero);
            this.grpDadosPessoais.Controls.Add(this.dtpNascimento);
            this.grpDadosPessoais.Controls.Add(this.label1);
            this.grpDadosPessoais.Controls.Add(this.lblCpf);
            this.grpDadosPessoais.Controls.Add(this.txtCpf);
            this.grpDadosPessoais.Controls.Add(this.lblNomeSocial);
            this.grpDadosPessoais.Controls.Add(this.txtNomeSocial);
            this.grpDadosPessoais.Controls.Add(this.lblNome);
            this.grpDadosPessoais.Controls.Add(this.txtNome);
            this.grpDadosPessoais.Location = new System.Drawing.Point(12, 157);
            this.grpDadosPessoais.Name = "grpDadosPessoais";
            this.grpDadosPessoais.Size = new System.Drawing.Size(1023, 215);
            this.grpDadosPessoais.TabIndex = 8;
            this.grpDadosPessoais.TabStop = false;
            this.grpDadosPessoais.Text = "Dados Pessoais:";
            // 
            // rdoNaoBinario
            // 
            this.rdoNaoBinario.AutoSize = true;
            this.rdoNaoBinario.Location = new System.Drawing.Point(665, 131);
            this.rdoNaoBinario.Name = "rdoNaoBinario";
            this.rdoNaoBinario.Size = new System.Drawing.Size(109, 22);
            this.rdoNaoBinario.TabIndex = 18;
            this.rdoNaoBinario.TabStop = true;
            this.rdoNaoBinario.Text = "Não Binário";
            this.rdoNaoBinario.UseVisualStyleBackColor = true;
            this.rdoNaoBinario.CheckedChanged += new System.EventHandler(this.rdoNaoBinario_CheckedChanged);
            // 
            // rdoFeminino
            // 
            this.rdoFeminino.AutoSize = true;
            this.rdoFeminino.Location = new System.Drawing.Point(560, 131);
            this.rdoFeminino.Name = "rdoFeminino";
            this.rdoFeminino.Size = new System.Drawing.Size(91, 22);
            this.rdoFeminino.TabIndex = 17;
            this.rdoFeminino.TabStop = true;
            this.rdoFeminino.Text = "Feminino";
            this.rdoFeminino.UseVisualStyleBackColor = true;
            // 
            // rdoMasculino
            // 
            this.rdoMasculino.AutoSize = true;
            this.rdoMasculino.Location = new System.Drawing.Point(448, 131);
            this.rdoMasculino.Name = "rdoMasculino";
            this.rdoMasculino.Size = new System.Drawing.Size(96, 22);
            this.rdoMasculino.TabIndex = 16;
            this.rdoMasculino.TabStop = true;
            this.rdoMasculino.Text = "Masculino";
            this.rdoMasculino.UseVisualStyleBackColor = true;
            // 
            // txtNaoBinario
            // 
            this.txtNaoBinario.Location = new System.Drawing.Point(803, 130);
            this.txtNaoBinario.Name = "txtNaoBinario";
            this.txtNaoBinario.Size = new System.Drawing.Size(188, 26);
            this.txtNaoBinario.TabIndex = 15;
            this.txtNaoBinario.Visible = false;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(445, 104);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(64, 18);
            this.lblGenero.TabIndex = 13;
            this.lblGenero.Text = "Gênero:";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Location = new System.Drawing.Point(239, 130);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(183, 26);
            this.dtpNascimento.TabIndex = 8;
            this.dtpNascimento.Value = new System.DateTime(2023, 5, 10, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Data de nascimento:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(28, 109);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(45, 18);
            this.lblCpf.TabIndex = 5;
            this.lblCpf.Text = "CPF:";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(31, 130);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(188, 26);
            this.txtCpf.TabIndex = 4;
            // 
            // lblNomeSocial
            // 
            this.lblNomeSocial.AutoSize = true;
            this.lblNomeSocial.Location = new System.Drawing.Point(550, 42);
            this.lblNomeSocial.Name = "lblNomeSocial";
            this.lblNomeSocial.Size = new System.Drawing.Size(102, 18);
            this.lblNomeSocial.TabIndex = 3;
            this.lblNomeSocial.Text = "Nome Social:";
            // 
            // txtNomeSocial
            // 
            this.txtNomeSocial.Location = new System.Drawing.Point(553, 63);
            this.txtNomeSocial.Name = "txtNomeSocial";
            this.txtNomeSocial.Size = new System.Drawing.Size(438, 26);
            this.txtNomeSocial.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(28, 42);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(128, 18);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome completo:*";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(31, 63);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(437, 26);
            this.txtNome.TabIndex = 0;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Black;
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrar.Image = global::Escola.Properties.Resources.retangulo;
            this.btnCadastrar.Location = new System.Drawing.Point(584, 437);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(184, 38);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // chkPoliticas
            // 
            this.chkPoliticas.AutoSize = true;
            this.chkPoliticas.BackgroundImage = global::Escola.Properties.Resources.retangulo;
            this.chkPoliticas.Location = new System.Drawing.Point(251, 446);
            this.chkPoliticas.Name = "chkPoliticas";
            this.chkPoliticas.Size = new System.Drawing.Size(309, 22);
            this.chkPoliticas.TabIndex = 9;
            this.chkPoliticas.Text = "Você aceita as políticas de privacidade?";
            this.chkPoliticas.UseVisualStyleBackColor = true;
            // 
            // picBackground
            // 
            this.picBackground.Image = global::Escola.Properties.Resources.retangulo;
            this.picBackground.Location = new System.Drawing.Point(-1, 398);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(1048, 131);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackground.TabIndex = 11;
            this.picBackground.TabStop = false;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1047, 524);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.chkPoliticas);
            this.Controls.Add(this.grpDadosPessoais);
            this.Controls.Add(this.grpAcesso);
            this.Controls.Add(this.picBackground);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Encerrar);
            this.grpAcesso.ResumeLayout(false);
            this.grpAcesso.PerformLayout();
            this.grpDadosPessoais.ResumeLayout(false);
            this.grpDadosPessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAcesso;
        private System.Windows.Forms.Label lblConfirmarEmail;
        private System.Windows.Forms.TextBox txtConfirmarEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.GroupBox grpDadosPessoais;
        private System.Windows.Forms.TextBox txtNaoBinario;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label lblNomeSocial;
        private System.Windows.Forms.TextBox txtNomeSocial;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox chkPoliticas;
        private System.Windows.Forms.PictureBox picBackground;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.RadioButton rdoNaoBinario;
        private System.Windows.Forms.RadioButton rdoFeminino;
        private System.Windows.Forms.RadioButton rdoMasculino;
    }
}