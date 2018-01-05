using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioFixacao5 {
    class Program {
        static void Main(string[] args) {

            int n;

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.Write("Quantos alunos possui o curso A? ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso A:");
            for (int i = 0; i < n; i++) {
                int alu = int.Parse(Console.ReadLine());
                A.Add(alu);
            }

            Console.Write("Quantos alunos possui o curso B? ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso b:");
            for (int i = 0; i < n; i++) {
                int alu = int.Parse(Console.ReadLine());
                B.Add(alu);
            }

            Console.Write("Quantos alunos possui o curso C? ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso C:");
            for (int i = 0; i < n; i++) {
                int alu = int.Parse(Console.ReadLine());
                C.Add(alu);
            }

            HashSet<int> Total = new HashSet<int>();
            Total.UnionWith(A);
            Total.UnionWith(B);
            Total.UnionWith(C);

            Console.Write("Total de alunos: " + Total.Count);
            Console.ReadKey();
        }
    }
}
