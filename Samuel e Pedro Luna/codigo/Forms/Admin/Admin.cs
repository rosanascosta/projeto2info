namespace Projeto.Forms;

public partial class Admin : BaseForm
{
    bool navegando = false;
    public Admin()
    {
        InitializeComponent();
    }

    public void Admin_Load(object? sender, EventArgs e)
    {
        tabela_usuarios.DefaultCellStyle.ForeColor = Color.Black;
        tabela_usuarios.DefaultCellStyle.Font = new Font("Segoe UI", 10);
        tabela_usuarios.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        tabela_usuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        tabela_usuarios.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        tabela_usuarios.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        tabela_usuarios.DataSource = BD.GetUsuarios();
    }

    private void button_excluirConta_Click(object sender, EventArgs e)
    {

        navegando = true;
        DeleteAdm deleteAdm = new();
        this.Hide();
        deleteAdm.ShowDialog();

    }

    private void button_fecharApp_Click(object sender, EventArgs e)
    {
        if (BD.RemoveAcesso() == 1)
            MessageBox.Show("Aplicativo fechado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        else
            MessageBox.Show("Erro ao fechar o aplicativo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void button_abrirApp_Click(object sender, EventArgs e)
    {
        if (BD.DarAcesso())
            MessageBox.Show("Aplicativo aberto com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        else
            MessageBox.Show("Erro ao abrir o aplicativo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
