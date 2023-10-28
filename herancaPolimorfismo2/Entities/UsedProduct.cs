namespace herencaPolimorfismo2.Entities
{
    public class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }
        
        public UsedProduct() {}

        public UsedProduct(string name, double price, DateTime manufactureDate) : base (name, price) {
            ManufactureDate = manufactureDate;
        }

        public override string ToString()
        {
            return $"{Name} (used) $ {Price:F2} (Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}