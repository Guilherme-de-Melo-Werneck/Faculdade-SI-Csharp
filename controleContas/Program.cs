using System;

namespace controleContas
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Gustavo", 21, "19878965427");
            Cliente cliente2 = new Cliente("Guilherme", 21, "17914527793");

            Conta conta1 = new Conta(123456, 1000.00m, cliente1);
            Conta conta2 = new Conta(654321, 2000.00m, cliente2);

            while (true)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Informações das Contas");
                Console.WriteLine("2 - Saldo Total Geral");
                Console.WriteLine("3 - Dados do Cliente 1");
                Console.WriteLine("4 - Dados do Cliente 2");
                Console.WriteLine("5 - Saque da Conta 1");
                Console.WriteLine("6 - Saque da Conta 2");
                Console.WriteLine("7 - Adicionar dinheiro à Conta 1");
                Console.WriteLine("8 - Adicionar dinheiro à Conta 2");
                Console.WriteLine("0 - Sair");

                int escolha = Convert.ToInt32(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine($"Número da Conta 1: {conta1.Numero} com saldo {conta1.Saldo}");
                        Console.WriteLine($"Número da Conta 2: {conta2.Numero} com saldo {conta2.Saldo}");
                        break;
                    case 2:
                        decimal saldoTotal = Conta.CalcularSaldoTotal(conta1, conta2);
                        Console.WriteLine($"Saldo total geral: {saldoTotal}");
                        break;
                    case 3:
                        Console.WriteLine($"Dados do cliente 1: {cliente1.Nome}, CPF: {cliente1.CPF}, Saldo: R${conta1.Saldo}");
                        break;
                    case 4:
                        Console.WriteLine($"Dados do cliente 2: {cliente2.Nome}, CPF: {cliente2.CPF}, Saldo: R${conta2.Saldo}");
                        break;
                    case 5:
                        Console.WriteLine("Digite o valor do saque da Conta 1:");
                        decimal valorSaqueConta1 = Convert.ToDecimal(Console.ReadLine());
                        conta1.Saque(valorSaqueConta1);
                        Console.WriteLine($"Saldo da Conta 1 após saque: {conta1.Saldo}");
                        break;
                    case 6:
                        Console.WriteLine("Digite o valor do saque da Conta 2:");
                        decimal valorSaqueConta2 = Convert.ToDecimal(Console.ReadLine());
                        conta2.Saque(valorSaqueConta2);
                        Console.WriteLine($"Saldo da Conta 2 após saque: {conta2.Saldo}");
                        break;
                    case 7:
                        Console.WriteLine("Digite o valor a ser adicionado à Conta 1:");
                        decimal valorAdicionarConta1 = Convert.ToDecimal(Console.ReadLine());
                        conta1.AtualizarSaldo(valorAdicionarConta1);
                        Console.WriteLine($"Saldo da Conta 1 após adição: {conta1.Saldo}");
                        break;
                    case 8:
                        Console.WriteLine("Digite o valor a ser adicionado à Conta 2:");
                        decimal valorAdicionarConta2 = Convert.ToDecimal(Console.ReadLine());
                        conta2.AtualizarSaldo(valorAdicionarConta2);
                        Console.WriteLine($"Saldo da Conta 2 após adição: {conta2.Saldo}");
                        break;
                    case 0:
                        Console.WriteLine("Saindo do programa.");
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}

