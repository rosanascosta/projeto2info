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

namespace WinFormsApp1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FisicaI fisica_I = new FisicaI();
            fisica_I.ShowDialog();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FisicaII fisica_II = new FisicaII();
            fisica_II.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FisicaIII fisica_III = new FisicaIII();
            fisica_III.ShowDialog();
        }
    }
}
