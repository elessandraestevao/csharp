using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploClasseConta
{
    class Conta
    {
        public double saldo;
        public Cliente titular;
        public int numero;        
        
        public bool Saca(double valor)
        {
            if(valor >= 0 && valor <= this.saldo)
            {                
                if (titular.EhMaiorDeIdade())
                {
                    this.saldo -= valor;                    
                }
                else
                {
                    if (valor > 200)
                    {
                        valor = 200;                        
                    }
                    this.saldo -= valor;
                }
                return true;
            }
            else
            {
                return false;
            }            
        }

        public void Deposita(double valor)
        {
            this.saldo += valor;
        }

        public void Transfere(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }
    }
}
