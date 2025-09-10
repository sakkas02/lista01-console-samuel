float salarioMensal;
float reajuste;
Console.WriteLine("Digite seu sálario mensal:");
salarioMensal = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor que deseja o reajuste em porcentagem:");
reajuste = float.Parse(Console.ReadLine());
Console.WriteLine($"Digite seu sálario atual é {(reajuste / 100 * salarioMensal) + salarioMensal} com o reajuste de {reajuste / 100 * salarioMensal}");