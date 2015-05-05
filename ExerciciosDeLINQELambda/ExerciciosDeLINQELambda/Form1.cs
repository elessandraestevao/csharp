using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciciosDeLINQELambda
{
    public partial class Form1 : Form
    {
        private List<Conta> listaContas = new List<Conta>();
        private List<String> listaStrings = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Lista de Contas
            Conta c1 = new Conta();
            c1.Titular = "Adriana";
            c1.Numero = 1;
            c1.Deposita(9000.0);
            Conta c2= new Conta();
            c2.Titular = "Beraldo";
            c2.Numero = 2;
            c2.Deposita(2000.0);
            Conta c3 = new Conta();
            c3.Titular = "Carlos";
            c3.Numero = 3;
            c3.Deposita(6000.0);
            Conta c4 = new Conta();
            c4.Titular = "Daniela";
            c4.Numero = 4;
            c4.Deposita(1000.0);
            Conta c5 = new Conta();
            c5.Titular = "Amanda";
            c5.Numero = 5;
            c5.Deposita(1000.0);

            listaContas.Add(c1);
            listaContas.Add(c2);
            listaContas.Add(c3);
            listaContas.Add(c4);
            listaContas.Add(c5);

            //Lista de strings
            listaStrings.Add("abacaxi");
            listaStrings.Add("figo");
            listaStrings.Add("banana");
            listaStrings.Add("goiaba");
            listaStrings.Add("caju");
            listaStrings.Add("jamelão");
            listaStrings.Add("damasco");
            listaStrings.Add("laranja");


        }        

        private void buttonFiltroSimples_Click(object sender, EventArgs e)
        {
            var filtradas = from c in listaContas
                            where c.Titular.StartsWith("A")
                            select c;
            foreach (Conta c in filtradas)
            {
                MessageBox.Show(c.Titular);
            }
                            
        }

        private void buttonLambda_Click(object sender, EventArgs e)
        {
            var filtradas = listaContas.Where(c => c.Numero < 10 && c.Saldo > 4000.0);
            foreach (Conta c in filtradas)
            {
                MessageBox.Show(c.Titular);
            }
        }

        private void buttonMenorValor_Click(object sender, EventArgs e)
        {
            var menorValor = listaContas.Min(c => c.Saldo);            
            MessageBox.Show(menorValor.ToString());            
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            int contador = listaContas.Count(c => c.Saldo > 1000.0);
            MessageBox.Show(contador.ToString());
        }

        private void buttonProjecao_Click(object sender, EventArgs e)
        {
            var filtradas = from c in listaContas
                            where c.Numero < 5
                            select new {c.Titular, c.Saldo };
            foreach (var c in filtradas)
            {
                MessageBox.Show(c.Titular + " " + c.Saldo);
            }
        }

        private void buttonArray_Click(object sender, EventArgs e)
        {
            int[] inteiros = new int[] {1,2,3,4,5,6,7,8,9};
            int soma = inteiros.Where(x => x > 0).Sum();
            MessageBox.Show(soma.ToString());
        }

        private void buttonOrdenarArray_Click(object sender, EventArgs e)
        {
            var inteiros = new int[] {9,8,7,6,5,4,3,2,1,10};
            var ordenados = from x in inteiros
                            orderby x
                            select x;
            foreach (var x in ordenados)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void buttonOrdenarLista1_Click(object sender, EventArgs e)
        {
            var ordenadas = from c in listaContas
                            orderby c.Saldo descending
                            select c;
            foreach (Conta c in ordenadas)
            {
                MessageBox.Show(c.Titular + " " + c.Numero + " " + c.Saldo);
            }

        }

        private void buttonOrdenarLista2_Click(object sender, EventArgs e)
        {
            var ordenadas = from c in listaContas
                             where c.Saldo > 1000.0
                             orderby c.Numero descending
                             select c;
            foreach (Conta c in ordenadas)
            {
                MessageBox.Show(c.Titular + " " + c.Numero + " " + c.Saldo);
            }
        }

        private void buttonOrdenarLista3_Click(object sender, EventArgs e)
        {
            var ordenadas = listaContas.OrderByDescending(c => c.Saldo);
            foreach (Conta c in ordenadas)
            {
                MessageBox.Show(c.Titular + " " + c.Numero + " " + c.Saldo);
            }
        }

        private void buttonOrdenarLista4_Click(object sender, EventArgs e)
        {
            var ordenadas = listaContas.Where(c => c.Saldo < 3000.0).OrderByDescending(c => c.Numero);
            foreach (Conta c in ordenadas)
            {
                MessageBox.Show(c.Titular + " " + c.Numero + " " + c.Saldo);
            }               
        }

        private void buttonOrdenarLista5_Click(object sender, EventArgs e)
        {
            var ordenadas = from c in listaContas
                            orderby c.Saldo, c.Numero
                            select c;
            foreach (Conta c in ordenadas)
            {
                MessageBox.Show(c.Titular + " " + c.Numero + " " + c.Saldo);
            }
        }

        private void buttonOrdenarLista6_Click(object sender, EventArgs e)
        {
            var ordenadas = from s in listaStrings
                            orderby s.Length, s
                            select s;
            foreach (var s in ordenadas)
            {
                MessageBox.Show(s);
            }
        }

        private void buttonOrdenarLista7_Click(object sender, EventArgs e)
        {
            var ordenadas = listaContas.OrderBy(c => c.Saldo).ThenByDescending(c => c.Numero);
            foreach (Conta c in ordenadas)
            {
                MessageBox.Show(c.Titular + " " + c.Numero + " " + c.Saldo);
            }
        }

        private void buttonOrdenarLista8_Click(object sender, EventArgs e)
        {
            var ordenadas = listaStrings.OrderBy(s => s.Length).ThenBy(s => s);
            foreach (var s in ordenadas)
            {
                MessageBox.Show(s);
            }
        }
    }
}
