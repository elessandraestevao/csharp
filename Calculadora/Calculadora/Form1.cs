using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curso.Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        void Form1_Load(object sender, EventArgs e)
        {
            MudarCorDeFundoParaDarkBlue();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoSomar_Click(object sender, EventArgs e)
        {
            MudarCorDeFundoParaHotPink();
            try
            {
                SomarDoisNumeros();
            }
            catch (OverflowException exception)
            {
                ProcederComOverflowException();
            }catch (FormatException exception)
            {
                ProcederComFormatException();
            }
        }

        private void botaoSubtrair_Click(object sender, EventArgs e)
        {
            MudarCorDeFundoParaCoral();
            try
            {
                SubtrairDoisNumeros();
            }
            catch (OverflowException exception)
            {
                ProcederComOverflowException();
            }
            catch (FormatException exception)
            {
                ProcederComFormatException();
            }

        }

        private void botaoMultiplicar_Click(object sender, EventArgs e)
        {
            MudarCorDeFundoParaDarkMagenta();
            try
            {
                MultiplicarDoisNumeros();
            }
            catch (OverflowException exception)
            {
                ProcederComOverflowException();
            }
            catch (FormatException exception)
            {
                ProcederComFormatException();
            }
            
        }

        private void botaoDividir_Click(object sender, EventArgs e)
        {
            MudarCorDeFundoParaDarkOrchid();
            try
            {
                DividirDoisNumeros();
            }
            catch (OverflowException exception)
            {
                ProcederComOverflowException();
            }catch (FormatException exception)
            {
                ProcederComFormatException();
            }catch (DivideByZeroException exception)
            {
                ProcederComDiviByZeroException();
            }
            
        }

        private void botaoLimpar_Click(object sender, EventArgs e)
        {            
            LimparCalculo();
        }

        private void ProcederComOverflowException()
        {
            MessageBox.Show("Números digitados fora do limite de cálculo!");
            LimparCalculo();
        }

        private void ProcederComFormatException()
        {
            MessageBox.Show("Digite os números!");
            LimparCalculo();
        }

        private void ProcederComDiviByZeroException()
        {
            MessageBox.Show("Divisão por zero é inválida!");
            LimparCalculo();
        }

        private void MudarCorDeFundoParaDarkBlue()
        {
            this.BackColor = System.Drawing.Color.DarkBlue;
        }

        private void MudarCorDeFundoParaCoral()
        {
            this.BackColor = System.Drawing.Color.Coral;
        }

        private void MudarCorDeFundoParaDarkMagenta()
        {
            this.BackColor = System.Drawing.Color.DarkMagenta;
        }

        private void MudarCorDeFundoParaDarkOrchid()
        {
            this.BackColor = System.Drawing.Color.DarkOrchid;
        }

        private void MudarCorDeFundoParaHotPink()
        {
            this.BackColor = System.Drawing.Color.HotPink;
        }

        private void SomarDoisNumeros()
        {
            double num1 = Convert.ToDouble(textoNumeroUm.Text);
            double num2 = Convert.ToDouble(textoNumeroDois.Text);
            textoNumeroResposta.Text = Convert.ToString(num1 + num2);
        }

        private void SubtrairDoisNumeros()
        {
            double num1 = Convert.ToDouble(textoNumeroUm.Text);
            double num2 = Convert.ToDouble(textoNumeroDois.Text);
            textoNumeroResposta.Text = Convert.ToString(num1 - num2);
        }

        private void MultiplicarDoisNumeros()
        {
            double num1 = Convert.ToDouble(textoNumeroUm.Text);
            double num2 = Convert.ToDouble(textoNumeroDois.Text);
            textoNumeroResposta.Text = Convert.ToString(num1 * num2);
        }

        private void DividirDoisNumeros()
        {
            double num1 = Convert.ToDouble(textoNumeroUm.Text);
            double num2 = Convert.ToDouble(textoNumeroDois.Text);
            textoNumeroResposta.Text = Convert.ToString(num1 / num2);
        }

        private void LimparCalculo()
        {
            textoNumeroUm.Text = "";
            textoNumeroDois.Text = "";
            textoNumeroResposta.Text = "";
            MudarCorDeFundoParaDarkBlue();
        }
    }
}
