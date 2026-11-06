namespace Biblioteca.WinForms
{
    partial class FrmNovoEmprestimo
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
            lblLivro = new Label();
            lblUsuario = new Label();
            cmbLivros = new ComboBox();
            cmbUsuarios = new ComboBox();
            btnCancelar = new Button();
            btnSalvar = new Button();
            lblNovoEmprestimo = new Label();
            SuspendLayout();
            // 
            // lblLivro
            // 
            lblLivro.AutoSize = true;
            lblLivro.Location = new Point(68, 107);
            lblLivro.Name = "lblLivro";
            lblLivro.Size = new Size(36, 15);
            lblLivro.TabIndex = 9;
            lblLivro.Text = "Livro:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(68, 142);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 10;
            lblUsuario.Text = "Usuário";
            // 
            // cmbLivros
            // 
            cmbLivros.BackColor = Color.FromArgb(229, 221, 204);
            cmbLivros.FormattingEnabled = true;
            cmbLivros.Location = new Point(123, 99);
            cmbLivros.Name = "cmbLivros";
            cmbLivros.Size = new Size(154, 23);
            cmbLivros.TabIndex = 11;
            // 
            // cmbUsuarios
            // 
            cmbUsuarios.BackColor = Color.FromArgb(229, 221, 204);
            cmbUsuarios.FormattingEnabled = true;
            cmbUsuarios.Location = new Point(123, 134);
            cmbUsuarios.Name = "cmbUsuarios";
            cmbUsuarios.Size = new Size(154, 23);
            cmbUsuarios.TabIndex = 12;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(69, 86, 64);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(92, 110, 84);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(68, 188);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 30);
            btnCancelar.TabIndex = 18;
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
            btnSalvar.Location = new Point(187, 188);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(90, 30);
            btnSalvar.TabIndex = 19;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblNovoEmprestimo
            // 
            lblNovoEmprestimo.AutoSize = true;
            lblNovoEmprestimo.Font = new Font("Segoe UI", 15F);
            lblNovoEmprestimo.ForeColor = Color.FromArgb(41, 47, 39);
            lblNovoEmprestimo.Location = new Point(87, 28);
            lblNovoEmprestimo.Name = "lblNovoEmprestimo";
            lblNovoEmprestimo.Size = new Size(171, 28);
            lblNovoEmprestimo.TabIndex = 20;
            lblNovoEmprestimo.Text = "Novo empréstimo";
            // 
            // FrmNovoEmprestimo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 240, 229);
            ClientSize = new Size(345, 271);
            Controls.Add(lblNovoEmprestimo);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(cmbUsuarios);
            Controls.Add(cmbLivros);
            Controls.Add(lblUsuario);
            Controls.Add(lblLivro);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmNovoEmprestimo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmNovoEmprestimo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLivro;
        private Label lblUsuario;
        private ComboBox cmbLivros;
        private ComboBox cmbUsuarios;
        private Button btnCancelar;
        private Button btnSalvar;
        private Label lblNovoEmprestimo;
    }
}