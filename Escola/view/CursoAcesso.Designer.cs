
namespace Escola.forms
{
    partial class frmCursoAcesso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCursoAcesso));
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.btnAdicionarCurso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // picBackground
            // 
            this.picBackground.Image = global::Escola.Properties.Resources.retangulo;
            this.picBackground.Location = new System.Drawing.Point(-5, 467);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(371, 101);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackground.TabIndex = 3;
            this.picBackground.TabStop = false;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(109, 31);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(151, 36);
            this.lblCurso.TabIndex = 4;
            this.lblCurso.Text = "CURSOS";
            // 
            // btnAdicionarCurso
            // 
            this.btnAdicionarCurso.BackColor = System.Drawing.Color.Black;
            this.btnAdicionarCurso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdicionarCurso.Location = new System.Drawing.Point(100, 103);
            this.btnAdicionarCurso.Name = "btnAdicionarCurso";
            this.btnAdicionarCurso.Size = new System.Drawing.Size(169, 56);
            this.btnAdicionarCurso.TabIndex = 5;
            this.btnAdicionarCurso.Text = "Adicionar Curso";
            this.btnAdicionarCurso.UseVisualStyleBackColor = false;
            this.btnAdicionarCurso.Click += new System.EventHandler(this.btnAdicionarCurso_Click);
            // 
            // frmCursoAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(361, 564);
            this.Controls.Add(this.btnAdicionarCurso);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.picBackground);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCursoAcesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela do Curso";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Encerrar);
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBackground;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Button btnAdicionarCurso;
    }
}