using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploClasseConta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            conta.Numero = 00001;
            //conta.Saldo = 5000.0;

            Cliente cliente = new Cliente();
            conta.Titular = cliente;
            conta.Titular.Nome = "Marina Costa Silva";

            MessageBox.Show("Nome do titular é: " + conta.Titular.Nome);

            Conta contaDois = new Conta();
            contaDois.Numero = 00002;
            //contaDois.Saldo = 400.0;
            Cliente cliente2 = new Cliente();
            contaDois.Titular = cliente2;
            contaDois.Titular.Nome = "José Carlos";
            cliente2.Idade = 17;


            /*TotalizadorDeContas totalizador = new TotalizadorDeContas();
            Conta c = new Conta();
            totalizador.Adiciona(c);*/

            MessageBox.Show("Maior de idade: " + cliente2.EhMaiorDeIdade());           
            

            if(contaDois.Saca(300.0))
            {
                MessageBox.Show("Saque realizado com sucesso.");
            }
            else
            {
                MessageBox.Show("Saque não realizado.");
            }

            MessageBox.Show("Saldo da conta após saque: " + contaDois.Saldo);

            

            MessageBox.Show("Segunda Conta ---- Titular: " + contaDois.Titular.Nome + " Saldo: " + contaDois.Saldo
                + " Número: " + contaDois.Numero);
        }
    }
}
