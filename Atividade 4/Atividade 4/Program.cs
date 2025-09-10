int anos;
int dias;
Console.WriteLine("Digite quantos anos você tem:");
anos = int.Parse(Console.ReadLine());
Console.WriteLine("Digite quantos dias atrás foi seu aniversário:");
dias = int.Parse(Console.ReadLine());
Console.WriteLine($"Você tem {anos * 365 + dias} de vida");