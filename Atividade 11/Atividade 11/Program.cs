using System.ComponentModel.Design;

int ano1;
int ano2;

Console.WriteLine("Escreva o ano atual");
ano1 = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva o ano que você nasceu!");
ano2 = int.Parse(Console.ReadLine());

if ((ano1 - ano2) >= 18)
{
    Console.WriteLine("Seu voto é OBRIGATORIO");
}
else if ((ano1 - ano2) >= 16)
{
    Console.WriteLine("Seu voto é FACULTATIVO");
}
else
{
    Console.WriteLine("Você NÃO PODE votar esse ano");
}