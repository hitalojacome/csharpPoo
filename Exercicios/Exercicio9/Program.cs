using System;

namespace Exercicio9 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Qual é a cotação do dólar? ");
            double priceQuote = double.Parse(Console.ReadLine());

            Console.Write("Quantos dólares você irá comprar? ");
            double quantity = double.Parse(Console.ReadLine());

            double result = CurrencyConverter.DolarToReal(quantity, priceQuote);

            Console.WriteLine($"Valor a ser pago em reais = R$ {result:F2}");
            
        }
    }
}