namespace Exercicio1 {
    class Triangulo {

        // Classe básica para solução do problema
        public double A; // Atributo A
        public double B; // Atributo B
        public double C; // Atributo C

        public double Area() // Criando um método que não necessita de parametro pois irá utilizar os atributos da própria classe
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p * (p - A) * (p - B) * (p - C)));

        }

    }
}