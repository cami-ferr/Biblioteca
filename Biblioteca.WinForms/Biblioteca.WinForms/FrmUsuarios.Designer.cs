namespace Biblioteca.WinForms
{
    partial class FrmUsuarios
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            lblTituloUsuarios = new Label();
            btnCadastrarUsuario = new Button();
            dgvUsuarios = new DataGridView();
            cmbBuscarUsuario = new ComboBox();
            btnListarUsuarios = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // lblTituloUsuarios
            // 
            lblTituloUsuarios.AutoSize = true;
            lblTituloUsuarios.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTituloUsuarios.ForeColor = Color.FromArgb(41, 47, 39);
            lblTituloUsuarios.Location = new Point(24, 27);
            lblTituloUsuarios.Name = "lblTituloUsuarios";
            lblTituloUsuarios.Size = new Size(208, 30);
            lblTituloUsuarios.TabIndex = 1;
            lblTituloUsuarios.Text = "Gerenciar Usuários";
            // 
            // btnCadastrarUsuario
            // 
            btnCadastrarUsuario.BackColor = Color.FromArgb(69, 86, 64);
            btnCadastrarUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(92, 110, 84);
            btnCadastrarUsuario.FlatStyle = FlatStyle.Flat;
            btnCadastrarUsuario.Font = new Font("Segoe UI", 10F);
            btnCadastrarUsuario.ForeColor = Color.White;
            btnCadastrarUsuario.Location = new Point(24, 69);
            btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            btnCadastrarUsuario.Size = new Size(135, 35);
            btnCadastrarUsuario.TabIndex = 2;
            btnCadastrarUsuario.Text = "Cadastrar usuário";
            btnCadastrarUsuario.UseVisualStyleBackColor = false;
            btnCadastrarUsuario.Click += btnCadastrarUsuario_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(245, 240, 229);
            dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.BackgroundColor = Color.FromArgb(245, 240, 229);
            dgvUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(69, 86, 64);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(69, 86, 64);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(69, 86, 64);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle6;
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.Location = new Point(23, 113);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(660, 315);
            dgvUsuarios.TabIndex = 6;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // cmbBuscarUsuario
            // 
            cmbBuscarUsuario.BackColor = Color.FromArgb(229, 221, 204);
            cmbBuscarUsuario.FlatStyle = FlatStyle.Flat;
            cmbBuscarUsuario.FormattingEnabled = true;
            cmbBuscarUsuario.Location = new Point(369, 67);
            cmbBuscarUsuario.Name = "cmbBuscarUsuario";
            cmbBuscarUsuario.Size = new Size(273, 23);
            cmbBuscarUsuario.TabIndex = 7;
            cmbBuscarUsuario.Text = "Buscar usuário...";
            cmbBuscarUsuario.TextChanged += cmbBuscarUsuario_TextChanged;
            cmbBuscarUsuario.Enter += cmbBuscarUsuario_Enter;
            cmbBuscarUsuario.KeyDown += cmbBuscarUsuario_KeyDown;
            cmbBuscarUsuario.Leave += cmbBuscarUsuario_Leave;
            // 
            // btnListarUsuarios
            // 
            btnListarUsuarios.BackColor = Color.Transparent;
            btnListarUsuarios.FlatAppearance.BorderSize = 0;
            btnListarUsuarios.FlatStyle = FlatStyle.Flat;
            btnListarUsuarios.Image = (Image)resources.GetObject("btnListarUsuarios.Image");
            btnListarUsuarios.Location = new Point(648, 66);
            btnListarUsuarios.Name = "btnListarUsuarios";
            btnListarUsuarios.Size = new Size(35, 23);
            btnListarUsuarios.TabIndex = 8;
            btnListarUsuarios.UseVisualStyleBackColor = false;
            btnListarUsuarios.Click += btnListarUsuarios_Click;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 240, 229);
            ClientSize = new Size(707, 450);
            Controls.Add(btnListarUsuarios);
            Controls.Add(cmbBuscarUsuario);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnCadastrarUsuario);
            Controls.Add(lblTituloUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuarios";
            Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloUsuarios;
        private Button btnCadastrarUsuario;
        private DataGridView dgvUsuarios;
        private ComboBox cmbBuscarUsuario;
        private Button btnListarUsuarios;
    }
}