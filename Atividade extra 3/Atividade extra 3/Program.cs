Console.WriteLine("Escreva a icognita A");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Escreva a icognita B");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Escreva a icognita C");
double c = double.Parse(Console.ReadLine());

Console.WriteLine($"O Valor de delta é de: {((b*b) * (-4 * a * c))}");
