using Biblioteca;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.WinForms
{
    public partial class FrmEmprestimos : Form
    {
        public FrmEmprestimos() //Construtor
        {
            InitializeComponent();
            cmbPesquisa.Text = "Digite um título ou usuário...";
            cmbPesquisa.ForeColor = Color.Gray;
            rdbTodos.Checked = true;
            CarregarEmprestimos();
        }

        private void cmbPesquisa_Enter(object sender, EventArgs e) //Remove o placeholder ao clicar
        {
            if (cmbPesquisa.Text == "Digite um título ou usuário...")
            {
                cmbPesquisa.Text = "";
                cmbPesquisa.ForeColor = Color.Black;
            }
        }

        private void cmbPesquisa_Leave(object sender, EventArgs e) //Retorna o placeholder ao sair
        {
            if (string.IsNullOrWhiteSpace(cmbPesquisa.Text))
            {
                cmbPesquisa.Text = "Digite um título ou usuário...";
                cmbPesquisa.ForeColor = Color.Gray;
            }
        }

        private void FiltrarEmprestimos() //Responsável por filtrar os empréstimos com base na pesquisa e na situação selecionada nos botões
        {
            string pesquisa = cmbPesquisa.Text.Trim();

            if (pesquisa == "Digite um título ou usuário...")
            {
                pesquisa = "";
            }

            using BibliotecaContext contexto = ContextoFactory.Criar();

            var consulta = contexto.Emprestimos
                .Select(emprestimo => new
                {
                    emprestimo.Id,
                    Livro = emprestimo.Livro.Titulo,
                    Usuario = emprestimo.Usuario.Nome,
                    DataEmprestimo = emprestimo.DataEmprestimo,
                    DataDevolucao = emprestimo.DataDevolucao,
                    Situacao = emprestimo.DataDevolucao == null
                        ? "Em andamento"
                        : "Devolvido"
                });

            if (!string.IsNullOrWhiteSpace(pesquisa))
            {
                consulta = consulta.Where(emprestimo =>
                    emprestimo.Livro.Contains(pesquisa) ||
                    emprestimo.Usuario.Contains(pesquisa));
            }

            if (rdbEmAndamento.Checked)
                consulta = consulta.Where(emprestimo => emprestimo.DataDevolucao == null);

            else if (rdbDevolvidos.Checked)
                consulta = consulta.Where(emprestimo => emprestimo.DataDevolucao != null);

            dgvEmprestimos.DataSource = consulta.ToList();
            dgvEmprestimos.Columns["Id"].Visible = false;
            dgvEmprestimos.Columns["Usuario"].HeaderText = "Usuário";
            dgvEmprestimos.Columns["DataEmprestimo"].HeaderText = "Emprestado em:";
            dgvEmprestimos.Columns["DataDevolucao"].HeaderText = "Devolvido em:";
            dgvEmprestimos.Columns["Situacao"].HeaderText = "Situação";
        }

        private void CarregarEmprestimos() //Carrega os empréstimos no ComboBox de pesquisa
        {
            using BibliotecaContext contexto = ContextoFactory.Criar();

            var emprestimos = contexto.Emprestimos
                .Select(emprestimo => new
                {
                    emprestimo.Livro.Titulo,
                    NomeUsuario = emprestimo.Usuario.Nome,
                    emprestimo.DataEmprestimo
                })
                .ToList();

            cmbPesquisa.Items.Clear();

            foreach (var emprestimo in emprestimos)
            {
                string item = $"{emprestimo.Titulo}, " +
                              $"{emprestimo.NomeUsuario}, " +
                              $"{emprestimo.DataEmprestimo:dd/MM/yyyy}";

                cmbPesquisa.Items.Add(item);
            }
        }
        private void cmbPesquisa_KeyDown(object sender, KeyEventArgs e) //Realiza a pesquisa ao pressionar Enter
        {
            if (e.KeyCode == Keys.Enter)
            {
                FiltrarEmprestimos();
                e.SuppressKeyPress = true;
            }
        }
        private void btnNovoEmprestimo_Click(object sender, EventArgs e) //Abre o formulário de novo empréstimo e atualiza a lista após o fechamento
        {
            using FrmNovoEmprestimo formulario = new FrmNovoEmprestimo();

            formulario.ShowDialog();

            FiltrarEmprestimos();
        }

        private void btnDevolver_Click(object sender, EventArgs e) //Registra a devolução do livro selecionado
        {
            if (dgvEmprestimos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um empréstimo.");
                return;
            }

            int emprestimoId = Convert.ToInt32(
                dgvEmprestimos.SelectedRows[0].Cells["Id"].Value
            );

            using BibliotecaContext contexto = ContextoFactory.Criar();

            Emprestimo? emprestimo = contexto.Emprestimos
                .Include(e => e.Livro)
                .FirstOrDefault(e => e.Id == emprestimoId);

            if (emprestimo == null)
            {
                MessageBox.Show("Empréstimo não encontrado.");
                return;
            }

            if (emprestimo.DataDevolucao != null)
            {
                MessageBox.Show("Este livro já foi devolvido.");
                return;
            }

            DialogResult confirmacao = MessageBox.Show("Deseja realmente registrar a devolução deste livro?", "Confirmar devolução",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (confirmacao == DialogResult.No)
            {
                return;
            }

            try
            {
                emprestimo.DataDevolucao = DateTime.Now;
                emprestimo.Livro.Disponivel = true;
                contexto.SaveChanges();
                MessageBox.Show("Livro devolvido com sucesso!");
                FiltrarEmprestimos();
            }
            catch (Exception ex)
            {
                try
                {
                    LogErros.Registrar(ex);
                }
                catch
                {

                }
                MessageBox.Show("Não foi possível registrar a devolução. Tente novamente.", "Erro ao registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdbEmAndamento_CheckedChanged(object sender, EventArgs e) //Filtra os empréstimos para exibir apenas os em andamento
        {
            if (rdbEmAndamento.Checked)
                FiltrarEmprestimos();
        }

        private void rdbDevolvidos_CheckedChanged(object sender, EventArgs e) //Filtra os empréstimos para exibir apenas os devolvidos
        {
            if (rdbDevolvidos.Checked)
                FiltrarEmprestimos();   
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e) //Filtra os empréstimos para exibir todos
        {
            if (rdbTodos.Checked)
                FiltrarEmprestimos();   
        }
    }
}
