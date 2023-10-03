namespace Exercicio9 {
    class CurrencyConverter {

        public static double Iof = 6.0;

        public static double DolarToReal(double quantity, double priceQuote) {
            double total = quantity * priceQuote;
            return total + total * Iof / 100.0;
        }
    }
}