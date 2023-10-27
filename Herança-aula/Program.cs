using System;
using Herança_aula.Entities;

namespace Workspace {
    class Program {
        static void Main(string[] args) {

            Account acc = new Account(8010, "Hitalo Jacome", 0.0);
            BusinessAccount bacc = new BusinessAccount(6482, "Pedro Cabral", 0.0, 500.0);

            // UPCASTING
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(3791, "Maria Sousa", 0.0, 200.0);
            Account acc3 = new SavingAccount(2746, "Mariana Souza", 0.0, 0.01);

            // DOWNCASTING
            BusinessAccount acc4 = (BusinessAccount) acc2;
            acc4.Loan(100.0);

            // BusinessAccount acc5 = (BusinessAccount) acc3;

            if (acc3 is BusinessAccount) {
                BusinessAccount acc5 = (BusinessAccount) acc3;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingAccount) {
                SavingAccount acc5 = (SavingAccount) acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }

        }
    }
}