﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoOOCaixaEletronico
{
    class ContaPoupanca : Conta, ITributavel
    {
        public override void Saca(double valor)
        {
            this.Saldo -= valor + 0.10;
        }

        public double CalculaTributos()
        {
            return this.Saldo * 0.02;
        }
    }
}
