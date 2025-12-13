namespace Projeto.Models;

public static class Sessao
{
    public static Usuario? UsuarioAtual { get; set; }
    private static bool TemaEscuro = Properties.Settings.Default.TemaEscuro;

}