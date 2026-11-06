using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace Biblioteca.WinForms
{
    public partial class FrmCadastrarUsuario : Form
    {
        public FrmCadastrarUsuario() //Construtor
        {
            InitializeComponent();
        }

        private bool TelefoneValido(string telefone) //Validação do número de telefone
        {
            string numeros = new string(
                telefone.Where(char.IsDigit).ToArray()
            );

            return numeros.Length == 10 || numeros.Length == 11;
        }

        private bool EmailValido(string email) //Validação do e-mail
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

        private void btnSalvar_Click(object sender, EventArgs e) //Salva o usuário no banco de dados após validar informações
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
            .Any(usuario => usuario.Email.ToLower() == email.ToLower());

            if (emailExiste)
            {
                MessageBox.Show("Já existe um usuário cadastrado com esse e-mail.");
                txtEmail.Focus();
                return;
            }

            Usuario usuario = new Usuario
            {
                Nome = nome,
                Telefone = telefone,
                Email = email
            };

            try
            {
                contexto.Usuarios.Add(usuario);
                contexto.SaveChanges();

                MessageBox.Show("Usuário cadastrado com sucesso!");
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
                MessageBox.Show("Não foi possível cadastrar o usuário. Tente novamente.", "Erro ao cadastrar.",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



            
        }

        private void btnCancelar_Click(object sender, EventArgs e) //Fecha o formulário
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
