using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3 {
    class Program {
        static void Main(string[] args) {
            vidaAcademica Alu;
            Alu = new vidaAcademica();

            Console.Write("Nome: ");
            Alu.nome = Console.ReadLine();
            Console.WriteLine("Digite as 3 notas:");

            Alu.nota1 = double.Parse(Console.ReadLine());
            while(Alu.nota1 > 30 || Alu.nota1 < 0) {
                Console.Clear();
                Console.Write("A primeira nota não pode ser maior que 30 pontos nem menor que zero\nDigite novamente: ");
                Alu.nota1 = double.Parse(Console.ReadLine());
            }

            Alu.nota2 = double.Parse(Console.ReadLine());
            while (Alu.nota2 > 35 || Alu.nota2 < 0) {
                Console.Clear();
                Console.Write("A segunda nota não pode ser maior que 35 pontos nem menor que zero\nDigite novamente: ");
                Alu.nota2 = double.Parse(Console.ReadLine());
            }

            Alu.nota3 = double.Parse(Console.ReadLine());
            while (Alu.nota3 > 30 || Alu.nota3 < 0) {
                Console.Clear();
                Console.Write("A terceira nota não pode ser maior que 35 pontos nem menor que zero\nDigite novamente: ");
                Alu.nota3 = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Nota Final: " + Alu.somaNota().ToString("F1"));
            Console.WriteLine(Alu.statusAcademico());

            Console.ReadKey();
        }
    }
}
