namespace metodoAbstrato02.Entities
{
    public class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees) : base (name, anualIncome) {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            throw new NotImplementedException();
        }
    }
}