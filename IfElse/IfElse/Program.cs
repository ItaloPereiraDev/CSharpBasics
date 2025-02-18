using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hora = int.Parse(Console.ReadLine());
            if (0 <= hora && hora <= 5)
            {
                Console.WriteLine("Boa madrugada");
            }
            else if (hora<=12)
            {
                Console.WriteLine("Bom dia");
            }
            else if (hora <= 18)
            {
                Console.WriteLine("Boa tarde");
            }
            else if (hora <= 24)
            {
                Console.WriteLine("Boa noite");
            }
            else //if (hora >= 24)
            {
                Console.WriteLine("Digite uma hora válida. Meia noite é 00");
            }
        }
    }
}