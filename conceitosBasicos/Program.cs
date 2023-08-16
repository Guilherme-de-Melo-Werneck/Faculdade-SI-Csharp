// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");

int num1 = 20;
string num2 = "22";
string soma = num2 + num2;
Console.WriteLine($"A soma entre {num1} e {num2} é {soma}");

float pi = 3.141697f;
decimal salario = 4343535.34334m;

Console.WriteLine("PI: {0}", pi.ToString(CultureInfo.InvariantCulture));
Console.WriteLine($"salario {salario}");
