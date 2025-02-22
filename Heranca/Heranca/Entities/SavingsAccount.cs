using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; }
        public SavingsAccount() { }
        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }
        public void updateBalance()
        {
            Balance += Balance + InterestRate;
        }
        public sealed override void Withdraw(double amount)
        {
            // Balance -= amount; Se eu não quiser cobrar a taxa de 5
            // O exemplo abaixo é se, além dos 5 reais, eu quiser taxar +2
            base.Withdraw(amount);
            Balance -= 2;
        }
    }
}
