using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1 {
    class Retangulo {
        public double largura, altura;

        public double area() {
            return largura * altura;
        }

        public double perimetro() {
            return 2 * (altura + largura);
        }

        public double diagonal() {
            return Math.Sqrt((largura * largura) + (altura * altura));
        }
    }
}
