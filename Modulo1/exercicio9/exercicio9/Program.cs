using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio9 {
    class Program {
        static void Main(string[] args) {
            int tempoBateria, xJogadas, tempoJogado, bateriaRestante = 0;

            bateriaRestante = tempoBateria = int.Parse(Console.ReadLine());
            xJogadas = int.Parse(Console.ReadLine());

            for(int i = 0; i < xJogadas; i++) {
                tempoJogado = int.Parse(Console.ReadLine());
                bateriaRestante -= tempoJogado;
                if(bateriaRestante < 0) {
                    Console.WriteLine("Recarregar");
                }
                else {
                    Console.WriteLine("Tempo Restante: " + bateriaRestante);
                }
            }
            Console.ReadKey();
        }
    }
}
