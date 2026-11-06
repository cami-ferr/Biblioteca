using Biblioteca;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
namespace Biblioteca.WinForms
{
    partial class FrmLivros
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLivros));
            lblTituloLivros = new Label();
            btnCadastrarLivro = new Button();
            dgvLivros = new DataGridView();
            btnListarTodos = new Button();
            cmbBuscarLivro = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvLivros).BeginInit();
            SuspendLayout();
            // 
            // lblTituloLivros
            // 
            lblTituloLivros.AutoSize = true;
            lblTituloLivros.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTituloLivros.ForeColor = Color.FromArgb(41, 47, 39);
            lblTituloLivros.Location = new Point(24, 27);
            lblTituloLivros.Name = "lblTituloLivros";
            lblTituloLivros.Size = new Size(180, 30);
            lblTituloLivros.TabIndex = 0;
            lblTituloLivros.Text = "Gerenciar Livros";
            // 
            // btnCadastrarLivro
            // 
            btnCadastrarLivro.BackColor = Color.FromArgb(69, 86, 64);
            btnCadastrarLivro.FlatAppearance.MouseOverBackColor = Color.FromArgb(92, 110, 84);
            btnCadastrarLivro.FlatStyle = FlatStyle.Flat;
            btnCadastrarLivro.Font = new Font("Segoe UI", 10F);
            btnCadastrarLivro.ForeColor = Color.White;
            btnCadastrarLivro.Location = new Point(24, 69);
            btnCadastrarLivro.Name = "btnCadastrarLivro";
            btnCadastrarLivro.Size = new Size(130, 35);
            btnCadastrarLivro.TabIndex = 1;
            btnCadastrarLivro.Text = "Cadastrar livro";
            btnCadastrarLivro.UseVisualStyleBackColor = false;
            btnCadastrarLivro.Click += btnCadastrarLivro_Click;
            // 
            // dgvLivros
            // 
            dgvLivros.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 240, 229);
            dgvLivros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvLivros.BackgroundColor = Color.FromArgb(245, 240, 229);
            dgvLivros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(69, 86, 64);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(69, 86, 64);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvLivros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvLivros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(69, 86, 64);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvLivros.DefaultCellStyle = dataGridViewCellStyle3;
            dgvLivros.EnableHeadersVisualStyles = false;
            dgvLivros.Location = new Point(24, 110);
            dgvLivros.MultiSelect = false;
            dgvLivros.Name = "dgvLivros";
            dgvLivros.ReadOnly = true;
            dgvLivros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLivros.Size = new Size(660, 315);
            dgvLivros.TabIndex = 5;
            dgvLivros.CellContentClick += dgvLivros_CellContentClick;
            // 
            // btnListarTodos
            // 
            btnListarTodos.BackColor = Color.Transparent;
            btnListarTodos.FlatAppearance.BorderSize = 0;
            btnListarTodos.FlatStyle = FlatStyle.Flat;
            btnListarTodos.Image = (Image)resources.GetObject("btnListarTodos.Image");
            btnListarTodos.Location = new Point(649, 67);
            btnListarTodos.Name = "btnListarTodos";
            btnListarTodos.Size = new Size(35, 23);
            btnListarTodos.TabIndex = 6;
            btnListarTodos.UseVisualStyleBackColor = false;
            btnListarTodos.Click += btnListarTodos_Click;
            // 
            // cmbBuscarLivro
            // 
            cmbBuscarLivro.BackColor = Color.FromArgb(229, 221, 204);
            cmbBuscarLivro.FlatStyle = FlatStyle.Flat;
            cmbBuscarLivro.FormattingEnabled = true;
            cmbBuscarLivro.Location = new Point(369, 67);
            cmbBuscarLivro.Name = "cmbBuscarLivro";
            cmbBuscarLivro.Size = new Size(259, 23);
            cmbBuscarLivro.TabIndex = 7;
            cmbBuscarLivro.TextChanged += cmbBuscarLivro_TextChanged;
            cmbBuscarLivro.Enter += cmbBuscarLivro_Enter;
            cmbBuscarLivro.KeyDown += cmbBuscarLivro_KeyDown;
            cmbBuscarLivro.Leave += cmbBuscarLivro_Leave;
            // 
            // FrmLivros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 240, 229);
            ClientSize = new Size(707, 450);
            Controls.Add(cmbBuscarLivro);
            Controls.Add(btnListarTodos);
            Controls.Add(dgvLivros);
            Controls.Add(btnCadastrarLivro);
            Controls.Add(lblTituloLivros);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLivros";
            Text = "Livros";
            ((System.ComponentModel.ISupportInitialize)dgvLivros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloLivros;
        private Button btnCadastrarLivro;
        private DataGridView dgvLivros;
        private Button btnListarTodos;
        private ComboBox cmbBuscarLivro;
    }
}