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
    public partial class FrmEditarUsuario : Form
    {
        public int UsuarioId { get; set; }

        private bool TelefoneValido(string telefone) //Valida o número de telefone
        {
            string numeros = new string(
                telefone.Where(char.IsDigit).ToArray()
            );

            return numeros.Length == 10 || numeros.Length == 11;
        }

        private bool EmailValido(string email) //Valida o e-mail
        {
            try
            {
                var endereco = new System.Net.Mail.MailAddress(email);
                return endereco.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void CarregarDadosUsuario() //Carrega os dados do usuário a ser editado nos campos do formulário
        {
            using BibliotecaContext contexto = ContextoFactory.Criar();

            Usuario? usuario = contexto.Usuarios
                .FirstOrDefault(u => u.Id == UsuarioId);

            if (usuario == null)
            {
                MessageBox.Show("Usuário não encontrado.");
                Close();
                return;
            }

            txtNome.Text = usuario.Nome;
            txtTelefone.Text = usuario.Telefone;
            txtEmail.Text = usuario.Email;
        }

        public FrmEditarUsuario(int usuarioId) //Construtor que recebe o ID do usuário a ser editado
        {
            InitializeComponent();
            UsuarioId = usuarioId;
            CarregarDadosUsuario();
        }

        private void btnSalvar_Click(object sender, EventArgs e) //Salva as alterações feitas no usuário
        {
            string nome = txtNome.Text.Trim();
            string telefone = txtTelefone.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(nome) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(telefone))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            if (!TelefoneValido(telefone))
            {
                MessageBox.Show(
                    "Informe um telefone válido com DDD (10 ou 11 dígitos)."
                );
                txtTelefone.Focus();
                return;
            }

            if (!EmailValido(email))
            {
                MessageBox.Show("Informe um e-mail válido.");
                txtEmail.Focus();
                return;
            }

            using BibliotecaContext contexto = ContextoFactory.Criar();

            bool emailExiste = contexto.Usuarios
           .Any(usuario => usuario.Email.ToLower() == email.ToLower() && usuario.Id != UsuarioId);

            if (emailExiste)
            {
                MessageBox.Show("Já existe um usuário cadastrado com esse e-mail.");
                txtEmail.Focus();
                return;
            }

            Usuario? usuario = contexto.Usuarios
                .FirstOrDefault(u => u.Id == UsuarioId);

            if (usuario == null)
            {
                MessageBox.Show("Usuário não encontrado.");
                Close();
                return;
            }

            usuario.Nome = nome;
            usuario.Telefone = telefone;
            usuario.Email = email;

            try
            {
                contexto.SaveChanges();
                MessageBox.Show("Usuário atualizado com sucesso!");
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
                MessageBox.Show("Não foi possível atualizar o usuário. Tente novamente.", "Erro ao atualizar usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnCancelar_Click(object sender, EventArgs e) //Fecha o formulário de edição de usuário
        {
            Close();
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e) //Permite apenas números, parênteses, traços e espaços no campo de telefone
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '(' &&
                e.KeyChar != ')' &&
                e.KeyChar != '-' &&
                e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
