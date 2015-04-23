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
            conta.titular = "Marina Costa Silva";

            MessageBox.Show("Nome do titular é: " + conta.titular);

            Conta contaDois = new Conta();
            contaDois.numero = 00002;
            contaDois.saldo = 400.0;
            contaDois.titular = "José Carlos";
            contaDois.agencia = 0909;
            contaDois.cpf = "09009009080";

            MessageBox.Show("Segunda Conta ---- Titular: " + contaDois.titular + " Saldo: " + contaDois.saldo
                + " Número: " + contaDois.numero + " Agência: " + contaDois.agencia);
        }
    }
}
