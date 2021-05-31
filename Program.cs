using Bank.Agency;
using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            



            Bank.Bank bank = new Bank.Bank();
            Account vitor = new Account(firstName: "Vitor", lastName: "Medina", age: 18, cpf: "123-456-123-12", numberAccount: 0001, money: 1000);
            Account snow = new Account(firstName: "Snow", lastName: "zin", age: 19, cpf: "123-456-123-12", numberAccount: 0001, money: 1000);


            Console.WriteLine("Testando Metodo de Sacar!!!");
            Console.WriteLine("Dinherio antes do saque " + vitor.money);
            bank.Withdraw(vitor, 3213131);
            Console.WriteLine("Dinherio após do saque " + vitor.money);

            Console.WriteLine("\n\n");

            Console.WriteLine("Testando Metodo de Depositar!!!");
            Console.WriteLine("Dinherio antes do depostio " + vitor.money);
            bank.Deposit(vitor, 100);
            Console.WriteLine("Dinherio após do deposito " + vitor.money);

            Console.WriteLine("\n\n");

            Console.WriteLine("Testando Metodo de Transferir!!!");
            Console.WriteLine($"Dinheiro do vitor antes da transferencia: {vitor.money} Dinheiro do snow antes da transfencia: {snow.money}");
            bank.Transfer(vitor,snow, 1000000);
            Console.WriteLine($"Dinheiro do vitor após a transferencia: {vitor.money} Dinheiro do snow após a transfencia: {snow.money}");


            Console.ReadLine();


        }
    }
}
