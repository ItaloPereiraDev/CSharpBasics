using System;
using SegundaAulaObjetos;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);
            p.SetNome("LGTV 4KHD+");
            Console.WriteLine(p.GetNome());
        }
    }
}