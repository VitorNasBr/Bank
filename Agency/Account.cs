using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Agency
{
    class Account : Person
    {
        public Account(string firstName, string lastName, int age, string cpf, int numberAccount, decimal money)
        {

            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.cpf = cpf;
            this.numberAccount = numberAccount;
            this.money = money;

            checkAge();
        }

        public bool checkAge()
        {
            if(age >= 18)
            {
                Console.WriteLine($"{firstName} Account created successfully!");
                return true;
            }
            Console.WriteLine($"{firstName} Children under 18 cannot create an account");
            return false;
        }
    }
}
