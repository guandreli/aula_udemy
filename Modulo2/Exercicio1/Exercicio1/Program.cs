using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1 {
    class Program {
        static void Main(string[] args) {
            Retangulo R;
            R = new Retangulo();

            Console.Write("Altura: ");
            R.altura = double.Parse(Console.ReadLine());
            Console.Write("Largura: ");
            R.largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Area: " + R.area().ToString("F2"));
            Console.WriteLine("Perimetro: " + R.perimetro().ToString("F2"));
            Console.WriteLine("Diagonal: " + R.diagonal().ToString("F2"));

            Console.ReadKey();
        }
    }
}
