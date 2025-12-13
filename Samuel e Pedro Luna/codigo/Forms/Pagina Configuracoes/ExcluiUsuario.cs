namespace Projeto.Forms;

public partial class ExcluiUsuario : BaseForm
{
    public ExcluiUsuario()
    {
        InitializeComponent();
    }

    private void button_apagar_Click(object sender, EventArgs e)
    {
        string senha = TxtSenha.Text;

        DialogResult apagar = MessageBox.Show(
            "Essa ação não pode ser desfeita! Está certo disso?",
            "Confirmação",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
            );

        if (apagar == DialogResult.Yes && Conta.ExcluirConta(senha) == 1)
        {
            Sessao.UsuarioAtual!.Sair();
            MessageBox.Show(
                    "Conta excluida com sucesso.",
                    "Excluida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            Application.Restart();
        }
        else
            MessageBox.Show(
                    "Erro ao tentar excluir a conta, verifique a senha inserida.",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
    }
}
