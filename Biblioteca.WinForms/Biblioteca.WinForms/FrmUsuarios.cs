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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios() //Construtor
        {
            InitializeComponent();
            btnListarUsuarios.Image = new Bitmap(btnListarUsuarios.Image, new Size(24, 24));
            cmbBuscarUsuario.Text = "Buscar usuário...";
            cmbBuscarUsuario.ForeColor = Color.Gray;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvUsuarios.CellMouseEnter += dgvUsuarios_CellMouseEnter;
            dgvUsuarios.CellMouseLeave += dgvUsuarios_CellMouseLeave;
            CarregarUsuarios();
            CarregarUsuariosComboBox();
        }

        private void CarregarUsuarios() //Carrega os usuários do banco de dados e configura as colunas da tabela
        {
            using BibliotecaContext contexto = ContextoFactory.Criar();

            dgvUsuarios.DataSource = contexto.Usuarios
                .Select(usuario => new
                {
                    usuario.Id,
                    usuario.Nome,
                    usuario.Telefone,
                    usuario.Email
                })
                .ToList();

            ConfigurarColunaEditar();

            dgvUsuarios.Columns["Id"].Visible = false;
            dgvUsuarios.Columns["Nome"].HeaderText = "Nome";
            dgvUsuarios.Columns["Telefone"].HeaderText = "Telefone";
            dgvUsuarios.Columns["Email"].HeaderText = "E-mail";
            dgvUsuarios.Columns["Nome"].Width = 189;
            dgvUsuarios.Columns["Telefone"].Width = 130;
            dgvUsuarios.Columns["Email"].Width = 250;
            dgvUsuarios.Columns["btnEditar"].Width = 88;
        }

        private void ConfigurarColunaEditar() //Adiciona a coluna de edição à tabela de usuários
        {
            if (dgvUsuarios.Columns["btnEditar"] != null)
                return;

            DataGridViewImageColumn colunaEditar = new DataGridViewImageColumn();
            colunaEditar.Name = "btnEditar";
            colunaEditar.HeaderText = "Editar";
            colunaEditar.Image = RedimensionarIcone(Properties.Resources.editar, 16, 16);
            dgvUsuarios.Columns.Add(colunaEditar);

        }

        private Image RedimensionarIcone(Image imagem, int largura, int altura) //Redimensiona o ícone de edição para o tamanho especificado
        {
            Bitmap novaImagem = new Bitmap(largura, altura);

            using (Graphics g = Graphics.FromImage(novaImagem))
            {
                g.DrawImage(imagem, 0, 0, largura, altura);
            }

            return novaImagem;
        }

        private void dgvUsuarios_CellMouseEnter(object sender, DataGridViewCellEventArgs e) //Aumenta o tamanho do ícone de edição quando o mouse passa sobre ele
        {
            if (e.RowIndex < 0)
                return;

            string coluna = dgvUsuarios.Columns[e.ColumnIndex].Name;

            if (coluna == "btnEditar")
                dgvUsuarios.Rows[e.RowIndex].Cells[coluna].Value =
                    RedimensionarIcone(Properties.Resources.editar, 20, 20);
        }

        private void dgvUsuarios_CellMouseLeave(object sender, DataGridViewCellEventArgs e) //Retorna o tamanho do ícone de edição quando o mouse sai de cima dele
        {
            if (e.RowIndex < 0)
                return;

            string coluna = dgvUsuarios.Columns[e.ColumnIndex].Name;

            if (coluna == "btnEditar")
                dgvUsuarios.Rows[e.RowIndex].Cells[coluna].Value =
                    RedimensionarIcone(Properties.Resources.editar, 16, 16);
        }

        private void CarregarUsuariosComboBox() //Carrega os nomes dos usuários na ComboBox de busca
        {
            using BibliotecaContext contexto = ContextoFactory.Criar();

            var nomes = contexto.Usuarios
                .Select(usuario => usuario.Nome)
                .Distinct()
                .OrderBy(nome => nome)
                .ToList();

            cmbBuscarUsuario.Items.Clear();
            cmbBuscarUsuario.Items.AddRange(nomes.Cast<object>().ToArray());
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e) //Abre o formulário de cadastro de usuário
        {
            using (FrmCadastrarUsuario formulario = new FrmCadastrarUsuario())
            {
                formulario.ShowDialog();
            }

            CarregarUsuarios();
        }

        private void PesquisarUsuarios() //Filtra os usuários na tabela com base no texto digitado na ComboBox de busca
        {
            string pesquisa = cmbBuscarUsuario.Text.Trim();

            if (pesquisa == "Buscar usuário...")
            {
                pesquisa = "";
            }

            using BibliotecaContext contexto = ContextoFactory.Criar();

            dgvUsuarios.DataSource = contexto.Usuarios
                .Where(usuario =>
                    string.IsNullOrWhiteSpace(pesquisa) ||
                    usuario.Nome.Contains(pesquisa) ||
                    usuario.Email.Contains(pesquisa) || usuario.Telefone.Contains(pesquisa))
                .Select(usuario => new
                {
                    usuario.Id,
                    usuario.Nome,
                    usuario.Telefone,
                    usuario.Email
                })
                .ToList();
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e) //Define as ações do botão de editar na tabela de usuários
        {
            if (e.RowIndex < 0)
                return;

            if (dgvUsuarios.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int usuarioId = Convert.ToInt32(
                    dgvUsuarios.Rows[e.RowIndex].Cells["Id"].Value
                );

                using (FrmEditarUsuario formulario = new FrmEditarUsuario(usuarioId))
                {
                    formulario.ShowDialog();
                }

                CarregarUsuarios();
            }
        }

        private void cmbBuscarUsuario_KeyDown(object sender, KeyEventArgs e) //Executa a pesquisa quando a tecla Enter é pressionada
        {
            if (e.KeyCode == Keys.Enter)
            {
                PesquisarUsuarios();
                e.SuppressKeyPress = true;
            }
        }

        private void cmbBuscarUsuario_Enter(object sender, EventArgs e) //Remove o placeholder da ComboBox ao clicar
        {
            if (cmbBuscarUsuario.Text == "Buscar usuário...")
            {
                cmbBuscarUsuario.Text = "";
                cmbBuscarUsuario.ForeColor = Color.Black;
            }
        }

        private void cmbBuscarUsuario_Leave(object sender, EventArgs e) //Retorna o placeholder ao sair
        {
            if (string.IsNullOrWhiteSpace(cmbBuscarUsuario.Text))
            {
                cmbBuscarUsuario.Text = "Buscar usuário...";
                cmbBuscarUsuario.ForeColor = Color.Gray;
            }
        }

        private void btnListarUsuarios_Click(object sender, EventArgs e) //Mostra todos os usuários na tabela
        {
            CarregarUsuarios();
        }

        private void cmbBuscarUsuario_TextChanged(object sender, EventArgs e) //Atualiza a tabela de usuários conforme o texto da ComboBox muda
        {
            PesquisarUsuarios();
        }
    }
}
