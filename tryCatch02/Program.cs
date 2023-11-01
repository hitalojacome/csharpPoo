using System;
using tryCatch02.Entities;
using tryCatch02.Entities.Exceptions;

namespace Workspace {
    class Program {
        static void Main(string[] args) {

            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine()!);
                Console.Write("Holder: ");
                string holder = Console.ReadLine()!;
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine()!);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine()!);

                Account account = new Account(number, holder, balance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine()!);
                account.Withdraw(withdraw);
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Withdraw error: {e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Format error: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected error: {e.Message}");
            }

        }
    }
}