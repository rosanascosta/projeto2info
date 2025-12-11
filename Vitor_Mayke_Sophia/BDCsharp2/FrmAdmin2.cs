using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BDCsharp2
{
    public partial class FrmAdmin2 : Form
    {
        public MySqlConnection? Conexao;
        public int cod = 0;
        string sql = string.Empty;
        public string NomeUs, UserUs, EmailUs, SenhaUs;
        public string NomeHQ, Tipo, Desc, Lk;
        public int cods;

        private void CarregaGrid1()
        {
            Conexao = new MySqlConnection("server=localhost;database=BD_HQS;uid=root;pwd=");
            Conexao.Open();
            string sql = "select codigo, nome, username, email, senha from Tcadastro order by codigo";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, Conexao);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGrid1.DataSource = dt;
        }

        private void CarregaGrid2()
        {
            Conexao = new MySqlConnection("server=localhost;database=BD_HQS;uid=root;pwd=");
            Conexao.Open();
            string sql = "select codigo, nome, tipo, descricao, link from Hqs order by nome asc";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, Conexao);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGrid2.DataSource = dt;

        }

        private void Limpar1()
        {
            CampNomeUs.Clear();
            CampUserUs.Clear();
            CampEmailUs.Clear();
            CampSenhaUs.Clear();
        }

        private void Limpar2()
        {
            CampNomeHQ.Clear();
            CampTipo.Clear();
            CampDesc.Clear();
            Camplink.Clear();
        }

        public FrmAdmin2()
        {
            InitializeComponent();

            CarregaGrid1();
            CarregaGrid2();
        }



        private void BtnAlterar2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            FrmPrinc admn = new FrmPrinc();
            admn.ShowDialog();
        }

        private void Var1()
        {
            NomeUs = CampNomeUs.Text;
            UserUs = CampUserUs.Text;
            EmailUs = CampEmailUs.Text;
            SenhaUs = CampSenhaUs.Text;
        }

        private void Var2()
        {
            NomeHQ = CampNomeHQ.Text;
            Tipo = CampTipo.Text;
            Desc = CampDesc.Text;
            Lk = Camplink.Text;
        }

        private void BtnaddUs_Click(object sender, EventArgs e)
        {
            Var1();
            Conexao = new MySqlConnection("server=localhost;database=BD_HQS;uid=root;pwd=");
            Conexao.Open();
            string sql = string.Empty;

            if (cod == 0)
            {
                if (NomeUs != "" && UserUs != "" && EmailUs != "" && SenhaUs != "")
                {
                    sql = "insert into Tcadastro (nome, username, email, senha) values ('" + NomeUs + "', '" + UserUs + "', '" + EmailUs + "', '" + SenhaUs + "' )";
                    MySqlCommand commS = new MySqlCommand(sql, Conexao);
                    commS.ExecuteNonQuery();
                    MessageBox.Show("As informações foram salvas !!!");
                    CarregaGrid1();
                    Limpar1();
                }
                else
                {
                    MessageBox.Show("Preencha os campos necessários");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Var2();
            Conexao = new MySqlConnection("server=localhost;database=BD_HQS;uid=root;pwd=");
            Conexao.Open();
            string sql = string.Empty;

            if (cod == 0)
            {
                if (NomeHQ != "" && Tipo != "" && Desc != "" && Lk != "")
                {
                    sql = "insert into Hqs (nome, tipo, descricao, link) values ('" + NomeHQ + "', '" + Tipo + "', '" + Desc + "', '" + Lk + "' )";
                    MySqlCommand commS = new MySqlCommand(sql, Conexao);
                    commS.ExecuteNonQuery();
                    MessageBox.Show("As informações foram salvas !!!");
                    CarregaGrid2();
                    Limpar2();
                }
                else
                {
                    MessageBox.Show("Preencha os campos necessários");
                }
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            cods = int.Parse(CodUs.Text);
            Var1();
            Conexao = new MySqlConnection("server=localhost;database=BD_HQS;uid=root;pwd=");
            Conexao.Open();
            string sql = "DELETE FROM TCadastro WHERE codigo =" + cods;
            MySqlDataAdapter da = new MySqlDataAdapter(sql, Conexao);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGrid1.DataSource = dt;
            CarregaGrid1();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int cods = int.Parse(CampBD.Text);
            Var2();
            Conexao = new MySqlConnection("server=localhost;database=BD_HQS;uid=root;pwd=");
            Conexao.Open();
            string sql = "DELETE FROM Hqs WHERE codigo =" + cods;
            MySqlDataAdapter da = new MySqlDataAdapter(sql, Conexao);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGrid2.DataSource = dt;
            CarregaGrid2();
        }

        private void BtnAlterar1_Click(object sender, EventArgs e)
        {
            cods = int.Parse(CodUs.Text);
            Var1();
            Conexao = new MySqlConnection("server=localhost;database=BD_HQS;uid=root;pwd=");
            Conexao.Open();

            if (Nome.Checked)
            {
                sql = "UPDATE Tcadastro SET nome='" + NomeUs + "' WHERE codigo=" + cods;
                new MySqlCommand(sql, Conexao).ExecuteNonQuery();
            }

            if (User.Checked)
            {
                sql = "UPDATE Tcadastro SET username='" + UserUs + "' WHERE codigo=" + cods;
                new MySqlCommand(sql, Conexao).ExecuteNonQuery();
            }

            if (Email.Checked)
            {
                sql = "UPDATE Tcadastro SET email='" + EmailUs + "' WHERE codigo=" + cods;
                new MySqlCommand(sql, Conexao).ExecuteNonQuery();
            }

            if (Senha.Checked)
            {
                sql = "UPDATE Tcadastro SET senha='" + SenhaUs + "' WHERE codigo=" + cods;
                new MySqlCommand(sql, Conexao).ExecuteNonQuery();
            }

            Conexao.Close();

            MessageBox.Show("Campo(s) atualizados com sucesso!");
            CarregaGrid1();
        }

        private void BtnAlterar2_Click_1(object sender, EventArgs e)
        {
            cods = int.Parse(CampBD.Text);
            Var2();
            Conexao = new MySqlConnection("server=localhost;database=BD_HQS;uid=root;pwd=");
            Conexao.Open();

            if (NameBD.Checked)
            {
                sql = "UPDATE Hqs SET nome='" + NomeHQ + "' WHERE codigo=" + cods;
                new MySqlCommand(sql, Conexao).ExecuteNonQuery();
            }

            if (TipoBD.Checked)
            {
                sql = "UPDATE Hqs SET tipo='" + Tipo + "' WHERE codigo=" + cods;
                new MySqlCommand(sql, Conexao).ExecuteNonQuery();
            }

            if (Descricao.Checked)
            {
                sql = "UPDATE Hqs SET descricao='" + Desc + "' WHERE codigo=" + cods;
                new MySqlCommand(sql, Conexao).ExecuteNonQuery();
            }

            if (Lnk.Checked)
            {
                sql = "UPDATE Hqs SET link='" + Lk + "' WHERE codigo=" + cods;
                new MySqlCommand(sql, Conexao).ExecuteNonQuery();
            }

            Conexao.Close();

            MessageBox.Show("Campo(s) atualizados com sucesso!");
            CarregaGrid2();
        }

        private void BtnLimpar2_Click_1(object sender, EventArgs e)
        {
            Limpar2();
        }

        private void BtnLimpar1_Click(object sender, EventArgs e)
        {
            Limpar1();
        }
    }
}
