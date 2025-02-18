using System;
using SegundaAulaObjetos;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto:");

            Console.WriteLine("Nome:");
            string Nome = Console.ReadLine();

            Console.WriteLine("Preço:");
            double Preco = double.Parse(Console.ReadLine());
            /*
            Console.WriteLine("Quantidade no estoque:");
            int Quantia = int.Parse(Console.ReadLine());

            Produto p = new Produto(Nome, Preco, Quantia);
            */

            Produto p = new Produto(Nome, Preco);
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