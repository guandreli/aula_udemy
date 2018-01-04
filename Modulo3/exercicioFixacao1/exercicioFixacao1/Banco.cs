using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioFixacao1 {
    class Banco {
        public int conta { get; private set; }
        public string nome { get; set; }
        public double saldo { get; private set; }
        
        public Banco(int conta, string nome, double saldo) { //cadastro inicial
            this.conta = conta;
            this.nome = nome;
            this.saldo = saldo;
        }
        public Banco(int conta, string nome) { //cadastro inicial
            this.conta = conta;
            this.nome = nome;
            this.saldo = 0;
        }
        public void Deposito(double saldo) {
            this.saldo += saldo;
        }

        public void Saque(double saldo) {
            this.saldo -= saldo + 5;
        }

        public override string ToString() {
            return "Conta: "
                   + conta
                   + ", Titular: "
                   + nome
                   + ", Saldo: R$"
                   + saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
