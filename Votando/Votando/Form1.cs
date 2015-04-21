using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Votando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idade = 16;
            bool brasileira = false;
            bool podeVotar = (idade >= 16) && (brasileira == true);

            if(podeVotar)
            {
                MessageBox.Show("Você está apto (a) a votar");
            }
            else
            {
                MessageBox.Show("Você não está apto (a) a votar");
            }
        }
    }
}
