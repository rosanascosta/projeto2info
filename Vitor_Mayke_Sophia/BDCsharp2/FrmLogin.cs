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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BDCsharp2
{
    public partial class FrmLogin : Form
    {
        public MySqlConnection? Conexao;
        public int cod = 0;
        public FrmLogin()
        {
            InitializeComponent();
        }


        private void BtnLogar_Click(object sender, EventArgs e)
        {
            string Em = Email.Text;
            string Senh = Senha.Text;

            Conexao = new MySqlConnection("server=localhost;database=BD_HQs;uid=root; pwd= ");

            Conexao.Open();

            string sql = "select Email, Senha from Tcadastro";


            MySqlDataAdapter da = new MySqlDataAdapter(sql, Conexao);

            DataTable dt = new DataTable();

            da.Fill(dt);


            for (int i = 0; i < dt.Rows.Count; i++)

            {

                if (Em == Convert.ToString(dt.Rows[i]["Email"]))
                {
                    if (Senh == Convert.ToString(dt.Rows[i]["Senha"]))
                    {
                        Hide();
                        FrmSite Site = new FrmSite();
                        Site.ShowDialog();
                    }
                }
                else
                {
                    SN.Text = "USUÁRIO NÃO ENCONTRADO";
                }


            }

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
