﻿using System;
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
        Conta[] contas;
        int indiceSelecionado;
        int destinoSelecionado;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
           /* this.cc.Titular = "Victor";
            this.cc.Deposita(250.0);
            this.cc.Numero = 1;*/

            this.cp.Titular = "Victor";
            this.cp.Deposita(100.0);
            this.cp.Numero = 2;

            this.MostraConta(cc);

           
 //Exercicio do comboBox
            contas = new Conta[20];
            contas[0] = new ContaCorrente();
            contas[0].Titular = "Adriana";
            contas[0].Numero = 3;
            contas[0].Deposita(8000.0);

            contas[1] = new ContaCorrente();
            contas[1].Titular = "Beatriz";
            contas[1].Numero = 4;
            contas[1].Deposita(900.0);

            contas[2] = new ContaCorrente();
            contas[2].Titular = "Camila";
            contas[2].Numero = 5;
            contas[2].Deposita(2000.0);

            contas[3] = new ContaCorrente();
            contas[3].Titular = "Daniel";
            contas[3].Numero = 6;
            contas[3].Deposita(1000.0);
           foreach (Conta co in contas)
            {
                //MessageBox.Show(co.Titular + " ");
                //MessageBox.Show(Convert.ToString(ContaCorrente.ProximaConta()));
                comboContas.Items.Add(co.Titular);
                destinoDaTransferencia.Items.Add(co.Titular);
            }       
            
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceSelecionado = comboContas.SelectedIndex;
            textoNumeroCombo.Text = Convert.ToString(contas[indiceSelecionado].Numero);
            AtualizaSaldoComboBox();
            textoTitularCombo.Text = contas[indiceSelecionado].Titular;
            MostraConta(contas[indiceSelecionado]);            
           
        }

        private void botaoSacarComboBox_Click(object sender, EventArgs e)
        {
            contas[indiceSelecionado].Saca(Convert.ToDouble(textoValorComboBox.Text));
            MostraConta(contas[indiceSelecionado]);
            AtualizaSaldoComboBox();
        }

        private void botaoDepositarComboBox_Click(object sender, EventArgs e)
        {
            contas[indiceSelecionado].Deposita(Convert.ToDouble(textoValorComboBox.Text));
            MostraConta(contas[indiceSelecionado]);
            AtualizaSaldoComboBox();
        }       

        private void AtualizaSaldoComboBox()
        {
            textoSaldoCombo.Text = Convert.ToString(contas[indiceSelecionado].Saldo);
            textoSaldoDestino.Text = Convert.ToString(contas[destinoSelecionado].Saldo);
        }

        private void botaoTransferir_Click(object sender, EventArgs e)
        {
            contas[indiceSelecionado].Transfere(Convert.ToDouble(textoValorComboBox.Text), contas[destinoSelecionado]);
            MostraConta(contas[indiceSelecionado]);
            AtualizaSaldoComboBox();
        }

        private void destinoDaTransferencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            destinoSelecionado = destinoDaTransferencia.SelectedIndex;
            textoTitularDestino.Text = contas[destinoSelecionado].Titular;
            textoNumeroDestino.Text = Convert.ToString(contas[destinoSelecionado].Numero);
            textoSaldoDestino.Text = Convert.ToString(contas[destinoSelecionado].Saldo);            
        }

        private void botaoImposto_Click(object sender, EventArgs e)
        {
            ContaPoupanca cp = new ContaPoupanca();
            cp.Deposita(100.0);

            SeguroDeVida sv = new SeguroDeVida();

            GerenciadorDeImposto gi = new GerenciadorDeImposto();
            gi.Adiciona(cp);
            gi.Adiciona(sv);

            MessageBox.Show("O total é: " + gi.Total);
        } 
        
        public void CadastraNovaConta(Conta cta)
        {
            int qtde = ContaCorrente.ProximaConta();
            this.contas[qtde - 1] = cta;            
        }

        private void botaoCadastrarNovaConta_Click(object sender, EventArgs e)
        {
            CadastroDeConta cadastroConta = new CadastroDeConta(this);
            cadastroConta.ShowDialog();
        }

        private void botaoLINQ_Click(object sender, EventArgs e)
        {
            var filtrados = from c in this.contas
                            where c.Titular.StartsWith("A")
                            select c;

            foreach (Conta c in filtrados)
            {
                MessageBox.Show(c.Titular);
            }
        }
        
    }
}
