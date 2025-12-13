namespace Projeto.Models;

public class Usuario(int id, string nome, string email, string senhahash) : IDisposable
{

    public int Id { get; set; } = id;
    public string? Nome { get; set; } = nome;
    public string? Email { get; set; } = email;
    public string? SenhaHash { get; set; } = senhahash;

    public void Sair()
    {
        Id = -1;
        Nome = null;
        Email = null;
        SenhaHash = null;
        Properties.Settings.Default.UltimoUsuario = null;
        Properties.Settings.Default.TemaEscuro = false;
        Properties.Settings.Default.Save();
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
        GC.Collect();
    }

    ~Usuario() => Dispose();
}