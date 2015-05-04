using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite suas mensagens! Para sair digite CTRL + Z");
            TextReader leitor = Console.In;
            string linha = leitor.ReadLine();
            while (linha != null)
            {
                Console.WriteLine(linha);
                linha = leitor.ReadLine();
            }
        }
    }
}
