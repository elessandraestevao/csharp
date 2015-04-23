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
            conta.numero = 00001;
            conta.saldo = 5000.0;

            Cliente cliente = new Cliente();
            conta.titular = cliente;
            conta.titular.nome = "Marina Costa Silva";

            MessageBox.Show("Nome do titular é: " + conta.titular.nome);

            Conta contaDois = new Conta();
            contaDois.numero = 00002;
            contaDois.saldo = 400.0;
            Cliente cliente2 = new Cliente();
            contaDois.titular = cliente2;
            contaDois.titular.nome = "José Carlos";
            cliente2.idade = 17;

            MessageBox.Show("Maior de idade: " + cliente2.EhMaiorDeIdade());           
            

            if(contaDois.Saca(300.0))
            {
                MessageBox.Show("Saque realizado com sucesso.");
            }
            else
            {
                MessageBox.Show("Saque não realizado.");
            }

            MessageBox.Show("Saldo da conta após saque: " + contaDois.saldo);

            

            MessageBox.Show("Segunda Conta ---- Titular: " + contaDois.titular.nome + " Saldo: " + contaDois.saldo
                + " Número: " + contaDois.numero);
        }
    }
}
