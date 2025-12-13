namespace Projeto.Utils;

public class Validador
{
    private readonly string query = "select count(*) from usuario where nome = @nome or email = @email";

    public bool ValidarUsuario(string nome, string email)
    {

        if (!nome.All(char.IsLetterOrDigit)) // arrumar pois a função está dando erro com espaço e acentos
        {
            MessageBox.Show("O nome só pode conter caracteres alfanuméricos",
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            return false;
        }

        try
        {
            if (String.IsNullOrEmpty(email)) return false;

            var endereco = new MailAddress(email);
            if (endereco.Address != email) return false;
        }
        catch
        {
            MessageBox.Show("Insira um email válido.",
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            return false;
        }


        using (var conn = BD.Conectar())
        {
            if (conn == null) return false;
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count != 0)
                {
                    MessageBox.Show("Já existe um usuário com este nome ou email.",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                    return false;
                }
            }
        }

        return true;
    }

    public bool Auth(string usuario, string senha)
    {

        if ((AuthNome(usuario, senha) || AuthEmail(usuario, senha)) && AuthSenha(usuario, senha))
        {

            if (!Conta.Logar(usuario))
            {
                MessageBox.Show(
                    "Tivemos um problema nos nossos servidores. Tente novamente",
                    "Erro de login",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
                return false;
            }
            else return true;

        }

        return false;
    }

    private bool AuthNome(string nome, string senha)
    {
        string UsuarioLido = "";

        string query_user = "select nome as usuario from usuario where nome = @usuario";

        //autenticação usuario
        using (var conn = BD.Conectar())
        {
            if (conn == null) return false;

            using (var cmd = new MySqlCommand(query_user, conn))
            {

                cmd.Parameters.AddWithValue("@usuario", nome);

                using (var data = cmd.ExecuteReader())
                {

                    if (data.Read())
                        UsuarioLido = data.GetString("usuario");

                    else
                        UsuarioLido = "-1";

                    return UsuarioLido == nome;

                }
            }
        }
    }

    private bool AuthEmail(string email, string senha)
    {
        string UsuarioLido = "";
        string query_user = "select email as usuario from usuario where email = @usuario";

        //autenticação usuario
        using (var conn = BD.Conectar())
        {
            if (conn == null) return false;

            using (var cmd = new MySqlCommand(query_user, conn))
            {

                cmd.Parameters.AddWithValue("@usuario", email);

                using (var data = cmd.ExecuteReader())
                {

                    if (data.Read())
                        UsuarioLido = data.GetString("usuario");

                    else
                        UsuarioLido = "-1";


                    return UsuarioLido == email;

                }
            }
        }
    }

    private bool AuthSenha(string usuario, string senha)
    {

        string HashedSenha = "";
        string query_senha = usuario.Contains("@")
        ? "select senha from usuario where email = @usuario"
        : "select senha from usuario where nome = @usuario";

        //autenticação senha
        using (var conn = BD.Conectar())
        {
            if (conn == null) return false;

            using (var cmd = new MySqlCommand(query_senha, conn))
            {

                cmd.Parameters.AddWithValue("@usuario", usuario);

                using (var data = cmd.ExecuteReader())
                {

                    HashedSenha = data.Read() ? data.GetString("senha") : "-1";

                    return Conta.VerificarSenha(HashedSenha, senha);

                }

            }
        }

    }

}
