using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3 {
    class Program {
        static void Main(string[] args) {
            int larguraFoto, alturaFoto, larguraMoldura, alturaMoldura;

            larguraFoto = int.Parse(Console.ReadLine());
            alturaFoto = int.Parse(Console.ReadLine());
            larguraMoldura = int.Parse(Console.ReadLine());
            alturaMoldura = int.Parse(Console.ReadLine());

            if ((larguraFoto <= larguraMoldura && alturaFoto <= alturaMoldura) || 
                (larguraFoto <= alturaMoldura && alturaFoto <= larguraMoldura)) {
                Console.WriteLine("Sim");
            }
            else {
                Console.WriteLine("Não");
            }
            Console.ReadKey();
        }
    }
}
