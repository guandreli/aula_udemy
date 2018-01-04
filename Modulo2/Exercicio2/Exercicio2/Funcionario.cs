using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2 {
    class Funcionario {
        public string nome;
        public double salario, desconto;

        public double salarioLiquido() {
            return salario - desconto;
        }

        public void aumentarSalario(double perc) {
            salario += ((salario * perc) / 100);
        }

        public override string ToString() {
            return nome
                   + ", R$"
                   + salarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
