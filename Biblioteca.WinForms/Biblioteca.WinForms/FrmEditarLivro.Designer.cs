namespace Biblioteca.WinForms
{
    partial class FrmEditarLivro
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
            txtAno = new TextBox();
            txtGenero = new TextBox();
            txtAutor = new TextBox();
            txtTitulo = new TextBox();
            lblAno = new Label();
            lblGenero = new Label();
            lblAutor = new Label();
            lblTitulo = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
            lblEditarLivro = new Label();
            SuspendLayout();
            // 
            // txtAno
            // 
            txtAno.BackColor = Color.FromArgb(229, 221, 204);
            txtAno.Location = new Point(118, 197);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(154, 23);
            txtAno.TabIndex = 15;
            txtAno.KeyPress += txtAno_KeyPress;
            // 
            // txtGenero
            // 
            txtGenero.BackColor = Color.FromArgb(229, 221, 204);
            txtGenero.Location = new Point(118, 162);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(154, 23);
            txtGenero.TabIndex = 14;
            // 
            // txtAutor
            // 
            txtAutor.BackColor = Color.FromArgb(229, 221, 204);
            txtAutor.Location = new Point(118, 127);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(154, 23);
            txtAutor.TabIndex = 13;
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = Color.FromArgb(229, 221, 204);
            txtTitulo.Location = new Point(118, 92);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(154, 23);
            txtTitulo.TabIndex = 12;
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Location = new Point(63, 205);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(32, 15);
            lblAno.TabIndex = 11;
            lblAno.Text = "Ano:";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(63, 170);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(48, 15);
            lblGenero.TabIndex = 10;
            lblGenero.Text = "Gênero:";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(63, 135);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(40, 15);
            lblAutor.TabIndex = 9;
            lblAutor.Text = "Autor:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(63, 100);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(40, 15);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Título:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(69, 86, 64);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(92, 110, 84);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(63, 250);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 30);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(69, 86, 64);
            btnSalvar.FlatAppearance.MouseOverBackColor = Color.FromArgb(92, 110, 84);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(165, 250);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(107, 30);
            btnSalvar.TabIndex = 16;
            btnSalvar.Text = "Salvar alterações";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblEditarLivro
            // 
            lblEditarLivro.AutoSize = true;
            lblEditarLivro.Font = new Font("Segoe UI", 15F);
            lblEditarLivro.ForeColor = Color.FromArgb(41, 47, 39);
            lblEditarLivro.Location = new Point(123, 28);
            lblEditarLivro.Name = "lblEditarLivro";
            lblEditarLivro.Size = new Size(107, 28);
            lblEditarLivro.TabIndex = 18;
            lblEditarLivro.Text = "Editar livro";
            lblEditarLivro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmEditarLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 240, 229);
            ClientSize = new Size(334, 341);
            Controls.Add(lblEditarLivro);
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
            Name = "FrmEditarLivro";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmEditarLivro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAno;
        private TextBox txtGenero;
        private TextBox txtAutor;
        private TextBox txtTitulo;
        private Label lblAno;
        private Label lblGenero;
        private Label lblAutor;
        private Label lblTitulo;
        private Button btnCancelar;
        private Button btnSalvar;
        private Label lblEditarLivro;
    }
}