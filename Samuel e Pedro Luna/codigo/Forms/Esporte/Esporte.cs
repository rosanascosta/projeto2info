namespace Projeto.Forms;

public partial class Esporte : BaseForm
{
    private readonly string _esporte;
    private readonly List<Image> _ownedImages = [];

    public Esporte(string esporte)
    {
        _esporte = esporte;
        InitializeComponent();
    }
    private void Esporte_Load(object? sender, EventArgs e)
    {
        var panels = AllControls(this)
            .OfType<Panel>()
            .Where(p => p.Name.StartsWith("panel_foto", StringComparison.OrdinalIgnoreCase))
            .OrderBy(p => p.Name)
            .Take(5)
            .ToList();

        var flows = AllControls(this)
            .OfType<FlowLayoutPanel>()
            .Where(p => p.Name.StartsWith("flowLayoutPanel", StringComparison.OrdinalIgnoreCase))
            .OrderBy(p => p.Name)
            .Take(5)
            .ToList();

        string[]? nomes = EsporteService.GetJogadores(_esporte)?.ToArray();
        if (nomes == null || nomes.Length == 0)
        {
            this.Visible = true;
            return;
        }

        for (int i = 0; i < panels.Count && i < nomes.Length; i++)
        {
            var key = EsporteService.GetImages(nomes[i]);
            if (String.IsNullOrEmpty(key)) continue;

            var path = Constantes.GetPath(key);

            if (path == null) continue;

            // create a resized bitmap to the panel current size
            var bmp = ImageService.LoadResizedBitmap(path, panels[i].Size);
            if (bmp == null) continue;

            // assign and keep ownership so we can dispose later
            panels[i].BackgroundImage = bmp;
            panels[i].BackgroundImageLayout = ImageLayout.Stretch;
            _ownedImages.Add(bmp);
        }

        for (int i = 0; i < flows.Count && i < nomes.Length; i++)
            CriarCards(flows[i], i);
    }

    private void CriarCards(FlowLayoutPanel flow, int index)
    {
        var nomes = EsporteService.GetJogadores(_esporte) ?? [];
        var stats = EsporteService.GetStats(nomes[index], _esporte) ?? [];
        var dados = EsporteService.GetDados(EsporteService.GetCodigo(nomes[index]) ?? -1) ?? [];

        var jogador = EsporteService.CriarCardJogador
        (
            nome: nomes[index],
            stats: stats,
            dados: dados,
            index: index
        );

        flow.Controls.Add(jogador);

    }

    private static IEnumerable<Control> AllControls(Control root)
    {
        foreach (Control child in root.Controls)
        {
            yield return child;
            foreach (var desc in AllControls(child)) yield return desc;
        }
    }

}
