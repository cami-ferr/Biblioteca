namespace Biblioteca.WinForms
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnUsuarios = new Button();
            btnLivros = new Button();
            btnEmprestimos = new Button();
            lblTitulo = new Label();
            btnSair = new Button();
            pnlConteudo = new Panel();
            pnlBotoes = new Panel();
            pnlBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // btnUsuarios
            // 
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(92, 110, 94);
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsuarios.Location = new Point(20, 117);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Padding = new Padding(15, 0, 0, 0);
            btnUsuarios.Size = new Size(128, 44);
            btnUsuarios.TabIndex = 2;
            btnUsuarios.Text = "Usuários";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnLivros
            // 
            btnLivros.FlatAppearance.BorderSize = 0;
            btnLivros.FlatAppearance.MouseOverBackColor = Color.FromArgb(92, 110, 94);
            btnLivros.FlatStyle = FlatStyle.Flat;
            btnLivros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLivros.Location = new Point(20, 57);
            btnLivros.Name = "btnLivros";
            btnLivros.Padding = new Padding(15, 0, 0, 0);
            btnLivros.Size = new Size(128, 44);
            btnLivros.TabIndex = 1;
            btnLivros.Text = "Livros";
            btnLivros.TextAlign = ContentAlignment.MiddleLeft;
            btnLivros.UseVisualStyleBackColor = true;
            btnLivros.Click += btnLivros_Click;
            // 
            // btnEmprestimos
            // 
            btnEmprestimos.FlatAppearance.BorderSize = 0;
            btnEmprestimos.FlatAppearance.MouseOverBackColor = Color.FromArgb(92, 110, 94);
            btnEmprestimos.FlatStyle = FlatStyle.Flat;
            btnEmprestimos.Font = new Font("Segoe UI", 12F);
            btnEmprestimos.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmprestimos.Location = new Point(20, 177);
            btnEmprestimos.Name = "btnEmprestimos";
            btnEmprestimos.Padding = new Padding(15, 0, 0, 0);
            btnEmprestimos.Size = new Size(128, 44);
            btnEmprestimos.TabIndex = 3;
            btnEmprestimos.Text = "Empréstimos";
            btnEmprestimos.TextAlign = ContentAlignment.MiddleLeft;
            btnEmprestimos.UseVisualStyleBackColor = true;
            btnEmprestimos.Click += btnEmprestimos_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(41, 47, 39);
            lblTitulo.Location = new Point(40, 26);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(146, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Biblioteca";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(69, 86, 64);
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatAppearance.MouseOverBackColor = Color.FromArgb(92, 110, 94);
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 12F);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(60, 490);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(128, 44);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click_1;
            // 
            // pnlConteudo
            // 
            pnlConteudo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlConteudo.Location = new Point(237, 26);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(707, 508);
            pnlConteudo.TabIndex = 6;
            // 
            // pnlBotoes
            // 
            pnlBotoes.BackColor = Color.FromArgb(69, 86, 64);
            pnlBotoes.Controls.Add(btnLivros);
            pnlBotoes.Controls.Add(btnEmprestimos);
            pnlBotoes.Controls.Add(btnUsuarios);
            pnlBotoes.ForeColor = Color.White;
            pnlBotoes.Location = new Point(40, 80);
            pnlBotoes.Name = "pnlBotoes";
            pnlBotoes.Size = new Size(168, 279);
            pnlBotoes.TabIndex = 7;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 240, 229);
            ClientSize = new Size(984, 561);
            Controls.Add(pnlBotoes);
            Controls.Add(pnlConteudo);
            Controls.Add(btnSair);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(900, 550);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biblioteca";
            pnlBotoes.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUsuarios;
        private Button btnLivros;
        private Button btnEmprestimos;
        private Label lblTitulo;
        private Button btnSair;
        private Panel pnlConteudo;
        private Panel pnlBotoes;
    }
}
