using System.Runtime.CompilerServices;

namespace Projeto.Forms;
public partial class BaseForm : Form
{
    private static readonly Color ThemeBack = ColorTranslator.FromHtml("#071323");
    private static readonly Color ThemeFore = ColorTranslator.FromHtml("#c3f030");
    private readonly IDisposable _bar;

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            foreach (var pb in get_pbs(this))
            {
                pb.Image?.Dispose();
                pb.Image = null;
            }
        }
        base.Dispose(disposing);
    }

    public BaseForm()
    {
        KeyPreview = true;
        StartPosition = FormStartPosition.CenterScreen;

        // local form theme
        BackColor = ThemeBack;
        ForeColor = ThemeFore;
    }

    private static IEnumerable<PictureBox> get_pbs(Control root)
    {
        foreach (Control c in root.Controls)
        {
            if (c is PictureBox pb)
                yield return pb;

            if (c.HasChildren)
            {
                foreach (var child in get_pbs(c))
                    yield return child;
            }
        }
    }


    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        applyTheme(this);
    }

    private static void applyTheme(Control root)
    {
        foreach (Control c in root.Controls)
        {
            c.ForeColor = ThemeFore;

            // background: inherit unless explicitly transparent
            if (c is Button b)
            {
                b.UseVisualStyleBackColor = false;
                b.BackColor = ThemeBack;    // matches form (you can darken if u want contrast)
            }
            else if (c.BackColor != Color.Transparent)
            {
                c.BackColor = ThemeBack;
            }

            if (c.HasChildren)
                applyTheme(c);
        }
    }

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
        if (keyData == Keys.Escape)
        {
            Close();
            return true;
        }
        return base.ProcessCmdKey(ref msg, keyData);
    }

}