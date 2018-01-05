using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercicio1.dominio; //para poder acessar as classes dentro da pasta "Dominio"

namespace exercicio1 {
    class Program {

        public static List<Produto> produtos = new List<Produto>(); //lista de produtos
        public static List<Pedido> pedidos = new List<Pedido>(); //lista de pedidos

        static void Main(string[] args) {
            int opcao = 0;
            //insere na lista de produtos os dados abaixo
            produtos.Add(new Produto(1001, "Cadeira simples", 500.00));
            produtos.Add(new Produto(1002, "Cadeira acolchoada", 900.00));
            produtos.Add(new Produto(1003, "Sofá de três lugares", 2000.00));
            produtos.Add(new Produto(1004, "Mesa retangular", 1500.00));
            produtos.Add(new Produto(1005, "Mesa retangular", 2000.00));
            produtos.Sort(); //Chama a função de ordenação

            while (opcao != 5) { //executa enquanto for diferente de 5 (que é a opção de sair)
                Console.Clear();//limpa o console
                Tela.mostrarMenu();//chama a função mostrar menu da classe Tela
                try { //se o usuário digita um caractere não permitido, exibe o erro (catch) se não passa (try)
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (Exception e) {
                    Console.WriteLine("Erro inesperado: " + e.Message);
                    opcao = 0;
                }
                Console.WriteLine();

                if (opcao == 1) {
                    Tela.mostrarProdutos(); //se o usuário digitar a opção 1, chama a função da classe Tela
                }
                else if (opcao == 2) { //se o usuário selecionar a opção 2
                    try { //tratativa de erro no cadastro do produto
                        Tela.cadastrarProduto(); //se os dados forem corretos, chama a função
                    }
                    catch (Exception e) {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if (opcao == 3) {
                    try {
                        Tela.cadastrarPedido();
                    }
                    catch (ModelExeption e) {
                        Console.WriteLine("Erro de negócio: " + e.Message);
                    }
                    catch (Exception e) {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if (opcao == 4) {
                    try {
                        Tela.mostrarPedido();
                    }
                    catch (ModelExeption e) {
                        Console.WriteLine("Erro de negócio: " + e.Message);
                    }
                    catch (Exception e) {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if (opcao == 5) {
                    Console.WriteLine("Fim do programa!");
                }
                else {
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
        }
    }
}
