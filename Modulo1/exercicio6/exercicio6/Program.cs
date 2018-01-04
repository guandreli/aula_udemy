using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio6 {
    class Program {
        static void Main(string[] args) {
            int num1, num2, soma = 0;

            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2; i++) {
                if (num1 % 2 != 0) {
                    soma += num1;
                }
                num1++;
            }
            Console.WriteLine(soma);
            Console.ReadKey();
        }
    }
}
