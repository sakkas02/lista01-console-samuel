
        Console.Write("Digite o primeiro número: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Digite o terceiro número: ");
        int c = int.Parse(Console.ReadLine());
        int menor, meio, maior;
        if (a <= b && a <= c)
        {
            menor = a;
            if (b <= c)
            {
                meio = b;
                maior = c;
            }
            else
            {
                meio = c;
                maior = b;
            }
        }
        else if (b <= a && b <= c)
        {
            menor = b;
            if (a <= c)
            {
                meio = a;
                maior = c;
            }
            else
            {
                meio = c;
                maior = a;
            }
        }
        else
        {
            menor = c;
            if (a <= b)
            {
                meio = a;
                maior = b;
            }
            else
            {
                meio = b;
                maior = a;
            }
        }
        Console.WriteLine($"Ordem crescente: {menor}, {meio}, {maior}");