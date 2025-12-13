namespace Projeto.Forms;

public partial class DeleteAdm : BaseForm
{
    public DeleteAdm()
    {
        InitializeComponent();
    }
    private void DeleteAdm_Load(object sender, EventArgs e)
    {
        var nomes = BD.GetTodosNomes();
        if (nomes is null) return;
        foreach (var conta in nomes)
        {
            if (Constantes.admins.Contains(conta.ToLower())) continue;
            combo_contas.Items.Add(conta);
        }
    }

    private void button_excluir_Click(object sender, EventArgs e)
    {
        string nome = combo_contas.SelectedItem?.ToString() ?? "";
        if (nome == "")
        {
            MessageBox.Show("Selecione uma conta para excluir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (Utils.Conta.ExcluirContaPorAdmin(BD.GetId(nome)) == 2)
        {

            MessageBox.Show("Conta excluída com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            combo_contas.Items.Remove(nome);

        }
        else
        {
            MessageBox.Show("Erro ao excluir a conta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
