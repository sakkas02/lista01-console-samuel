using System.ComponentModel.Design;

Console.WriteLine("Escreva quantas maças deseja!");
int maca;

maca = int.Parse(Console.ReadLine());

if (maca > 12)
{
    Console.WriteLine($" O Custo total das {maca} será R${maca}");
}
else
{
    Console.WriteLine($"O custo total será R${maca*1.3}");
}