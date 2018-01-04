using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace construtorThis {
    class Produto {
        public string nome { get; private set; }
        public double preco { get; private set; }
        public int quantidadeEmEstoque { get; private set; }

        public Produto(string _nome, double _preco, int _quantidadeEmEstoque) {
            this.nome = _nome;
            this.preco = _preco;
            this.quantidadeEmEstoque = _quantidadeEmEstoque;
        }

        public Produto(string _nome, double _preco) {
            this.nome = _nome;
            this.preco = _preco;
            this.quantidadeEmEstoque = 0;
        }

        public double valorTotalEmEstoque() {
            return preco * quantidadeEmEstoque;
        }

        public void realizarEntrada(int quantidade) {
            quantidadeEmEstoque += quantidade;
        }

        public void realizarSaida(int quantidade) {
            quantidadeEmEstoque -= quantidade;
        }

        public override string ToString() {
            return nome
                   + ", R$"
                   + preco.ToString("F2", CultureInfo.InvariantCulture)
                   + ", "
                   + quantidadeEmEstoque
                   + " unidades, Total: R$"
                   + valorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
