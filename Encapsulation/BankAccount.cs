using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class BankAccount
    {
        private decimal _amount;
        public BankAccount(decimal amount)
        {
            Deposit(amount);
        }

        public void Deposit(decimal amount) 
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit can't be minus value or zero! it must be positive!");
            else
                _amount += amount;
        }

        public decimal GetBlance()
        {
            return _amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Withdrawal amount must be positive!");

            if (amount > _amount)
                throw new InvalidOperationException("Infficient funds");

            _amount -= amount;
        }

        protected void something()
        {
            Console.WriteLine("hello");
        }
    }
}
