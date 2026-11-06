namespace Biblioteca.WinForms
{
    partial class FrmEditarUsuario
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
            lblNome = new Label();
            lblEmail = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            btnCancelar = new Button();
            btnSalvar = new Button();
            txtTelefone = new TextBox();
            lblTelefone = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15F);
            lblTitulo.ForeColor = Color.FromArgb(41, 47, 39);
            lblTitulo.Location = new Point(100, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(132, 28);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Editar usuário";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(69, 100);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(69, 172);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "E-mail:";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(229, 221, 204);
            txtNome.Location = new Point(124, 92);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(154, 23);
            txtNome.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(229, 221, 204);
            txtEmail.Location = new Point(124, 162);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(154, 23);
            txtEmail.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(69, 86, 64);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(92, 110, 84);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(69, 210);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 30);
            btnCancelar.TabIndex = 11;
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
            btnSalvar.Location = new Point(198, 210);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(80, 30);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtTelefone
            // 
            txtTelefone.BackColor = Color.FromArgb(229, 221, 204);
            txtTelefone.Location = new Point(124, 127);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(154, 23);
            txtTelefone.TabIndex = 1;
            txtTelefone.KeyPress += txtTelefone_KeyPress;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(69, 135);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(54, 15);
            lblTelefone.TabIndex = 14;
            lblTelefone.Text = "Telefone:";
            // 
            // FrmEditarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 240, 229);
            ClientSize = new Size(346, 280);
            Controls.Add(lblTelefone);
            Controls.Add(txtTelefone);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEditarUsuario";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmEditarUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNome;
        private Label lblEmail;
        private TextBox txtNome;
        private TextBox txtEmail;
        private Button btnCancelar;
        private Button btnSalvar;
        private TextBox txtTelefone;
        private Label lblTelefone;
    }
}