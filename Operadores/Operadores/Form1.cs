﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String divisivelPorTres = "";
            String divisivelPorQuatro = "";
            for (int i = 0; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    divisivelPorTres += " " + i;
                }
                else if (i % 4 == 0)
                {
                    divisivelPorQuatro += " " + i;                    
                }
            }
            MessageBox.Show("Números de 0 a 30 divisíveis por 3: " + divisivelPorTres);
            MessageBox.Show("Números de 0 a 30 divisíveis por 4: " + divisivelPorQuatro);
        }
    }
}
