using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2 {
    class Program {
        static void Main(string[] args) {

            double perc;

            Funcionario F;
            F = new Funcionario();

            Console.Write("Nome: ");
            F.nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            F.salario = double.Parse(Console.ReadLine());
            Console.Write("Desconto: ");
            F.desconto = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do Funcionário: " + F);
            Console.Write("Deseja aumentar o salario do funcionarioem qual porcentagem? ");
            perc = double.Parse(Console.ReadLine());
            F.aumentarSalario(perc);
            Console.WriteLine("Dados do Funcionário: " + F);

            Console.ReadKey();            
        }
    }
}
