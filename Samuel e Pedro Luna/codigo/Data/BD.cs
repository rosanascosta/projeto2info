namespace Projeto.Data;
public static class BD
{

    private static readonly string con = "server=localhost;user=root;password=;database=trabalho";

    public static MySqlConnection? Conectar()
    {
        try
        {
            var conn = new MySqlConnection(con);
            conn.Open();
            return conn;
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"Erro de conexão. Tente novamente.\n\nDetalhes: {ex.Message}",
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );

            return null;
        }
    }

    public static int UpdatePreferencias(
        int usuario,
        bool atletismo,
        bool baseball,
        bool basquete,
        bool boxe,
        bool cod,
        bool cs,
        bool formula1,
        bool futebol,
        bool futebolAmericano,
        bool golfe,
        bool judo,
        bool natacao,
        bool rocket,
        bool valorant,
        bool xadrez
    )

    {

        using (var conn = BD.Conectar())
        {

            if (conn == null) return -1;
            using (var cmd = new MySqlCommand("updatepreferences", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("p_usuario", usuario);
                cmd.Parameters.AddWithValue("p_atletismo", atletismo);
                cmd.Parameters.AddWithValue("p_baseball", baseball);
                cmd.Parameters.AddWithValue("p_basquete", basquete);
                cmd.Parameters.AddWithValue("p_boxe", boxe);
                cmd.Parameters.AddWithValue("p_cod", cod);
                cmd.Parameters.AddWithValue("p_cs", cs);
                cmd.Parameters.AddWithValue("p_formula1", formula1);
                cmd.Parameters.AddWithValue("p_futebol", futebol);
                cmd.Parameters.AddWithValue("p_futebol_americano", futebolAmericano);
                cmd.Parameters.AddWithValue("p_golfe", golfe);
                cmd.Parameters.AddWithValue("p_judo", judo);
                cmd.Parameters.AddWithValue("p_natacao", natacao);
                cmd.Parameters.AddWithValue("p_rocket", rocket);
                cmd.Parameters.AddWithValue("p_valorant", valorant);
                cmd.Parameters.AddWithValue("p_xadrez", xadrez);

                return cmd.ExecuteNonQuery();
            }
        }

    }

    public static int GetId(string? nome = null, string? email = null)
    {
        string query = "select id from usuario where nome = @nome or email = @email";

        using (var conn = BD.Conectar())
        {
            if (conn == null) return 0;
            using (var cmd = new MySqlCommand(query, conn))
            {

                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);

                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.Read()) return 0;

                    return reader.GetInt32("id");
                }

            }
        }

    }

    public static string GetNome(string? nome = null, string? email = null)
    {
        string query = "select nome from usuario where nome = @nome or email = @email";

        using (var conn = BD.Conectar())
        {
            if (conn == null) return "";
            using (var cmd = new MySqlCommand(query, conn))
            {

                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);

                using (var reader = cmd.ExecuteReader())
                {
                    MessageBox.Show(reader.GetString("nome"));
                    return reader.GetString("nome");
                }

            }
        }

    }

    public static List<string>? GetTodosNomes()
    {
        List<string> nomes = [];
        string query = "select nome from usuario order by nome desc";
        using (var conn = BD.Conectar())
        {
            if (conn == null) return null;
            using (var cmd = new MySqlCommand(query, conn))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        nomes.Add(reader.GetString("nome"));
                    }
                }
            }
        }
        return nomes;
    }


    public static string GetSenhaHash(string? nome = null, string? email = null)
    {
        string query = "select senha from usuario where nome = @nome or email = @email";

        using (var conn = BD.Conectar())
        {
            if (conn == null) return "";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.Read()) return "";
                    return reader.GetString("senha") ?? "";
                }
            }
        }
    }

    public static DataTable? GetUsuarios()
    {
        string query = "select id, nome, email from usuario";
        using (var conn = BD.Conectar())
        {
            if (conn == null) return null;

            using (var adapter = new MySqlDataAdapter(query, conn))
            {
                DataTable usuarios = new();
                adapter.Fill(usuarios);

                return usuarios;
            }
        }
    }

    public static List<bool> GetPreferencias(string nome)
    {
        string query = "select * from preferencias where usuario = @usuario";
        List<bool> preferencias = [];
        using (var conn = BD.Conectar())
        {
            if (conn == null) return preferencias;

            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@usuario", GetId(nome: nome));
                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.Read()) return preferencias;
                    for (int i = 1; i < reader.FieldCount; i++)
                    {
                        preferencias.Add(reader.GetBoolean(i));
                    }
                    return preferencias;
                }
            }
        }
    }

    public static bool Acesso()
    {
        string query = "select ligado from estado";
        using (var conn = BD.Conectar())
        {
            if (conn == null) return false;
            using (var cmd = new MySqlCommand(query, conn))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.Read()) return false;
                    return reader.GetBoolean("ligado");
                }
            }
        }
    }

    public static int RemoveAcesso()
    {
        string query = "update estado set ligado = false";
        using (var conn = BD.Conectar())
        {
            if (conn == null) return -1;
            using (var cmd = new MySqlCommand(query, conn))
            {
                return cmd.ExecuteNonQuery();
            }
        }
    }

    public static bool DarAcesso()
    {
        string query = "update estado set ligado = true";
        using (var conn = BD.Conectar())
        {
            if (conn == null) return false;
            using (var cmd = new MySqlCommand(query, conn))
            {
                return cmd.ExecuteNonQuery() == 1;
            }
        }

    }
}
