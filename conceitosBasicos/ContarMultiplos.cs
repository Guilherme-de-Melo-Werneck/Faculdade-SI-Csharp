using System.Runtime.Intrinsics.X86;

namespace conceitosBasicos
{
    // Declaração do namespace chamado "conceitosBasicos" para agrupar classes relacionadas.

    public class MultiplosCalcular
    {
        // Declaração da classe pública chamada "MultiplosCalculator".

        public bool Multiplo(int numero, int divisor)
        {
            // Declaração de um método público chamado "Multiplo" que aceita dois parâmetros inteiros: "numero" e "divisor".
            // O método irá verificar se "numero" é um múltiplo de "divisor".

            return numero % divisor == 0;
            // Retorna verdadeiro (true) se "numero" for um múltiplo de "divisor".
            // A expressão "numero % divisor" calcula o resto da divisão e compara com 0 para determinar se é um múltiplo.
        }
    }
}

