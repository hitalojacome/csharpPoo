namespace Exercicio4 {
    class Product {
        
        // Atributos
        private string _name;
        public double Price { get; private set; }
        public int Quantity { get; private set; }

        // Construtores
        public Product() {}
        public Product(string name, double price, int quantity) {
            _name = name; Price = price; Quantity = quantity;
        }

        // Properties
        public string Name {
            get {return _name;}
            set {
                if (value != null && value.Length > 1) {
                _name = value;
            }
            }
        }

        // Método ToString
        public override string ToString() {
            return ($"{_name}, $ {Price:F2}, {Quantity} unidades, Total: $ {TotalValueInStock():F2}.");
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