// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite o preço:");
double preco = double.Parse(Console.ReadLine());
double desconto = (preco > 20) ? preco * 0.1 : preco * 0.05;
Console.WriteLine(desconto);
