namespace Exercicio4 {
    class Product {

        public string name;
        public double price;
        public int quantity;

        public double TotalValueInStock() {
            return quantity * price;
        }

        void AddProduct() {
            quantity++;
        }

        void RemoveProduct() {
            quantity--;
        }


    }
}