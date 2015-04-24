using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploClasseConta
{
    class Conta
    {
        public double Saldo{get; private set;}
        public Cliente Titular {get; set;}
        public int Numero { get; set; }        
        
        public bool Saca(double valor)
        {
            if(valor >= 0 && valor <= this.Saldo)
            {                
                if (Titular.EhMaiorDeIdade())
                {
                    this.Saldo -= valor;                    
                }
                else
                {
                    if (valor > 200)
                    {
                        valor = 200;                        
                    }
                    this.Saldo -= valor;
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
            this.Saldo += valor;
        }

        public void Transfere(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }
    }
}
