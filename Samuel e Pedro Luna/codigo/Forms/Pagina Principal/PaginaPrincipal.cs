using System.Drawing;
using System.IO;
using SkiaSharp;
using System.Globalization;
using System.Configuration;

namespace Projeto;

public partial class PaginaPrincipal : BaseForm
{
    private bool navegando = false;
    private readonly Dictionary<Button, string> botaoParaEsporte = [];

    private Image LoadAndResize(string path, Size size)
    {
        try
        {
            using var fs = File.OpenRead(path);
            using var original = Image.FromStream(fs, true, true);
            var resized = new Bitmap(size.Width, size.Height);
            using (var g = Graphics.FromImage(resized))
            {
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.DrawImage(original, 0, 0, size.Width, size.Height);
            }
            return resized;
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(
                $"Erro ao carregar a imagem em '{path}' por causa de {ex.Message}. Tentando método alternativo...",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            using var fs2 = File.OpenRead(path);
            using var codec = SKCodec.Create(fs2);
            if (codec is null)
                throw;

            using var originalBitmap = SKBitmap.Decode(codec);

            // PRESERVAR COLOR TYPE / ALPHA / COLORSPACE !!!
            var info = new SKImageInfo(
                size.Width,
                size.Height,
                originalBitmap.ColorType,
                originalBitmap.AlphaType,
                originalBitmap.ColorSpace
            );

            using var resizedSk = originalBitmap.Resize(info, SKFilterQuality.High);
            if (resizedSk is null)
                throw new ArgumentException("Não foi possível decodificar a imagem.");

            using var image = SKImage.FromBitmap(resizedSk);
            using var data = image.Encode(SKEncodedImageFormat.Png, 100);
            using var ms = new MemoryStream();
            data.SaveTo(ms);
            ms.Position = 0;
            return Image.FromStream(ms);
        }

    }


    private void Esporte(string esporte)
    {
        navegando = true;

        Esporte esporteForm = new(esporte);
        esporteForm.Show();

        navegando = false;
    }

    private void SemConta()
    {

        foreach (var botao in Constantes.ReceberBotoes(this))
        {
            if (botao.Name is not ("button_baseball" or "button_basquete" or "button_futebol"))
                botao.Visible = false;
            else
                botao.Visible = true;
        }


    }

    private void Deslogar()
    {
        Properties.Settings.Default.UltimoUsuario = null;
        Sessao.UsuarioAtual?.Sair();
        label_bemvindo.Text = "Bem-vindo ao site";
        menu_admin.Visible = false;
        menu_sair.Visible = false;
        menu_opcoes.Visible = false;
        menu_cadastro.Visible = true;
        menu_login.Visible = true;
        SemConta();
    }

    private void Logar()
    {
        if (Constantes.admins.Contains(Sessao.UsuarioAtual?.Nome))
        {
            menu_admin.Visible = true;
            foreach (var btn in botaoParaEsporte.Keys)
                btn.Visible = true;
        }
        else
        {
            // Esconder todos os botões por padrão
            foreach (var btn in botaoParaEsporte.Keys)
                btn.Visible = false;

            var preferencias = BD.GetPreferencias(Sessao.UsuarioAtual?.Nome);

            if (preferencias != null)
            {
                // Ordem deve corresponder à ordem de inserção no construtor
                var esportes = Constantes.tabelas.ToList();

                int i = 0;
                foreach (bool pref in preferencias)
                {
                    if (i >= esportes.Count) break;

                    string esporte = esportes[i++];
                    var kv = botaoParaEsporte.FirstOrDefault(p => p.Value == esporte);

                    // kv.Key será null se não encontrado
                    if (kv.Key is not null)
                        kv.Key.Visible = pref;
                }
            }
        }

        menu_sair.Visible = true;
        menu_opcoes.Visible = true;
        menu_cadastro.Visible = false;
        menu_login.Visible = false;
        label_bemvindo.Text = $"Bem-vindo, {Sessao.UsuarioAtual?.Nome}";
    }

    public PaginaPrincipal()
    {
        InitializeComponent();
        this.FormClosed += PaginaPrincipal_FormClosed;

        botaoParaEsporte = new Dictionary<Button, string>
            {
                { button_atletismo, "atletismo" },
                { button_baseball, "baseball" },
                { button_basquete, "basquete" },
                { button_boxe, "boxe" },
                { button_cod, "cod" },
                { button_cs, "cs" },
                { button_futebol, "futebol" },
                { button_futebolAmericano, "futebolamericano" },
                { button_formula1, "formula1" },
                { button_golfe, "golfe" },
                { button_judo, "judo" },
                { button_natacao, "natacao" },
                { button_rocket, "rocket" },
                { button_valorant, "valorant" },
                { button_xadrez, "xadrez" }
            };
    }


    private void PaginaPrincipal_FormClosed(object? sender, EventArgs e)
    {
        if (!navegando) Application.Exit();

        foreach (var item in menuStrip1.Items.OfType<ToolStripMenuItem>())
            item.Image?.Dispose();

        foreach (var btn in botaoParaEsporte.Keys)
            btn.BackgroundImage?.Dispose();

        foreach (var btn in botaoParaEsporte.Keys)
        {
            btn.BackgroundImage?.Dispose();
            btn.BackgroundImage = null;
        }
    }

    private void menu_cadastro_Click(object sender, EventArgs e)
    {

        navegando = true;
        PaginaCadastro cadastro = new();
        this.Hide();
        cadastro.ShowDialog();
        this.Show();

    }

    private void menu_login_Click(object sender, EventArgs e)
    {

        navegando = true;
        PaginaLogin login = new();
        this.Hide();
        login.ShowDialog();
        
        if (login.DialogResult == DialogResult.OK)
            Logar();

        this.Show();
    }

    private void menu_preferencias_Click(object sender, EventArgs e)
    {

        Preferencias preferencias = new();
        preferencias.ShowDialog();
        if (preferencias.DialogResult == DialogResult.OK)
            Logar();
    }

    private void menu_sair_Click(object sender, EventArgs e)
    {
        DialogResult confirma = MessageBox.Show(
            "Deseja sair da sua conta?",
            "Sair",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

        if (confirma == DialogResult.Yes)
            Deslogar();
    }

    private void PaginaPrincipal_Load(object sender, EventArgs e)
    {
        Image imagem, redimensionada;
        
        foreach (ToolStripMenuItem item in menuStrip1.Items)
        {
            item.ImageScaling = ToolStripItemImageScaling.None;
            var key = item.Name?.Replace("menu_", "") ?? "";
            if (!string.IsNullOrEmpty(key) && Constantes.ImagePaths.TryGetValue(key, out var imagePath) && !string.IsNullOrEmpty(imagePath))
            {
                imagem = LoadAndResize(imagePath, new Size(64, 64));
                if (item.Image != null)
                {
                    item.Image.Dispose();
                    item.Image = null;
                }

                item.Image = imagem;
            }
            item.ImageAlign = ContentAlignment.MiddleCenter;
            item.TextImageRelation = TextImageRelation.ImageAboveText;
        }

        var ultimo = Properties.Settings.Default.UltimoUsuario;
        Image imagemBtn;

        foreach (Button btn in botaoParaEsporte.Keys)
        {
            if (btn is null) continue;

            if (!botaoParaEsporte.TryGetValue(btn, out var esporte) || string.IsNullOrEmpty(esporte))
                continue;

            var path = Constantes.GetPath(esporte);
            if (string.IsNullOrEmpty(path))
                continue;

            imagemBtn = null;
            try
            {
                imagemBtn = System.Drawing.Image.FromFile(path);
            }
            catch (Exception)
            {
                continue;
            }

            if (imagemBtn is not null)
            {
                btn.BackgroundImage = imagemBtn;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.TextAlign = ContentAlignment.BottomCenter;
                btn.TextImageRelation = TextImageRelation.ImageBeforeText;
                btn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            }
        }

        // fluxo 1: site em manutenção
        if (!BD.Acesso() && !Constantes.admins.Contains(ultimo))
        {
            using var dialog = new Dialog(
                "O site está em manutenção. Tente novamente mais tarde.",
                "Logar como admin",
                "Sair"
            );

            var r = dialog.ShowDialog();

            if (r == DialogResult.Cancel)
            {
                BeginInvoke(new Action(() => Application.Exit()));
                return; // aborta TUDO
            }

            // logar como admin
            navegando = true;

            using (var login = new PaginaLogin())
                login.ShowDialog();

            // após fechar a tela de login admin, esse form principal NÃO deve continuar existindo
            // pq ele nasceu “pré-login”
            BeginInvoke(new Action(() => Close()));
            return;
        }

        // fluxo 2: auto-login normal (sem manutenção)
        if (!string.IsNullOrEmpty(ultimo) && Conta.Logar(ultimo))
            Logar();

        else
            SemConta();
    }

    private void menu_admin_Click(object sender, EventArgs e)
    {
        Admin admin = new();
        admin.Show();
    }

    private void menu_fechar_Click(object sender, EventArgs e) => Application.Exit();

    private void menu_configuracoes_Click(object sender, EventArgs e)
    {
        Configuracoes config = new();
        config.Show();
    }

    private void button_atletismo_Click(object sender, EventArgs e) => Esporte(botaoParaEsporte[(Button)sender]);

    private void button_basquete_Click(object sender, EventArgs e) => Esporte(botaoParaEsporte[(Button)sender]);

    private void button_boxe_Click(object sender, EventArgs e) => Esporte(botaoParaEsporte[(Button)sender]);

    private void button_baseball_Click(object sender, EventArgs e) => Esporte(botaoParaEsporte[(Button)sender]);

    private void button_cod_Click(object sender, EventArgs e) => Esporte(botaoParaEsporte[(Button)sender]);

    private void button_cs_Click(object sender, EventArgs e) => Esporte(botaoParaEsporte[(Button)sender]);

    private void button_formula1_Click(object sender, EventArgs e) => Esporte(botaoParaEsporte[(Button)sender]);

    private void button_futebol_Click(object sender, EventArgs e) => Esporte(botaoParaEsporte[(Button)sender]);

    private void button_futebolAmericano_Click(object sender, EventArgs e) => Esporte(botaoParaEsporte[(Button)sender]);

    private void button_golf_Click(object sender, EventArgs e) => Esporte(botaoParaEsporte[(Button)sender]);

    private void button_judo_Click(object sender, EventArgs e) => Esporte(botaoParaEsporte[(Button)sender]);

    private void button_natacao_Click(object sender, EventArgs e) => Esporte(botaoParaEsporte[(Button)sender]);

    private void button_rocket_Click(object sender, EventArgs e) => Esporte(botaoParaEsporte[(Button)sender]);

    private void button_todosJogadores_Click(object sender, EventArgs e) => Esporte(botaoParaEsporte[(Button)sender]);

    private void button_valorant_Click(object sender, EventArgs e) => Esporte(botaoParaEsporte[(Button)sender]);

    private void button_xadrez_Click(object sender, EventArgs e) => Esporte(botaoParaEsporte[(Button)sender]);
}
