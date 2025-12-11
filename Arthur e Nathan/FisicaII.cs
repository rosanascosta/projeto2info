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
    public partial class FisicaII : Form
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

        public FisicaII()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selecionado = comboBox1.Text;
            if (selecionado == "Equação Geral da Calorimetria")
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
                combo.Items.Add("Equação Fundamental da Calorimetria");
                combo.Items.Add("Potência Térmica");
                combo.Items.Add("Equação Fundamental da Calorimetria = Potência Térmica");
                combo.Location = new Point(5, 250);
                combo.Size = new Size(320, 15);
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
            else if (selecionado == "Lei Geral dos Gases")
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
                this.Controls.Remove(dataGrid);

                label2 = new System.Windows.Forms.Label();
                label2.Text = "(P.V)/T = (P₀.V₀)/T₀";
                label2.Location = new Point(500, 50);
                label2.Font = new Font("Segoe UI", 15);
                label2.AutoSize = true;
                label2.Visible = true;
                this.Controls.Add(label2);

                label3 = new System.Windows.Forms.Label();
                label3.Text = "P (atm):";
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
                label4.Text = "V (L):";
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
                label5.Text = "T (K):";
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
                label6.Text = "P₀ (atm):";
                label6.Location = new Point(485, 185);
                label6.Font = new Font("Segoe UI", 9);
                label6.AutoSize = true;
                label6.Visible = true;
                this.Controls.Add(label6);

                number4 = new System.Windows.Forms.TextBox();
                number4.Location = new Point(540, 185);
                number4.AutoSize = true;
                number4.Visible = true;
                this.Controls.Add(number4);

                label7 = new System.Windows.Forms.Label();
                label7.Text = "V₀ (L):";
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

                label8 = new System.Windows.Forms.Label();
                label8.Text = "T₀ (K):";
                label8.Location = new Point(485, 245);
                label8.Font = new Font("Segoe UI", 9);
                label8.AutoSize = true;
                label8.Visible = true;
                this.Controls.Add(label8);

                number6 = new System.Windows.Forms.TextBox();
                number6.Location = new Point(535, 245);
                number6.AutoSize = true;
                number6.Visible = true;
                this.Controls.Add(number6);

                Enviar = new System.Windows.Forms.Button();
                Enviar.Text = "Enviar";
                Enviar.Location = new Point(485, 295);
                Enviar.AutoSize = true;
                Enviar.Visible = true;
                Enviar.Click += Button7_Click;
                this.Controls.Add(Enviar);

                Limpar = new System.Windows.Forms.Button();
                Limpar.Text = "Limpar";
                Limpar.Location = new Point(565, 295);
                Limpar.AutoSize = true;
                Limpar.Visible = true;
                Limpar.Click += Button3_Click;
                this.Controls.Add(Limpar);
            }
            else if (selecionado == "Primeira Lei da Termodinâmica")
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
                this.Controls.Remove(dataGrid);

                label2 = new System.Windows.Forms.Label();
                label2.Text = "ΔU = Q - W";
                label2.Location = new Point(500, 50);
                label2.Font = new Font("Segoe UI", 15);
                label2.AutoSize = true;
                label2.Visible = true;
                this.Controls.Add(label2);

                label3 = new System.Windows.Forms.Label();
                label3.Text = "U (cal ou J):";
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
                label4.Text = "U₀ (cal ou J):";
                label4.Location = new Point(485, 125);
                label4.Font = new Font("Segoe UI", 9);
                label4.AutoSize = true;
                label4.Visible = true;
                this.Controls.Add(label4);

                number2 = new System.Windows.Forms.TextBox();
                number2.Location = new Point(560, 125);
                number2.AutoSize = true;
                number2.Visible = true;
                this.Controls.Add(number2);

                label5 = new System.Windows.Forms.Label();
                label5.Text = "Q (cal ou J):";
                label5.Location = new Point(485, 155);
                label5.Font = new Font("Segoe UI", 9);
                label5.AutoSize = true;
                label5.Visible = true;
                this.Controls.Add(label5);

                number3 = new System.Windows.Forms.TextBox();
                number3.Location = new Point(555, 155);
                number3.AutoSize = true;
                number3.Visible = true;
                this.Controls.Add(number3);

                label6 = new System.Windows.Forms.Label();
                label6.Text = "W (cal ou J):";
                label6.Location = new Point(485, 185);
                label6.Font = new Font("Segoe UI", 9);
                label6.AutoSize = true;
                label6.Visible = true;
                this.Controls.Add(label6);

                number4 = new System.Windows.Forms.TextBox();
                number4.Location = new Point(560, 185);
                number4.AutoSize = true;
                number4.Visible = true;
                this.Controls.Add(number4);

                label7 = new System.Windows.Forms.Label();
                label7.Text = "Lembrete: Utilizar a mesma unidade de medida para todos os campos.";
                label7.Location = new Point(385, 215);
                label7.Font = new Font("Segoe UI", 9);
                label7.AutoSize = true;
                label7.Visible = true;
                this.Controls.Add(label7);

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
            else if (selecionado == "Lei de Coulomb")
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
                this.Controls.Remove(dataGrid);

                label2 = new System.Windows.Forms.Label();
                label2.Text = "Fe = (K.|Q₁|.|Q₂|) / d²";
                label2.Location = new Point(500, 50);
                label2.Font = new Font("Segoe UI", 15);
                label2.AutoSize = true;
                label2.Visible = true;
                this.Controls.Add(label2);

                label3 = new System.Windows.Forms.Label();
                label3.Text = "Fe (N):";
                label3.Location = new Point(485, 95);
                label3.Font = new Font("Segoe UI", 9);
                label3.AutoSize = true;
                label3.Visible = true;
                this.Controls.Add(label3);

                number1 = new System.Windows.Forms.TextBox();
                number1.Location = new Point(527, 95);
                number1.AutoSize = true;
                number1.Visible = true;
                this.Controls.Add(number1);

                label4 = new System.Windows.Forms.Label();
                label4.Text = "K (constante): 9.10⁹ Nm²/C²";
                label4.Location = new Point(485, 125);
                label4.Font = new Font("Segoe UI", 9);
                label4.AutoSize = true;
                label4.Visible = true;
                this.Controls.Add(label4);

                label5 = new System.Windows.Forms.Label();
                label5.Text = "Q₁ (C):";
                label5.Location = new Point(485, 155);
                label5.Font = new Font("Segoe UI", 9);
                label5.AutoSize = true;
                label5.Visible = true;
                this.Controls.Add(label5);

                number2 = new System.Windows.Forms.TextBox();
                number2.Location = new Point(535, 155);
                number2.AutoSize = true;
                number2.Visible = true;
                this.Controls.Add(number2);

                label6 = new System.Windows.Forms.Label();
                label6.Text = "Q₂ (C):";
                label6.Location = new Point(485, 185);
                label6.Font = new Font("Segoe UI", 9);
                label6.AutoSize = true;
                label6.Visible = true;
                this.Controls.Add(label6);

                number3 = new System.Windows.Forms.TextBox();
                number3.Location = new Point(535, 185);
                number3.AutoSize = true;
                number3.Visible = true;
                this.Controls.Add(number3);

                label7 = new System.Windows.Forms.Label();
                label7.Text = "d (m):";
                label7.Location = new Point(485, 215);
                label7.Font = new Font("Segoe UI", 9);
                label7.AutoSize = true;
                label7.Visible = true;
                this.Controls.Add(label7);

                number4 = new System.Windows.Forms.TextBox();
                number4.Location = new Point(525, 215);
                number4.AutoSize = true;
                number4.Visible = true;
                this.Controls.Add(number4);

                label8 = new System.Windows.Forms.Label();
                label8.Text = "OBS.: No Q₁ e Q₂, insira apenas valores positivos.";
                label8.Location = new Point(485, 245);
                label8.Font = new Font("Segoe UI", 9);
                label8.AutoSize = true;
                label8.Visible = true;
                this.Controls.Add(label8);

                Enviar = new System.Windows.Forms.Button();
                Enviar.Text = "Enviar";
                Enviar.Location = new Point(485, 265);
                Enviar.AutoSize = true;
                Enviar.Visible = true;
                Enviar.Click += Button9_Click;
                this.Controls.Add(Enviar);

                Limpar = new System.Windows.Forms.Button();
                Limpar.Text = "Limpar";
                Limpar.Location = new Point(565, 265);
                Limpar.AutoSize = true;
                Limpar.Visible = true;
                Limpar.Click += Button3_Click;
                this.Controls.Add(Limpar);
            }
            else if (selecionado == "Corrente Elétrica")
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
                this.Controls.Remove(dataGrid);

                label2 = new System.Windows.Forms.Label();
                label2.Text = "Escolha uma dessas fórmulas.";
                label2.Location = new Point(75, 225);
                label2.Font = new Font("Segoe UI", 9);
                label2.AutoSize = true;
                label2.Visible = true;
                this.Controls.Add(label2);

                combo = new System.Windows.Forms.ComboBox();
                combo.Items.Add("i = ΔQ/Δt");
                combo.Items.Add("U = r.i");
                combo.Items.Add("P = U.i");
                combo.Location = new Point(110, 250);
                combo.Size = new Size(100, 15);
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
            if (sub == "Equação Fundamental da Calorimetria")
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
                label3.Text = "Q = m.c.ΔT";
                label3.Location = new Point(500, 50);
                label3.Font = new Font("Segoe UI", 15);
                label3.AutoSize = true;
                label3.Visible = true;
                this.Controls.Add(label3);

                label4 = new System.Windows.Forms.Label();
                label4.Text = "Q (cal):";
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
                label5.Text = "m (g):";
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
                label6.Text = "c (cal/g°C):";
                label6.Location = new Point(485, 155);
                label6.Font = new Font("Segoe UI", 9);
                label6.AutoSize = true;
                label6.Visible = true;
                this.Controls.Add(label6);

                number3 = new System.Windows.Forms.TextBox();
                number3.Location = new Point(555, 155);
                number3.AutoSize = true;
                number3.Visible = true;
                this.Controls.Add(number3);

                label7 = new System.Windows.Forms.Label();
                label7.Text = "T (°C):";
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
                label8.Text = "T₀ (°C):";
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
                Enviar.Click += Button4_Click;
                this.Controls.Add(Enviar);

                Limpar = new System.Windows.Forms.Button();
                Limpar.Text = "Limpar";
                Limpar.Location = new Point(565, 255);
                Limpar.AutoSize = true;
                Limpar.Visible = true;
                Limpar.Click += Button3_Click;
                this.Controls.Add(Limpar);
            }
            else if (sub == "Potência Térmica")
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
                label3.Text = "Q = P.Δt";
                label3.Location = new Point(500, 50);
                label3.Font = new Font("Segoe UI", 15);
                label3.AutoSize = true;
                label3.Visible = true;
                this.Controls.Add(label3);

                label4 = new System.Windows.Forms.Label();
                label4.Text = "Q (cal):";
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
                label5.Text = "P (W):";
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
                label6.Text = "t (s):";
                label6.Location = new Point(485, 155);
                label6.Font = new Font("Segoe UI", 9);
                label6.AutoSize = true;
                label6.Visible = true;
                this.Controls.Add(label6);

                number3 = new System.Windows.Forms.TextBox();
                number3.Location = new Point(520, 155);
                number3.AutoSize = true;
                number3.Visible = true;
                this.Controls.Add(number3);

                label7 = new System.Windows.Forms.Label();
                label7.Text = "t₀ (s):";
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
            else if (sub == "Equação Fundamental da Calorimetria = Potência Térmica")
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
                label3.Text = "P.Δt = m.c.ΔT";
                label3.Location = new Point(500, 10);
                label3.Font = new Font("Segoe UI", 15);
                label3.AutoSize = true;
                label3.Visible = true;
                this.Controls.Add(label3);

                label4 = new System.Windows.Forms.Label();
                label4.Text = "P (W):";
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
                label5.Text = "t (s):";
                label5.Location = new Point(485, 85);
                label5.Font = new Font("Segoe UI", 9);
                label5.AutoSize = true;
                label5.Visible = true;
                this.Controls.Add(label5);

                number2 = new System.Windows.Forms.TextBox();
                number2.Location = new Point(525, 85);
                number2.AutoSize = true;
                number2.Visible = true;
                this.Controls.Add(number2);

                label6 = new System.Windows.Forms.Label();
                label6.Text = "t₀ (s):";
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
                label7.Text = "m (g):";
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
                label8.Text = "c (cal/g°C):";
                label8.Location = new Point(485, 175);
                label8.Font = new Font("Segoe UI", 9);
                label8.AutoSize = true;
                label8.Visible = true;
                this.Controls.Add(label8);

                number5 = new System.Windows.Forms.TextBox();
                number5.Location = new Point(555, 175);
                number5.AutoSize = true;
                number5.Visible = true;
                this.Controls.Add(number5);

                label9 = new System.Windows.Forms.Label();
                label9.Text = "T (°C):";
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

                label10 = new System.Windows.Forms.Label();
                label10.Text = "T₀ (°C):";
                label10.Location = new Point(485, 235);
                label10.Font = new Font("Segoe UI", 9);
                label10.AutoSize = true;
                label10.Visible = true;
                this.Controls.Add(label10);

                number7 = new System.Windows.Forms.TextBox();
                number7.Location = new Point(535, 235);
                number7.AutoSize = true;
                number7.Visible = true;
                this.Controls.Add(number7);

                Enviar = new System.Windows.Forms.Button();
                Enviar.Text = "Enviar";
                Enviar.Location = new Point(485, 265);
                Enviar.AutoSize = true;
                Enviar.Visible = true;
                Enviar.Click += Button6_Click;
                this.Controls.Add(Enviar);

                Limpar = new System.Windows.Forms.Button();
                Limpar.Text = "Limpar";
                Limpar.Location = new Point(565, 265);
                Limpar.AutoSize = true;
                Limpar.Visible = true;
                Limpar.Click += Button3_Click;
                this.Controls.Add(Limpar);
            }
            else if (sub == "i = ΔQ/Δt")
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
                label3.Text = "i = ΔQ/Δt";
                label3.Location = new Point(500, 50);
                label3.Font = new Font("Segoe UI", 15);
                label3.AutoSize = true;
                label3.Visible = true;
                this.Controls.Add(label3);

                label4 = new System.Windows.Forms.Label();
                label4.Text = "i (A):";
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
                label5.Text = "Q (C):";
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
                label6.Text = "Q₀ (C):";
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
                label7.Text = "t (s):";
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
                label8.Text = "t₀ (s):";
                label8.Location = new Point(485, 215);
                label8.Font = new Font("Segoe UI", 9);
                label8.AutoSize = true;
                label8.Visible = true;
                this.Controls.Add(label8);

                number5 = new System.Windows.Forms.TextBox();
                number5.Location = new Point(530, 215);
                number5.AutoSize = true;
                number5.Visible = true;
                this.Controls.Add(number5);

                Enviar = new System.Windows.Forms.Button();
                Enviar.Text = "Enviar";
                Enviar.Location = new Point(485, 255);
                Enviar.AutoSize = true;
                Enviar.Visible = true;
                Enviar.Click += Button10_Click;
                this.Controls.Add(Enviar);

                Limpar = new System.Windows.Forms.Button();
                Limpar.Text = "Limpar";
                Limpar.Location = new Point(565, 255);
                Limpar.AutoSize = true;
                Limpar.Visible = true;
                Limpar.Click += Button3_Click;
                this.Controls.Add(Limpar);
            }
            else if (sub == "U = r.i")
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
                label3.Text = "U = r.i";
                label3.Location = new Point(500, 50);
                label3.Font = new Font("Segoe UI", 15);
                label3.AutoSize = true;
                label3.Visible = true;
                this.Controls.Add(label3);

                label4 = new System.Windows.Forms.Label();
                label4.Text = "U (V):";
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
                label5.Text = "r (Ω):";
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

                Enviar = new System.Windows.Forms.Button();
                Enviar.Text = "Enviar";
                Enviar.Location = new Point(485, 185);
                Enviar.AutoSize = true;
                Enviar.Visible = true;
                Enviar.Click += Button11_Click;
                this.Controls.Add(Enviar);

                Limpar = new System.Windows.Forms.Button();
                Limpar.Text = "Limpar";
                Limpar.Location = new Point(565, 185);
                Limpar.AutoSize = true;
                Limpar.Visible = true;
                Limpar.Click += Button3_Click;
                this.Controls.Add(Limpar);
            }
            else if (sub == "P = U.i")
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
                label3.Text = "P = U.i";
                label3.Location = new Point(500, 50);
                label3.Font = new Font("Segoe UI", 15);
                label3.AutoSize = true;
                label3.Visible = true;
                this.Controls.Add(label3);

                label4 = new System.Windows.Forms.Label();
                label4.Text = "P (W):";
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
                label5.Text = "U (V):";
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

                Enviar = new System.Windows.Forms.Button();
                Enviar.Text = "Enviar";
                Enviar.Location = new Point(485, 185);
                Enviar.AutoSize = true;
                Enviar.Visible = true;
                Enviar.Click += Button12_Click;
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
            variaveis["q"] = number1.Text == "" ? null : Convert.ToDouble(number1.Text);
            variaveis["m"] = number2.Text == "" ? null : Convert.ToDouble(number2.Text);
            variaveis["c"] = number3.Text == "" ? null : Convert.ToDouble(number3.Text);
            variaveis["temp"] = number4.Text == "" ? null : Convert.ToDouble(number4.Text);
            variaveis["temp0"] = number5.Text == "" ? null : Convert.ToDouble(number5.Text);

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
            sql = "delete from mct";
            MySqlCommand command_1 = new MySqlCommand(sql, trabalhoconn);
            command_1.ExecuteNonQuery();
            sql = "insert into calor (" + campos + ") values (" + valores + ")";
            MySqlCommand command_2 = new MySqlCommand(sql, trabalhoconn);
            command_2.ExecuteNonQuery();
            sql = "select q_calculado, m_calculado, c_calculado, temp_calculado, temp0_calculado from mct";
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

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(dataGrid);

            Dictionary<string, double?> variaveis = new Dictionary<string, double?>();
            variaveis["q"] = number1.Text == "" ? null : Convert.ToDouble(number1.Text);
            variaveis["p"] = number2.Text == "" ? null : Convert.ToDouble(number2.Text);
            variaveis["t"] = number3.Text == "" ? null : Convert.ToDouble(number3.Text);
            variaveis["t0"] = number4.Text == "" ? null : Convert.ToDouble(number4.Text);

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
            sql = "delete from pt";
            MySqlCommand command_1 = new MySqlCommand(sql, trabalhoconn);
            command_1.ExecuteNonQuery();
            sql = "insert into calor (" + campos + ") values (" + valores + ")";
            MySqlCommand command_2 = new MySqlCommand(sql, trabalhoconn);
            command_2.ExecuteNonQuery();
            sql = "select q_calculado, p_calculado, t_calculado, t0_calculado from pt";
            MySqlDataAdapter data = new MySqlDataAdapter(sql, trabalhoconn);
            DataTable dt = new DataTable();
            data.Fill(dt);

            dataGrid = new System.Windows.Forms.DataGridView();
            dataGrid.Location = new Point(320, 275);
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
            variaveis["p"] = number1.Text == "" ? null : Convert.ToDouble(number1.Text);
            variaveis["t"] = number2.Text == "" ? null : Convert.ToDouble(number2.Text);
            variaveis["t0"] = number3.Text == "" ? null : Convert.ToDouble(number3.Text);
            variaveis["m"] = number4.Text == "" ? null : Convert.ToDouble(number4.Text);
            variaveis["c"] = number5.Text == "" ? null : Convert.ToDouble(number5.Text);
            variaveis["temp"] = number6.Text == "" ? null : Convert.ToDouble(number6.Text);
            variaveis["temp0"] = number7.Text == "" ? null : Convert.ToDouble(number7.Text);

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
            sql = "delete from pm";
            MySqlCommand command_1 = new MySqlCommand(sql, trabalhoconn);
            command_1.ExecuteNonQuery();
            sql = "insert into calor (" + campos + ") values (" + valores + ")";
            MySqlCommand command_2 = new MySqlCommand(sql, trabalhoconn);
            command_2.ExecuteNonQuery();
            sql = "select p_calculado, t_calculado, t0_calculado, m_calculado, c_calculado, temp_calculado, temp0_calculado from pm";
            MySqlDataAdapter data = new MySqlDataAdapter(sql, trabalhoconn);
            DataTable dt = new DataTable();
            data.Fill(dt);

            dataGrid = new System.Windows.Forms.DataGridView();
            dataGrid.Location = new Point(300, 295);
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
            variaveis["p"] = number1.Text == "" ? null : Convert.ToDouble(number1.Text);
            variaveis["v"] = number2.Text == "" ? null : Convert.ToDouble(number2.Text);
            variaveis["t"] = number3.Text == "" ? null : Convert.ToDouble(number3.Text);
            variaveis["p0"] = number4.Text == "" ? null : Convert.ToDouble(number4.Text);
            variaveis["v0"] = number5.Text == "" ? null : Convert.ToDouble(number5.Text);
            variaveis["t0"] = number6.Text == "" ? null : Convert.ToDouble(number6.Text);

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
            sql = "delete from gas_calculos";
            MySqlCommand command_1 = new MySqlCommand(sql, trabalhoconn);
            command_1.ExecuteNonQuery();
            sql = "insert into gas (" + campos + ") values (" + valores + ")";
            MySqlCommand command_2 = new MySqlCommand(sql, trabalhoconn);
            command_2.ExecuteNonQuery();
            sql = "select p_calculado, v_calculado, t_calculado, p0_calculado, v0_calculado, t0_calculado from gas_calculos";
            MySqlDataAdapter data = new MySqlDataAdapter(sql, trabalhoconn);
            DataTable dt = new DataTable();
            data.Fill(dt);

            dataGrid = new System.Windows.Forms.DataGridView();
            dataGrid.Location = new Point(300, 325);
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
            variaveis["u"] = number1.Text == "" ? null : Convert.ToDouble(number1.Text);
            variaveis["u0"] = number2.Text == "" ? null : Convert.ToDouble(number2.Text);
            variaveis["q"] = number3.Text == "" ? null : Convert.ToDouble(number3.Text);
            variaveis["w"] = number4.Text == "" ? null : Convert.ToDouble(number4.Text);

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
            sql = "delete from ter_calculos";
            MySqlCommand command_1 = new MySqlCommand(sql, trabalhoconn);
            command_1.ExecuteNonQuery();
            sql = "insert into ter (" + campos + ") values (" + valores + ")";
            MySqlCommand command_2 = new MySqlCommand(sql, trabalhoconn);
            command_2.ExecuteNonQuery();
            sql = "select u_calculado, u0_calculado, q_calculado, w_calculado from ter_calculos";
            MySqlDataAdapter data = new MySqlDataAdapter(sql, trabalhoconn);
            DataTable dt = new DataTable();
            data.Fill(dt);

            dataGrid = new System.Windows.Forms.DataGridView();
            dataGrid.Location = new Point(300, 295);
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
            variaveis["q1"] = number2.Text == "" ? null : Convert.ToDouble(number2.Text);
            variaveis["q2"] = number3.Text == "" ? null : Convert.ToDouble(number3.Text);
            variaveis["d"] = number4.Text == "" ? null : Convert.ToDouble(number4.Text);

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
            sql = "delete from fe_calculos";
            MySqlCommand command_1 = new MySqlCommand(sql, trabalhoconn);
            command_1.ExecuteNonQuery();
            sql = "insert into fe (" + campos + ") values (" + valores + ")";
            MySqlCommand command_2 = new MySqlCommand(sql, trabalhoconn);
            command_2.ExecuteNonQuery();
            sql = "select f_calculado, q1_calculado, q2_calculado, d_calculado from fe_calculos";
            MySqlDataAdapter data = new MySqlDataAdapter(sql, trabalhoconn);
            DataTable dt = new DataTable();
            data.Fill(dt);

            dataGrid = new System.Windows.Forms.DataGridView();
            dataGrid.Location = new Point(300, 295);
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
            variaveis["i"] = number1.Text == "" ? null : Convert.ToDouble(number1.Text);
            variaveis["q"] = number2.Text == "" ? null : Convert.ToDouble(number2.Text);
            variaveis["q0"] = number3.Text == "" ? null : Convert.ToDouble(number3.Text);
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
            sql = "delete from iqt";
            MySqlCommand command_1 = new MySqlCommand(sql, trabalhoconn);
            command_1.ExecuteNonQuery();
            sql = "insert into ce (" + campos + ") values (" + valores + ")";
            MySqlCommand command_2 = new MySqlCommand(sql, trabalhoconn);
            command_2.ExecuteNonQuery();
            sql = "select i_calculado, q_calculado, q0_calculado, t_calculado, t0_calculado from iqt";
            MySqlDataAdapter data = new MySqlDataAdapter(sql, trabalhoconn);
            DataTable dt = new DataTable();
            data.Fill(dt);

            dataGrid = new System.Windows.Forms.DataGridView();
            dataGrid.Location = new Point(300, 295);
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
            variaveis["u"] = number1.Text == "" ? null : Convert.ToDouble(number1.Text);
            variaveis["r"] = number2.Text == "" ? null : Convert.ToDouble(number2.Text);
            variaveis["i"] = number3.Text == "" ? null : Convert.ToDouble(number3.Text);

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
            sql = "delete from uri";
            MySqlCommand command_1 = new MySqlCommand(sql, trabalhoconn);
            command_1.ExecuteNonQuery();
            sql = "insert into ce (" + campos + ") values (" + valores + ")";
            MySqlCommand command_2 = new MySqlCommand(sql, trabalhoconn);
            command_2.ExecuteNonQuery();
            sql = "select u_calculado, r_calculado, i_calculado from uri";
            MySqlDataAdapter data = new MySqlDataAdapter(sql, trabalhoconn);
            DataTable dt = new DataTable();
            data.Fill(dt);

            dataGrid = new System.Windows.Forms.DataGridView();
            dataGrid.Location = new Point(300, 295);
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
            variaveis["p"] = number1.Text == "" ? null : Convert.ToDouble(number1.Text);
            variaveis["u"] = number2.Text == "" ? null : Convert.ToDouble(number2.Text);
            variaveis["i"] = number3.Text == "" ? null : Convert.ToDouble(number3.Text);

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
            sql = "delete from pui";
            MySqlCommand command_1 = new MySqlCommand(sql, trabalhoconn);
            command_1.ExecuteNonQuery();
            sql = "insert into ce (" + campos + ") values (" + valores + ")";
            MySqlCommand command_2 = new MySqlCommand(sql, trabalhoconn);
            command_2.ExecuteNonQuery();
            sql = "select p_calculado, u_calculado, i_calculado from pui";
            MySqlDataAdapter data = new MySqlDataAdapter(sql, trabalhoconn);
            DataTable dt = new DataTable();
            data.Fill(dt);

            dataGrid = new System.Windows.Forms.DataGridView();
            dataGrid.Location = new Point(300, 295);
            dataGrid.AutoSize = true;
            dataGrid.Visible = true;
            this.Controls.Add(dataGrid);

            dataGrid.DataSource = dt;
            trabalhoconn.Close();
        }
    }
}