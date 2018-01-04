using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3 {
    class vidaAcademica {
        public string nome;
        public double nota1, nota2, nota3;

        public double somaNota() {
            return nota1 + nota2 + nota3;
        }

        public string statusAcademico() {
            if (somaNota() >= 60) {
                return "Aprovado";
            }
            else {
                return "Reprovado\nFaltam " + (60 - somaNota()) + " pontos";
            }
        }
    }
}
