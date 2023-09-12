using System;

namespace controleContas
{
    public class Conta
    {
        public Conta(long numero, Agencia agencia, Banco banco, decimal saldoInicial)
        {
            this.Numero = numero;
            this.Saldo = saldoInicial; // Não verifica mais o saldo inicial
            this.Titular = null;
            this.Agencia = agencia;
            this.Banco = banco;
        }

        public long Numero { get; private set; }
        public decimal Saldo { get; private set; }
        public Cliente? Titular { get; private set; }
        public Agencia Agencia { get; private set; }
        public Banco Banco { get; private set; }
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
            if (novoSaldo <= 10.00m)
            {
                Console.WriteLine("O valor a ser adicionado à conta deve ser maior que R$10,00.");
                Environment.Exit(0);
            }

            Saldo += novoSaldo;
        }

        public void DefinirCliente(Cliente cliente)
        {
            if (cliente != null)
            {
                this.Titular = cliente;
            }
            else
            {
                Console.WriteLine("Cliente inválido");
            }
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

