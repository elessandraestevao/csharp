using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo4Formularios
{
    public partial class CadastroDeContas : Form
    {
        private Form1 formPrincipal;
        public CadastroDeContas(Form1 form1)
        {
            this.formPrincipal = form1;
            InitializeComponent();
        }

        private void botaoCadastrarNovaConta_Click(object sender, EventArgs e)
        {
            Conta conta = null;
            if (comboTipoDeConta.Text == "Conta Corrente")
            {
                conta = new ContaCorrente();
            }
            else
            {
                conta = new ContaPoupanca();
            }
            conta.Titular = textoNovoTitular.Text;
            conta.Numero = Convert.ToInt32(textoNovoNumero.Text);
            this.formPrincipal.CadastraNovaConta(conta);
        }

        private void CadastroDeContas_Load(object sender, EventArgs e)
        {
            comboTipoDeConta.Items.Add("Conta Corrente");
            comboTipoDeConta.Items.Add("Conta Poupança");
        }
    }
}
