Console.WriteLine("Números entre 1000 e 2000 que deixam resto 5 ao serem divididos por 11:");
for (int i = 1000; i <= 2000; i++)
{
    if (i % 11 == 5)
    {
        Console.WriteLine(i);
    }
}