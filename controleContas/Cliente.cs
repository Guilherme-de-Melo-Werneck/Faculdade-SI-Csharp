using System;

namespace controleContas
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string CPF { get; private set; }

        public Cliente(string nome, int idade, string cpf)
        {
            if (idade > 18)
            {
                Nome = nome;
                Idade = idade;
                CPF = cpf;
            }
            else
            {
                throw new ArgumentException("Dados inválidos!");
            }
        }
    }
}

