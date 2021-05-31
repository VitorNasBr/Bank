using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Bank
{
    class Bank 
    {
        public void Withdraw(Agency.Account account, decimal amount)
        {
            if(account.money >= amount)
            {
                account.money = account.money - amount;
                
                Console.WriteLine($"You got it: {amount}");
            }

            Console.WriteLine($"{account.firstName} do not have ${amount} in your account");
        }
        
        public void Deposit(Agency.Account account, decimal amount)
        {
            account.money = account.money + amount;
            Console.WriteLine($"You deposited: {amount}");
        }
    
        public void Transfer(Agency.Account initialAccount, Agency.Account targetAccount, decimal amount)
        {
            if(initialAccount.money >= amount)
            {
                initialAccount.money = initialAccount.money - amount;
                targetAccount.money = targetAccount.money + amount;
                Console.WriteLine($"Transfer made from: {initialAccount} for {targetAccount} of {amount}");
            }
            Console.WriteLine($"{initialAccount.firstName} do not have ${amount} in your account");
        }
       
    }
}
