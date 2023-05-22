
namespace Escola.forms
{
    partial class frmCadastroCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroCurso));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCadastroCurso = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCarga = new System.Windows.Forms.Label();
            this.txtCarga = new System.Windows.Forms.TextBox();
            this.lblModalidade = new System.Windows.Forms.Label();
            this.cboModalidade = new System.Windows.Forms.ComboBox();
            this.cboNivel = new System.Windows.Forms.ComboBox();
            this.lblNivel = new System.Windows.Forms.Label();
            this.btnAdicionarCurso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Escola.Properties.Resources.retangulo;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 498);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 78);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblCadastroCurso
            // 
            this.lblCadastroCurso.AutoSize = true;
            this.lblCadastroCurso.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroCurso.Location = new System.Drawing.Point(71, 30);
            this.lblCadastroCurso.Name = "lblCadastroCurso";
            this.lblCadastroCurso.Size = new System.Drawing.Size(216, 32);
            this.lblCadastroCurso.TabIndex = 2;
            this.lblCadastroCurso.Text = "Cadastrar Curso";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(88, 131);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(188, 26);
            this.txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(85, 110);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(54, 18);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // lblCarga
            // 
            this.lblCarga.AutoSize = true;
            this.lblCarga.Location = new System.Drawing.Point(85, 188);
            this.lblCarga.Name = "lblCarga";
            this.lblCarga.Size = new System.Drawing.Size(112, 18);
            this.lblCarga.TabIndex = 6;
            this.lblCarga.Text = "Carga Horária:";
            // 
            // txtCarga
            // 
            this.txtCarga.Location = new System.Drawing.Point(88, 209);
            this.txtCarga.Name = "txtCarga";
            this.txtCarga.Size = new System.Drawing.Size(188, 26);
            this.txtCarga.TabIndex = 5;
            // 
            // lblModalidade
            // 
            this.lblModalidade.AutoSize = true;
            this.lblModalidade.Location = new System.Drawing.Point(85, 265);
            this.lblModalidade.Name = "lblModalidade";
            this.lblModalidade.Size = new System.Drawing.Size(95, 18);
            this.lblModalidade.TabIndex = 8;
            this.lblModalidade.Text = "Modalidade:";
            // 
            // cboModalidade
            // 
            this.cboModalidade.FormattingEnabled = true;
            this.cboModalidade.Location = new System.Drawing.Point(88, 286);
            this.cboModalidade.Name = "cboModalidade";
            this.cboModalidade.Size = new System.Drawing.Size(188, 26);
            this.cboModalidade.TabIndex = 9;
            // 
            // cboNivel
            // 
            this.cboNivel.FormattingEnabled = true;
            this.cboNivel.Location = new System.Drawing.Point(88, 366);
            this.cboNivel.Name = "cboNivel";
            this.cboNivel.Size = new System.Drawing.Size(188, 26);
            this.cboNivel.TabIndex = 11;
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(85, 345);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(46, 18);
            this.lblNivel.TabIndex = 10;
            this.lblNivel.Text = "Nivel:";
            // 
            // btnAdicionarCurso
            // 
            this.btnAdicionarCurso.BackColor = System.Drawing.Color.Black;
            this.btnAdicionarCurso.Location = new System.Drawing.Point(88, 434);
            this.btnAdicionarCurso.Name = "btnAdicionarCurso";
            this.btnAdicionarCurso.Size = new System.Drawing.Size(188, 33);
            this.btnAdicionarCurso.TabIndex = 12;
            this.btnAdicionarCurso.Text = "Adicionar Curso";
            this.btnAdicionarCurso.UseVisualStyleBackColor = false;
            this.btnAdicionarCurso.Click += new System.EventHandler(this.btnAdicionarCurso_Click);
            // 
            // frmCadastroCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(351, 568);
            this.Controls.Add(this.btnAdicionarCurso);
            this.Controls.Add(this.cboNivel);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.cboModalidade);
            this.Controls.Add(this.lblModalidade);
            this.Controls.Add(this.lblCarga);
            this.Controls.Add(this.txtCarga);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCadastroCurso);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCadastroCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar o curso";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Encerrar);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCadastroCurso;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCarga;
        private System.Windows.Forms.TextBox txtCarga;
        private System.Windows.Forms.Label lblModalidade;
        private System.Windows.Forms.ComboBox cboModalidade;
        private System.Windows.Forms.ComboBox cboNivel;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Button btnAdicionarCurso;
    }
}