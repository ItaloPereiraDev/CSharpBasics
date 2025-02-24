using System;
using Heranca.Entities;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Account acc = new Account(1000, "Jhon Dove", 1000); Como a classe é abstract, não funciona mais isso.
            BusinessAccount businessAcc = new BusinessAccount(1001, "Bob Brown", 500, 600);

            //Upcasting
            Account acc1 = businessAcc;
            Account acc2 = new BusinessAccount(1002, "Fulano de tal", 1000, 10);
            Account acc3 = new SavingsAccount(1003, "Sicrano de sal", 1000, 1.01);

            //Downcasting (operação perigosa! É importante checar usando if antes de fazer)
            BusinessAccount acc4 = (BusinessAccount)acc2;

            //acc4.Loan(100); Nisso, já dá pra usar essa operação exclusiva de classe

            /* Usando o if pra ser mais seguro!
             * 
            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
                acc5.Loan(200);
                Console.WriteLine("Loan!");
            }
            if (acc3 is SavingsAccount)
            {
                // SavingsAccount acc5 = acc3 as SavingsAccount; Outra maneira de fazer o casting
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.updateBalance();
                Console.WriteLine("Updated!");
            }
            */
            acc1.Withdraw(100);
            acc3.Withdraw(100);
            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc3.Balance);
        }
    }
}