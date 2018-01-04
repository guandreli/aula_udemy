using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
    class Program{
        static void Main(string[] args){
            int volInicial, vazBomba, tempo, volRestante;

            volInicial = int.Parse(Console.ReadLine());
            vazBomba = int.Parse(Console.ReadLine());
            tempo = int.Parse(Console.ReadLine());

            volRestante = volInicial - (vazBomba * tempo);

            if(volRestante < 0) {
                Console.WriteLine("Volume insuficiente");
            }
            else {
                Console.WriteLine("Volume restante: " + volRestante);
            }
            Console.ReadKey();
        }
    }
}
