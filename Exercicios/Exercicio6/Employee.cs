namespace Exercicio6 {
    class Employee {

        public string Name;
        public double GrossSalary;
        public double Tax;

        public double NetSalary() {
            return GrossSalary - Tax;
        }

        public void IncreaseSalary(double percentage) {
            GrossSalary += GrossSalary * (percentage / 100.00);
        }

        public override string ToString() {
            return ($"{Name}, $ {NetSalary():F2}.");
        }
        
    }
}