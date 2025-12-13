using Microsoft.Graph.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projeto.Utils;

public static class Conta
{

    private static Usuario? usuario { get; set; }
    private static readonly PasswordHasher<object> hasher = new();
    private static readonly string query = "select id, nome, email, senha from usuario where nome = @usuario or email = @usuario";

    public static string HasharSenha(string senha) => hasher.HashPassword("", senha);

    public static bool VerificarSenha(string hash, string senha)
    {

        var resultado = hasher.VerifyHashedPassword("", hash, senha); // se bugado, formato do banco de dados está ERRADO
        return resultado == PasswordVerificationResult.Success;

    }

    public static int Cadastrar(string usuario, string email, string senha)
    {

        string insertcadastro = "insert into usuario (nome, email, senha) values (@usuario, @email, @senha)";

        using (var conn = BD.Conectar())
        {
            if (conn == null) return 0;

            using (var cmd = new MySqlCommand(insertcadastro, conn))
            {

                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);
                return cmd.ExecuteNonQuery();

            }
        }
    }

    public static bool Logar(string user)
    {

        if (user is null) return false;

        using (var conn = BD.Conectar())
        {
            if (conn is null) return false;

            using (var cmd = new MySqlCommand(query, conn))
            {

                cmd.Parameters.AddWithValue("@usuario", user);

                cmd.ExecuteNonQuery();

                using (var data = cmd.ExecuteReader())
                {
                    if (data.Read())
                    Sessao.UsuarioAtual = new(
                        data.GetInt32("id"),
                        data.GetString("nome").ToString(),
                        data.GetString("email").ToString(),
                        data.GetString("senha").ToString()
                        );

                    //return Sessao.UsuarioAtual.Nome == user || Sessao.UsuarioAtual.Email == user;
                    return true;
                }
            }
        }

    }

    public static int AlterarSenha(string senha, string nova)
    {
        string hash;
        string query = "select senha from usuario where nome = @nome";
        bool resultsenha;

        using (var conn = BD.Conectar())
        {

            if (conn == null) return 0;

            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@nome", Sessao.UsuarioAtual!.Nome);
                hash = cmd.ExecuteScalar().ToString() ?? "";

                if (!Conta.VerificarSenha(hash, senha)) return -1;
                else resultsenha = true;
            }
            using (var cmd = new MySqlCommand("updatesenha", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_nome", Sessao.UsuarioAtual.Nome);
                cmd.Parameters.AddWithValue("atual", resultsenha);
                cmd.Parameters.AddWithValue("nova", nova);

                return cmd.ExecuteNonQuery();
            }
        }

    }

    public static int ExcluirConta(string senha)
    {
        bool resultsenha;
        using (var conn = BD.Conectar())
        {
            if (conn == null) return 0;

            using (var cmd = new MySqlCommand("deleteconta", conn))
            {
                resultsenha = Conta.VerificarSenha(Sessao.UsuarioAtual!.SenhaHash!, senha);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_nome", Sessao.UsuarioAtual.Nome);
                cmd.Parameters.AddWithValue("_email", Sessao.UsuarioAtual.Email);
                cmd.Parameters.AddWithValue("senha", resultsenha);

                return cmd.ExecuteNonQuery();
            }
        }
    }

    public static int ExcluirContaPorAdmin(int id)
    {
        using (var conn = BD.Conectar())
        {
            if (conn == null) return 0;
            using (var cmd = new MySqlCommand("deleteContaAdmin", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_id", id);
                return cmd.ExecuteNonQuery();
            }
        }
    }
}