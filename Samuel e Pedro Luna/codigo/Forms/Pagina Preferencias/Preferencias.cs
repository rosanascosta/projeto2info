namespace Projeto;

public partial class Preferencias : BaseForm
{
    public Preferencias()
    {
        InitializeComponent();
    }



    private void button_salvar_Click(object sender, EventArgs e)
    {
        bool atletismo = check_atletismo.Checked;
        bool baseball = check_baseball.Checked;
        bool basquete = check_basquete.Checked;
        bool boxe = check_boxe.Checked;
        bool cod = check_cod.Checked;
        bool cs = check_cs.Checked;
        bool formula1 = check_formula1.Checked;
        bool futebol = check_futebol.Checked;
        bool futebol_americano = check_futebol_americano.Checked;
        bool golfe = check_golfe.Checked;
        bool judo = check_judo.Checked;
        bool natacao = check_natacao.Checked;
        bool rocket = check_rocket.Checked;
        bool valorant = check_valorant.Checked;
        bool xadrez = check_xadrez.Checked;

        if (BD.UpdatePreferencias(
            Sessao.UsuarioAtual!.Id, atletismo, baseball, basquete,
            boxe, cod, cs,
            formula1, futebol, futebol_americano,
            golfe, judo, natacao,
            rocket, valorant, xadrez
            ) == 1)
        {

            this.DialogResult = DialogResult.OK;
            MessageBox.Show(
                "Suas preferências foram atualizadas com sucesso!",
                "Preferências atualizadas",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
            this.Close();            

        }
        else MessageBox.Show(
                "Erro na atualização das preferências",
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
    }
    private void button_cancelar_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }

    private void Preferências_Load(object sender, EventArgs e)
    {

        var checkboxMap = new Dictionary<string, CheckBox>
            {
                { "atletismo", check_atletismo },
                { "baseball", check_baseball },
                { "basquete", check_basquete },
                { "boxe", check_boxe },
                { "cod", check_cod },
                { "cs", check_cs },
                { "formula1", check_formula1 },
                { "futebol", check_futebol },
                { "futebolamericano", check_futebol_americano },
                { "golfe", check_golfe },
                { "judo", check_judo },
                { "natacao", check_natacao },
                { "rocket", check_rocket },
                { "valorant", check_valorant },
                { "xadrez", check_xadrez }
            };

        string query = "select * from preferencias where usuario = @usuario";

        using (var conn = BD.Conectar())
        {
            if (conn == null) return;

            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@usuario", Sessao.UsuarioAtual!.Id);

                using (var data = cmd.ExecuteReader())
                {
                    if (data.Read())
                    {
                        foreach (string tabela in Constantes.tabelas)
                        {
                            bool valor = data.GetBoolean(tabela);

                            if (valor && checkboxMap.TryGetValue(tabela, out CheckBox? value))
                                value.Checked = true;
                        }
                    }
                }
            }

        }

    }

}
