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