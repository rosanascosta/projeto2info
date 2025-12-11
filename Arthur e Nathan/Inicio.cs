using MySql.Data.MySqlClient;
using Mysqlx.Sql;
using Org.BouncyCastle.Security;
using System.Security.Cryptography;
using System.Data;
using System.Text;
namespace WinFormsApp1
{
    public partial class Inicio : Form
    {
        public MySqlConnection trabalhoconn;
        public MySqlDataAdapter mAdapter;
        public DataSet mDataSet;
        public Inicio()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            trabalhoconn = new MySqlConnection("server=localhost; database=trabalho; uid=root; pwd=");
            trabalhoconn.Open();
            string sql = string.Empty;
            string Email = textBox1.Text,
                   Senha = textBox2.Text;
            sql = "select id, senha from usuario where email = '" + Email + "' limit 1";
            MySqlCommand command = new MySqlCommand(sql, trabalhoconn);
            command.ExecuteNonQuery();
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.FieldCount == 0) {
                trabalhoconn.Close();
                MessageBox.Show("Email ou senha inválidos.");
            }
            reader.Close();
            string pwd = "select senha from usuario where email = @email";
            using (MySqlCommand cmd = new MySqlCommand(pwd, trabalhoconn))
            {
                cmd.Parameters.AddWithValue("@email", Email);
                object senhabd = cmd.ExecuteScalar();
                if (senhabd != null && GerarSHA256(Senha) == senhabd.ToString()) {
                    textBox1.Clear();
                    textBox2.Clear();
                    MessageBox.Show("Você foi logado com sucesso!!!");
                    Menu menu = new Menu();
                    menu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Email ou senha inválidos!");
                }
            }
        }

        private string GerarSHA256(string texto)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(texto);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes) sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            trabalhoconn = new MySqlConnection("server=localhost; database=trabalho; uid=root; pwd=");
            trabalhoconn.Open();
            string sql = string.Empty;

            string Emailcad = textBox3.Text,
                   Senhacad = textBox4.Text;
            string verifica = "select count(*) from usuario where email = @email;";
            using (MySqlCommand comando = new MySqlCommand(verifica, trabalhoconn))
            {
                comando.Parameters.AddWithValue("@email", Emailcad);
                Int64 linhas = (Int64)comando.ExecuteScalar();
                if (!string.IsNullOrWhiteSpace(Emailcad) && !string.IsNullOrWhiteSpace(Senhacad))
                {
                    if (linhas == 0)
                    {
                        sql = "insert into usuario (email, senha) values ('" + Emailcad + "', '" + GerarSHA256(Senhacad) + "');";
                        MySqlCommand command = new MySqlCommand(sql, trabalhoconn);
                        command.ExecuteNonQuery();
                        textBox3.Clear();
                        textBox4.Clear();
                        MessageBox.Show("Seus dados foram cadastrados!!!");
                    }
                    else
                    {
                        MessageBox.Show("Já existe uma conta utilizando esse email.");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos.");
                }
            }     
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
