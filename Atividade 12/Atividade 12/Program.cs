int num1;
int num2;

Console.WriteLine("Escreva o primeiro numero");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva o segundo numero");
num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("O primeiro numero é maior que o segundo");
}
else
{
    Console.WriteLine("O segundo numero é maior que o primeiro");
}