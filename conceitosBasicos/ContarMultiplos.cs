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


//public: É um modificador de acesso que indica que o método pode ser acessado por outras classes fora da própria classe onde ele está definido. 
// sso significa que o método é visível e pode ser chamado de qualquer lugar onde a classe que contém esse método seja acessível.

//bool: É o tipo de retorno do método. Isso significa que quando o método é chamado, ele retornará um valor do tipo bool, que representa um valor 
//lógico (true ou false).

//Multiplo: É o nome do método. Nesse contexto, o nome sugere que o método será usado para verificar se um número é um múltiplo de outro número.

//(int numero, int divisor): Entre parênteses, estão os parâmetros do método. Nesse caso, o método recebe dois parâmetros: numero e divisor, 
//ambos do tipo int (inteiro).

//numero: Este é um parâmetro que representa o número que será verificado para determinar se ele é um múltiplo.
//divisor: Este é um parâmetro que representa o número pelo qual vamos verificar se o numero é um múltiplo.


//Esse código é um exemplo de um namespace chamado "Multiplos3" que contém uma classe chamada "MultiplosCalcular". A classe "MultiplosCalcular" 
//possui um método público chamado "Multiplo" que verifica se um número é um múltiplo de 3