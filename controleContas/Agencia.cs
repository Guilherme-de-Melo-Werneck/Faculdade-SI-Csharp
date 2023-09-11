using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleContas;
public class Agencia
{
    public int Numero { get; private set; }
    public string CEP { get; private set; }
    public string Telefone { get; private set; }

    public Agencia(int numero, string cep, string telefone)
    {
        Numero = numero;
        CEP = cep;
        Telefone = telefone;
    }
}
