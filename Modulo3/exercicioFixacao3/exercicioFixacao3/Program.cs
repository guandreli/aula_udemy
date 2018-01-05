using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioFixacao3 {
    class Program {
        static void Main(string[] args) {
            int[,] mat;
            int m, n, contador;

            Console.Write("Digite o numero de linhas: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Digite o numero de colunas: ");
            m = int.Parse(Console.ReadLine());
            mat = new int[m, n];

            for (int i = 0; i < m; i++) {
                string[] linha = Console.ReadLine().Split();
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(linha[j]);
                }
            }

            for (int i = 0; m < n; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
