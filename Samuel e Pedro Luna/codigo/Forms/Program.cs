using Microsoft.Extensions.DependencyInjection;

namespace Projeto.Forms;

internal static class Program
{
    [STAThread]
    static void Main()
    {

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var PaginaPrincipal = new PaginaPrincipal();
        PaginaPrincipal.Show();
        Application.Run();

    }
}