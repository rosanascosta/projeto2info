namespace Projeto.Forms;
public partial class Configuracoes : BaseForm
{
    public Configuracoes()
    {
        InitializeComponent();
    }

    private void button_consultar_Click(object sender, EventArgs e)
    {
        DialogResult aviso = MessageBox.Show(
            "Cuidado, informações pessoais de sua conta a seguir. \nDeseja continuar?",
            "Aviso",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );
        if (aviso == DialogResult.Yes)
        {
            MessageBox.Show(
                $"Id de conta: {Sessao.UsuarioAtual!.Id} \n" +
                $"Nome de usuário: {Sessao.UsuarioAtual!.Nome} \n" +
                $"Email: {Sessao.UsuarioAtual.Email}",
                "Informações",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }
    }

    private void button_mudarsenha_Click(object sender, EventArgs e)
    {
        Senha senha = new();

        senha.ShowDialog();
    }

    private void button_excluirconta_Click(object sender, EventArgs e)
    {
        ExcluiUsuario excluiUsuario = new();

        excluiUsuario.ShowDialog();
    }

}
