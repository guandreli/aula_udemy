using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio8 {
    class Program {
        static void Main(string[] args) {
            int n, a, b;
            n = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            for(int i = a; i < b; i++) {
                if(a % n == 0) {
                    Console.WriteLine(i);
                }
                a++;
            }
            Console.ReadKey();
        }
    }
}
