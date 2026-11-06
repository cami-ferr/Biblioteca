namespace Biblioteca.WinForms
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal() //Construtor do Form principal
        {
            InitializeComponent();
            AbrirFormulario(new FrmLivros());
        }

        //Botões de navegação
        private void btnLivros_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmLivros());
        }

        private void btnEmprestimos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmEmprestimos());
        }


        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmUsuarios());
        }

        //

        private void AbrirFormulario(Form formulario) //Abre o formulário dentro do painel de conteúdo e altera a cor do botão ativo
        {
            pnlConteudo.Controls.Clear();
            btnLivros.BackColor = formulario is FrmLivros
                ? Color.FromArgb(92, 110, 84)
                : Color.FromArgb(69, 86, 64);

            btnUsuarios.BackColor = formulario is FrmUsuarios
                ? Color.FromArgb(92, 110, 84)
                : Color.FromArgb(69, 86, 64);

            btnEmprestimos.BackColor = formulario is FrmEmprestimos
                ? Color.FromArgb(92, 110, 84)
                : Color.FromArgb(69, 86, 64);

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            pnlConteudo.Controls.Add(formulario);
            formulario.Show();
        }

        private void btnSair_Click_1(object sender, EventArgs e) //Fecha o formulário principal
        {
            Close();
        }

    }
}
