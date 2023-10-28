namespace herencaPolimorfismo2.Entities
{
    public class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() {}

        public ImportedProduct(string name, double price, double customsFee) : base (name, price) {
            CustomsFee = customsFee;
        }

        public double TotalPrice() {
            return Price + CustomsFee;
        }

        public override string ToString()
        {
            return $"{Name} $ {TotalPrice():F2} (Cumstoms fee: $ {CustomsFee:F2})";
        }

    }
}