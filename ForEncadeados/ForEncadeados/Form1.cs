using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForEncadeados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int qtdeDeLinhas = 5;
            String triangulo = "";
            for(int i = 1; i <= qtdeDeLinhas; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    triangulo += j * i + " ";
                }
                triangulo += "\n";
            }
            MessageBox.Show(triangulo);
        }
    }
}
