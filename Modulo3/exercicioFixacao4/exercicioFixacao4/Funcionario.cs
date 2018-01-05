using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioFixacao4 {
    class Funcionario {
        public string nome { get; set; }
        public int cpf { get; private set; }
        public double salario { get; private set; }

        public Funcionario(string nome, int cpf, double salario) {
            this.nome = nome;
            this.cpf = cpf;
            this.salario = salario;
        }

        public void aumento(int perc) {
            salario += (double) perc /100 * salario;
        }
                
        public override string ToString() {
            return cpf
                   + ", "
                   + nome
                   + ", R$"
                   + salario.ToString("F2", CultureInfo.InvariantCulture); ;
        }
    }
}
