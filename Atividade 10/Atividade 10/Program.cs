using System;

double nota1;
double nota2;
double media;
Console.WriteLine("Escreva a sua primeira nota");
nota1 = double.Parse(Console.ReadLine());
Console.WriteLine("Escreva a sua segunda nota");
nota2 = double.Parse(Console.ReadLine());
media = (nota1 + nota2) / 2;

if (media>=6)
{
    Console.WriteLine($"Sua situação é de APROVADO, com a média {media}");
}
else
{
    Console.WriteLine($"Sua situação é de REPROVADO, com a média {media}");
}
