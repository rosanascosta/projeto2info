using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    public partial class FisicaIII : Form
    {
        private System.Windows.Forms.Label label2 = null!;
        private System.Windows.Forms.Label label3 = null!;
        private System.Windows.Forms.Label label4 = null!;
        private System.Windows.Forms.Label label5 = null!;
        private System.Windows.Forms.Label label6 = null!;
        private System.Windows.Forms.Label label7 = null!;
        private System.Windows.Forms.Label label8 = null!;
        private System.Windows.Forms.Label label9 = null!;
        private System.Windows.Forms.Label label10 = null!;
        private System.Windows.Forms.TextBox number1 = null!;
        private System.Windows.Forms.TextBox number2 = null!;
        private System.Windows.Forms.TextBox number3 = null!;
        private System.Windows.Forms.TextBox number4 = null!;
        private System.Windows.Forms.TextBox number5 = null!;
        private System.Windows.Forms.TextBox number6 = null!;
        private System.Windows.Forms.TextBox number7 = null!;
        private System.Windows.Forms.Button Enviar = null!;
        private System.Windows.Forms.Button Enviarsub = null!;
        private System.Windows.Forms.Button Limpar = null!;
        private System.Windows.Forms.ComboBox combo = null!;
        private System.Windows.Forms.DataGridView dataGrid = null!;

        public MySqlConnection trabalhoconn = null!;
        public MySqlDataAdapter mAdapter = null!;
        public DataSet mDataSet = null!;
        public FisicaIII()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selecionado = comboBox1.Text;
            if (selecionado == "Campo Magnético")
            {
                this.Controls.Remove(label2);
                this.Controls.Remove(label3);
                this.Controls.Remove(label4);
                this.Controls.Remove(label5);
                this.Controls.Remove(label6);
                this.Controls.Remove(label7);
                this.Controls.Remove(label8);
                this.Controls.Remove(label9);
                this.Controls.Remove(label10);
                this.Controls.Remove(number1);
                this.Controls.Remove(number2);
                this.Controls.Remove(number3);
                this.Controls.Remove(number4);
                this.Controls.Remove(number5);
                this.Controls.Remove(number6);
                this.Controls.Remove(number7);
                this.Controls.Remove(combo);
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
                combo.Items.Add("Em fio");
                combo.Items.Add("Em espira circular");
                combo.Items.Add("Em bobina");
                combo.Items.Add("Em solenoide");
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
                Enviarsub.Click += Button2_Click;
                this.Controls.Add(Enviarsub);
            }
            else if (selecionado == "Força Magnética")
            {
                this.Controls.Remove(label2);
                this.Controls.Remove(label3);
                this.Controls.Remove(label4);
                this.Controls.Remove(label5);
                this.Controls.Remove(label6);
                this.Controls.Remove(label7);
                this.Controls.Remove(label8);
                this.Controls.Remove(label9);
                this.Controls.Remove(label10);
                this.Controls.Remove(number1);
                this.Controls.Remove(number2);
                this.Controls.Remove(number3);
                this.Controls.Remove(number4);
                this.Controls.Remove(number5);
                this.Controls.Remove(number6);
                this.Controls.Remove(number7);
                this.Controls.Remove(combo);
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
                combo.Items.Add("Partícula carregada");
                combo.Items.Add("Em um fio condutor");
                combo.Items.Add("Em fios paralelos");
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
                Enviarsub.Click += Button2_Click;
                this.Controls.Add(Enviarsub);
            }
            else if (selecionado == "Indução Magnética")
            {
                this.Controls.Remove(label2);
                this.Controls.Remove(label3);
                this.Controls.Remove(label4);
                this.Controls.Remove(label5);
                this.Controls.Remove(label6);
                this.Controls.Remove(label7);
                this.Controls.Remove(label8);
                this.Controls.Remove(label9);
                this.Controls.Remove(label10);
                this.Controls.Remove(number1);
                this.Controls.Remove(number2);
                this.Controls.Remove(number3);
                this.Controls.Remove(number4);
                this.Controls.Remove(number5);
                this.Controls.Remove(number6);
                this.Controls.Remove(number7);
                this.Controls.Remove(combo);
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
                combo.Items.Add("Fluxo magnético");
                combo.Items.Add("Lei de Faraday");
                combo.Items.Add("Transformador");
                combo.Items.Add("Potência em transformador");
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
                Enviarsub.Click += Button2_Click;
                this.Controls.Add(Enviarsub);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string sub = combo.Text;
            if (sub == "Em fio")
            {
                this.Controls.Remove(label3);
                this.Controls.Remove(label4);
                this.Controls.Remove(label5);
                this.Controls.Remove(label6);
                this.Controls.Remove(label7);
                this.Controls.Remove(label8);
                this.Controls.Remove(label9);
                this.Controls.Remove(label10);
                this.Controls.Remove(number1);
                this.Controls.Remove(number2);
                this.Controls.Remove(number3);
                this.Controls.Remove(number4);
                this.Controls.Remove(number5);
                this.Controls.Remove(number6);
                this.Controls.Remove(number7);
                this.Controls.Remove(Enviar);
                this.Controls.Remove(Limpar);
                this.Controls.Remove(dataGrid);

                label3 = new System.Windows.Forms.Label();
                label3.Text = "B = μ·i / 2·π·r";
                label3.Location = new Point(500, 50);
                label3.Font = new Font("Segoe UI", 15);
                label3.AutoSize = true;
                label3.Visible = true;
                this.Controls.Add(label3);

                label4 = new System.Windows.Forms.Label();
                label4.Text = "B (T):";
                label4.Location = new Point(485, 95);
                label4.Font = new Font("Segoe UI", 9);
                label4.AutoSize = true;
                label4.Visible = true;
                this.Controls.Add(label4);

                number1 = new System.Windows.Forms.TextBox();
                number1.Location = new Point(525, 95);
                number1.AutoSize = true;
                number1.Visible = true;
                this.Controls.Add(number1);

                label5 = new System.Windows.Forms.Label();
                label5.Text = "μ (Tm/A):";
                label5.Location = new Point(485, 125);
                label5.Font = new Font("Segoe UI", 9);
                label5.AutoSize = true;
                label5.Visible = true;
                this.Controls.Add(label5);

                number2 = new System.Windows.Forms.TextBox();
                number2.Location = new Point(545, 125);
                number2.AutoSize = true;
                number2.Visible = true;
                this.Controls.Add(number2);

                label6 = new System.Windows.Forms.Label();
                label6.Text = "i (A):";
                label6.Location = new Point(485, 155);
                label6.Font = new Font("Segoe UI", 9);
                label6.AutoSize = true;
                label6.Visible = true;
                this.Controls.Add(label6);

                number3 = new System.Windows.Forms.TextBox();
                number3.Location = new Point(525, 155);
                number3.AutoSize = true;
                number3.Visible = true;
                this.Controls.Add(number3);

                label7 = new System.Windows.Forms.Label();
                label7.Text = "r (m):";
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

                Enviar = new System.Windows.Forms.Button();
                Enviar.Text = "Enviar";
                Enviar.Location = new Point(485, 225);
                Enviar.AutoSize = true;
                Enviar.Visible = true;
                Enviar.Click += Button4_Click;
                this.Controls.Add(Enviar);

                Limpar = new System.Windows.Forms.Button();
                Limpar.Text = "Limpar";
                Limpar.Location = new Point(565, 225);
                Limpar.AutoSize = true;
                Limpar.Visible = true;
                Limpar.Click += Button3_Click;
                this.Controls.Add(Limpar);
            }
            else if (sub == "Em espira circular")
            {
                this.Controls.Remove(label3);
                this.Controls.Remove(label4);
                this.Controls.Remove(label5);
                this.Controls.Remove(label6);
                this.Controls.Remove(label7);
                this.Controls.Remove(label8);
                this.Controls.Remove(label9);
                this.Controls.Remove(label10);
                this.Controls.Remove(number1);
                this.Controls.Remove(number2);
                this.Controls.Remove(number3);
                this.Controls.Remove(number4);
                this.Controls.Remove(number5);
                this.Controls.Remove(number6);
                this.Controls.Remove(number7);
                this.Controls.Remove(Enviar);
                this.Controls.Remove(Limpar);
                this.Controls.Remove(dataGrid);

                label3 = new System.Windows.Forms.Label();
                label3.Text = "B = μ·i / 2·r";
                label3.Location = new Point(500, 50);
                label3.Font = new Font("Segoe UI", 15);
                label3.AutoSize = true;
                label3.Visible = true;
                this.Controls.Add(label3);

                label4 = new System.Windows.Forms.Label();
                label4.Text = "B (T):";
                label4.Location = new Point(485, 95);
                label4.Font = new Font("Segoe UI", 9);
                label4.AutoSize = true;
                label4.Visible = true;
                this.Controls.Add(label4);

                number1 = new System.Windows.Forms.TextBox();
                number1.Location = new Point(525, 95);
                number1.AutoSize = true;
                number1.Visible = true;
                this.Controls.Add(number1);

                label5 = new System.Windows.Forms.Label();
                label5.Text = "μ (Tm/A):";
                label5.Location = new Point(485, 125);
                label5.Font = new Font("Segoe UI", 9);
                label5.AutoSize = true;
                label5.Visible = true;
                this.Controls.Add(label5);

                number2 = new System.Windows.Forms.TextBox();
                number2.Location = new Point(545, 125);
                number2.AutoSize = true;
                number2.Visible = true;
                this.Controls.Add(number2);

                label6 = new System.Windows.Forms.Label();
                label6.Text = "i (A):";
                label6.Location = new Point(485, 155);
                label6.Font = new Font("Segoe UI", 9);
                label6.AutoSize = true;
                label6.Visible = true;
                this.Controls.Add(label6);

                number3 = new System.Windows.Forms.TextBox();
                number3.Location = new Point(525, 155);
                number3.AutoSize = true;
                number3.Visible = true;
                this.Controls.Add(number3);

                label7 = new System.Windows.Forms.Label();
                label7.Text = "r (m):";
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
            }
            else if (sub == "Em bobina")
            {
                this.Controls.Remove(label3);
                this.Controls.Remove(label4);
                this.Controls.Remove(label5);
                this.Controls.Remove(label6);
                this.Controls.Remove(label7);
                this.Controls.Remove(label8);
                this.Controls.Remove(label9);
                this.Controls.Remove(label10);
                this.Controls.Remove(number1);
                this.Controls.Remove(number2);
                this.Controls.Remove(number3);
                this.Controls.Remove(number4);
                this.Controls.Remove(number5);
                this.Controls.Remove(number6);
                this.Controls.Remove(number7);
                this.Controls.Remove(Enviar);
                this.Controls.Remove(Limpar);
                this.Controls.Remove(dataGrid);

                label3 = new System.Windows.Forms.Label();
                label3.Text = "B = (μ·i / 2·r) · N";
                label3.Location = new Point(500, 50);
                label3.Font = new Font("Segoe UI", 15);
                label3.AutoSize = true;
                label3.Visible = true;
                this.Controls.Add(label3);

                label4 = new System.Windows.Forms.Label();
                label4.Text = "B (T):";
                label4.Location = new Point(485, 95);
                label4.Font = new Font("Segoe UI", 9);
                label4.AutoSize = true;
                label4.Visible = true;
                this.Controls.Add(label4);

                number1 = new System.Windows.Forms.TextBox();
                number1.Location = new Point(525, 95);
                number1.AutoSize = true;
                number1.Visible = true;
                this.Controls.Add(number1);

                label5 = new System.Windows.Forms.Label();
                label5.Text = "μ (Tm/A):";
                label5.Location = new Point(485, 125);
                label5.Font = new Font("Segoe UI", 9);
                label5.AutoSize = true;
                label5.Visible = true;
                this.Controls.Add(label5);

                number2 = new System.Windows.Forms.TextBox();
                number2.Location = new Point(545, 125);
                number2.AutoSize = true;
                number2.Visible = true;
                this.Controls.Add(number2);

                label6 = new System.Windows.Forms.Label();
                label6.Text = "i (A):";
                label6.Location = new Point(485, 155);
                label6.Font = new Font("Segoe UI", 9);
                label6.AutoSize = true;
                label6.Visible = true;
                this.Controls.Add(label6);

                number3 = new System.Windows.Forms.TextBox();
                number3.Location = new Point(525, 155);
                number3.AutoSize = true;
                number3.Visible = true;
                this.Controls.Add(number3);

                label7 = new System.Windows.Forms.Label();
                label7.Text = "r (m):";
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
                label8.Text = "N:";
                label8.Location = new Point(485, 215);
                label8.Font = new Font("Segoe UI", 9);
                label8.AutoSize = true;
                label8.Visible = true;
                this.Controls.Add(label8);

                number5 = new System.Windows.Forms.TextBox();
                number5.Location = new Point(515, 215);
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
            }
            else if (sub == "Em solenoide")
            {
                this.Controls.Remove(label3);
                this.Controls.Remove(label4);
                this.Controls.Remove(label5);
                this.Controls.Remove(label6);
                this.Controls.Remove(label7);
                this.Controls.Remove(label8);
                this.Controls.Remove(label9);
                this.Controls.Remove(label10);
                this.Controls.Remove(number1);
                this.Controls.Remove(number2);
                this.Controls.Remove(number3);
                this.Controls.Remove(number4);
                this.Controls.Remove(number5);
                this.Controls.Remove(number6);
                this.Controls.Remove(number7);
                this.Controls.Remove(Enviar);
                this.Controls.Remove(Limpar);
                this.Controls.Remove(dataGrid);

                label3 = new System.Windows.Forms.Label();
                label3.Text = "B = μ·i · (N / l)";
                label3.Location = new Point(500, 50);
                label3.Font = new Font("Segoe UI", 15);
                label3.AutoSize = true;
                label3.Visible = true;
                this.Controls.Add(label3);

                label4 = new System.Windows.Forms.Label();
                label4.Text = "B (T):";
                label4.Location = new Point(485, 95);
                label4.Font = new Font("Segoe UI", 9);
                label4.AutoSize = true;
                label4.Visible = true;
                this.Controls.Add(label4);

                number1 = new System.Windows.Forms.TextBox();
                number1.Location = new Point(525, 95);
                number1.AutoSize = true;
                number1.Visible = true;
                this.Controls.Add(number1);

                label5 = new System.Windows.Forms.Label();
                label5.Text = "μ (Tm/A):";
                label5.Location = new Point(485, 125);
                label5.Font = new Font("Segoe UI", 9);
                label5.AutoSize = true;
                label5.Visible = true;
                this.Controls.Add(label5);

                number2 = new System.Windows.Forms.TextBox();
                number2.Location = new Point(545, 125);
                number2.AutoSize = true;
                number2.Visible = true;
                this.Controls.Add(number2);

                label6 = new System.Windows.Forms.Label();
                label6.Text = "i (A):";
                label6.Location = new Point(485, 155);
                label6.Font = new Font("Segoe UI", 9);
                label6.AutoSize = true;
                label6.Visible = true;
                this.Controls.Add(label6);

                number3 = new System.Windows.Forms.TextBox();
                number3.Location = new Point(525, 155);
                number3.AutoSize = true;
                number3.Visible = true;
                this.Controls.Add(number3);

                label7 = new System.Windows.Forms.Label();
                label7.Text = "N:";
                label7.Location = new Point(485, 185);
                label7.Font = new Font("Segoe UI", 9);
                label7.AutoSize = true;
                label7.Visible = true;
                this.Controls.Add(label7);

                number4 = new System.Windows.Forms.TextBox();
                number4.Location = new Point(515, 185);
                number4.AutoSize = true;
                number4.Visible = true;
                this.Controls.Add(number4);

                label8 = new System.Windows.Forms.Label();
                label8.Text = "l (m):";
                label8.Location = new Point(485, 215);
                label8.Font = new Font("Segoe UI", 9);
                label8.AutoSize = true;
                label8.Visible = true;
                this.Controls.Add(label8);

                number5 = new System.Windows.Forms.TextBox();
                number5.Location = new Point(525, 215);
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
            else if (sub == "Partícula carregada")
            {
                this.Controls.Remove(label3);
                this.Controls.Remove(label4);
                this.Controls.Remove(label5);
                this.Controls.Remove(label6);
                this.Controls.Remove(label7);
                this.Controls.Remove(label8);
                this.Controls.Remove(label9);
                this.Controls.Remove(label10);
                this.Controls.Remove(number1);
                this.Controls.Remove(number2);
                this.Controls.Remove(number3);
                this.Controls.Remove(number4);
                this.Controls.Remove(number5);
                this.Controls.Remove(number6);
                this.Controls.Remove(number7);
                this.Controls.Remove(Enviar);
                this.Controls.Remove(Limpar);
                this.Controls.Remove(dataGrid);

                label3 = new System.Windows.Forms.Label();
                label3.Text = "F = B·q·v · senθ";
                label3.Location = new Point(500, 50);
                label3.Font = new Font("Segoe UI", 15);
                label3.AutoSize = true;
                label3.Visible = true;
                this.Controls.Add(label3);

                label4 = new System.Windows.Forms.Label();
                label4.Text = "F (N):";
                label4.Location = new Point(485, 95);
                label4.Font = new Font("Segoe UI", 9);
                label4.AutoSize = true;
                label4.Visible = true;
                this.Controls.Add(label4);

                number1 = new System.Windows.Forms.TextBox();
                number1.Location = new Point(525, 95);
                number1.AutoSize = true;
                number1.Visible = true;
                this.Controls.Add(number1);

                label5 = new System.Windows.Forms.Label();
                label5.Text = "B (T):";
                label5.Location = new Point(485, 125);
                label5.Font = new Font("Segoe UI", 9);
                label5.AutoSize = true;
                label5.Visible = true;
                this.Controls.Add(label5);

                number2 = new System.Windows.Forms.TextBox();
                number2.Location = new Point(525, 125);
                number2.AutoSize = true;
                number2.Visible = true;
                this.Controls.Add(number2);

                label6 = new System.Windows.Forms.Label();
                label6.Text = "q (T):";
                label6.Location = new Point(485, 155);
                label6.Font = new Font("Segoe UI", 9);
                label6.AutoSize = true;
                label6.Visible = true;
                this.Controls.Add(label6);

                number3 = new System.Windows.Forms.TextBox();
                number3.Location = new Point(525, 155);
                number3.AutoSize = true;
                number3.Visible = true;
                this.Controls.Add(number3);

                label7 = new System.Windows.Forms.Label();
                label7.Text = "v (T):";
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
                label8.Text = "θ (°):";
                label8.Location = new Point(485, 215);
                label8.Font = new Font("Segoe UI", 9);
                label8.AutoSize = true;
                label8.Visible = true;
                this.Controls.Add(label8);

                number5 = new System.Windows.Forms.TextBox();
                number5.Location = new Point(525, 215);
                number5.AutoSize = true;
                number5.Visible = true;
                this.Controls.Add(number5);

                Enviar = new System.Windows.Forms.Button();
                Enviar.Text = "Enviar";
                Enviar.Location = new Point(485, 245);
                Enviar.AutoSize = true;
                Enviar.Visible = true;
                Enviar.Click += Button8_Click;
                this.Controls.Add(Enviar);

                Limpar = new System.Windows.Forms.Button();
                Limpar.Text = "Limpar";
                Limpar.Location = new Point(565, 245);
                Limpar.AutoSize = true;
                Limpar.Visible = true;
                Limpar.Click += Button3_Click;
                this.Controls.Add(Limpar);
            }
            else if (sub == "Em um fio condutor")
            {
                this.Controls.Remove(label3);
                this.Controls.Remove(label4);
                this.Controls.Remove(label5);
                this.Controls.Remove(label6);
                this.Controls.Remove(label7);
                this.Controls.Remove(label8);
                this.Controls.Remove(label9);
                this.Controls.Remove(label10);
                this.Controls.Remove(number1);
                this.Controls.Remove(number2);
                this.Controls.Remove(number3);
                this.Controls.Remove(number4);
                this.Controls.Remove(number5);
                this.Controls.Remove(number6);
                this.Controls.Remove(number7);
                this.Controls.Remove(Enviar);
                this.Controls.Remove(Limpar);
                this.Controls.Remove(dataGrid);

                label3 = new System.Windows.Forms.Label();
                label3.Text = "F = B·i·l · senθ";
                label3.Location = new Point(500, 50);
                label3.Font = new Font("Segoe UI", 15);
                label3.AutoSize = true;
                label3.Visible = true;
                this.Controls.Add(label3);

                label4 = new System.Windows.Forms.Label();
                label4.Text = "F (N):";
                label4.Location = new Point(485, 95);
                label4.Font = new Font("Segoe UI", 9);
                label4.AutoSize = true;
                label4.Visible = true;
                this.Controls.Add(label4);

                number1 = new System.Windows.Forms.TextBox();
                number1.Location = new Point(525, 95);
                number1.AutoSize = true;
                number1.Visible = true;
                this.Controls.Add(number1);

                label5 = new System.Windows.Forms.Label();
                label5.Text = "B (T):";
                label5.Location = new Point(485, 125);
                label5.Font = new Font("Segoe UI", 9);
                label5.AutoSize = true;
                label5.Visible = true;
                this.Controls.Add(label5);

                number2 = new System.Windows.Forms.TextBox();
                number2.Location = new Point(525, 125);
                number2.AutoSize = true;
                number2.Visible = true;
                this.Controls.Add(number2);

                label6 = new System.Windows.Forms.Label();
                label6.Text = "i (A):";
                label6.Location = new Point(485, 155);
                label6.Font = new Font("Segoe UI", 9);
                label6.AutoSize = true;
                label6.Visible = true;
                this.Controls.Add(label6);

                number3 = new System.Windows.Forms.TextBox();
                number3.Location = new Point(525, 155);
                number3.AutoSize = true;
                number3.Visible = true;
                this.Controls.Add(number3);

                label7 = new System.Windows.Forms.Label();
                label7.Text = "l (m):";
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
                label8.Text = "θ (°):";
                label8.Location = new Point(485, 215);
                label8.Font = new Font("Segoe UI", 9);
                label8.AutoSize = true;
                label8.Visible = true;
                this.Controls.Add(label8);

                number5 = new System.Windows.Forms.TextBox();
                number5.Location = new Point(525, 215);
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
            if (sub == "Em fios paralelos")
            {
                this.Controls.Remove(label3);
                this.Controls.Remove(label4);
                this.Controls.Remove(label5);
                this.Controls.Remove(label6);
                this.Controls.Remove(label7);
                this.Controls.Remove(label8);
                this.Controls.Remove(label9);
                this.Controls.Remove(label10);
                this.Controls.Remove(number1);
                this.Controls.Remove(number2);
                this.Controls.Remove(number3);
                this.Controls.Remove(number4);
                this.Controls.Remove(number5);
                this.Controls.Remove(number6);
                this.Controls.Remove(number7);
                this.Controls.Remove(Enviar);
                this.Controls.Remove(Limpar);
                this.Controls.Remove(dataGrid);

                label3 = new System.Windows.Forms.Label();
                label3.Text = "F = μ·i₁·i₂·l / 2·π·d";
                label3.Location = new Point(500, 10);
                label3.Font = new Font("Segoe UI", 15);
                label3.AutoSize = true;
                label3.Visible = true;
                this.Controls.Add(label3);

                label4 = new System.Windows.Forms.Label();
                label4.Text = "F (N):";
                label4.Location = new Point(485, 55);
                label4.Font = new Font("Segoe UI", 9);
                label4.AutoSize = true;
                label4.Visible = true;
                this.Controls.Add(label4);

                number1 = new System.Windows.Forms.TextBox();
                number1.Location = new Point(525, 55);
                number1.AutoSize = true;
                number1.Visible = true;
                this.Controls.Add(number1);

                label5 = new System.Windows.Forms.Label();
                label5.Text = "μ (Tm/A):";
                label5.Location = new Point(485, 85);
                label5.Font = new Font("Segoe UI", 9);
                label5.AutoSize = true;
                label5.Visible = true;
                this.Controls.Add(label5);

                number2 = new System.Windows.Forms.TextBox();
                number2.Location = new Point(545, 85);
                number2.AutoSize = true;
                number2.Visible = true;
                this.Controls.Add(number2);

                label6 = new System.Windows.Forms.Label();
                label6.Text = "i₁ (A):";
                label6.Location = new Point(485, 115);
                label6.Font = new Font("Segoe UI", 9);
                label6.AutoSize = true;
                label6.Visible = true;
                this.Controls.Add(label6);

                number3 = new System.Windows.Forms.TextBox();
                number3.Location = new Point(530, 115);
                number3.AutoSize = true;
                number3.Visible = true;
                this.Controls.Add(number3);

                label7 = new System.Windows.Forms.Label();
                label7.Text = "i₂ (A):";
                label7.Location = new Point(485, 145);
                label7.Font = new Font("Segoe UI", 9);
                label7.AutoSize = true;
                label7.Visible = true;
                this.Controls.Add(label7);

                number4 = new System.Windows.Forms.TextBox();
                number4.Location = new Point(530, 145);
                number4.AutoSize = true;
                number4.Visible = true;
                this.Controls.Add(number4);

                label8 = new System.Windows.Forms.Label();
                label8.Text = "l (m):";
                label8.Location = new Point(485, 175);
                label8.Font = new Font("Segoe UI", 9);
                label8.AutoSize = true;
                label8.Visible = true;
                this.Controls.Add(label8);

                number5 = new System.Windows.Forms.TextBox();
                number5.Location = new Point(525, 175);
                number5.AutoSize = true;
                number5.Visible = true;
                this.Controls.Add(number5);

                label9 = new System.Windows.Forms.Label();
                label9.Text = "d (m):";
                label9.Location = new Point(485, 205);
                label9.Font = new Font("Segoe UI", 9);
                label9.AutoSize = true;
                label9.Visible = true;
                this.Controls.Add(label9);

                number6 = new System.Windows.Forms.TextBox();
                number6.Location = new Point(525, 205);
                number6.AutoSize = true;
                number6.Visible = true;
                this.Controls.Add(number6);

                Enviar = new System.Windows.Forms.Button();
                Enviar.Text = "Enviar";
                Enviar.Location = new Point(485, 245);
                Enviar.AutoSize = true;
                Enviar.Visible = true;
                Enviar.Click += Button10_Click;
                this.Controls.Add(Enviar);

                Limpar = new System.Windows.Forms.Button();
                Limpar.Text = "Limpar";
                Limpar.Location = new Point(565, 245);
                Limpar.AutoSize = true;
                Limpar.Visible = true;
                Limpar.Click += Button3_Click;
                this.Controls.Add(Limpar);
            }
            else if (sub == "Fluxo magnético")
            {
                this.Controls.Remove(label3);
                this.Controls.Remove(label4);
                this.Controls.Remove(label5);
                this.Controls.Remove(label6);
                this.Controls.Remove(label7);
                this.Controls.Remove(label8);
                this.Controls.Remove(label9);
                this.Controls.Remove(label10);
                this.Controls.Remove(number1);
                this.Controls.Remove(number2);
                this.Controls.Remove(number3);
                this.Controls.Remove(number4);
                this.Controls.Remove(number5);
                this.Controls.Remove(number6);
                this.Controls.Remove(number7);
                this.Controls.Remove(Enviar);
                this.Controls.Remove(Limpar);
                this.Controls.Remove(dataGrid);

                label3 = new System.Windows.Forms.Label();
                label3.Text = "Φ = B·A · cosα";
                label3.Location = new Point(500, 50);
                label3.Font = new Font("Segoe UI", 15);
                label3.AutoSize = true;
                label3.Visible = true;
                this.Controls.Add(label3);

                label4 = new System.Windows.Forms.Label();
                label4.Text = "Φ (Wb):";
                label4.Location = new Point(485, 95);
                label4.Font = new Font("Segoe UI", 9);
                label4.AutoSize = true;
                label4.Visible = true;
                this.Controls.Add(label4);

                number1 = new System.Windows.Forms.TextBox();
                number1.Location = new Point(530, 95);
                number1.AutoSize = true;
                number1.Visible = true;
                this.Controls.Add(number1);

                label5 = new System.Windows.Forms.Label();
                label5.Text = "B (T):";
                label5.Location = new Point(485, 125);
                label5.Font = new Font("Segoe UI", 9);
                label5.AutoSize = true;
                label5.Visible = true;
                this.Controls.Add(label5);

                number2 = new System.Windows.Forms.TextBox();
                number2.Location = new Point(525, 125);
                number2.AutoSize = true;
                number2.Visible = true;
                this.Controls.Add(number2);

                label6 = new System.Windows.Forms.Label();
                label6.Text = "A (s):";
                label6.Location = new Point(485, 155);
                label6.Font = new Font("Segoe UI", 9);
                label6.AutoSize = true;
                label6.Visible = true;
                this.Controls.Add(label6);

                number3 = new System.Windows.Forms.TextBox();
                number3.Location = new Point(525, 155);
                number3.AutoSize = true;
                number3.Visible = true;
                this.Controls.Add(number3);

                label7 = new System.Windows.Forms.Label();
                label7.Text = "α (°):";
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

                Enviar = new System.Windows.Forms.Button();
                Enviar.Text = "Enviar";
                Enviar.Location = new Point(485, 225);
                Enviar.AutoSize = true;
                Enviar.Visible = true;
                Enviar.Click += Button11_Click;
                this.Controls.Add(Enviar);

                Limpar = new System.Windows.Forms.Button();
                Limpar.Text = "Limpar";
                Limpar.Location = new Point(565, 225);
                Limpar.AutoSize = true;
                Limpar.Visible = true;
                Limpar.Click += Button3_Click;
                this.Controls.Add(Limpar);
            }
            else if (sub == "Lei de Faraday")
            {
                this.Controls.Remove(label3);
                this.Controls.Remove(label4);
                this.Controls.Remove(label5);
                this.Controls.Remove(label6);
                this.Controls.Remove(label7);
                this.Controls.Remove(label8);
                this.Controls.Remove(label9);
                this.Controls.Remove(label10);
                this.Controls.Remove(number1);
                this.Controls.Remove(number2);
                this.Controls.Remove(number3);
                this.Controls.Remove(number4);
                this.Controls.Remove(number5);
                this.Controls.Remove(number6);
                this.Controls.Remove(number7);
                this.Controls.Remove(Enviar);
                this.Controls.Remove(Limpar);
                this.Controls.Remove(dataGrid);

                label3 = new System.Windows.Forms.Label();
                label3.Text = "ε = -ΔΦ / Δt";
                label3.Location = new Point(500, 10);
                label3.Font = new Font("Segoe UI", 15);
                label3.AutoSize = true;
                label3.Visible = true;
                this.Controls.Add(label3);

                label4 = new System.Windows.Forms.Label();
                label4.Text = "ε (V):";
                label4.Location = new Point(485, 55);
                label4.Font = new Font("Segoe UI", 9);
                label4.AutoSize = true;
                label4.Visible = true;
                this.Controls.Add(label4);

                number1 = new System.Windows.Forms.TextBox();
                number1.Location = new Point(525, 55);
                number1.AutoSize = true;
                number1.Visible = true;
                this.Controls.Add(number1);

                label5 = new System.Windows.Forms.Label();
                label5.Text = "Φ (Wb):";
                label5.Location = new Point(485, 85);
                label5.Font = new Font("Segoe UI", 9);
                label5.AutoSize = true;
                label5.Visible = true;
                this.Controls.Add(label5);

                number2 = new System.Windows.Forms.TextBox();
                number2.Location = new Point(530, 85);
                number2.AutoSize = true;
                number2.Visible = true;
                this.Controls.Add(number2);

                label6 = new System.Windows.Forms.Label();
                label6.Text = "Φ₀ (Wb):";
                label6.Location = new Point(485, 115);
                label6.Font = new Font("Segoe UI", 9);
                label6.AutoSize = true;
                label6.Visible = true;
                this.Controls.Add(label6);

                number3 = new System.Windows.Forms.TextBox();
                number3.Location = new Point(540, 115);
                number3.AutoSize = true;
                number3.Visible = true;
                this.Controls.Add(number3);

                label7 = new System.Windows.Forms.Label();
                label7.Text = "t (s):";
                label7.Location = new Point(485, 145);
                label7.Font = new Font("Segoe UI", 9);
                label7.AutoSize = true;
                label7.Visible = true;
                this.Controls.Add(label7);

                number4 = new System.Windows.Forms.TextBox();
                number4.Location = new Point(525, 145);
                number4.AutoSize = true;
                number4.Visible = true;
                this.Controls.Add(number4);

                label8 = new System.Windows.Forms.Label();
                label8.Text = "t₀ (s):";
                label8.Location = new Point(485, 175);
                label8.Font = new Font("Segoe UI", 9);
                label8.AutoSize = true;
                label8.Visible = true;
                this.Controls.Add(label8);

                number5 = new System.Windows.Forms.TextBox();
                number5.Location = new Point(530, 175);
                number5.AutoSize = true;
                number5.Visible = true;
                this.Controls.Add(number5);

                Enviar = new System.Windows.Forms.Button();
                Enviar.Text = "Enviar";
                Enviar.Location = new Point(485, 215);
                Enviar.AutoSize = true;
                Enviar.Visible = true;
                Enviar.Click += Button12_Click;
                this.Controls.Add(Enviar);

                Limpar = new System.Windows.Forms.Button();
                Limpar.Text = "Limpar";
                Limpar.Location = new Point(565, 215);
                Limpar.AutoSize = true;
                Limpar.Visible = true;
                Limpar.Click += Button3_Click;
                this.Controls.Add(Limpar);
            }
            else if (sub == "Transformador")
            {
                this.Controls.Remove(label3);
                this.Controls.Remove(label4);
                this.Controls.Remove(label5);
                this.Controls.Remove(label6);
                this.Controls.Remove(label7);
                this.Controls.Remove(label8);
                this.Controls.Remove(label9);
                this.Controls.Remove(label10);
                this.Controls.Remove(number1);
                this.Controls.Remove(number2);
                this.Controls.Remove(number3);
                this.Controls.Remove(number4);
                this.Controls.Remove(number5);
                this.Controls.Remove(number6);
                this.Controls.Remove(number7);
                this.Controls.Remove(Enviar);
                this.Controls.Remove(Limpar);
                this.Controls.Remove(dataGrid);

                label3 = new System.Windows.Forms.Label();
                label3.Text = "U₂ / N₂ = U₁ / N₁";
                label3.Location = new Point(500, 50);
                label3.Font = new Font("Segoe UI", 15);
                label3.AutoSize = true;
                label3.Visible = true;
                this.Controls.Add(label3);

                label4 = new System.Windows.Forms.Label();
                label4.Text = "U₂ (V):";
                label4.Location = new Point(485, 95);
                label4.Font = new Font("Segoe UI", 9);
                label4.AutoSize = true;
                label4.Visible = true;
                this.Controls.Add(label4);

                number1 = new System.Windows.Forms.TextBox();
                number1.Location = new Point(525, 95);
                number1.AutoSize = true;
                number1.Visible = true;
                this.Controls.Add(number1);

                label5 = new System.Windows.Forms.Label();
                label5.Text = "N₂:";
                label5.Location = new Point(485, 125);
                label5.Font = new Font("Segoe UI", 9);
                label5.AutoSize = true;
                label5.Visible = true;
                this.Controls.Add(label5);

                number2 = new System.Windows.Forms.TextBox();
                number2.Location = new Point(515, 125);
                number2.AutoSize = true;
                number2.Visible = true;
                this.Controls.Add(number2);

                label6 = new System.Windows.Forms.Label();
                label6.Text = "U₁ (V):";
                label6.Location = new Point(485, 155);
                label6.Font = new Font("Segoe UI", 9);
                label6.AutoSize = true;
                label6.Visible = true;
                this.Controls.Add(label6);

                number3 = new System.Windows.Forms.TextBox();
                number3.Location = new Point(525, 155);
                number3.AutoSize = true;
                number3.Visible = true;
                this.Controls.Add(number3);

                label7 = new System.Windows.Forms.Label();
                label7.Text = "N₁:";
                label7.Location = new Point(485, 185);
                label7.Font = new Font("Segoe UI", 9);
                label7.AutoSize = true;
                label7.Visible = true;
                this.Controls.Add(label7);

                number4 = new System.Windows.Forms.TextBox();
                number4.Location = new Point(515, 185);
                number4.AutoSize = true;
                number4.Visible = true;
                this.Controls.Add(number4);

                Enviar = new System.Windows.Forms.Button();
                Enviar.Text = "Enviar";
                Enviar.Location = new Point(485, 215);
                Enviar.AutoSize = true;
                Enviar.Visible = true;
                Enviar.Click += Button13_Click;
                this.Controls.Add(Enviar);

                Limpar = new System.Windows.Forms.Button();
                Limpar.Text = "Limpar";
                Limpar.Location = new Point(565, 215);
                Limpar.AutoSize = true;
                Limpar.Visible = true;
                Limpar.Click += Button3_Click;
                this.Controls.Add(Limpar);
            }
            else if (sub == "Potência em transformador")
            {
                this.Controls.Remove(label3);
                this.Controls.Remove(label4);
                this.Controls.Remove(label5);
                this.Controls.Remove(label6);
                this.Controls.Remove(label7);
                this.Controls.Remove(label8);
                this.Controls.Remove(label9);
                this.Controls.Remove(label10);
                this.Controls.Remove(number1);
                this.Controls.Remove(number2);
                this.Controls.Remove(number3);
                this.Controls.Remove(number4);
                this.Controls.Remove(number5);
                this.Controls.Remove(number6);
                this.Controls.Remove(number7);
                this.Controls.Remove(Enviar);
                this.Controls.Remove(Limpar);
                this.Controls.Remove(dataGrid);

                label3 = new System.Windows.Forms.Label();
                label3.Text = "U₁·i₁ = U₂·i₂";
                label3.Location = new Point(500, 50);
                label3.Font = new Font("Segoe UI", 15);
                label3.AutoSize = true;
                label3.Visible = true;
                this.Controls.Add(label3);

                label4 = new System.Windows.Forms.Label();
                label4.Text = "U₁ (V):";
                label4.Location = new Point(485, 95);
                label4.Font = new Font("Segoe UI", 9);
                label4.AutoSize = true;
                label4.Visible = true;
                this.Controls.Add(label4);

                number1 = new System.Windows.Forms.TextBox();
                number1.Location = new Point(530, 95);
                number1.AutoSize = true;
                number1.Visible = true;
                this.Controls.Add(number1);

                label5 = new System.Windows.Forms.Label();
                label5.Text = "i₁ (A):";
                label5.Location = new Point(485, 125);
                label5.Font = new Font("Segoe UI", 9);
                label5.AutoSize = true;
                label5.Visible = true;
                this.Controls.Add(label5);

                number2 = new System.Windows.Forms.TextBox();
                number2.Location = new Point(530, 125);
                number2.AutoSize = true;
                number2.Visible = true;
                this.Controls.Add(number2);

                label6 = new System.Windows.Forms.Label();
                label6.Text = "U₂ (V):";
                label6.Location = new Point(485, 155);
                label6.Font = new Font("Segoe UI", 9);
                label6.AutoSize = true;
                label6.Visible = true;
                this.Controls.Add(label6);

                number3 = new System.Windows.Forms.TextBox();
                number3.Location = new Point(530, 155);
                number3.AutoSize = true;
                number3.Visible = true;
                this.Controls.Add(number3);

                label7 = new System.Windows.Forms.Label();
                label7.Text = "i₂ (A):";
                label7.Location = new Point(485, 185);
                label7.Font = new Font("Segoe UI", 9);
                label7.AutoSize = true;
                label7.Visible = true;
                this.Controls.Add(label7);

                number4 = new System.Windows.Forms.TextBox();
                number4.Location = new Point(530, 185);
                number4.AutoSize = true;
                number4.Visible = true;
                this.Controls.Add(number4);

                Enviar = new System.Windows.Forms.Button();
                Enviar.Text = "Enviar";
                Enviar.Location = new Point(485, 215);
                Enviar.AutoSize = true;
                Enviar.Visible = true;
                Enviar.Click += Button14_Click;
                this.Controls.Add(Enviar);

                Limpar = new System.Windows.Forms.Button();
                Limpar.Text = "Limpar";
                Limpar.Location = new Point(565, 215);
                Limpar.AutoSize = true;
                Limpar.Visible = true;
                Limpar.Click += Button3_Click;
                this.Controls.Add(Limpar);
            }
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
            this.Controls.Remove(dataGrid);

            Dictionary<string, double?> variaveis = new Dictionary<string, double?>();
            variaveis["b"] = number1.Text == "" ? null : Convert.ToDouble(number1.Text);
            variaveis["μ"] = number2.Text == "" ? null : Convert.ToDouble(number2.Text);
            variaveis["i"] = number3.Text == "" ? null : Convert.ToDouble(number3.Text);
            variaveis["r"] = number4.Text == "" ? null : Convert.ToDouble(number4.Text);

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
            sql = "delete from f";
            MySqlCommand command_1 = new MySqlCommand(sql, trabalhoconn);
            command_1.ExecuteNonQuery();
            sql = "insert into cm (" + campos + ") values (" + valores + ")";
            MySqlCommand command_2 = new MySqlCommand(sql, trabalhoconn);
            command_2.ExecuteNonQuery();
            sql = "select b_calculado, μ_calculado, i_calculado, r_calculado from f";
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

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(dataGrid);

            Dictionary<string, double?> variaveis = new Dictionary<string, double?>();
            variaveis["b"] = number1.Text == "" ? null : Convert.ToDouble(number1.Text);
            variaveis["μ"] = number2.Text == "" ? null : Convert.ToDouble(number2.Text);
            variaveis["i"] = number3.Text == "" ? null : Convert.ToDouble(number3.Text);
            variaveis["r"] = number4.Text == "" ? null : Convert.ToDouble(number4.Text);

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
            sql = "delete from ec";
            MySqlCommand command_1 = new MySqlCommand(sql, trabalhoconn);
            command_1.ExecuteNonQuery();
            sql = "insert into cm (" + campos + ") values (" + valores + ")";
            MySqlCommand command_2 = new MySqlCommand(sql, trabalhoconn);
            command_2.ExecuteNonQuery();
            sql = "select b_calculado, μ_calculado, i_calculado, r_calculado from ec";
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
            variaveis["b"] = number1.Text == "" ? null : Convert.ToDouble(number1.Text);
            variaveis["μ"] = number2.Text == "" ? null : Convert.ToDouble(number2.Text);
            variaveis["i"] = number3.Text == "" ? null : Convert.ToDouble(number3.Text);
            variaveis["r"] = number4.Text == "" ? null : Convert.ToDouble(number4.Text);
            variaveis["n"] = number5.Text == "" ? null : Convert.ToDouble(number5.Text);

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
            sql = "delete from b";
            MySqlCommand command_1 = new MySqlCommand(sql, trabalhoconn);
            command_1.ExecuteNonQuery();
            sql = "insert into cm (" + campos + ") values (" + valores + ")";
            MySqlCommand command_2 = new MySqlCommand(sql, trabalhoconn);
            command_2.ExecuteNonQuery();
            sql = "select b_calculado, μ_calculado, i_calculado, r_calculado, n_calculado from b";
            MySqlDataAdapter data = new MySqlDataAdapter(sql, trabalhoconn);
            DataTable dt = new DataTable();
            data.Fill(dt);

            dataGrid = new System.Windows.Forms.DataGridView();
            dataGrid.Location = new Point(310, 285);
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
            variaveis["b"] = number1.Text == "" ? null : Convert.ToDouble(number1.Text);
            variaveis["μ"] = number2.Text == "" ? null : Convert.ToDouble(number2.Text);
            variaveis["i"] = number3.Text == "" ? null : Convert.ToDouble(number3.Text);
            variaveis["n"] = number4.Text == "" ? null : Convert.ToDouble(number4.Text);
            variaveis["l"] = number5.Text == "" ? null : Convert.ToDouble(number5.Text);

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
            sql = "delete from s";
            MySqlCommand command_1 = new MySqlCommand(sql, trabalhoconn);
            command_1.ExecuteNonQuery();
            sql = "insert into cm (" + campos + ") values (" + valores + ")";
            MySqlCommand command_2 = new MySqlCommand(sql, trabalhoconn);
            command_2.ExecuteNonQuery();
            sql = "select b_calculado, μ_calculado, i_calculado, n_calculado, l_calculado from s";
            MySqlDataAdapter data = new MySqlDataAdapter(sql, trabalhoconn);
            DataTable dt = new DataTable();
            data.Fill(dt);

            dataGrid = new System.Windows.Forms.DataGridView();
            dataGrid.Location = new Point(300, 285);
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
            variaveis["f"] = number1.Text == "" ? null : Convert.ToDouble(number1.Text);
            variaveis["b"] = number2.Text == "" ? null : Convert.ToDouble(number2.Text);
            variaveis["q"] = number3.Text == "" ? null : Convert.ToDouble(number3.Text);
            variaveis["v"] = number4.Text == "" ? null : Convert.ToDouble(number4.Text);
            variaveis["θ"] = number5.Text == "" ? null : Convert.ToDouble(number5.Text);

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
            sql = "delete from pc";
            MySqlCommand command_1 = new MySqlCommand(sql, trabalhoconn);
            command_1.ExecuteNonQuery();
            sql = "insert into fm (" + campos + ") values (" + valores + ")";
            MySqlCommand command_2 = new MySqlCommand(sql, trabalhoconn);
            command_2.ExecuteNonQuery();
            sql = "select f_calculado, b_calculado, q_calculado, v_calculado, θ_calculado from pc";
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

        private void Button9_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(dataGrid);

            Dictionary<string, double?> variaveis = new Dictionary<string, double?>();
            variaveis["f"] = number1.Text == "" ? null : Convert.ToDouble(number1.Text);
            variaveis["b"] = number2.Text == "" ? null : Convert.ToDouble(number2.Text);
            variaveis["i"] = number3.Text == "" ? null : Convert.ToDouble(number3.Text);
            variaveis["l"] = number4.Text == "" ? null : Convert.ToDouble(number4.Text);
            variaveis["θ"] = number5.Text == "" ? null : Convert.ToDouble(number5.Text);

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
            sql = "delete from fc";
            MySqlCommand command_1 = new MySqlCommand(sql, trabalhoconn);
            command_1.ExecuteNonQuery();
            sql = "insert into fm (" + campos + ") values (" + valores + ")";
            MySqlCommand command_2 = new MySqlCommand(sql, trabalhoconn);
            command_2.ExecuteNonQuery();
            sql = "select f_calculado, b_calculado, i_calculado, l_calculado, θ_calculado from fc";
            MySqlDataAdapter data = new MySqlDataAdapter(sql, trabalhoconn);
            DataTable dt = new DataTable();
            data.Fill(dt);

            dataGrid = new System.Windows.Forms.DataGridView();
            dataGrid.Location = new Point(300, 285);
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
            variaveis["μ"] = number2.Text == "" ? null : Convert.ToDouble(number2.Text);
            variaveis["i"] = number3.Text == "" ? null : Convert.ToDouble(number3.Text);
            variaveis["i2"] = number4.Text == "" ? null : Convert.ToDouble(number4.Text);
            variaveis["l"] = number5.Text == "" ? null : Convert.ToDouble(number5.Text);
            variaveis["d"] = number6.Text == "" ? null : Convert.ToDouble(number6.Text);

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
            sql = "delete from fp";
            MySqlCommand command_1 = new MySqlCommand(sql, trabalhoconn);
            command_1.ExecuteNonQuery();
            sql = "insert into fm (" + campos + ") values (" + valores + ")";
            MySqlCommand command_2 = new MySqlCommand(sql, trabalhoconn);
            command_2.ExecuteNonQuery();
            sql = "select f_calculado, μ_calculado, i1_calculado, i2_calculado, l_calculado, d_calculado from fp";
            MySqlDataAdapter data = new MySqlDataAdapter(sql, trabalhoconn);
            DataTable dt = new DataTable();
            data.Fill(dt);

            dataGrid = new System.Windows.Forms.DataGridView();
            dataGrid.Location = new Point(300, 285);
            dataGrid.AutoSize = true;
            dataGrid.Visible = true;
            this.Controls.Add(dataGrid);

            dataGrid.DataSource = dt;
            trabalhoconn.Close();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(dataGrid);

            Dictionary<string, double?> variaveis = new Dictionary<string, double?>();
            variaveis["φ"] = number1.Text == "" ? null : Convert.ToDouble(number1.Text);
            variaveis["b"] = number2.Text == "" ? null : Convert.ToDouble(number2.Text);
            variaveis["a"] = number3.Text == "" ? null : Convert.ToDouble(number3.Text);
            variaveis["alpha"] = number4.Text == "" ? null : Convert.ToDouble(number4.Text);

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
            sql = "delete from fom";
            MySqlCommand command_1 = new MySqlCommand(sql, trabalhoconn);
            command_1.ExecuteNonQuery();
            sql = "insert into im (" + campos + ") values (" + valores + ")";
            MySqlCommand command_2 = new MySqlCommand(sql, trabalhoconn);
            command_2.ExecuteNonQuery();
            sql = "select φ_calculado, b_calculado, a_calculado, alpha_calculado from fom";
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

        private void Button12_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(dataGrid);

            Dictionary<string, double?> variaveis = new Dictionary<string, double?>();
            variaveis["ε"] = number1.Text == "" ? null : Convert.ToDouble(number1.Text);
            variaveis["Φ"] = number2.Text == "" ? null : Convert.ToDouble(number2.Text);
            variaveis["Φ₀"] = number3.Text == "" ? null : Convert.ToDouble(number3.Text);
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
            sql = "delete from lf";
            MySqlCommand command_1 = new MySqlCommand(sql, trabalhoconn);
            command_1.ExecuteNonQuery();
            sql = "insert into im (" + campos + ") values (" + valores + ")";
            MySqlCommand command_2 = new MySqlCommand(sql, trabalhoconn);
            command_2.ExecuteNonQuery();
            sql = "select ε_calculado, Φ_calculado, Φ₀_calculado, t_calculado, t0_calculado from lf";
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

        private void Button13_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(dataGrid);

            Dictionary<string, double?> variaveis = new Dictionary<string, double?>();
            variaveis["u2"] = number1.Text == "" ? null : Convert.ToDouble(number1.Text);
            variaveis["n2"] = number2.Text == "" ? null : Convert.ToDouble(number2.Text);
            variaveis["u1"] = number3.Text == "" ? null : Convert.ToDouble(number3.Text);
            variaveis["n1"] = number4.Text == "" ? null : Convert.ToDouble(number4.Text);

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
            sql = "delete from t";
            MySqlCommand command_1 = new MySqlCommand(sql, trabalhoconn);
            command_1.ExecuteNonQuery();
            sql = "insert into im (" + campos + ") values (" + valores + ")";
            MySqlCommand command_2 = new MySqlCommand(sql, trabalhoconn);
            command_2.ExecuteNonQuery();
            sql = "select u2_calculado, n2_calculado, u1_calculado, n1_calculado from t";
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

        private void Button14_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(dataGrid);

            Dictionary<string, double?> variaveis = new Dictionary<string, double?>();
            variaveis["u1"] = number1.Text == "" ? null : Convert.ToDouble(number1.Text);
            variaveis["i1"] = number2.Text == "" ? null : Convert.ToDouble(number2.Text);
            variaveis["u2"] = number3.Text == "" ? null : Convert.ToDouble(number3.Text);
            variaveis["i2"] = number4.Text == "" ? null : Convert.ToDouble(number4.Text);

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
            sql = "delete from tp";
            MySqlCommand command_1 = new MySqlCommand(sql, trabalhoconn);
            command_1.ExecuteNonQuery();
            sql = "insert into im (" + campos + ") values (" + valores + ")";
            MySqlCommand command_2 = new MySqlCommand(sql, trabalhoconn);
            command_2.ExecuteNonQuery();
            sql = "select u1_calculado, i1_calculado, u2_calculado, i2_calculado from tp";
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
    }
}
