namespace Biblioteca.WinForms
{
    partial class FrmEmprestimos
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
            lblTituloEmprestimos = new Label();
            btnNovoEmprestimo = new Button();
            btnDevolver = new Button();
            dgvEmprestimos = new DataGridView();
            cmbPesquisa = new ComboBox();
            rdbEmAndamento = new RadioButton();
            rdbDevolvidos = new RadioButton();
            rdbTodos = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgvEmprestimos).BeginInit();
            SuspendLayout();
            // 
            // lblTituloEmprestimos
            // 
            lblTituloEmprestimos.AutoSize = true;
            lblTituloEmprestimos.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTituloEmprestimos.ForeColor = Color.FromArgb(41, 47, 39);
            lblTituloEmprestimos.Location = new Point(24, 27);
            lblTituloEmprestimos.Name = "lblTituloEmprestimos";
            lblTituloEmprestimos.Size = new Size(148, 30);
            lblTituloEmprestimos.TabIndex = 1;
            lblTituloEmprestimos.Text = "Empréstimos";
            lblTituloEmprestimos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNovoEmprestimo
            // 
            btnNovoEmprestimo.BackColor = Color.FromArgb(69, 86, 64);
            btnNovoEmprestimo.FlatAppearance.MouseOverBackColor = Color.FromArgb(92, 110, 84);
            btnNovoEmprestimo.FlatStyle = FlatStyle.Flat;
            btnNovoEmprestimo.Font = new Font("Segoe UI", 10F);
            btnNovoEmprestimo.ForeColor = Color.White;
            btnNovoEmprestimo.Location = new Point(26, 85);
            btnNovoEmprestimo.Name = "btnNovoEmprestimo";
            btnNovoEmprestimo.Size = new Size(60, 30);
            btnNovoEmprestimo.TabIndex = 2;
            btnNovoEmprestimo.Text = "Novo";
            btnNovoEmprestimo.UseVisualStyleBackColor = false;
            btnNovoEmprestimo.Click += btnNovoEmprestimo_Click;
            // 
            // btnDevolver
            // 
            btnDevolver.BackColor = Color.FromArgb(69, 86, 64);
            btnDevolver.FlatAppearance.MouseOverBackColor = Color.FromArgb(92, 110, 84);
            btnDevolver.FlatStyle = FlatStyle.Flat;
            btnDevolver.Font = new Font("Segoe UI", 10F);
            btnDevolver.ForeColor = Color.White;
            btnDevolver.Location = new Point(92, 85);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(80, 30);
            btnDevolver.TabIndex = 4;
            btnDevolver.Text = "Devolver";
            btnDevolver.UseVisualStyleBackColor = false;
            btnDevolver.Click += btnDevolver_Click;
            // 
            // dgvEmprestimos
            // 
            dgvEmprestimos.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(245, 240, 229);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(69, 86, 64);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgvEmprestimos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvEmprestimos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmprestimos.BackgroundColor = Color.FromArgb(245, 240, 229);
            dgvEmprestimos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(69, 86, 64);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(69, 86, 64);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvEmprestimos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvEmprestimos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(69, 86, 64);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvEmprestimos.DefaultCellStyle = dataGridViewCellStyle6;
            dgvEmprestimos.EnableHeadersVisualStyles = false;
            dgvEmprestimos.Location = new Point(23, 124);
            dgvEmprestimos.MultiSelect = false;
            dgvEmprestimos.Name = "dgvEmprestimos";
            dgvEmprestimos.ReadOnly = true;
            dgvEmprestimos.RowHeadersVisible = false;
            dgvEmprestimos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmprestimos.Size = new Size(660, 314);
            dgvEmprestimos.TabIndex = 5;
            // 
            // cmbPesquisa
            // 
            cmbPesquisa.BackColor = Color.FromArgb(229, 221, 204);
            cmbPesquisa.FlatStyle = FlatStyle.Flat;
            cmbPesquisa.FormattingEnabled = true;
            cmbPesquisa.Location = new Point(413, 69);
            cmbPesquisa.Name = "cmbPesquisa";
            cmbPesquisa.Size = new Size(270, 23);
            cmbPesquisa.TabIndex = 6;
            cmbPesquisa.Enter += cmbPesquisa_Enter;
            cmbPesquisa.KeyDown += cmbPesquisa_KeyDown;
            cmbPesquisa.Leave += cmbPesquisa_Leave;
            // 
            // rdbEmAndamento
            // 
            rdbEmAndamento.AutoSize = true;
            rdbEmAndamento.FlatAppearance.CheckedBackColor = Color.Black;
            rdbEmAndamento.ForeColor = SystemColors.ControlText;
            rdbEmAndamento.Location = new Point(414, 96);
            rdbEmAndamento.Name = "rdbEmAndamento";
            rdbEmAndamento.Size = new Size(106, 19);
            rdbEmAndamento.TabIndex = 7;
            rdbEmAndamento.Text = "Em andamento";
            rdbEmAndamento.UseVisualStyleBackColor = true;
            rdbEmAndamento.CheckedChanged += rdbEmAndamento_CheckedChanged;
            // 
            // rdbDevolvidos
            // 
            rdbDevolvidos.AutoSize = true;
            rdbDevolvidos.Location = new Point(526, 96);
            rdbDevolvidos.Name = "rdbDevolvidos";
            rdbDevolvidos.Size = new Size(83, 19);
            rdbDevolvidos.TabIndex = 8;
            rdbDevolvidos.Text = "Devolvidos";
            rdbDevolvidos.UseVisualStyleBackColor = true;
            rdbDevolvidos.CheckedChanged += rdbDevolvidos_CheckedChanged;
            // 
            // rdbTodos
            // 
            rdbTodos.AutoSize = true;
            rdbTodos.Location = new Point(615, 96);
            rdbTodos.Name = "rdbTodos";
            rdbTodos.Size = new Size(56, 19);
            rdbTodos.TabIndex = 9;
            rdbTodos.Text = "Todos";
            rdbTodos.UseVisualStyleBackColor = true;
            rdbTodos.CheckedChanged += rdbTodos_CheckedChanged;
            // 
            // FrmEmprestimos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 240, 229);
            ClientSize = new Size(707, 450);
            Controls.Add(rdbTodos);
            Controls.Add(rdbDevolvidos);
            Controls.Add(rdbEmAndamento);
            Controls.Add(cmbPesquisa);
            Controls.Add(dgvEmprestimos);
            Controls.Add(btnDevolver);
            Controls.Add(btnNovoEmprestimo);
            Controls.Add(lblTituloEmprestimos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEmprestimos";
            Text = "Emprestimos";
            ((System.ComponentModel.ISupportInitialize)dgvEmprestimos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloEmprestimos;
        private Button btnNovoEmprestimo;
        private Button btnDevolver;
        private DataGridView dgvEmprestimos;
        private ComboBox cmbPesquisa;
        private RadioButton rdbEmAndamento;
        private RadioButton rdbDevolvidos;
        private RadioButton rdbTodos;
    }
}