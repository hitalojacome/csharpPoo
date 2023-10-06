using System;

namespace Exercicio10 {
    class Program {
        static void Main(string[] args) {

            BankAccount account;

            Console.Write("Insira o número da conta: ");
            int accountNumber = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string accountHolder = Console.ReadLine();

            Console.Write("Haverá depósito incial? (s/n) ");
            char yesNo = char.Parse(Console.ReadLine());

            if (yesNo == 's' || yesNo == 'S') {
                Console.Write("Entre o valor de depósito inicial: ");
                double initialDeposit = double.Parse(Console.ReadLine());

                account = new BankAccount(accountNumber, accountHolder, initialDeposit);
            } else {
                account = new BankAccount(accountNumber, accountHolder);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(account);

            Console.WriteLine();
            Console.Write("Entre com o valor de depósito: ");
            double value = double.Parse(Console.ReadLine());
            account.Deposit(value);
            Console.WriteLine("Dados atualizados da conta: ");
            Console.WriteLine(account);

            Console.WriteLine();
            Console.Write("Entre com o valor de saque: ");
            value = double.Parse(Console.ReadLine());
            account.Withdraw(value);
            Console.WriteLine("Dados atualizados da conta: ");
            Console.WriteLine(account);
        }
    }
}