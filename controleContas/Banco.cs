using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleContas;
public class Banco
{
    public string Nome { get; private set; }
    public int Numero { get; private set; }

    public Banco(string nome, int numero)
    {
        Nome = nome;
        Numero = numero;
    }
}