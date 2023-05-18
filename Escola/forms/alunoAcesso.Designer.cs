
namespace Escola.forms
{
    partial class AlunoAcesso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlunoAcesso));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnInformacoes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Escola.Properties.Resources.retangulo;
            this.pictureBox1.Location = new System.Drawing.Point(-5, 445);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(437, 103);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Snow;
            this.lblTitulo.Location = new System.Drawing.Point(105, 30);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(229, 32);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "TELA DO ALUNO";
            // 
            // btnInformacoes
            // 
            this.btnInformacoes.BackColor = System.Drawing.Color.Black;
            this.btnInformacoes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInformacoes.Location = new System.Drawing.Point(128, 124);
            this.btnInformacoes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInformacoes.Name = "btnInformacoes";
            this.btnInformacoes.Size = new System.Drawing.Size(180, 48);
            this.btnInformacoes.TabIndex = 2;
            this.btnInformacoes.Text = "INFORMAÇÕES";
            this.btnInformacoes.UseVisualStyleBackColor = false;
            this.btnInformacoes.Click += new System.EventHandler(this.btnInformacoes_Click);
            // 
            // alunoAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(427, 543);
            this.Controls.Add(this.btnInformacoes);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "alunoAcesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela do Aluno";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Encerrar);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnInformacoes;
    }
}