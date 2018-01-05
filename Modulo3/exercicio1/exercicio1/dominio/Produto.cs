using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1.dominio {
    class Produto : IComparable {
        public int codigo { get; set; }
        public string descricao { get; set; }
        public double preco { get; set; }

        public Produto(int codigo, string descricao, double preco) {
            this.codigo = codigo;
            this.descricao = descricao;
            this.preco = preco;
        }

        public override string ToString() {
            return codigo
                + ", "
                + descricao
                + ", Preço: "
                + preco.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj) { //função de ordenação
            Produto outro = (Produto)obj;
            int resultado = descricao.CompareTo(outro.descricao); //resultado recebe o resultado da comparação, é retornado 1 caso maior, -1 caso menor ou 0 caso igual
            int ord = preco.CompareTo(outro.preco);
            if (resultado != 0) { // se não for igual, retorna o resultado
                return resultado;
            }
            else if(resultado == 0 && ord != 0){ //se não, compara o preço e ordena decrescente, por isso o -preco
                return -preco.CompareTo(outro.preco);
            }
            else {
                return codigo.CompareTo(outro.codigo);
            }
        }
    }
}
