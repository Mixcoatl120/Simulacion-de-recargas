using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercisio_SI_13
{
    public partial class Modulo_de_tarjetas : Form
    {
        public static int i,NID;
        public Modulo_de_tarjetas()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (i = 0; i < 7; i++)
            {
                NID = r.Next(0, 9);
                IDCard.ID = IDCard.ID + Convert.ToString(NID);
            }
            textBox1.Text = IDCard.ID;
            button4.Enabled = false;
            button1.Enabled = true;
            button9.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            IDCard.saldo = 0;
            IDCard.ID = "";
            textBox1.Clear();
            button4.Enabled = true;
            button1.Enabled = false;
            button9.Enabled = false;
        }

        private void Modulo_de_tarjetas_Load(object sender, EventArgs e)
        {
            if (IDCard.saldo>0)
            {
                button4.Enabled = false;
                button1.Enabled = true;
                button9.Enabled = true;
                textBox1.Text = IDCard.ID;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IDCard iDCard = new IDCard();
            iDCard.Show();
            Close();
        }
    }
}
