using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod3 {
    class Program {
        static void Main(string[] args) {

            int[,] mat;
            int n, contador;

            Console.Write("Digite o tamanho da matriz: ");
            n = int.Parse(Console.ReadLine());
            mat = new int[n, n];

            for (int i = 0; i < n; i++) {
                string[] linha = Console.ReadLine().Split();
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(linha[j]);
                }
            }
            Console.Write("\n\nDiagonal: ");
            for(int i = 0; i < n; i++) {
                Console.Write(mat[i, i] + " ");
            }
            
            Console.Write("\n\nNegativos: ");
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] < 0) {
                        Console.Write(mat[i, j] + "  ");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
