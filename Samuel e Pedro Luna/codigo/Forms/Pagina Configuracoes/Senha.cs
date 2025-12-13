namespace Projeto.Forms;

public partial class Senha : BaseForm
{
    public Senha()
    {
        InitializeComponent();
    }

    private void Senha_Load(object sender, EventArgs e) { }

    private void button_alterar_Click(object sender, EventArgs e)
    {
        string atual = TxtAtual.Text;
        string nova = Conta.HasharSenha(TxtNova.Text);

        if (Conta.AlterarSenha(atual, nova) == 1)
        {
            MessageBox.Show(
                "Sua senha foi alterada com sucesso!",
                "Senha alterada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            Sessao.UsuarioAtual!.SenhaHash = nova;
            Close();
        }
        else
            MessageBox.Show(
                "Erro ao tentar alterar a senha.",
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
    }

    private void button_cancelar_Click(object sender, EventArgs e) => Close();
}
