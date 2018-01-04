using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio5 {
    class Program {
        static void Main(string[] args) {
            int i = 0;
            do {
                double lancamento1, lancamento2, lancamento3, maior;

                maior = lancamento1 = double.Parse(Console.ReadLine());
                lancamento2 = double.Parse(Console.ReadLine());
                if (maior < lancamento2) {
                    maior = lancamento2;
                }
                lancamento3 = double.Parse(Console.ReadLine());
                if (maior < lancamento3) {
                    maior = lancamento3;
                }
                Console.WriteLine("Maior: " + maior);
            } while (i == 0);
            Console.ReadKey();
        }
    }
}
