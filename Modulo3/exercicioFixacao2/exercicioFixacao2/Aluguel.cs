using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioFixacao2 {
    class Aluguel {
        string nome { get; set; }
        string email { get; set; }
        int quarto { get; set; }

        public Aluguel(string nome, string email, int quarto) {
            this.nome = nome;
            this.email = email;
            this.quarto = quarto;
        }

        public override string ToString() {
            return "Nome: "
                   + nome
                   + "\nEmail: "
                   + email
                   +"\nQuarto: "
                   +quarto;
        }
    }
}
