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
    public partial class Portada : Form
    {
        public Portada()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modulo_de_tarjetas modulo = new Modulo_de_tarjetas();
            modulo.Show();
        }
    }
}
