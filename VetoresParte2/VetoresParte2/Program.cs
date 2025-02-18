// See https://aka.ms/new-console-template for more information
using VetoresParte2;

int n = int.Parse(Console.ReadLine());
Produto[] vect = new Produto[n];
double sumPrice = 0;

for (int i  = 0;  i < n;  i++)
{
    Console.WriteLine("Digite o nome do produto:");
    string name = Console.ReadLine();
    Console.WriteLine("Digite o preço do produto:");
    double price = double.Parse(Console.ReadLine());
    vect[i] = new Produto { Name = name, Price = price };
    sumPrice += price;
}
double avgPrice = sumPrice / n;
Console.WriteLine($"Preço médio = {avgPrice.ToString("F2")}");