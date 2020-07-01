using BankEncapsulation;
using System;
using System.Reflection.Metadata;

namespace ConsoleApp1UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //here is the instance of the class BankAccount
            BankAccount bankAcct = new BankAccount();

            Console.WriteLine("Deposit your money.");//user input for Balance
            bankAcct.Balance = double.Parse(Console.ReadLine());
            Console.WriteLine("Retreive your balance(y) or (n).");
            bankAcct.UserInput = Console.ReadLine();//user input for UserInput
            bankAcct.GetBalance(); //here we call the method from BankAccounts

        }
}
}
