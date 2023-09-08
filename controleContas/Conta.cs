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
                throw new ArgumentException("O saldo inicial deve ser superior ou igual a R$10,00.");
            }
        }

        public long Numero { get; private set; }
        public decimal Saldo { get; set; }
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
            AtualizarSaldoTotal();
            return Saldo;
        }

        public void AtualizarSaldo(decimal novoSaldo)
        {
            Saldo += novoSaldo;
            AtualizarSaldoTotal();
        }

        private void AtualizarSaldoTotal()
        {
            Conta.AtualizarSaldoTotal(this, Titular.Conta);
        }

        public static void AtualizarSaldoTotal(Conta conta1, Conta conta2)
        {
            SaldoTotalGeral = conta1.Saldo + conta2.Saldo;
        }
    }
}