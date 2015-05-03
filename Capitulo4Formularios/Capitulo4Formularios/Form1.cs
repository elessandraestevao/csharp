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
    public partial class Form1 : Form
    {
        Conta[] contas = null;
        int qtdeContas;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Exercicio do comboBox
            contas = new Conta[5];
            contas[0] = new ContaCorrente();
            contas[0].Titular = "Adriana";
            contas[0].Numero = 3;
            contas[0].Deposita(8000.0);
            qtdeContas++;

            contas[1] = new ContaCorrente();
            contas[1].Titular = "Beatriz";
            contas[1].Numero = 4;
            contas[1].Deposita(900.0);
            qtdeContas++;

            contas[2] = new ContaCorrente();
            contas[2].Titular = "Camila";
            contas[2].Numero = 5;
            contas[2].Deposita(2000.0);
            qtdeContas++;

            contas[3] = new ContaCorrente();
            contas[3].Titular = "Daniel";
            contas[3].Numero = 6;
            contas[3].Deposita(1000.0);
            qtdeContas++;

            PreencheComboContas();         
        }

        private void PreencheComboContas()
        {
             foreach (Conta conta in this.contas)
            {
                if (conta != null)
                {
                    comboContas.Items.Add(conta);
                }                
            }
            comboContas.DisplayMember = "Titular";
        }

        public void CadastraNovaConta(Conta conta)
        {    
            if(this.qtdeContas == this.contas.Length)
            {
                Conta[] novo = new Conta[this.contas.Length * 2];
                for(int i = 0; i < this.contas.Length; i++)
                {
                    novo[i] = this.contas[i];
                }
                this.contas = novo;
            }
            this.contas[this.qtdeContas] = conta;
            this.qtdeContas++;
            comboContas.Items.Add(conta);            
        }

        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            CadastroDeContas cadastro = new CadastroDeContas(this);
            cadastro.ShowDialog();
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelecionado = comboContas.SelectedIndex;            
            textoTitular.Text = contas[indiceSelecionado].Titular;
            textoNumero.Text = Convert.ToString(contas[indiceSelecionado].Numero);
            textoSaldo.Text = Convert.ToString(contas[indiceSelecionado].Saldo);            
        }

        private void botaoRemoverConta_Click(object sender, EventArgs e)
        {
            int contaSelecionada = comboContas.SelectedIndex;
            RemoveContaDoCombo(this.contas[contaSelecionada]);
            RemoveContaDoArray(this.contas[contaSelecionada]);
        }

        private void RemoveContaDoArray(Conta conta)
        {
            for (int i = 0; i < this.contas.Length; i++)
            {
                if (this.contas[i] == conta)
                {
                    for (int j = i; j + 1 < this.contas.Length; j++)
                    {
                        this.contas[j] = this.contas[j + 1];
                    }
                    break;
                }                
            }
        }

        private void RemoveContaDoCombo(Conta conta)
        {
            comboContas.Items.Remove(conta);
            textoNumero.Text = "";
            textoSaldo.Text = "";
            textoTitular.Text = "";
        }
    }
}
 