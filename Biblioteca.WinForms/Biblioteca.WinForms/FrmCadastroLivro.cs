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
    public partial class FrmCadastroLivro : Form
    {
        public FrmCadastroLivro() //Construtor
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e) //Conecta o botão de salvar ao método SalvarLivro
        {
            SalvarLivro();
        }

        private void SalvarLivro() //Salva o livro no banco de dados após validar os campos e verificar se o livro já existe
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                string.IsNullOrWhiteSpace(txtAutor.Text) ||
                string.IsNullOrWhiteSpace(txtGenero.Text) ||
                string.IsNullOrWhiteSpace(txtAno.Text))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            if (!int.TryParse(txtAno.Text, out int ano) || ano < 1 || ano > DateTime.Now.Year)
            {
                MessageBox.Show("Digite um ano válido de publicação.");
                txtAno.Focus();
                return;
            }

            using BibliotecaContext contexto = ContextoFactory.Criar();

            string titulo = txtTitulo.Text.Trim();

            bool livroExiste = contexto.Livros.Any(l => l.Titulo.ToLower() == titulo.ToLower());

            if (livroExiste)
            {
                MessageBox.Show("Já existe um livro com esse título.");
                txtTitulo.Focus();
                return;
            }

            Livro livro = new Livro
            {
                Titulo = txtTitulo.Text.Trim(),
                Autor = txtAutor.Text.Trim(),
                Genero = txtGenero.Text.Trim(),
                Ano = ano,
                Disponivel = true,
                Ativo = true
            };

            try
            {
                contexto.Livros.Add(livro);
                contexto.SaveChanges();

                MessageBox.Show("Livro cadastrado com sucesso!");
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
                    "Não foi possível cadastrar o livro. Tente novamente.",
                    "Erro ao cadastrar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e) //Fecha o formulário de cadastro de livro
        {
            Close();
        }
        private void txtAno_KeyPress(object sender, KeyPressEventArgs e) //Permite apenas a entrada de números no campo Ano
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
