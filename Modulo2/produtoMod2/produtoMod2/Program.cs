using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace produtoMod2 {
    class Program {
        static void Main(string[] args) {
            int qtd;
            Produto p;
            p = new Produto();

            Console.Write("Digite os dados do produto\nNome: ");
            p.nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.preco = double.Parse(Console.ReadLine());
            Console.Write("Estoque: ");
            p.quantidadeEmEstoque = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.Write("Digite a quantidade de produtos que entraram no estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.realizarEntrada(qtd);
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();

            Console.Write("Digite a quantidade de produtos que sairam do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.realizarSaida(qtd);
            Console.WriteLine("Dados atualizados: " + p);

            Console.ReadKey();
        }
    }
}
