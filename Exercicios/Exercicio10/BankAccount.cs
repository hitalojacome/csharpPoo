namespace Exercicio10 {
    class BankAccount {

        public int AccountNumber { get; private set; }
        public string AccountHolder { get; set; }
        public double AccountBalance { get; private set; }

        public BankAccount(int accountNumber, string accountHolder) {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
        }

        public BankAccount(int accountNumber, string accountHolder, double accountBalance) : this(accountNumber, accountHolder) {
            AccountBalance = accountBalance;
        }

        public override string ToString() {
            return ($"Conta {AccountNumber}, Titular: {AccountHolder}, Saldo: $ {AccountBalance:F2}");
        }

        public void Deposit(double value) {
            AccountBalance += value;
        }

        public void Withdraw(double value) {
            value += 5.0;
            AccountBalance -= value;
        }
    }
}