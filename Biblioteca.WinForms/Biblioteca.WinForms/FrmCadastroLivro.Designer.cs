namespace Biblioteca.WinForms
{
    partial class FrmCadastroLivro
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
            lblTitulo = new Label();
            lblAutor = new Label();
            lblGenero = new Label();
            lblAno = new Label();
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            txtGenero = new TextBox();
            txtAno = new TextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            lblCadastroLivro = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(70, 102);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(40, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Título:";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(70, 137);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(40, 15);
            lblAutor.TabIndex = 1;
            lblAutor.Text = "Autor:";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(70, 172);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(48, 15);
            lblGenero.TabIndex = 2;
            lblGenero.Text = "Gênero:";
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Location = new Point(70, 207);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(32, 15);
            lblAno.TabIndex = 3;
            lblAno.Text = "Ano:";
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = Color.FromArgb(229, 221, 204);
            txtTitulo.ForeColor = SystemColors.ControlText;
            txtTitulo.Location = new Point(125, 94);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(154, 23);
            txtTitulo.TabIndex = 4;
            // 
            // txtAutor
            // 
            txtAutor.BackColor = Color.FromArgb(229, 221, 204);
            txtAutor.Location = new Point(125, 129);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(154, 23);
            txtAutor.TabIndex = 5;
            // 
            // txtGenero
            // 
            txtGenero.BackColor = Color.FromArgb(229, 221, 204);
            txtGenero.Location = new Point(125, 164);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(154, 23);
            txtGenero.TabIndex = 6;
            // 
            // txtAno
            // 
            txtAno.BackColor = Color.FromArgb(229, 221, 204);
            txtAno.Location = new Point(125, 199);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(154, 23);
            txtAno.TabIndex = 7;
            txtAno.KeyPress += txtAno_KeyPress;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(69, 86, 64);
            btnSalvar.FlatAppearance.MouseOverBackColor = Color.FromArgb(92, 110, 84);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(199, 252);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(80, 30);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(69, 86, 64);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(92, 110, 84);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(70, 252);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 30);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblCadastroLivro
            // 
            lblCadastroLivro.AutoSize = true;
            lblCadastroLivro.Font = new Font("Segoe UI", 15F);
            lblCadastroLivro.ForeColor = Color.FromArgb(41, 47, 39);
            lblCadastroLivro.Location = new Point(105, 28);
            lblCadastroLivro.Name = "lblCadastroLivro";
            lblCadastroLivro.Size = new Size(139, 28);
            lblCadastroLivro.TabIndex = 10;
            lblCadastroLivro.Text = "Cadastrar livro";
            // 
            // FrmCadastroLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 240, 229);
            ClientSize = new Size(348, 326);
            Controls.Add(lblCadastroLivro);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtAno);
            Controls.Add(txtGenero);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Controls.Add(lblAno);
            Controls.Add(lblGenero);
            Controls.Add(lblAutor);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCadastroLivro";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblAutor;
        private Label lblGenero;
        private Label lblAno;
        private TextBox txtTitulo;
        private TextBox txtAutor;
        private TextBox txtGenero;
        private TextBox txtAno;
        private Button btnSalvar;
        private Button btnCancelar;
        private Label lblCadastroLivro;
    }
}