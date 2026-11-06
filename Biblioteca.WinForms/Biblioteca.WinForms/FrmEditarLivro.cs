using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Biblioteca.WinForms
{
    public partial class FrmEditarLivro : Form
    {
        public int LivroId { get; set; }
        private void CarregarDadosLivro() //Carrega os dados do livro a ser editado nos campos do formulário
        {
            using BibliotecaContext contexto = ContextoFactory.Criar();

            Livro? livro = contexto.Livros
                .FirstOrDefault(l => l.Id == LivroId && l.Ativo);

            if (livro == null)
            {
                MessageBox.Show("Livro não encontrado.");
                Close();
                return;
            }

            txtTitulo.Text = livro.Titulo;
            txtAutor.Text = livro.Autor;
            txtGenero.Text = livro.Genero;
            txtAno.Text = livro.Ano.ToString();
        }
        public FrmEditarLivro(int livroId) //Construtor que recebe o ID do livro a ser editado
        {
            InitializeComponent();
            LivroId = livroId;
            CarregarDadosLivro();
        }

        private void btnSalvar_Click(object sender, EventArgs e) //Salva as alterações feitas no livro
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                string.IsNullOrWhiteSpace(txtAutor.Text) ||
                string.IsNullOrWhiteSpace(txtGenero.Text) ||
                string.IsNullOrWhiteSpace(txtAno.Text))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            if (!int.TryParse(txtAno.Text, out int ano) ||
                ano < 1 ||
                ano > DateTime.Now.Year)
            {
                MessageBox.Show("Digite um ano válido de publicação.");
                txtAno.Focus();
                return;
            }

            using BibliotecaContext contexto = ContextoFactory.Criar();

            Livro? livro = contexto.Livros
                .FirstOrDefault(l => l.Id == LivroId && l.Ativo);

            if (livro == null)
            {
                MessageBox.Show("Livro não encontrado.");
                return;
            }

            string titulo = txtTitulo.Text.Trim();

            bool tituloExiste = contexto.Livros.Any(l =>
                l.Titulo.ToLower() == titulo.ToLower() &&
                l.Id != LivroId &&
                l.Ativo);

            if (tituloExiste)
            {
                MessageBox.Show("Já existe outro livro com esse título.");
                txtTitulo.Focus();
                return;
            }

            livro.Titulo = txtTitulo.Text.Trim();
            livro.Autor = txtAutor.Text.Trim();
            livro.Genero = txtGenero.Text.Trim();
            livro.Ano = ano;

            try
            {
                contexto.SaveChanges();

                MessageBox.Show("Livro atualizado com sucesso!");
                Close();
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

                MessageBox.Show(
                    "Não foi possível atualizar o livro. Tente novamente.",
                    "Erro ao atualizar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e) //Fecha o formulário de edição de livro
        {
            Close();
        }

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e) //Permite apenas a entrada de números no campo de ano
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
