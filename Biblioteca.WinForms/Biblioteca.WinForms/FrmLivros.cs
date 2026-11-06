using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.WinForms
{
    public partial class FrmLivros : Form
    {
        public FrmLivros() //Construtor do formulário de livros
        {
            InitializeComponent();
            dgvLivros.RowHeadersVisible = false;
            dgvLivros.CellMouseEnter += dgvLivros_CellMouseEnter;
            dgvLivros.CellMouseLeave += dgvLivros_CellMouseLeave;
            btnListarTodos.Image = new Bitmap(btnListarTodos.Image, new Size(24, 24));
            cmbBuscarLivro.Text = "Buscar livro...";
            cmbBuscarLivro.ForeColor = Color.Gray;
            CarregarLivros();
            CarregarTitulos();

            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
            Dock = DockStyle.Fill;
        }

        private Image RedimensionarIcone(Image imagem, int largura, int altura) //Método para redimensionar ícones para as colunas de ações da tabela
        {
            Bitmap novaImagem = new Bitmap(largura, altura);

            using (Graphics g = Graphics.FromImage(novaImagem))
            {
                g.DrawImage(imagem, 0, 0, largura, altura);
            }

            return novaImagem;
        }

        private void ConfigurarColunasAcoes() //Criação das colunas de ações (editar e arquivar) na tabela de livros
        {
            if (dgvLivros.Columns["btnEditar"] != null)
                return;

            if (dgvLivros.Columns["btnArquivar"] != null)
                return; 

            DataGridViewImageColumn colunaEditar = new DataGridViewImageColumn();
            colunaEditar.Name = "btnEditar";
            colunaEditar.HeaderText = "Editar";
            colunaEditar.Image = RedimensionarIcone(Properties.Resources.editar, 16, 16);
            dgvLivros.Columns.Add(colunaEditar);

            DataGridViewImageColumn colunaArquivar = new DataGridViewImageColumn();
            colunaArquivar.Name = "btnArquivar";
            colunaArquivar.HeaderText = "Arquivar";
            colunaArquivar.Image = RedimensionarIcone(Properties.Resources.arquivar, 16, 16);
            dgvLivros.Columns.Add(colunaArquivar);
        }

        private void dgvLivros_CellMouseEnter(object sender, DataGridViewCellEventArgs e) //Aumenta o tamanho do ícone quando o mouse passa por cima da célula
        {
            if (e.RowIndex < 0)
                return;

            string coluna = dgvLivros.Columns[e.ColumnIndex].Name;

            if (coluna == "btnEditar")
                dgvLivros.Rows[e.RowIndex].Cells[coluna].Value =
                    RedimensionarIcone(Properties.Resources.editar, 20, 20);

            else if (coluna == "btnArquivar")
                dgvLivros.Rows[e.RowIndex].Cells[coluna].Value =
                    RedimensionarIcone(Properties.Resources.arquivar, 20, 20);
        }

        private void dgvLivros_CellMouseLeave(object sender, DataGridViewCellEventArgs e) // Volta o tamanho do ícone ao normal quando o mouse sai da célula
        {
            if (e.RowIndex < 0)
                return;

            string coluna = dgvLivros.Columns[e.ColumnIndex].Name;

            if (coluna == "btnEditar")
                dgvLivros.Rows[e.RowIndex].Cells[coluna].Value =
                    RedimensionarIcone(Properties.Resources.editar, 16, 16);

            else if (coluna == "btnArquivar")
                dgvLivros.Rows[e.RowIndex].Cells[coluna].Value =
                    RedimensionarIcone(Properties.Resources.arquivar, 16, 16);
        }

        private void CarregarLivros() //Carrega os livros ativos do banco de dados e configura as colunas da tabela
        {
            using BibliotecaContext contexto = ContextoFactory.Criar();

            dgvLivros.DataSource = contexto.Livros
                .Where(livro => livro.Ativo)
                .Select(livro => new
                {
                    livro.Id,
                    livro.Titulo,
                    livro.Autor,
                    livro.Genero,
                    livro.Ano,
                    livro.Disponivel
                })
                .ToList();

            ConfigurarColunasAcoes();

            dgvLivros.Columns["Id"].Visible = false;

            dgvLivros.Columns["Titulo"].HeaderText = "Título";
            dgvLivros.Columns["Titulo"].Width = 130;

            dgvLivros.Columns["Autor"].HeaderText = "Autor";
            dgvLivros.Columns["Autor"].Width = 150;

            dgvLivros.Columns["Genero"].HeaderText = "Gênero";
            dgvLivros.Columns["Genero"].Width = 80;

            dgvLivros.Columns["Ano"].HeaderText = "Ano";
            dgvLivros.Columns["Ano"].Width = 60;

            dgvLivros.Columns["Disponivel"].HeaderText = "Disponível";
            dgvLivros.Columns["Disponivel"].Width = 90;

            dgvLivros.Columns["btnEditar"].Width = 73;
            dgvLivros.Columns["btnArquivar"].Width = 74;

        }

        private void CarregarTitulos() //Carrega os títulos dos livros ativos na ComboBox de busca
        {
            using BibliotecaContext contexto = ContextoFactory.Criar();

            var titulos = contexto.Livros
                .Where(livro => livro.Ativo)
                .Select(livro => livro.Titulo)
                .Distinct()
                .OrderBy(titulo => titulo)
                .ToList();

            cmbBuscarLivro.Items.Clear();
            cmbBuscarLivro.Items.AddRange(titulos.Cast<object>().ToArray());
        }
        private void dgvLivros_CellContentClick(object sender, DataGridViewCellEventArgs e) //Define as ações dos botões de editar e arquivar na tabela de livros
        {
            if (e.RowIndex < 0)
                return;

            if (dgvLivros.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int livroId = Convert.ToInt32(
                    dgvLivros.Rows[e.RowIndex].Cells["Id"].Value
                );

                using (FrmEditarLivro formulario = new FrmEditarLivro(livroId))
                {
                    formulario.ShowDialog();
                }

                CarregarLivros();
            }

            else if (dgvLivros.Columns[e.ColumnIndex].Name == "btnArquivar")
            {
                int livroId = Convert.ToInt32(
                    dgvLivros.Rows[e.RowIndex].Cells["Id"].Value
                    );

                DialogResult resposta = MessageBox.Show(
                "Tem certeza de que deseja arquivar este livro?",
                "Confirmar arquivamento",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                if (resposta != DialogResult.Yes)
                {
                    return;
                }

                using BibliotecaContext contexto = ContextoFactory.Criar();

                Livro? livro = contexto.Livros
                    .FirstOrDefault(l => l.Id == livroId && l.Ativo);

                if (livro == null)
                {
                    MessageBox.Show("Livro não encontrado.");
                    CarregarLivros();
                    return;
                }

                bool emprestado = contexto.Emprestimos
                    .Any(e => e.LivroId == livroId && e.DataDevolucao == null);

                if (emprestado)
                {
                    MessageBox.Show(
                        "Não é possível arquivar um livro que possui um empréstimo ativo."
                    );
                    return;
                }

                try
                {
                    livro.Ativo = false;
                    contexto.SaveChanges();
                    MessageBox.Show("Livro arquivado com sucesso!");
                    CarregarLivros();
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
                    MessageBox.Show("Não foi possível arquivar o livro. Tente novamente.", "Erro ao arquivar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnCadastrarLivro_Click(object sender, EventArgs e) //Abre o form de cadastro de livro e atualiza a tabela após o cadastro
        {
            using (FrmCadastroLivro formulario = new FrmCadastroLivro())
            {
                formulario.ShowDialog();
            }

            CarregarLivros();
        }

        private void PesquisarLivros() //Filtra os livros na tabela com base no título digitado na ComboBox de busca
        {
            string titulo = cmbBuscarLivro.Text.Trim();

            if (titulo == "Buscar livro...")
            {
                titulo = "";
            }

            using BibliotecaContext contexto = ContextoFactory.Criar();

            dgvLivros.DataSource = contexto.Livros
                .Where(livro => livro.Ativo &&
                    (string.IsNullOrWhiteSpace(titulo) ||
                     livro.Titulo.Contains(titulo)))
                .Select(livro => new
                {
                    livro.Id,
                    livro.Titulo,
                    livro.Autor,
                    livro.Genero,
                    livro.Ano,
                    livro.Disponivel
                })
                .ToList();
        }

        private void btnListarTodos_Click(object sender, EventArgs e) //Mostra todos os livros ativos na tabela
        {
            CarregarLivros();
        }

        private void cmbBuscarLivro_KeyDown(object sender, KeyEventArgs e) //Realiza a busca ao pressionar a tecla Enter na ComboBox de busca
        {
            if (e.KeyCode == Keys.Enter)
            {
                PesquisarLivros();
                e.SuppressKeyPress = true;
            }
        }

        private void cmbBuscarLivro_Enter(object sender, EventArgs e) //Remove o placeholder ao entrar no campo de busca
        {
            if (cmbBuscarLivro.Text == "Buscar livro...")
            {
                cmbBuscarLivro.Text = "";
                cmbBuscarLivro.ForeColor = Color.Black;
            }
        }

        private void cmbBuscarLivro_Leave(object sender, EventArgs e) //Retorna o placeholder ao sair do campo de busca
        {
            if (string.IsNullOrWhiteSpace(cmbBuscarLivro.Text))
            {
                cmbBuscarLivro.Text = "Buscar livro...";
                cmbBuscarLivro.ForeColor = Color.Gray;
            }
        }

        private void cmbBuscarLivro_TextChanged(object sender, EventArgs e) //Realiza a busca ao alterar o texto na ComboBox de busca
        {
            PesquisarLivros();
        }
    }
}
