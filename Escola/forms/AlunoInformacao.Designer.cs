
namespace Escola.forms
{
    partial class Informação
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
            this.picBackground = new System.Windows.Forms.PictureBox();
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.grpAcesso = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.grpAcesso.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBackground
            // 
            this.picBackground.Image = global::Escola.Properties.Resources.retangulo;
            this.picBackground.Location = new System.Drawing.Point(0, 302);
            this.picBackground.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(1089, 86);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackground.TabIndex = 3;
            this.picBackground.TabStop = false;
            // 
            // txtNaoBinario
            // 
            this.txtNaoBinario.Location = new System.Drawing.Point(342, 132);
            this.txtNaoBinario.Name = "txtNaoBinario";
            this.txtNaoBinario.Size = new System.Drawing.Size(126, 26);
            this.txtNaoBinario.TabIndex = 15;
            this.txtNaoBinario.Visible = false;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(339, 111);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(64, 18);
            this.lblGenero.TabIndex = 13;
            this.lblGenero.Text = "Gênero:";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Location = new System.Drawing.Point(771, 132);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(220, 26);
            this.dtpNascimento.TabIndex = 8;
            this.dtpNascimento.Value = new System.DateTime(2023, 5, 10, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(768, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Data de nascimento:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(550, 111);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(45, 18);
            this.lblCpf.TabIndex = 5;
            this.lblCpf.Text = "CPF:";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(553, 132);
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
            this.lblNome.Location = new System.Drawing.Point(28, 181);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(128, 18);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome completo:*";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(31, 202);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(437, 26);
            this.txtNome.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(31, 63);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(258, 26);
            this.txtEmail.TabIndex = 0;
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
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(31, 132);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(258, 26);
            this.txtSenha.TabIndex = 4;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(28, 111);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(63, 18);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha:*";
            // 
            // grpAcesso
            // 
            this.grpAcesso.BackColor = System.Drawing.Color.Transparent;
            this.grpAcesso.Controls.Add(this.lblSenha);
            this.grpAcesso.Controls.Add(this.txtSenha);
            this.grpAcesso.Controls.Add(this.lblEmail);
            this.grpAcesso.Controls.Add(this.txtNaoBinario);
            this.grpAcesso.Controls.Add(this.lblGenero);
            this.grpAcesso.Controls.Add(this.txtEmail);
            this.grpAcesso.Controls.Add(this.txtNome);
            this.grpAcesso.Controls.Add(this.dtpNascimento);
            this.grpAcesso.Controls.Add(this.label1);
            this.grpAcesso.Controls.Add(this.lblNome);
            this.grpAcesso.Controls.Add(this.txtNomeSocial);
            this.grpAcesso.Controls.Add(this.lblCpf);
            this.grpAcesso.Controls.Add(this.lblNomeSocial);
            this.grpAcesso.Controls.Add(this.txtCpf);
            this.grpAcesso.Location = new System.Drawing.Point(30, 12);
            this.grpAcesso.Name = "grpAcesso";
            this.grpAcesso.Size = new System.Drawing.Size(1023, 252);
            this.grpAcesso.TabIndex = 9;
            this.grpAcesso.TabStop = false;
            this.grpAcesso.Text = "Acesso";
            // 
            // Informação
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1083, 388);
            this.Controls.Add(this.grpAcesso);
            this.Controls.Add(this.picBackground);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Informação";
            this.Text = "INFORMAÇÃO DADOS DO ALUNO";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Encerrar);
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.grpAcesso.ResumeLayout(false);
            this.grpAcesso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBackground;
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
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.GroupBox grpAcesso;
    }
}