using System;

namespace controleContas
{
    public class Conta
    {
        public Conta(long numero, Agencia agencia, Banco banco, decimal saldoInicial)
        {
            if (saldoInicial < 10.00m)
            {
                Console.WriteLine("O saldo inicial deve ser superior a R$10,00");
                Environment.Exit(0);
            }
            this.Numero = numero;
            this.Saldo = 0; // Saldo inicializado como zero
            this.Titular = null; // Cliente inicializado como nulo
            this.Agencia = agencia;
            this.Banco = banco;
        }

        public long Numero { get; private set; }
        public decimal Saldo { get; private set; }
        public Cliente? Titular { get; private set; } // Usando Cliente? para permitir nulo
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
