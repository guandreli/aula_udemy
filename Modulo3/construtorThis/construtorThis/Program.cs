using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace construtorThis {
    class Program {
        static void Main(string[] args) {
            int qtd;
            Produto p;

            Console.Write("Digite os dados do produto\nNome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Estoque: ");
            int quantidadeEmEstoque = int.Parse(Console.ReadLine());

            p = new Produto(nome, preco, quantidadeEmEstoque);
            Console.WriteLine(p);

            Console.ReadKey();
        }
    }
}
