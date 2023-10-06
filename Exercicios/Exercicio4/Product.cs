namespace Exercicio4 {
    class Product {
        // Atributos
        private string _name;
        private double _price;
        private int _quantity;

        // Construtores
        public Product() {}
        public Product(string name, double price, int quantity) {
            _name = name; _price = price; _quantity = quantity;
        }

        //Properties
        public string Name {
            get {return _name;}
            set {
                if (value != null && value.Length > 1) {
                _name = value;
            }
            }
        }

        public double Price { get {return _price;} }

        public int Quantity { get {return _quantity;} }


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