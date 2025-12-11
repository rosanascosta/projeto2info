using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
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
    public partial class FrmSite : Form
    {
        public MySqlConnection? Conexao;
        public int cod = 0;

        public FrmSite()
        {
            InitializeComponent();

            string capaBat = "https://m.media-amazon.com/images/I/61-2G84LF-L._UF1000,1000_QL80_.jpg";
            string capaSup = "https://m.media-amazon.com/images/I/81WtfAkb5iL._UF1000,1000_QL80_.jpg";
            string capaMs = "https://d14d9vp3wdof84.cloudfront.net/image/589816272436/image_h22fte8e85339fr48khsg7vl4e/-S897-FWEBP%22%22";
            Batman.LoadAsync(capaBat);
            Superman.LoadAsync(capaSup);
            MsMarvel.LoadAsync(capaMs);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string Quadrinho = Lgn.Text;

            Conexao = new MySqlConnection("server=localhost;database=BD_HQs;uid=root; pwd= ");

            Conexao.Open();

            string sql = "select nome from Hqs";


            MySqlDataAdapter da = new MySqlDataAdapter(sql, Conexao);

            DataTable dt = new DataTable();

            da.Fill(dt);


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (Quadrinho.ToUpper() == Convert.ToString(dt.Rows[i]["nome"]).ToUpper())
                {
                    //HqBat Hq = new HqBat();
                    //Hq.ShowDialog();

                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HqBat Hq = new HqBat();
            Hq.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HqSup Hq = new HqSup();
            Hq.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HqMs Hq = new HqMs();
            Hq.ShowDialog();
        }
    }
}
