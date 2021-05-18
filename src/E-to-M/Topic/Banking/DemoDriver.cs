using static System.Console;
using System;

namespace Topic.Banking
{
    public class DemoDriver
    {
        public static void Main(string[] args)
        {
            Account savings = new Account(7654321, 100, 200);
            Console.WriteLine($"Account # {savings.AccountNumber} has a balance of ${savings.Balance}");
        }
    }
}