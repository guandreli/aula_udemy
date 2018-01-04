using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio11 {
    class Program {
        static void Main(string[] args) {
            int volDefault, alterarVol = 0, novoVolume;
            novoVolume = volDefault = int.Parse(Console.ReadLine());
            do {
                alterarVol = int.Parse(Console.ReadLine());
                novoVolume += alterarVol;
                if (novoVolume <= 0) {
                    novoVolume = 0;
                    Console.WriteLine("Volume: " + novoVolume);
                }
                else if(novoVolume >= 100) {
                    novoVolume = 100;
                    Console.WriteLine("Volume: " + novoVolume);
                }
                else {
                    Console.WriteLine("Volume: " + novoVolume);
                }
            } while (alterarVol != 0);
        }
    }
}
