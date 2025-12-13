namespace Projeto.Forms;

public partial class Dialog : Form
{
    public Dialog(string text, string login, string sair)
    {
        InitializeComponent();
        label1.Text = text;
        button_loginAdmin.Text = login;
        button_sair.Text = sair;

        button_loginAdmin.DialogResult = DialogResult.OK;
        button_sair.DialogResult = DialogResult.Cancel;
    }
}
