namespace Herança_aula.Entities
{
    public class SavingAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingAccount () {}

        public SavingAccount (int number, string holder, double balance, double interestRate) : base (number, holder, balance) {
            InterestRate = interestRate;
        }

        public void UpdateBalance () {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw (double amount) {
		base.Withdraw(amount); // trás a implementação da classe base
		Balance -= 2.0; // Implementação especifica
}
    }
}