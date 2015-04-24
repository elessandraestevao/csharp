using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploClasseConta
{
    class Cliente
    {
        public string Nome {get; set;}
        public string Rg {get; set;}
        public string Cpf {get; set;}
        public string Endereco {get; set;}
        public int Idade {get; set;}

        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public Cliente() { }              

        public bool EhMaiorDeIdade()
        {
            if (this.Idade >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
