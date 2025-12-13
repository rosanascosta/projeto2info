namespace Projeto;

public partial class PaginaLogin : BaseForm
{
    public PaginaLogin()
    {
        InitializeComponent();
    }

    private void button_login_Click(object sender, EventArgs e)
    {
        string login = TxtEmailUsuario.Text;
        string? nome = null, email = null;

        if (login.Contains('@'))
            email = TxtEmailUsuario.Text;
        else
            nome = TxtEmailUsuario.Text;

        string senha = TxtSenha.Text;
        var validador = new Validador();

        if (validador.Auth(login, senha))
        {

            this.DialogResult = DialogResult.OK;
            MessageBox.Show(
                "Você fez login com sucesso!",
                "Login feito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );

            Properties.Settings.Default.UltimoUsuario = nome ?? email;
            Properties.Settings.Default.Save();

            this.DialogResult = DialogResult.OK;
            this.Close();

        }
        else
        {
            MessageBox.Show(
            "Erro no login",
            "Erro",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
            );
        }

    }

    private void label2_Click(object sender, EventArgs e)
    {
        var cadastro = new PaginaCadastro();
        this.Close();
        this.DialogResult = DialogResult.Cancel;
        cadastro.ShowDialog();
    }

    private void PaginaLogin_Load(object sender, EventArgs e)
    {

    }
}
