using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4 {
    class Program {
        static void Main(string[] args) {
            int glicose = int.Parse(Console.ReadLine());

            if(glicose < 100) {
                Console.WriteLine("Normal");
            }
            else if(glicose >= 100 && glicose <= 140) {
                Console.WriteLine("Elevada");
            }
            else {
                Console.WriteLine("Diabetes");
            }
            Console.ReadKey();
        }
    }
}
