Console.Write("Digite um valor para N: ");
int n = int.Parse(Console.ReadLine());

if (n < 0)
{
    Console.WriteLine("Fatorial de número negativo não existe!");
}
else
{
    int fatorial = 1;

    for (int i = 1; i <= n; i++)
    {
        fatorial *= i;
    }

    Console.WriteLine($"{n}! = {fatorial}");
}