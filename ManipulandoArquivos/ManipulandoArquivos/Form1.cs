using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ManipulandoArquivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("texto.txt"))
            {
                using(Stream entrada = File.Open("texto.txt", FileMode.Open))
                using (StreamReader leitor = new StreamReader(entrada))
                {
                    string linha = leitor.ReadToEnd();
                    textoInicial.Text += linha;
                }
                
                /*Stream entrada = File.Open("texto.txt", FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);
                string linha = leitor.ReadToEnd();
                textoInicial.Text += linha;
                leitor.Close();
                entrada.Close();
                /*Stream entrada = File.Open("texto.txt", FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);
                string linha = leitor.ReadLine();
                while (linha != null)
                {
                    textoInicial.Text += linha;
                    linha = leitor.ReadLine();
                }
                leitor.Close();
                entrada.Close();*/
            }
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            using(Stream saida = File.Open("texto.txt", FileMode.Create))
            using (StreamWriter escritor = new StreamWriter(saida))
            {
                escritor.Write(textoInicial.Text);
            }
            /*Stream saida = File.Open("texto.txt", FileMode.Create);
            StreamWriter escritor = new StreamWriter(saida);
            escritor.Write(textoInicial.Text);
            escritor.Close();
            saida.Close();*/
        }
    }
}
