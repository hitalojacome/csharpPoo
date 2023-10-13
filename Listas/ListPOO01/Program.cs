using System;

namespace ListPoo {
    class Program {
        static void Main(string[] args) {

            List<string> nomes = new List<string> {"Maria", "José", "Claudio", "mateus", "Mauricio"};

            nomes.RemoveAll(x => x[0] == 'M');

            int i=0;
            foreach (string nome in nomes) {
                Console.WriteLine($"Usuário {i}: {nome}");
                i++;
            }
            
        }
    }
}