using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioFixacao4 {
    class Program {
        static void Main(string[] args) {
            int verifica;
            Funcionario sal;

            List<Funcionario> lista = new List<Funcionario>();

            Console.Write("Quantos funcionários serão cadastrados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.Write("CPF: ");
                int cpf = int.Parse(Console.ReadLine());
                verifica = lista.FindIndex(x => x.cpf == cpf);
                while(verifica >= 0) {
                    Console.WriteLine("CPF já cadastrado, digite um outro");
                    cpf = int.Parse(Console.ReadLine());
                    verifica = lista.FindIndex(x => x.cpf == cpf);
                }
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine());
                lista.Add(new Funcionario(nome, cpf, salario));
            }

            Console.Write("Digite o CPF do funcionário que terá aumento: ");
            n = int.Parse(Console.ReadLine());
            verifica = lista.FindIndex(x => x.cpf == n);

            if(verifica >= 0) {
                Console.Write("Digite a porcentagem de aumento: ");
                int perc = int.Parse(Console.ReadLine());
                lista[verifica].aumento(perc);
            }
            else {
                Console.WriteLine("CPF INEXISTENTE");
            }
            Console.WriteLine("Listagem atualizada de funcionários:");
            for (int i = 0; i < lista.Count; i++) {
                Console.WriteLine(lista[i]);
            }
            Console.ReadKey();
        }
    }
}
