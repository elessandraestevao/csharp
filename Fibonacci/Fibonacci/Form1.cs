﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            int n1 = 0;
            int n2 = 1;
            String serieFibonacci = n1 + ", " + n2 + ", ";
            int fibonacci = n1 + n2;
            while (fibonacci <= 100)
            {
                fibonacci = n1 + n2;
                serieFibonacci += fibonacci + ", ";                
                n1 = n2;
                n2 = fibonacci;
            }
            MessageBox.Show("Série de Fibonacci até passar de 100: " + serieFibonacci);
        }

    }
}
