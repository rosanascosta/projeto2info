using Microsoft.VisualBasic.Logging;

namespace Projeto.Utils;
public static class Constantes
{
    // Lista de tabelas/esportes
    public static readonly string[] tabelas =
    [
        "atletismo", "baseball", "basquete",
            "boxe", "cod", "cs",
            "formula1", "futebol", "futebolamericano",
            "golfe", "judo", "natacao",
            "rocket", "valorant", "xadrez"
    ];

    public static readonly string[] admins =
    [
        "Admin", "admin", "Samuel", "administrador"
    ];

    public static List<Button> ReceberBotoes(Control parent)
    {
        List<Button> botoes = [];
        foreach (Control control in parent.Controls)
        {
            if (control is Button btn)
                botoes.Add(btn);
        }
        return botoes;
    }


    /*public static Dictionary<string, Type> esporteParaClasse = new()
    {
        { "atletismo", typeof(Forms.Atletismo) },
        { "baseball", typeof(Forms.Baseball) },
        { "basquete", typeof(Forms.Basquete) },
        { "boxe", typeof(Forms.Boxe) },
        { "cod", typeof(Forms.Cod) },
        { "cs", typeof(Forms.CS) },
        { "formula1", typeof(Forms.Formula1) },
        { "futebol", typeof(Forms.Futebol) },
        { "futebolamericano", typeof(Forms.FutebolAmericano) },
        { "golfe", typeof(Forms.Golfe) },
        { "jogadores", typeof(Forms.todosJogadores) },
        { "judo", typeof(Forms.Judo) },
        { "natacao", typeof(Forms.Natacao) },
        { "rocket", typeof(Forms.RocketLeague) },
        { "valorant", typeof(Forms.Valorant) },
        { "xadrez", typeof(Forms.Xadrez) }
    }; */

    public static readonly Dictionary<string, string> ImagePaths;

    static Constantes()
    {
        var directories = new[]
        {
            Path.Combine(Application.StartupPath, "Assets", "fotos"),
            Path.Combine(Application.StartupPath, "Assets", "fotos", "esportes"),
            Path.Combine(Application.StartupPath, "Assets", "fotos", "devs"),
            Path.Combine(Application.StartupPath, "Assets", "fotos", "atletas")
        };

        var validExtensions = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };

        var dict = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        foreach (var dir in directories)
        {
            if (!Directory.Exists(dir)) continue;
            foreach (var file in Directory.GetFiles(dir))
            {
                if (!validExtensions.Contains(Path.GetExtension(file))) continue;
                var key = Path.GetFileNameWithoutExtension(file);
                if (!dict.ContainsKey(key))
                    dict[key] = file; // store path only
            }
        }

        ImagePaths = dict;
    }

    // returns null if key not found or file missing
    public static string? GetPath(string key)
    {
        if (key == null) return null;
        return ImagePaths.TryGetValue(key, out var path) && File.Exists(path) ? path : null;
    }



}
