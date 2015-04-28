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
    public partial class Form1 : Form
    {        
        ContaCorrente cc = new ContaCorrente();
        ContaPoupanca cp = new ContaPoupanca();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            this.cc.Titular = "Victor";
            this.cc.Deposita(250.0);
            this.cc.Numero = 1;

            this.cp.Titular = "Victor";
            this.cp.Deposita(100.0);
            this.cp.Numero = 2;

            this.MostraConta(cc);
        }

        private void botaoDepositaCC_Click(object sender, EventArgs e)
        {
            this.cc.Deposita(Convert.ToDouble(textoValor.Text));
            this.MostraConta(cc);
        }

        private void MostraConta(Conta conta)
        {
            textoTitular.Text = conta.Titular;
            textoSaldo.Text = Convert.ToString(conta.Saldo);
            textoNumero.Text = Convert.ToString(conta.Numero);
            TotalizarContas();
        }

        private void botaoSacaCC_Click(object sender, EventArgs e)
        {
            this.cc.Saca(Convert.ToDouble(textoValor.Text));
            this.MostraConta(cc);
        }
        
        private void TotalizarContas()
        {
            TotalizadorDeContas tc = new TotalizadorDeContas();
            tc.Adiciona(this.cc);
            tc.Adiciona(this.cp);
            textoTotalizador.Text = Convert.ToString(tc.SaldoTotal);
        }

        private void botaoDepositaPP_Click(object sender, EventArgs e)
        {
            this.cp.Deposita(Convert.ToDouble(textoValor.Text));
            this.MostraConta(cp);
        }

        private void botaoSacaPP_Click(object sender, EventArgs e)
        {
            this.cp.Saca(Convert.ToDouble(textoValor.Text));
            this.MostraConta(cp);
        }
    }
}
