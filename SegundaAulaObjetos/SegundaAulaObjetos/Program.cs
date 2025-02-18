using System;
using SegundaAulaObjetos;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            Console.WriteLine("Entre os dados do produto:");

            Console.WriteLine("Nome:");
            p.Nome = Console.ReadLine();

            Console.WriteLine("Preço:");
            p.Preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade no estoque:");
            p.Quantia = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do Produto: {p}");

            Console.WriteLine("Digite a quantidade de produtos a ser adicionado no estoque:");
            int quantidadeAdicionada = int.Parse(Console.ReadLine());
            p.adicionarQuantidade(quantidadeAdicionada);

            Console.WriteLine($"Dados atualizados: {p}");

            Console.WriteLine("Digite a quantidade de produtos a ser removido no estoque:");
            int quantidadeRemovida = int.Parse(Console.ReadLine());
            p.removerQuantidade(quantidadeRemovida);

            Console.WriteLine($"Dados atualizados: {p}");
        }
    }
}