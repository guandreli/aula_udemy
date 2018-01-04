using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulo2 {
    class Program {
        static void Main(string[] args) {
            Triangulo x, y;
            double areaX, areaY;

            x = new Triangulo();
            y = new Triangulo();

            x.a = double.Parse(Console.ReadLine());
            x.b = double.Parse(Console.ReadLine());
            x.c = double.Parse(Console.ReadLine());
            y.a = double.Parse(Console.ReadLine());
            y.b = double.Parse(Console.ReadLine());
            y.c = double.Parse(Console.ReadLine());

            areaX = x.area();

            areaY = y.area();

            Console.WriteLine("Area X: " + areaX);
            Console.WriteLine("Area Y: " + areaY);
            Console.ReadKey();
        }
    }
}
