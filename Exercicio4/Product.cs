namespace Exercicio4 {
    class Product {
        // Atributos
        private string _name;
        private double _price;
        private int _quantity;

        // Construtor
        public Product(string name, double price, int quantity) {
            _name = name; _price = price; _quantity = quantity;
        }

        // Métodos
        // Método ToString
        public override string ToString() {
            return ($"{_name}, $ {_price:F2}, {_quantity} unidades, Total: $ {TotalValueInStock():F2}.");
        }

        // Método para calcular o valor total em estoque
        public double TotalValueInStock() {
            return _quantity * _price;
        }

        // Adiciona produtos
        public void AddProduct(int quantity) {
            _quantity += quantity;
        }

        // Remove produtos
        public void RemoveProduct(int quantity) {
            _quantity -= quantity;
        }


    }
}