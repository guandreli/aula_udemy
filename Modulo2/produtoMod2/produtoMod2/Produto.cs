using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace produtoMod2 {
    class Produto {
        public string nome;
        public double preco;
        public int quantidadeEmEstoque;

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
