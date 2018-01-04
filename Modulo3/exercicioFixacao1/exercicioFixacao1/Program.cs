using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioFixacao1 {
    class Program {
        static void Main(string[] args) {

            Banco B;

            Console.Write("Conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Titular Conta: ");
            string nome = Console.ReadLine();
            Console.Write("Deseja realizar deposito? (s/n): ");
            char conf = char.Parse(Console.ReadLine());
            if(conf == 's' || conf == 'S') {
                Console.Write("Digite o valor do deposito inicial: ");
                double deposito = double.Parse(Console.ReadLine());
                B = new Banco(conta, nome, deposito);
            }
            else {
                B = new Banco(conta, nome);
            }
            Console.WriteLine("Conta Criada:\n" + B);

            Console.Write("Digite um valor para deposito: ");
            double operacao = double.Parse(Console.ReadLine());
            B.Deposito(operacao);
            Console.WriteLine("Conta atualizada\n" + B);

            Console.Write("Digite um valor para saque: ");
            operacao = double.Parse(Console.ReadLine());
            B.Saque(operacao);
            Console.WriteLine("Conta atualizada\n" + B);

            Console.ReadKey();
        }
    }
}
