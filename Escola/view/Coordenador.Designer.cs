
namespace Escola
{
    partial class frmCoordenador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCoordenador));
            this.btnAdicionarProfessor = new System.Windows.Forms.Button();
            this.lblCoordenacao = new System.Windows.Forms.Label();
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.btnCursos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionarProfessor
            // 
            this.btnAdicionarProfessor.BackColor = System.Drawing.Color.Black;
            this.btnAdicionarProfessor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdicionarProfessor.Location = new System.Drawing.Point(111, 147);
            this.btnAdicionarProfessor.Name = "btnAdicionarProfessor";
            this.btnAdicionarProfessor.Size = new System.Drawing.Size(143, 38);
            this.btnAdicionarProfessor.TabIndex = 0;
            this.btnAdicionarProfessor.Text = "Adicionar Professor";
            this.btnAdicionarProfessor.UseVisualStyleBackColor = false;
            this.btnAdicionarProfessor.Click += new System.EventHandler(this.btnAdicionarProfessor_Click);
            // 
            // lblCoordenacao
            // 
            this.lblCoordenacao.AutoSize = true;
            this.lblCoordenacao.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoordenacao.Location = new System.Drawing.Point(91, 26);
            this.lblCoordenacao.Name = "lblCoordenacao";
            this.lblCoordenacao.Size = new System.Drawing.Size(191, 42);
            this.lblCoordenacao.TabIndex = 1;
            this.lblCoordenacao.Text = "Coordenação";
            // 
            // picBackground
            // 
            this.picBackground.Image = global::Escola.Properties.Resources.retangulo;
            this.picBackground.Location = new System.Drawing.Point(-1, 470);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(371, 131);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackground.TabIndex = 2;
            this.picBackground.TabStop = false;
            // 
            // btnCursos
            // 
            this.btnCursos.BackColor = System.Drawing.Color.Black;
            this.btnCursos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCursos.Location = new System.Drawing.Point(111, 227);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(143, 38);
            this.btnCursos.TabIndex = 3;
            this.btnCursos.Text = "Cursos";
            this.btnCursos.UseVisualStyleBackColor = false;
            this.btnCursos.Click += new System.EventHandler(this.btnCursos_Click);
            // 
            // frmCoordenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(368, 601);
            this.Controls.Add(this.btnCursos);
            this.Controls.Add(this.picBackground);
            this.Controls.Add(this.lblCoordenacao);
            this.Controls.Add(this.btnAdicionarProfessor);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmCoordenador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coordenador";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Encerrar);
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionarProfessor;
        private System.Windows.Forms.Label lblCoordenacao;
        private System.Windows.Forms.PictureBox picBackground;
        private System.Windows.Forms.Button btnCursos;
    }
}