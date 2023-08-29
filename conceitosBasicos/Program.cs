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



using conceitosBasicos;


            int multiplos = 0;
            // Declaração da variavel multiplos.

            MultiplosCalcular calcular = new MultiplosCalcular();
            //Instância da classe

            for (int i = 0; i <= 100; i++)
            {
                // Loop "for" para iterar de 0 a 100, inclusive.

                if (calcular.Multiplo(i, 3))
                {
                    // Verifica se o número "i" é múltiplo de 3 usando o método "Multiplo" da instância "calculator".

                    multiplos++;
                    // Incrementa a contagem de múltiplos se o número for um múltiplo de 3.

                    Console.WriteLine(i); // Imprime os múltiplos de 3 encontrados
                }
            }

            Console.WriteLine("Quantidade de múltiplos de 3 no intervalo de 0 a 100: " + multiplos);
            // Exibe a quantidade de múltiplos encontrados.

    
 

