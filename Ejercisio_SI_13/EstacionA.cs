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
    public partial class EstacionA : Form
    {
        public static int num_Estaciones = 0,cobro=0;
        public EstacionA()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EstacionB estacionB = new EstacionB();
            num_Estaciones = num_Estaciones + 1;
            estacionB.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EstacionE estacionE = new EstacionE();
            num_Estaciones = num_Estaciones + 1;
            estacionE.Show();
            Close();
        }

        private void EstacionA_Load(object sender, EventArgs e)
        {
            if (cobro >= 10)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = false;
            }
            label1.Text = IDCard.ID;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (num_Estaciones == 0)
            {
                IDCard.saldo = IDCard.saldo - cobro;
                MessageBox.Show("numero de estaciones:" + num_Estaciones + " El cargo total es:" + cobro+" tu saldo es:"+IDCard.saldo);
                num_Estaciones = 0;
                cobro = 0;
                IDCard iDCard = new IDCard();
                iDCard.Show();
                Close();
            }
            else
            {

                if (num_Estaciones <= 3)
                {
                    cobro = cobro + 18;
                    IDCard.saldo = IDCard.saldo - cobro;
                    MessageBox.Show("numero de estaciones:" + num_Estaciones + " El cargo total es:" + cobro + " tu saldo es:" + IDCard.saldo);
                    num_Estaciones = 0;
                    cobro = 0;
                    IDCard iDCard = new IDCard();
                    iDCard.Show();
                    Close();
                }
                else
                {
                    cobro = cobro + 22;
                    IDCard.saldo = IDCard.saldo - cobro;
                    MessageBox.Show("numero de estaciones:" + num_Estaciones + " El cargo total es:" + cobro + " tu saldo es:" + IDCard.saldo);
                    num_Estaciones = 0;
                    cobro = 0;
                    IDCard iDCard = new IDCard();
                    iDCard.Show();
                    Close();
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cobro = cobro + 10;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
        }
    }
}
