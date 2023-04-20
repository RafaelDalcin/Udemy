using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc2
{
    public class Conta
    {
        public int NumeroDaConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public Conta(string titular, int numeroDaConta)
        {
            Nome = titular;
            NumeroDaConta = numeroDaConta;
        }

        public Conta(int numeroDaConta, string nome, double saldo) : this(nome, numeroDaConta)
        {
            Saldo = saldo;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }
        public void Saque(double valor)
        {
            if (Saldo < valor + 5.0)
            {
                Console.WriteLine("Saldo insuficiente para saque!");
            }
            else { Saldo -= valor + 5.0 ; }
        }
        public override string ToString()
        {
            return "Conta "
                + NumeroDaConta
                + ", Titular: "
                + Nome
                + ", Saldo $: "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
