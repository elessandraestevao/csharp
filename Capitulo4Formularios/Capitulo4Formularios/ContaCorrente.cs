using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo4Formularios
{
    class ContaCorrente : Conta
    {
        public static int TotalDeContas { get; private set; }

        public ContaCorrente()
        {
            ContaCorrente.TotalDeContas++;
        }

        public static int Contador()
        {
            return ContaCorrente.TotalDeContas -1;
        }
    }
}
