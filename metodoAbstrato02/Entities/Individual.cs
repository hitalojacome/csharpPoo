using System.Diagnostics.CodeAnalysis;

namespace metodoAbstrato02.Entities
{
    public class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base (name, anualIncome) {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax = 0.0;

            if (AnualIncome < 20000.0) {
                tax += (AnualIncome * 0.15) - (HealthExpenditures * 0.50);
            } else {
                tax += (AnualIncome * 0.25) - (HealthExpenditures * 0.50);
            }

            return tax;
        }
    }
}