﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploClasseConta
{
    class Conta
    {
        public double saldo;
        public string titular;
        public int numero;
        public string cpf;
        public int agencia;

        public void Saca(double valor)
        {
            this.saldo -= valor;
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
