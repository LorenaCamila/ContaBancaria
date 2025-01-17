﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria.Entities
{
    internal class ContaPoupanca : Conta
    {
        public double TaxaDeJuros { get; set; }

        public ContaPoupanca()
        {
        }

        public ContaPoupanca(int numero, string titular, double saldo, double taxaDeJuros) : base(numero, titular, saldo)
        {
            TaxaDeJuros = taxaDeJuros;
        }

        public void AtualizarSaldo()
        {
            Saldo =+ Saldo * TaxaDeJuros;
        }
    }
}
