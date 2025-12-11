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
    public partial class HqSup : Form
    {
        public HqSup()
        {
            InitializeComponent();

            string nome = "Grandes Astros: Superman";
            name.Text = nome;

            string capaSup = "https://m.media-amazon.com/images/I/81WtfAkb5iL._UF1000,1000_QL80_.jpg";
            capaquadrinho.LoadAsync(capaSup);

            string tipo = "Graphic Novel";
            Tip.Text = tipo;

            string desc = "Setenta anos após ser criado e apresentado ao planeta por Joe Shuster e Jerry\r\n" +
                "Siegel, Superman ganhou, em meados da década passada, uma \r\n reinterpretação surpreendente" +
                " que chocou completa e positivamente o\r\n mundo das HQs e redefiniu todos os limites de um" +
                " personagem icônico,\r\n que acreditava-se ser inalterável. Por cortesia da genial e \r\n " +
                "excêntrica mente do roteirista Grant Morrison e do traço incomparável\r\n do desenhista " +
                "Frank Quitely, o Homem de Aço (e seus milhões de fãs pelo\r\n mundo) foram presenteados com    " +
                "uma obra-prima sem precedentes,\r\n publicada em doze partes sob o título Grandes Astros \r\n " +
                "Superman. Agora, essa imperdível obra volta a ser publicada no Brasil pela\r\n Panini Books," +
                "em uma edição única e com o tratamento condizente à sua\r\n relevância e qualidade. Grandes " +
                "Astros Superman Ed. Definitiva\r\n traz a história na integra em acabamento e formato \r\n " +
                "diferenciados, e acompanhada por extras inéditos no Brasil!";
            LblTxt.Text = desc;

        }

        private void capaSup_Click(object sender, EventArgs e)
        {

        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void HqSup_Load(object sender, EventArgs e)
        {

        }
    }
}
