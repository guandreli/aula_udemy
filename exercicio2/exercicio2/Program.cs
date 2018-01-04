using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2 {
    class Program {
        static void Main(string[] args) {
            double nota1, nota2, nota3;

            nota1 = double.Parse(Console.ReadLine());
            nota2 = double.Parse(Console.ReadLine());
            nota3 = double.Parse(Console.ReadLine());

            double soma = (double) nota1 + nota2 + nota3;
            if(soma >= 60) {
                Console.WriteLine("Aprovado");
            }
            else {
                Console.WriteLine("Reprovado");
            }
            Console.WriteLine("Nota: " + soma.ToString("F2"));
            Console.ReadKey();
        }
    }
}
