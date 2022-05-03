using System;

namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            Console.WriteLine("how much money do you want to deposit into your account?");
            double amountToDeposit = double.Parse(Console.ReadLine());

            account.Deposit(amountToDeposit);
            double userBalance =  account.GetBalance();

            Console.WriteLine($"Your current balance is: {userBalance, 0:c}");
        }
    }






}
