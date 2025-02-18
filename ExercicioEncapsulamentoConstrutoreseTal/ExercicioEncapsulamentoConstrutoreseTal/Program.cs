using System;
using ExercicioEncapsulamentoConstrutoreseTal;
using static System.Net.Mime.MediaTypeNames;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;
            Console.WriteLine("Entre o número da conta:");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre o Titular da conta:");
            string titular = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial (s/n)?");
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 's' || resposta == 'S')
            {
                Console.WriteLine("Digite o valor do depósito inicial:");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, titular, depositoInicial);
            } else
            {
                conta = new ContaBancaria(numero, titular);
            }
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine("Entre um valor para depositar na conta:");
            double deposito = double.Parse(Console.ReadLine());
            conta.Depositar(deposito);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine("Entre um valor para sacar da sua conta:");
            double saque = double.Parse(Console.ReadLine());
            conta.Sacar(saque);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

        }
    }
}