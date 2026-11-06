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

namespace Biblioteca.WinForms
{
    public partial class FrmNovoEmprestimo : Form
    {
        public FrmNovoEmprestimo() //Construtor
        {
            InitializeComponent();
            CarregarLivros();
            CarregarUsuarios();
        }

        private void CarregarLivros() //Carrega os livros disponíveis na ComboBox
        {
            using BibliotecaContext contexto = ContextoFactory.Criar();

            cmbLivros.DataSource = contexto.Livros
                .Where(livro => livro.Disponivel && livro.Ativo)
                .ToList();

            cmbLivros.DisplayMember = "Titulo";
            cmbLivros.ValueMember = "Id";
        }

        private void CarregarUsuarios() //Carrega os usuários na ComboBox
        {
            using BibliotecaContext contexto = ContextoFactory.Criar();

            cmbUsuarios.DataSource = contexto.Usuarios
                .ToList();

            cmbUsuarios.DisplayMember = "Nome";
            cmbUsuarios.ValueMember = "Id";
        }

        private void btnCancelar_Click(object sender, EventArgs e) //Fecha o formulário sem salvar
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e) //Salva o empréstimo no banco de dados
        {
            if (cmbLivros.SelectedItem == null || cmbUsuarios.SelectedItem == null)
            {
                MessageBox.Show("Selecione um livro e um usuário.");
                return;
            }

            int livroId = Convert.ToInt32(cmbLivros.SelectedValue);
            int usuarioId = Convert.ToInt32(cmbUsuarios.SelectedValue); 

            using BibliotecaContext contexto = ContextoFactory.Criar();

            Livro? livro = contexto.Livros.Find(livroId);

            if (livro == null)
            {
                MessageBox.Show("Livro não encontrado.");
                return;
            }

            try
            {
                Emprestimo emprestimo = new Emprestimo
                {
                    LivroId = livroId,
                    UsuarioId = usuarioId,
                    DataEmprestimo = DateTime.Now
                };

                contexto.Emprestimos.Add(emprestimo);

                livro.Disponivel = false;
                contexto.SaveChanges();
                MessageBox.Show("Empréstimo registrado com sucesso!");
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
                MessageBox.Show("Não foi possível registrar o empréstimo. Tente novamente.", "Erro ao registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
