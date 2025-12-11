using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace BDCsharp2
{
    public partial class HqBat : Form
    {
        public MySqlConnection? Conexao;

        public HqBat()
        {
            InitializeComponent();
            string capaBat = "https://m.media-amazon.com/images/I/61-2G84LF-L._UF1000,1000_QL80_.jpg";
            capaquadrinho.LoadAsync(capaBat);

            string nome = "Batman Ano Um";
            name.Text = nome;

            string tipo = "Graphic Novel";
            Tip.Text = tipo;

            string desc = "Em 1986, Frank Miller e David Mazzucchelli produziram esta revolucionária \r\n " +
                "reinterpretação da origem do Batman sobre quem ele é e  como se tornou o que é." +
                " \r\nEscrito pouco após Batman: o Cavaleiro das trevas, a distópica fábula de Miller \r\n " +
                "sobre os últimos dias do Homem-Morcego,Ano um abriu caminho para uma nova visão\r\n" +
                " de um lendário personagem. Esta edição inclui a história na íntegra, uma\r\n introdução" +
                " pelo escritor Frank Miller e um posfácio ilustrado pelo artista David\r\n Mazzucchelli." +
                " Inclui também mais de 40 páginas de estudos de personagem,\r\n páginas do roteiro " +
                "original, esboços e fornece mais do que um\r\nvislumbre na criação desse " +
                "clássico contemporâneo.";
            LblTxt.Text = desc;

        }

        private void capaquadrinho_Click(object sender, EventArgs e)
        {

        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
