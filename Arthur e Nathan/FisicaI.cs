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
using Mysqlx.Sql;
using Org.BouncyCastle.Security;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class FisicaI : Form
    {
        private System.Windows.Forms.Label label2 = null!;
        private System.Windows.Forms.Label label3 = null!;
        private System.Windows.Forms.Label label4 = null!;
        private System.Windows.Forms.Label label5 = null!;
        private System.Windows.Forms.Label label6 = null!;
        private System.Windows.Forms.Label label7 = null!;
        private System.Windows.Forms.Label label8 = null!;
        private System.Windows.Forms.TextBox number1 = null!;
        private System.Windows.Forms.TextBox number2 = null!;
        private System.Windows.Forms.TextBox number3 = null!;
        private System.Windows.Forms.TextBox number4 = null!;
        private System.Windows.Forms.TextBox number5 = null!;
        private System.Windows.Forms.Button Enviar = null!;
        private System.Windows.Forms.Button Enviarsub = null!;
        private System.Windows.Forms.Button Limpar = null!;
        private System.Windows.Forms.ComboBox combo = null!;
        private System.Windows.Forms.DataGridView dataGrid = null!;

        public MySqlConnection trabalhoconn = null!;
        public MySqlDataAdapter mAdapter = null!;
        public DataSet mDataSet = null!;

        public FisicaI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selecionado = comboBox1.Text;
            if (selecionado == "Movimento Retilíneo Uniforme")
            {
                this.Controls.Remove(label2);
                this.Controls.Remove(label3);
                this.Controls.Remove(label4);
                this.Controls.Remove(label5);
                this.Controls.Remove(label6);
                this.Controls.Remove(label7);
                this.Controls.Remove(label8);
                this.Controls.Remove(number1);
                this.Controls.Remove(number2);
                this.Controls.Remove(number3);
                this.Controls.Remove(number4);
                this.Controls.Remove(number5);
                this.Controls.Remove(Enviar);
                this.Controls.Remove(Enviarsub);
                this.Controls.Remove(Limpar);
                this.Controls.Remove(combo);
                this.Controls.Remove(dataGrid);

                label2 = new System.Windows.Forms.Label();
                label2.Text = "S = S₀ + V.t";
                label2.Location = new Point(500, 50);
                label2.Font = new Font("Segoe UI", 15);
                label2.AutoSize = true;
                label2.Visible = true;
                this.Controls.Add(label2);

                label3 = new System.Windows.Forms.Label();
                label3.Text = "S (m):";
                label3.Location = new Point(485, 95);
                label3.Font = new Font("Segoe UI", 9);
                label3.AutoSize = true;
                label3.Visible = true;
                this.Controls.Add(label3);

                number1 = new System.Windows.Forms.TextBox();
                number1.Location = new Point(525, 95);
                number1.AutoSize = true;
                number1.Visible = true;
                this.Controls.Add(number1);

                label4 = new System.Windows.Forms.Label();
                label4.Text = "S₀ (m):";
                label4.Location = new Point(485, 125);
                label4.Font = new Font("Segoe UI", 9);
                label4.AutoSize = true;
                label4.Visible = true;
                this.Controls.Add(label4);

                number2 = new System.Windows.Forms.TextBox();
                number2.Location = new Point(530, 125);
                number2.AutoSize = true;
                number2.Visible = true;
                this.Controls.Add(number2);

                label5 = new System.Windows.Forms.Label();
                label5.Text = "V (m/s):";
                label5.Location = new Point(485, 155);
                label5.Font = new Font("Segoe UI", 9);
                label5.AutoSize = true;
                label5.Visible = true;
                this.Controls.Add(label5);

                number3 = new System.Windows.Forms.TextBox();
                number3.Location = new Point(535, 155);
                number3.AutoSize = true;
                number3.Visible = true;
                this.Controls.Add(number3);

                label6 = new System.Windows.Forms.Label();
                label6.Text = "t (s):";
                label6.Location = new Point(485, 185);
                label6.Font = new Font("Segoe UI", 9);
                label6.AutoSize = true;
                label6.Visible = true;
                this.Controls.Add(label6);

                number4 = new System.Windows.Forms.TextBox();
                number4.Location = new Point(520, 185);
                number4.AutoSize = true;
                number4.Visible = true;
                this.Controls.Add(number4);

                Enviar = new System.Windows.Forms.Button();
                Enviar.Text = "Enviar";
                Enviar.Location = new Point(485, 225);
                Enviar.AutoSize = true;
                Enviar.Visible = true;
                Enviar.Click += Button2_Click;
                this.Controls.Add(Enviar);

                Limpar = new System.Windows.Forms.Button();
                Limpar.Text = "Limpar";
                Limpar.Location = new Point(565, 225);
                Limpar.AutoSize = true;
                Limpar.Visible = true;
                Limpar.Click += Button3_Click;
                this.Controls.Add(Limpar);
  
            }else if (selecionado == "Movimento Uniformemente Variado")
            {
                this.Controls.Remove(label2);
                this.Controls.Remove(label3);
                this.Controls.Remove(label4);
                this.Controls.Remove(label5);
                this.Controls.Remove(label6);
                this.Controls.Remove(label7);
                this.Controls.Remove(label8);
                this.Controls.Remove(number1);
                this.Controls.Remove(number2);
                this.Controls.Remove(number3);
                this.Controls.Remove(number4);
                this.Controls.Remove(number5);
                this.Controls.Remove(Enviar);
                this.Controls.Remove(Enviarsub);
                this.Controls.Remove(Limpar);
                this.Controls.Remove(combo);
                this.Controls.Remove(dataGrid);

                label2 = new System.Windows.Forms.Label();
                label2.Text = "Escolha uma dessas fórmulas.";
                label2.Location = new Point(75, 225);
                label2.Font = new Font("Segoe UI", 9);
                label2.AutoSize = true;
                label2.Visible = true;
                this.Controls.Add(label2);

                combo = new System.Windows.Forms.ComboBox();
                combo.Items.Add("Função Horária da Velocidade");
                combo.Items.Add("Função Horária da Posição (Sorvetão)");
                combo.Items.Add("Equação de Torricelli");
                combo.Location = new Point(65, 250);
                combo.Size = new Size(200, 15);
                combo.AutoSize = true;
                combo.Visible = true;
                this.Controls.Add(combo);

                Enviarsub = new System.Windows.Forms.Button();
                Enviarsub.Text = "Enviar";
                Enviarsub.Location = new Point(125, 285);
                Enviarsub.AutoSize = true;
                Enviarsub.Visible = true;
                Enviarsub.Click += Button4_Click;
                this.Controls.Add(Enviarsub);
            }else if (selecionado == "Velocidade Média")
            {
                this.Controls.Remove(label2);
                this.Controls.Remove(label3);
                this.Controls.Remove(label4);
                this.Controls.Remove(label5);
                this.Controls.Remove(label6);
                this.Controls.Remove(label7);
                this.Controls.Remove(label8);
                this.Controls.Remove(number1);
                this.Controls.Remove(number2);
                this.Controls.Remove(number3);
                this.Controls.Remove(number4);
                this.Controls.Remove(number5);
                this.Controls.Remove(Enviar);
                this.Controls.Remove(Enviar);
                this.Controls.Remove(Limpar);
                this.Controls.Remove(dataGrid);

                label2 = new System.Windows.Forms.Label();
                label2.Text = "Vm = Δs /Δt";
                label2.Location = new Point(500, 50);
                label2.Font = new Font("Segoe UI", 15);
                label2.AutoSize = true;
                label2.Visible = true;
                this.Controls.Add(label2);

                label3 = new System.Windows.Forms.Label();
                label3.Text = "Vm (m/s):";
                label3.Location = new Point(485, 95);
                label3.Font = new Font("Segoe UI", 9);
                label3.AutoSize = true;
                label3.Visible = true;
                this.Controls.Add(label3);

                number1 = new System.Windows.Forms.TextBox();
                number1.Location = new Point(545, 95);
                number1.AutoSize = true;
                number1.Visible = true;
                this.Controls.Add(number1);

                label4 = new System.Windows.Forms.Label();
                label4.Text = "S (m):";
                label4.Location = new Point(485, 125);
                label4.Font = new Font("Segoe UI", 9);
                label4.AutoSize = true;
                label4.Visible = true;
                this.Controls.Add(label4);

                number2 = new System.Windows.Forms.TextBox();
                number2.Location = new Point(530, 125);
                number2.AutoSize = true;
                number2.Visible = true;
                this.Controls.Add(number2);

                label5 = new System.Windows.Forms.Label();
                label5.Text = "S₀ (m):";
                label5.Location = new Point(485, 155);
                label5.Font = new Font("Segoe UI", 9);
                label5.AutoSize = true;
                label5.Visible = true;
                this.Controls.Add(label5);

                number3 = new System.Windows.Forms.TextBox();
                number3.Location = new Point(535, 155);
                number3.AutoSize = true;
                number3.Visible = true;
                this.Controls.Add(number3);

                label6 = new System.Windows.Forms.Label();
                label6.Text = "t (s):";
                label6.Location = new Point(485, 185);
                label6.Font = new Font("Segoe UI", 9);
                label6.AutoSize = true;
                label6.Visible = true;
                this.Controls.Add(label6);

                number4 = new System.Windows.Forms.TextBox();
                number4.Location = new Point(525, 185);
                number4.AutoSize = true;
                number4.Visible = true;
                this.Controls.Add(number4);

                label7 = new System.Windows.Forms.Label();
                label7.Text = "t₀ (s):";
                label7.Location = new Point(485, 215);
                label7.Font = new Font("Segoe UI", 9);
                label7.AutoSize = true;
                label7.Visible = true;
                this.Controls.Add(label7);

                number5 = new System.Windows.Forms.TextBox();
                number5.Location = new Point(535, 215);
                number5.AutoSize = true;
                number5.Visible = true;
                this.Controls.Add(number5);

                Enviar = new System.Windows.Forms.Button();
                Enviar.Text = "Enviar";
                Enviar.Location = new Point(485, 255);
                Enviar.AutoSize = true;
                Enviar.Visible = true;
                Enviar.Click += Button8_Click;
                this.Controls.Add(Enviar);

                Limpar = new System.Windows.Forms.Button();
                Limpar.Text = "Limpar";
                Limpar.Location = new Point(565, 255);
                Limpar.AutoSize = true;
                Limpar.Visible = true;
                Limpar.Click += Button3_Click;
                this.Controls.Add(Limpar);
            }
            else if (selecionado == "Aceleração Média")
            {
                this.Controls.Remove(label2);
                this.Controls.Remove(label3);
                this.Controls.Remove(label4);
                this.Controls.Remove(label5);
                this.Controls.Remove(label6);
                this.Controls.Remove(label7);
                this.Controls.Remove(label8);
                this.Controls.Remove(number1);
                this.Controls.Remove(number2);
                this.Controls.Remove(number3);
                this.Controls.Remove(number4);
                this.Controls.Remove(number5);
                this.Controls.Remove(Enviar);
                this.Controls.Remove(Enviar);
                this.Controls.Remove(Limpar);
                this.Controls.Remove(dataGrid);

                label2 = new System.Windows.Forms.Label();
                label2.Text = "Am = Δv /Δt";
                label2.Location = new Point(500, 50);
                label2.Font = new Font("Segoe UI", 15);
                label2.AutoSize = true;
                label2.Visible = true;
                this.Controls.Add(label2);

                label3 = new System.Windows.Forms.Label();
                label3.Text = "Am (m/s²):";
                label3.Location = new Point(485, 95);
                label3.Font = new Font("Segoe UI", 9);
                label3.AutoSize = true;
                label3.Visible = true;
                this.Controls.Add(label3);

                number1 = new System.Windows.Forms.TextBox();
                number1.Location = new Point(555, 95);
                number1.AutoSize = true;
                number1.Visible = true;
                this.Controls.Add(number1);

                label4 = new System.Windows.Forms.Label();
                label4.Text = "V (m/s):";
                label4.Location = new Point(485, 125);
                label4.Font = new Font("Segoe UI", 9);
                label4.AutoSize = true;
                label4.Visible = true;
                this.Controls.Add(label4);

                number2 = new System.Windows.Forms.TextBox();
                number2.Location = new Point(540, 125);
                number2.AutoSize = true;
                number2.Visible = true;
                this.Controls.Add(number2);

                label5 = new System.Windows.Forms.Label();
                label5.Text = "V₀ (m/s):";
                label5.Location = new Point(485, 155);
                label5.Font = new Font("Segoe UI", 9);
                label5.AutoSize = true;
                label5.Visible = true;
                this.Controls.Add(label5);

                number3 = new System.Windows.Forms.TextBox();
                number3.Location = new Point(545, 155);
                number3.AutoSize = true;
                number3.Visible = true;
                this.Controls.Add(number3);

                label6 = new System.Windows.Forms.Label();
                label6.Text = "t (s):";
                label6.Location = new Point(485, 185);
                label6.Font = new Font("Segoe UI", 9);
                label6.AutoSize = true;
                label6.Visible = true;
                this.Controls.Add(label6);

                number4 = new System.Windows.Forms.TextBox();
                number4.Location = new Point(525, 185);
                number4.AutoSize = true;
                number4.Visible = true;
                this.Controls.Add(number4);

                label7 = new System.Windows.Forms.Label();
                label7.Text = "t₀ (s):";
                label7.Location = new Point(485, 215);
                label7.Font = new Font("Segoe UI", 9);
                label7.AutoSize = true;
                label7.Visible = true;
                this.Controls.Add(label7);

                number5 = new System.Windows.Forms.TextBox();
                number5.Location = new Point(535, 215);
                number5.AutoSize = true;
                number5.Visible = true;
                this.Controls.Add(number5);

                Enviar = new System.Windows.Forms.Button();
                Enviar.Text = "Enviar";
                Enviar.Location = new Point(485, 255);
                Enviar.AutoSize = true;
                Enviar.Visible = true;
                Enviar.Click += Button9_Click;
                this.Controls.Add(Enviar);

                Limpar = new System.Windows.Forms.Button();
                Limpar.Text = "Limpar";
                Limpar.Location = new Point(565, 255);
                Limpar.AutoSize = true;
                Limpar.Visible = true;
                Limpar.Click += Button3_Click;
                this.Controls.Add(Limpar);
            }
            else if (selecionado == "2° Lei de Newton")
            {
                this.Controls.Remove(label2);
                this.Controls.Remove(label3);
                this.Controls.Remove(label4);
                this.Controls.Remove(label5);
                this.Controls.Remove(label6);
                this.Controls.Remove(label7);
                this.Controls.Remove(label8);
                this.Controls.Remove(number1);
                this.Controls.Remove(number2);
                this.Controls.Remove(number3);
                this.Controls.Remove(number4);
                this.Controls.Remove(number5);
                this.Controls.Remove(Enviar);
                this.Controls.Remove(Enviar);
                this.Controls.Remove(Limpar);
                this.Controls.Remove(dataGrid);

                label2 = new System.Windows.Forms.Label();
                label2.Text = "F = m.a";
                label2.Location = new Point(500, 50);
                label2.Font = new Font("Segoe UI", 15);
                label2.AutoSize = true;
                label2.Visible = true;
                this.Controls.Add(label2);

                label3 = new System.Windows.Forms.Label();
                label3.Text = "F (N):";
                label3.Location = new Point(485, 95);
                label3.Font = new Font("Segoe UI", 9);
                label3.AutoSize = true;
                label3.Visible = true;
                this.Controls.Add(label3);

                number1 = new System.Windows.Forms.TextBox();
                number1.Location = new Point(525, 95);
                number1.AutoSize = true;
                number1.Visible = true;
                this.Controls.Add(number1);

                label4 = new System.Windows.Forms.Label();
                label4.Text = "m (kg):";
                label4.Location = new Point(485, 125);
                label4.Font = new Font("Segoe UI", 9);
                label4.AutoSize = true;
                label4.Visible = true;
                this.Controls.Add(label4);

                number2 = new System.Windows.Forms.TextBox();
                number2.Location = new Point(530, 125);
                number2.AutoSize = true;
                number2.Visible = true;
                this.Controls.Add(number2);

                label5 = new System.Windows.Forms.Label();
                label5.Text = "a (m/s²):";
                label5.Location = new Point(485, 155);
                label5.Font = new Font("Segoe UI", 9);
                label5.AutoSize = true;
                label5.Visible = true;
                this.Controls.Add(label5);

                number3 = new System.Windows.Forms.TextBox();
                number3.Location = new Point(545, 155);
                number3.AutoSize = true;
                number3.Visible = true;
                this.Controls.Add(number3);

                Enviar = new System.Windows.Forms.Button();
                Enviar.Text = "Enviar";
                Enviar.Location = new Point(485, 185);
                Enviar.AutoSize = true;
                Enviar.Visible = true;
                Enviar.Click += Button10_Click;
                this.Controls.Add(Enviar);

                Limpar = new System.Windows.Forms.Button();
                Limpar.Text = "Limpar";
                Limpar.Location = new Point(565, 185);
                Limpar.AutoSize = true;
                Limpar.Visible = true;
                Limpar.Click += Button3_Click;
                this.Controls.Add(Limpar);
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(dataGrid);

            Dictionary <string, double?> variaveis = new Dictionary<string, double?>();
            variaveis["s"] = number1.Text == "" ? null : Convert.ToDouble(number1.Text);
            variaveis["s0"] = number2.Text == "" ? null : Convert.ToDouble(number2.Text);
            variaveis["v"] = number3.Text == "" ? null : Convert.ToDouble(number3.Text);
            variaveis["t"] = number4.Text == "" ? null : Convert.ToDouble(number4.Text);

            string campos = "";
            string valores = "";
            int c = 0;

            foreach (KeyValuePair<string, double?> v in variaveis)
            {
                if (v.Value != null)
                {
                    if (campos != "")
                    {
                        campos += ",";
                        valores += ",";
                    }
                    campos += v.Key;
                    valores += v.Value;
                }
                else
                {
                    c++;
                }
            }

            if (c != 1)
            {
                MessageBox.Show("Só pode haver uma variável vazia.");
            }

            trabalhoconn = new MySqlConnection("server=localhost; database=trabalho; uid=root; pwd=");
            trabalhoconn.Open();
            string sql = string.Empty;
            sql = "delete from mu_calculos";
            MySqlCommand command_1 = new MySqlCommand(sql, trabalhoconn);
            command_1.ExecuteNonQuery();
            sql = "insert into mu (" + campos + ") values (" + valores + ")";
            MySqlCommand command_2 = new MySqlCommand(sql, trabalhoconn);
            command_2.ExecuteNonQuery();
            sql = "select s_calculado, s0_calculado, v_calculado, t_calculado from mu_calculos";
            MySqlDataAdapter data = new MySqlDataAdapter(sql, trabalhoconn);
            DataTable dt = new DataTable();
            data.Fill(dt);

            dataGrid = new System.Windows.Forms.DataGridView();
            dataGrid.Location = new Point(300, 275);
            dataGrid.AutoSize = true;
            dataGrid.Visible = true;
            this.Controls.Add(dataGrid);

            dataGrid.DataSource = dt;
            trabalhoconn.Close();
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            number1.Clear();
            number2.Clear();
            number3.Clear();
            number4.Clear();
            number5.Clear();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string sub = combo.Text;
            if (sub == "Função Horária da Velocidade")
            {
                this.Controls.Remove(label3);
                this.Controls.Remove(label4);
                this.Controls.Remove(label5);
                this.Controls.Remove(label6);
                this.Controls.Remove(label7);
                this.Controls.Remove(label8);
                this.Controls.Remove(number1);
                this.Controls.Remove(number2);
                this.Controls.Remove(number3);
                this.Controls.Remove(number4);
                this.Controls.Remove(number5);
                this.Controls.Remove(Enviar);
                this.Controls.Remove(Limpar);
                this.Controls.Remove(dataGrid);

                label3 = new System.Windows.Forms.Label();
                label3.Text = "V = V₀ + a.t";
                label3.Location = new Point(500, 50);
                label3.Font = new Font("Segoe UI", 15);
                label3.AutoSize = true;
                label3.Visible = true;
                this.Controls.Add(label3);

                label4 = new System.Windows.Forms.Label();
                label4.Text = "V (m/s):";
                label4.Location = new Point(485, 95);
                label4.Font = new Font("Segoe UI", 9);
                label4.AutoSize = true;
                label4.Visible = true;
                this.Controls.Add(label4);

                number1 = new System.Windows.Forms.TextBox();
                number1.Location = new Point(535, 95);
                number1.AutoSize = true;
                number1.Visible = true;
                this.Controls.Add(number1);

                label5 = new System.Windows.Forms.Label();
                label5.Text = "V₀ (m/s):";
                label5.Location = new Point(485, 125);
                label5.Font = new Font("Segoe UI", 9);
                label5.AutoSize = true;
                label5.Visible = true;
                this.Controls.Add(label5);

                number2 = new System.Windows.Forms.TextBox();
                number2.Location = new Point(540, 125);
                number2.AutoSize = true;
                number2.Visible = true;
                this.Controls.Add(number2);

                label6 = new System.Windows.Forms.Label();
                label6.Text = "a (m/s²):";
                label6.Location = new Point(485, 155);
                label6.Font = new Font("Segoe UI", 9);
                label6.AutoSize = true;
                label6.Visible = true;
                this.Controls.Add(label6);

                number3 = new System.Windows.Forms.TextBox();
                number3.Location = new Point(545, 155);
                number3.AutoSize = true;
                number3.Visible = true;
                this.Controls.Add(number3);

                label7 = new System.Windows.Forms.Label();
                label7.Text = "t (s):";
                label7.Location = new Point(485, 185);
                label7.Font = new Font("Segoe UI", 9);
                label7.AutoSize = true;
                label7.Visible = true;
                this.Controls.Add(label7);

                number4 = new System.Windows.Forms.TextBox();
                number4.Location = new Point(520, 185);
                number4.AutoSize = true;
                number4.Visible = true;
                this.Controls.Add(number4);

                Enviar = new System.Windows.Forms.Button();
                Enviar.Text = "Enviar";
                Enviar.Location = new Point(485, 225);
                Enviar.AutoSize = true;
                Enviar.Visible = true;
                Enviar.Click += Button5_Click;
                this.Controls.Add(Enviar);

                Limpar = new System.Windows.Forms.Button();
                Limpar.Text = "Limpar";
                Limpar.Location = new Point(565, 225);
                Limpar.AutoSize = true;
                Limpar.Visible = true;
                Limpar.Click += Button3_Click;
                this.Controls.Add(Limpar);

            }else if (sub == "Função Horária da Posição (Sorvetão)")
            {
                this.Controls.Remove(label3);
                this.Controls.Remove(label4);
                this.Controls.Remove(label5);
                this.Controls.Remove(label6);
                this.Controls.Remove(label7);
                this.Controls.Remove(label8);
                this.Controls.Remove(number1);
                this.Controls.Remove(number2);
                this.Controls.Remove(number3);
                this.Controls.Remove(number4);
                this.Controls.Remove(number5);
                this.Controls.Remove(Enviar);
                this.Controls.Remove(Limpar);
                this.Controls.Remove(dataGrid);

                label3 = new System.Windows.Forms.Label();
                label3.Text = "S = S₀ + V₀.t + (a.t²)/2";
                label3.Location = new Point(500, 50);
                label3.Font = new Font("Segoe UI", 15);
                label3.AutoSize = true;
                label3.Visible = true;
                this.Controls.Add(label3);

                label4 = new System.Windows.Forms.Label();
                label4.Text = "S (m):";
                label4.Location = new Point(485, 95);
                label4.Font = new Font("Segoe UI", 9);
                label4.AutoSize = true;
                label4.Visible = true;
                this.Controls.Add(label4);

                number1 = new System.Windows.Forms.TextBox();
                number1.Location = new Point(535, 95);
                number1.AutoSize = true;
                number1.Visible = true;
                this.Controls.Add(number1);

                label5 = new System.Windows.Forms.Label();
                label5.Text = "S₀ (m):";
                label5.Location = new Point(485, 125);
                label5.Font = new Font("Segoe UI", 9);
                label5.AutoSize = true;
                label5.Visible = true;
                this.Controls.Add(label5);

                number2 = new System.Windows.Forms.TextBox();
                number2.Location = new Point(540, 125);
                number2.AutoSize = true;
                number2.Visible = true;
                this.Controls.Add(number2);

                label6 = new System.Windows.Forms.Label();
                label6.Text = "V₀ (m/s):";
                label6.Location = new Point(485, 155);
                label6.Font = new Font("Segoe UI", 9);
                label6.AutoSize = true;
                label6.Visible = true;
                this.Controls.Add(label6);

                number3 = new System.Windows.Forms.TextBox();
                number3.Location = new Point(545, 155);
                number3.AutoSize = true;
                number3.Visible = true;
                this.Controls.Add(number3);

                label7 = new System.Windows.Forms.Label();
                label7.Text = "a (m/s²):";
                label7.Location = new Point(485, 185);
                label7.Font = new Font("Segoe UI", 9);
                label7.AutoSize = true;
                label7.Visible = true;
                this.Controls.Add(label7);

                number4 = new System.Windows.Forms.TextBox();
                number4.Location = new Point(545, 185);
                number4.AutoSize = true;
                number4.Visible = true;
                this.Controls.Add(number4);

                label8 = new System.Windows.Forms.Label();
                label8.Text = "t (s):";
                label8.Location = new Point(485, 215);
                label8.Font = new Font("Segoe UI", 9);
                label8.AutoSize = true;
                label8.Visible = true;
                this.Controls.Add(label8);

                number5 = new System.Windows.Forms.TextBox();
                number5.Location = new Point(535, 215);
                number5.AutoSize = true;
                number5.Visible = true;
                this.Controls.Add(number5);

                Enviar = new System.Windows.Forms.Button();
                Enviar.Text = "Enviar";
                Enviar.Location = new Point(485, 255);
                Enviar.AutoSize = true;
                Enviar.Visible = true;
                Enviar.Click += Button6_Click;
                this.Controls.Add(Enviar);

                Limpar = new System.Windows.Forms.Button();
                Limpar.Text = "Limpar";
                Limpar.Location = new Point(565, 255);
                Limpar.AutoSize = true;
                Limpar.Visible = true;
                Limpar.Click += Button3_Click;
                this.Controls.Add(Limpar);

            }else if (sub =="Equação de Torricelli")
            {
                this.Controls.Remove(label3);
                this.Controls.Remove(label4);
                this.Controls.Remove(label5);
                this.Controls.Remove(label6);
                this.Controls.Remove(label7);
                this.Controls.Remove(label8);
                this.Controls.Remove(number1);
                this.Controls.Remove(number2);
                this.Controls.Remove(number3);
                this.Controls.Remove(number4);
                this.Controls.Remove(number5);
                this.Controls.Remove(Enviar);
                this.Controls.Remove(Limpar);
                this.Controls.Remove(dataGrid);

                label3 = new System.Windows.Forms.Label();
                label3.Text = "V² = V₀² + 2.a.Δs";
                label3.Location = new Point(500, 50);
                label3.Font = new Font("Segoe UI", 15);
                label3.AutoSize = true;
                label3.Visible = true;
                this.Controls.Add(label3);

                label4 = new System.Windows.Forms.Label();
                label4.Text = "V (m/s):";
                label4.Location = new Point(485, 95);
                label4.Font = new Font("Segoe UI", 9);
                label4.AutoSize = true;
                label4.Visible = true;
                this.Controls.Add(label4);

                number1 = new System.Windows.Forms.TextBox();
                number1.Location = new Point(535, 95);
                number1.AutoSize = true;
                number1.Visible = true;
                this.Controls.Add(number1);

                label5 = new System.Windows.Forms.Label();
                label5.Text = "V₀ (m/s):";
                label5.Location = new Point(485, 125);
                label5.Font = new Font("Segoe UI", 9);
                label5.AutoSize = true;
                label5.Visible = true;
                this.Controls.Add(label5);

                number2 = new System.Windows.Forms.TextBox();
                number2.Location = new Point(540, 125);
                number2.AutoSize = true;
                number2.Visible = true;
                this.Controls.Add(number2);

                label6 = new System.Windows.Forms.Label();
                label6.Text = "a (m/s²):";
                label6.Location = new Point(485, 155);
                label6.Font = new Font("Segoe UI", 9);
                label6.AutoSize = true;
                label6.Visible = true;
                this.Controls.Add(label6);

                number3 = new System.Windows.Forms.TextBox();
                number3.Location = new Point(545, 155);
                number3.AutoSize = true;
                number3.Visible = true;
                this.Controls.Add(number3);

                label7 = new System.Windows.Forms.Label();
                label7.Text = "s (m):";
                label7.Location = new Point(485, 185);
                label7.Font = new Font("Segoe UI", 9);
                label7.AutoSize = true;
                label7.Visible = true;
                this.Controls.Add(label7);

                number4 = new System.Windows.Forms.TextBox();
                number4.Location = new Point(525, 185);
                number4.AutoSize = true;
                number4.Visible = true;
                this.Controls.Add(number4);

                label8 = new System.Windows.Forms.Label();
                label8.Text = "s₀ (m):";
                label8.Location = new Point(485, 215);
                label8.Font = new Font("Segoe UI", 9);
                label8.AutoSize = true;
                label8.Visible = true;
                this.Controls.Add(label8);

                number5 = new System.Windows.Forms.TextBox();
                number5.Location = new Point(535, 215);
                number5.AutoSize = true;
                number5.Visible = true;
                this.Controls.Add(number5);

                Enviar = new System.Windows.Forms.Button();
                Enviar.Text = "Enviar";
                Enviar.Location = new Point(485, 255);
                Enviar.AutoSize = true;
                Enviar.Visible = true;
                Enviar.Click += Button7_Click;
                this.Controls.Add(Enviar);

                Limpar = new System.Windows.Forms.Button();
                Limpar.Text = "Limpar";
                Limpar.Location = new Point(565, 255);
                Limpar.AutoSize = true;
                Limpar.Visible = true;
                Limpar.Click += Button3_Click;
                this.Controls.Add(Limpar);
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(dataGrid);

            Dictionary<string, double?> variaveis = new Dictionary<string, double?>();
            variaveis["v"] = number1.Text == "" ? null : Convert.ToDouble(number1.Text);
            variaveis["v0"] = number2.Text == "" ? null : Convert.ToDouble(number2.Text);
            variaveis["a"] = number3.Text == "" ? null : Convert.ToDouble(number3.Text);
            variaveis["t"] = number4.Text == "" ? null : Convert.ToDouble(number4.Text);

            string campos = "";
            string valores = "";
            int c = 0;

            foreach (KeyValuePair<string, double?> v in variaveis)
            {
                if (v.Value != null)
                {
                    if (campos != "")
                    {
                        campos += ",";
                        valores += ",";
                    }
                    campos += v.Key;
                    valores += v.Value;
                }
                else
                {
                    c++;
                }
            }

            if (c != 1)
            {
                MessageBox.Show("Só pode haver uma variável vazia.");
            }

            trabalhoconn = new MySqlConnection("server=localhost; database=trabalho; uid=root; pwd=");
            trabalhoconn.Open();
            string sql = string.Empty;
            sql = "delete from muv_h";
            MySqlCommand command_1 = new MySqlCommand(sql, trabalhoconn);
            command_1.ExecuteNonQuery();
            sql = "insert into muv (" + campos + ") values (" + valores + ")";
            MySqlCommand command_2 = new MySqlCommand(sql, trabalhoconn);
            command_2.ExecuteNonQuery();
            sql = "select v_calculado, v0_calculado, a_calculado, t_calculado from muv_h";
            MySqlDataAdapter data = new MySqlDataAdapter(sql, trabalhoconn);
            DataTable dt = new DataTable();
            data.Fill(dt);

            dataGrid = new System.Windows.Forms.DataGridView();
            dataGrid.Location = new Point(300, 275);
            dataGrid.AutoSize = true;
            dataGrid.Visible = true;
            this.Controls.Add(dataGrid);

            dataGrid.DataSource = dt;
            trabalhoconn.Close();
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(dataGrid);

            Dictionary<string, double?> variaveis = new Dictionary<string, double?>();
            variaveis["s"] = number1.Text == "" ? null : Convert.ToDouble(number1.Text);
            variaveis["s0"] = number2.Text == "" ? null : Convert.ToDouble(number2.Text);
            variaveis["v0"] = number3.Text == "" ? null : Convert.ToDouble(number3.Text);
            variaveis["a"] = number4.Text == "" ? null : Convert.ToDouble(number4.Text);
            variaveis["t"] = number5.Text == "" ? null : Convert.ToDouble(number5.Text);

            string campos = "";
            string valores = "";
            int c = 0;

            foreach (KeyValuePair<string, double?> v in variaveis)
            {
                if (v.Value != null)
                {
                    if (campos != "")
                    {
                        campos += ",";
                        valores += ",";
                    }
                    campos += v.Key;
                    valores += v.Value;
                }
                else
                {
                    c++;
                }
            }

            if (c != 1)
            {
                MessageBox.Show("Só pode haver uma variável vazia.");
            }

            trabalhoconn = new MySqlConnection("server=localhost; database=trabalho; uid=root; pwd=");
            trabalhoconn.Open();
            string sql = string.Empty;
            sql = "delete from muv_s";
            MySqlCommand command_1 = new MySqlCommand(sql, trabalhoconn);
            command_1.ExecuteNonQuery();
            sql = "insert into muv (" + campos + ") values (" + valores + ")";
            MySqlCommand command_2 = new MySqlCommand(sql, trabalhoconn);
            command_2.ExecuteNonQuery();
            sql = "select s_calculado, s0_calculado, v0_calculado, a_calculado, t_calculado from muv_s";
            MySqlDataAdapter data = new MySqlDataAdapter(sql, trabalhoconn);
            DataTable dt = new DataTable();
            data.Fill(dt);

            dataGrid = new System.Windows.Forms.DataGridView();
            dataGrid.Location = new Point(250, 295);
            dataGrid.AutoSize = true;
            dataGrid.Visible = true;
            this.Controls.Add(dataGrid);

            dataGrid.DataSource = dt;
            trabalhoconn.Close();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(dataGrid);

            Dictionary<string, double?> variaveis = new Dictionary<string, double?>();
            variaveis["v"] = number1.Text == "" ? null : Convert.ToDouble(number1.Text);
            variaveis["v0"] = number2.Text == "" ? null : Convert.ToDouble(number2.Text);
            variaveis["a"] = number3.Text == "" ? null : Convert.ToDouble(number3.Text);
            variaveis["s"] = number4.Text == "" ? null : Convert.ToDouble(number4.Text);
            variaveis["s0"] = number5.Text == "" ? null : Convert.ToDouble(number5.Text);

            string campos = "";
            string valores = "";
            int c = 0;

            foreach (KeyValuePair<string, double?> v in variaveis)
            {
                if (v.Value != null)
                {
                    if (campos != "")
                    {
                        campos += ",";
                        valores += ",";
                    }
                    campos += v.Key;
                    valores += v.Value;
                }
                else
                {
                    c++;
                }
            }

            if (c != 1)
            {
                MessageBox.Show("Só pode haver uma variável vazia.");
            }

            trabalhoconn = new MySqlConnection("server=localhost; database=trabalho; uid=root; pwd=");
            trabalhoconn.Open();
            string sql = string.Empty;
            sql = "delete from muv_t";
            MySqlCommand command_1 = new MySqlCommand(sql, trabalhoconn);
            command_1.ExecuteNonQuery();
            sql = "insert into muv (" + campos + ") values (" + valores + ")";
            MySqlCommand command_2 = new MySqlCommand(sql, trabalhoconn);
            command_2.ExecuteNonQuery();
            sql = "select v_calculado, v0_calculado, a_calculado, s_calculado, s0_calculado from muv_t";
            MySqlDataAdapter data = new MySqlDataAdapter(sql, trabalhoconn);
            DataTable dt = new DataTable();
            data.Fill(dt);

            dataGrid = new System.Windows.Forms.DataGridView();
            dataGrid.Location = new Point(250, 295);
            dataGrid.AutoSize = true;
            dataGrid.Visible = true;
            this.Controls.Add(dataGrid);

            dataGrid.DataSource = dt;
            trabalhoconn.Close();
        }
        private void Button8_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(dataGrid);

            Dictionary<string, double?> variaveis = new Dictionary<string, double?>();
            variaveis["vm"] = number1.Text == "" ? null : Convert.ToDouble(number1.Text);
            variaveis["s"] = number2.Text == "" ? null : Convert.ToDouble(number2.Text);
            variaveis["s0"] = number3.Text == "" ? null : Convert.ToDouble(number3.Text);
            variaveis["t"] = number4.Text == "" ? null : Convert.ToDouble(number4.Text);
            variaveis["t0"] = number5.Text == "" ? null : Convert.ToDouble(number5.Text);

            string campos = "";
            string valores = "";
            int c = 0;

            foreach (KeyValuePair<string, double?> v in variaveis)
            {
                if (v.Value != null)
                {
                    if (campos != "")
                    {
                        campos += ",";
                        valores += ",";
                    }
                    campos += v.Key;
                    valores += v.Value;
                }
                else
                {
                    c++;
                }
            }

            if (c != 1)
            {
                MessageBox.Show("Só pode haver uma variável vazia.");
            }

            trabalhoconn = new MySqlConnection("server=localhost; database=trabalho; uid=root; pwd=");
            trabalhoconn.Open();
            string sql = string.Empty;
            sql = "delete from vm_calculos";
            MySqlCommand command_1 = new MySqlCommand(sql, trabalhoconn);
            command_1.ExecuteNonQuery();
            sql = "insert into vm (" + campos + ") values (" + valores + ")";
            MySqlCommand command_2 = new MySqlCommand(sql, trabalhoconn);
            command_2.ExecuteNonQuery();
            sql = "select s_calculado, s0_calculado, t_calculado, t0_calculado, vm_calculado from vm_calculos";
            MySqlDataAdapter data = new MySqlDataAdapter(sql, trabalhoconn);
            DataTable dt = new DataTable();
            data.Fill(dt);

            dataGrid = new System.Windows.Forms.DataGridView();
            dataGrid.Location = new Point(250, 295);
            dataGrid.AutoSize = true;
            dataGrid.Visible = true;
            this.Controls.Add(dataGrid);

            dataGrid.DataSource = dt;
            trabalhoconn.Close();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(dataGrid);

            Dictionary<string, double?> variaveis = new Dictionary<string, double?>();
            variaveis["am"] = number1.Text == "" ? null : Convert.ToDouble(number1.Text);
            variaveis["v"] = number2.Text == "" ? null : Convert.ToDouble(number2.Text);
            variaveis["v0"] = number3.Text == "" ? null : Convert.ToDouble(number3.Text);
            variaveis["t"] = number4.Text == "" ? null : Convert.ToDouble(number4.Text);
            variaveis["t0"] = number5.Text == "" ? null : Convert.ToDouble(number5.Text);

            string campos = "";
            string valores = "";
            int c = 0;

            foreach (KeyValuePair<string, double?> v in variaveis)
            {
                if (v.Value != null)
                {
                    if (campos != "")
                    {
                        campos += ",";
                        valores += ",";
                    }
                    campos += v.Key;
                    valores += v.Value;
                }
                else
                {
                    c++;
                }
            }

            if (c != 1)
            {
                MessageBox.Show("Só pode haver uma variável vazia.");
            }

            trabalhoconn = new MySqlConnection("server=localhost; database=trabalho; uid=root; pwd=");
            trabalhoconn.Open();
            string sql = string.Empty;
            sql = "delete from am_calculos";
            MySqlCommand command_1 = new MySqlCommand(sql, trabalhoconn);
            command_1.ExecuteNonQuery();
            sql = "insert into am (" + campos + ") values (" + valores + ")";
            MySqlCommand command_2 = new MySqlCommand(sql, trabalhoconn);
            command_2.ExecuteNonQuery();
            sql = "select v_calculado, v0_calculado, t_calculado, t0_calculado, am_calculado from am_calculos";
            MySqlDataAdapter data = new MySqlDataAdapter(sql, trabalhoconn);
            DataTable dt = new DataTable();
            data.Fill(dt);

            dataGrid = new System.Windows.Forms.DataGridView();
            dataGrid.Location = new Point(250, 295);
            dataGrid.AutoSize = true;
            dataGrid.Visible = true;
            this.Controls.Add(dataGrid);

            dataGrid.DataSource = dt;
            trabalhoconn.Close();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(dataGrid);

            Dictionary<string, double?> variaveis = new Dictionary<string, double?>();
            variaveis["f"] = number1.Text == "" ? null : Convert.ToDouble(number1.Text);
            variaveis["m"] = number2.Text == "" ? null : Convert.ToDouble(number2.Text);
            variaveis["a"] = number3.Text == "" ? null : Convert.ToDouble(number3.Text);

            string campos = "";
            string valores = "";
            int c = 0;

            foreach (KeyValuePair<string, double?> v in variaveis)
            {
                if (v.Value != null)
                {
                    if (campos != "")
                    {
                        campos += ",";
                        valores += ",";
                    }
                    campos += v.Key;
                    valores += v.Value;
                }
                else
                {
                    c++;
                }
            }

            if (c != 1)
            {
                MessageBox.Show("Só pode haver uma variável vazia.");
            }

            trabalhoconn = new MySqlConnection("server=localhost; database=trabalho; uid=root; pwd=");
            trabalhoconn.Open();
            string sql = string.Empty;
            sql = "delete from forca_calculos";
            MySqlCommand command_1 = new MySqlCommand(sql, trabalhoconn);
            command_1.ExecuteNonQuery();
            sql = "insert into forca (" + campos + ") values (" + valores + ")";
            MySqlCommand command_2 = new MySqlCommand(sql, trabalhoconn);
            command_2.ExecuteNonQuery();
            sql = "select f_calculado, m_calculado, a_calculado from forca_calculos";
            MySqlDataAdapter data = new MySqlDataAdapter(sql, trabalhoconn);
            DataTable dt = new DataTable();
            data.Fill(dt);

            dataGrid = new System.Windows.Forms.DataGridView();
            dataGrid.Location = new Point(250, 295);
            dataGrid.AutoSize = true;
            dataGrid.Visible = true;
            this.Controls.Add(dataGrid);

            dataGrid.DataSource = dt;
            trabalhoconn.Close();
        }
    }
}
