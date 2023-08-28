//// See https://aka.ms/new-console-template for more information
//using System.Globalization;

//15/08/23
//Console.WriteLine("Hello, World!");

//int num1 = 20;
//string num2 = "22";
//string soma = num2 + num2;
//Console.WriteLine($"A soma entre {num1} e {num2} é {soma}");

//float pi = 3.141697f;
//decimal salario = 4343535.34334m;

//Console.WriteLine("PI: {0}", pi.ToString(CultureInfo.InvariantCulture));
//Console.WriteLine($"salario {salario}");


//22/08/23
//using conceitosBasicos;

//int n1 = 20;
//int n2 = 11, result;

//Somador soma;
//soma = new Somador();

//result = soma.Soma(n1, n2);
//Console.WriteLine($"A soma dos números {n1} + {n2} é {result}");

//Conversor conversor = new Conversor();

//double metros = 1.76;
//Console.WriteLine("A medida {0} metros corresponde a {1}", metros, Conversor.MetrosMilimetros(1.76));



/////////////////////////////////////////////////////////////////////////////////////////////////////////////////



using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System;
using Multiplos3;

namespace Multiplos3
{
    // Declaração do namespace "Multiplos3" para agrupar as classes e o programa principal.

    class Program
    {
        // Declaração da classe "Program", que contém o método principal.

        static void Main(string[] args)
        {
            // Declaração do método principal do programa.

            MultiplosCalcular calcular = new MultiplosCalcular();
            // Criação de uma instância da classe "MultiplosCalculator" para calcular múltiplos.


            int multiplos = 0;
            
            // Declaração de variáveis para armazenar a quantidade de múltiplos 

            for (int i = 0; i <= 100; i++)
            {
                // Loop "for" para iterar de 0 a 100, inclusive.

                if (calcular.Multiplo(i, 3))
                {
                    // Verifica se o número "i" é múltiplo de 3 usando o método "Multiplo" da instância "calculator".

                    multiplos++;
                    // Incrementa a contagem de múltiplos se o número for um múltiplo de 3.
                }
            }

            Console.WriteLine("Quantidade de múltiplos de 3 no intervalo de 0 a 100: " + multiplos);
            // Exibe a quantidade de múltiplos encontrados.

            
            
        }
    }
    // Fim da declaração da classe "Program".
}
// Fim do namespace "MultiplosDe3".



//Namespace: O código está dentro do namespace Multiplos3, que é usado para organizar as classes e o programa principal.

//Classe Program: Esta é a classe principal que contém o método Main, que é o ponto de entrada do programa.

//Método Main: O método Main é o ponto de partida para a execução do programa.

//Instanciação da Classe MultiplosCalcular: Uma instância da classe MultiplosCalcular é criada usando MultiplosCalcular 
//calcular = new MultiplosCalcular();. Isso permitirá que usemos os métodos definidos na classe MultiplosCalcular.

//Contagem de Múltiplos: Um loop for é usado para iterar de 0 a 100. Para cada valor i no intervalo, verifica-se se é um múltiplo de 3 usando o
//método calcular.Multiplo(i, 3) da instância da classe MultiplosCalcular.Se for, a variável multiplos é incrementada.

//Exibição do Resultado: Após o loop, a quantidade de múltiplos de 3 encontrados é exibida no console usando Console.WriteLine.

//MultiplosCalcular calcular = new MultiplosCalcular(); = MultiplosCalcular calcular = new MultiplosCalcular();: Aqui, estamos criando uma instância 
//da classe MultiplosCalcular e a atribuindo a uma variável chamada calcular. Essa instância será usada para chamar o método Multiplo mais tarde.

//int multiplos = 0; = int multiplos = 0;: Esta linha declara uma variável inteira chamada multiplos e a inicializa com o valor zero. Essa variável 
//será usada para contar quantos números múltiplos de 3 são encontrados no intervalo.

//for (int i = 0; i <= 100; i++) = for (int i = 0; i <= 100; i++): Este é um loop for que itera de 0 a 100, inclusive. Ele declara uma variável i 
//que começa em 0, e enquanto i for menor ou igual a 100, o loop continuará executando. A cada iteração, i é incrementado em 1.

//if (calcular.Multiplo(i, 3)) = if (calcular.Multiplo(i, 3)): Aqui, estamos verificando se o número i é um múltiplo de 3 usando o método Multiplo da 
// instância calcular. O método Multiplo retorna true se i for múltiplo de 3 e false caso contrário.
//multiplos++; = Se o número i for um múltiplo de 3, incrementamos a variável multiplos em 1



