namespace Exercicio4 {
    class Product {
        // Atributos
        public string Name;
        public double Price;
        public int Quantity;

        // Construtor
        public Product(string name, double price, int quantity) {
            Name = name; Price = price; Quantity = quantity;
        }

        // Métodos
        // Método ToString
        public override string ToString() {
            return ($"{Name}, $ {Price:F2}, {Quantity} unidades, Total: $ {TotalValueInStock():F2}.");
        }

        // Método para calcular o valor total em estoque
        public double TotalValueInStock() {
            return Quantity * Price;
        }

        // Adiciona produtos
        public void AddProduct(int quantity) {
            Quantity += quantity;
        }

        // Remove produtos
        public void RemoveProduct(int quantity) {
            Quantity -= quantity;
        }


    }
}