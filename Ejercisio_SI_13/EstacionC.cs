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
    public partial class EstacionC : Form
    {
        public EstacionC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EstacionB estacionB = new EstacionB();
            EstacionA.num_Estaciones = EstacionA.num_Estaciones + 1;
            estacionB.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EstacionD estacionD = new EstacionD();
            EstacionA.num_Estaciones = EstacionA.num_Estaciones + 1;
            estacionD.Show();
            Close();
        }

        private void EstacionC_Load(object sender, EventArgs e)
        {
            if (EstacionA.cobro >= 10)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = false;
            }
            label1.Text = IDCard.ID;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EstacionA.cobro = EstacionA.cobro + 10;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (EstacionA.num_Estaciones == 0)
            {
                IDCard.saldo = IDCard.saldo - EstacionA.cobro;
                MessageBox.Show("numero de estaciones: " + EstacionA.num_Estaciones + " El cargo total es: " + EstacionA.cobro + " tu saldo es: " + IDCard.saldo);
                EstacionA.num_Estaciones = 0;
                EstacionA.cobro = 0;
                IDCard iDCard = new IDCard();
                iDCard.Show();
                Close();
            }
            else
            {
                if (EstacionA.num_Estaciones <= 3)
                {
                    EstacionA.cobro = EstacionA.cobro + 18;
                    IDCard.saldo = IDCard.saldo - EstacionA.cobro;
                    MessageBox.Show("numero de estaciones: " + EstacionA.num_Estaciones + " El cargo total es: " + EstacionA.cobro + " tu saldo es: " + IDCard.saldo);
                    EstacionA.num_Estaciones = 0;
                    EstacionA.cobro = 0;
                    IDCard iDCard = new IDCard();
                    iDCard.Show();
                    Close();
                }
                else
                {
                    EstacionA.cobro = EstacionA.cobro + 22;
                    IDCard.saldo = IDCard.saldo - EstacionA.cobro;
                    MessageBox.Show("numero de estaciones: " + EstacionA.num_Estaciones + " El cargo total es: " + EstacionA.cobro + " tu saldo es: " + IDCard.saldo);
                    EstacionA.num_Estaciones = 0;
                    EstacionA.cobro = 0;
                    IDCard iDCard = new IDCard();
                    iDCard.Show();
                    Close();
                }
            }
        }
    }
}

