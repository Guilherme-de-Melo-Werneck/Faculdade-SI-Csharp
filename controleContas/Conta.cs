using System;

namespace controleContas
{
    public class Conta
    {
        public Conta(long numero, decimal saldoInicial, Cliente titular)
        {
            if (saldoInicial >= 10.00m)
            {
                this.Numero = numero;
                this.Saldo = saldoInicial;
                this.Titular = titular;
            }
            else
            {
                Console.WriteLine("O saldo inicial deve ser superior ou igual a R$10,00.");
                Environment.Exit(0); // Encerra o programa
            }
        }

        public long Numero { get; private set; }
        public decimal Saldo { get; private set; }
        public Cliente Titular { get; private set; }
        public static decimal SaldoTotalGeral { get; private set; }

        public decimal Saque(decimal valorSaque)
        {
            if (valorSaque > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para saque");
                return Saldo;
            }

            Saldo -= valorSaque;
            return Saldo;
        }

        public void AtualizarSaldo(decimal novoSaldo)
        {
            Saldo += novoSaldo;
        }

        public static decimal CalcularSaldoTotal(params Conta[] contas)
        {
            decimal saldoTotal = 0;

            foreach (var conta in contas)
            {
                saldoTotal += conta.Saldo;
            }

            return saldoTotal;
        }
    }
}



