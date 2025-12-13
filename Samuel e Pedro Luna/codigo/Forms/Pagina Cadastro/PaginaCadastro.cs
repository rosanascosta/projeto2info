namespace Projeto;

public partial class PaginaCadastro : BaseForm
{
    public PaginaCadastro()
    {
        InitializeComponent();
    }

    private void button_enviar_Click(object sender, EventArgs e)
    {
        string usuario = TxtUsuario.Text;
        string email = TxtEmail.Text;
        string senha = Conta.HasharSenha(TxtSenha.Text);


        var validador = new Validador();
        if (!validador.ValidarUsuario(usuario, email))
            return;


        if (Conta.Cadastrar(usuario, email, senha) == 1)
        {

            this.DialogResult = DialogResult.OK;
            MessageBox.Show(
                "Você se cadastrou com sucesso!",
                "Cadastro feito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
