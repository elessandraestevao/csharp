using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoOOCaixaEletronico
{
    public partial class CadastroDeConta : Form
    {
        private Form1 form1;
        public CadastroDeConta(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoCadastrarNovaConta_Click(object sender, EventArgs e)
        {
            string titular = textoTitularNovaConta.Text;
            int numero = Convert.ToInt32(textoNumeroNovaConta.Text);
            Conta conta = new ContaCorrente()
            {
                Titular = titular, Numero = numero
            };
            this.form1.CadastraNovaConta(conta);
        } 
    }
}
