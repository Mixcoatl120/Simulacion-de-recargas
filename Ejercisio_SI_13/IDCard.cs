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
    public partial class IDCard : Form
    {
        public static int saldo = 0;
        public static string ID = "";
        public IDCard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saldo < 28)
            {
                MessageBox.Show("Saldo insuficiente");
            }
            else
            {
                EstacionA estacionA = new EstacionA();
                estacionA.Show();
                Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (saldo < 28)
            {
                MessageBox.Show("Saldo insuficiente");
            }
            else
            {
                EstacionB estacionB = new EstacionB();
                estacionB.Show();
                Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (saldo < 28)
            {
                MessageBox.Show("Saldo insuficiente");
            }
            else
            {
                EstacionC estacionC = new EstacionC();
                estacionC.Show();
                Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (saldo < 28)
            {
                MessageBox.Show("Saldo insuficiente");
            }
            else
            {
                EstacionD estacionD = new EstacionD();
                estacionD.Show();
                Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (saldo < 28)
            {
                MessageBox.Show("Saldo insuficiente");
            }
            else
            {
                EstacionE estacionE = new EstacionE();
                estacionE.Show();
                Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saldo = saldo + Convert.ToInt32(comboBox1.Text);
            textBox3.Text = Convert.ToString(saldo);
        }

        private void IDCard_Load(object sender, EventArgs e)
        {
                textBox1.Text = ID;
                textBox3.Text = Convert.ToString(saldo);
            if (ID != "")
            {
                textBox1.ReadOnly=true;
            }
        }
    }
}
