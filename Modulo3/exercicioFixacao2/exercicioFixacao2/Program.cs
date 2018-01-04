using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioFixacao2 {
    class Program {
        static void Main(string[] args) {

            string nome, email;
            int q;

            Aluguel[] cadastro = new Aluguel[10];

            Console.Write("Quantos quartos serão alugados?: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("Email: ");
                email = Console.ReadLine();
                Console.Write("Quarto: ");
                q = int.Parse(Console.ReadLine());
                while(q < 0 || q > 9) {
                    Console.Write("Quatos apenas de 0 a 9: ");
                    q = int.Parse(Console.ReadLine());
                }
                cadastro[q] = new Aluguel(nome, email, q);
            }

            for (int i = 0; i < 10; i++) {
                if (cadastro[i] != null) {
                    Console.WriteLine(cadastro[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
