using MySql.Data.MySqlClient;
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
    public partial class HqMs : Form
    {
        public MySqlConnection? Conexao;
        public HqMs()
        {
            InitializeComponent();

            string nome = "Ms. Marvel: Nada Normal";
            name.Text = nome;

            string capaSup = "https://d14d9vp3wdof84.cloudfront.net/image/589816272436/image_h22fte8e85339fr48khsg7vl4e/-S897-FWEBP%22%22";
            capaquadrinho.LoadAsync(capaSup);

            string tipo = "Graphic Novel";
            Tip.Text = tipo;

            string desc = "Kamala Khan era uma garota de New Jersey como muitas outras \r\n " +
                "de sua idade... até o dia em que adquiriu poderes extraordinários!\r\n " +
                "Mas quem realmente é a nova Miss Marvel? Uma adolescente?\r\n Uma muçulmana? " +
                "Uma inumana? Mas, acima de tudo: conseguirá a jovem \r\nresponder" +
                "a estas perguntas ou será esmagada pelo peso da responsabilidade \r\n em suas mãos?" +
                "Os primórdios de uma das mais importantes, celebradas \r\n e comentadas" +
                "entre as novas heroínas da Marvel, capaz em pouco tempo de \r\n " +
                "conquistar fãs do mundo todo e se tornar um verdadeiro fenômeno!\r\n " +
                "Um marco moderno da roteirista e escritora G. Willow Wilson \r\n " +
                "(Força-V) e do artista Adrian Alphona (Fugitivos).";
            LblTxt.Text = desc;
        }

        private void HqMs_Load(object sender, EventArgs e)
        {

        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
