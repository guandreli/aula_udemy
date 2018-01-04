using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio10 {
    class Program {
        static void Main(string[] args) {
            double nota1, nota2, nota3;
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++) {
                nota1 = double.Parse(Console.ReadLine());
                nota2 = double.Parse(Console.ReadLine());
                nota3 = double.Parse(Console.ReadLine());
                Console.WriteLine("Total: " + (nota1 + nota2 + nota3));
            }
            Console.ReadKey();
        }
    }
}
