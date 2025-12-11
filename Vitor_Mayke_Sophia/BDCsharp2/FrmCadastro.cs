using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BDCsharp2
{
    public partial class FrmCadastro : Form
    {
        public MySqlConnection? Conexao;
        public int cod = 0;

        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            Nm.Clear();
            Usnm.Clear();
            Email.Clear();
            Senha.Clear();
        }


        private void Gravar_Click(object sender, EventArgs e)
        {
            Conexao = new
            MySqlConnection("server=localhost;database=BD_HQS;uid=root;pwd=");
            Conexao.Open();
            string sql = string.Empty;

                if (Nm.Text != "" && Usnm.Text != "" && Email.Text != "" && Senha.Text != "")
                {
                    sql = "insert into Tcadastro (nome, username, email, senha) values ('" + Nm.Text + "', '" + Usnm.Text + "', '" + Email.Text + "', '" + Senha.Text + "' )";
                    MySqlCommand commS = new MySqlCommand(sql, Conexao);
                    commS.ExecuteNonQuery();
                    MessageBox.Show("As informações foram salvas !!! \n\n Volte para o início e faça login ");
                    Limpar();
                }
                else
                {
                    MessageBox.Show("Preencha os campos necessários");
                }
            
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Limpar();
        }

    }
}
