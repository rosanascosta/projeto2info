using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDCsharp2
{
    public partial class FrmPrinc : Form
    {
        public FrmPrinc()
        {
            InitializeComponent();

            string capaHA = "https://m.media-amazon.com/images/I/91TZeW-s9KL._UF894,1000_QL80_.jpg";
            capaquadrinho.LoadAsync(capaHA);

            string capaRb = "https://rika.vtexassets.com/arquivos/ids/237282-1200-auto?v=635316667491770000&width=1200&height=auto&aspect=true%22";
            capaquadrinho2.LoadAsync(capaRb);

            string capaGA = "https://m.media-amazon.com/images/I/4115wobcBtL._SY445_SX342_ML2_.jpg";
            capaquadrinho3.LoadAsync(capaGA);

            Ha.Text = "Graphic Novel";
            Rb.Text = "Minissérie";
            GA.Text = "Run";
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastro Cad = new FrmCadastro();
            Cad.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin Log = new FrmLogin();
            Log.ShowDialog();
        }

        private void aDMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmAdmin2 admn = new FrmAdmin2();
            admn.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
