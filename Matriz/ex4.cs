using System;

class Program {
    static void Main(string[] args) {
        int[,] a = new int[,] { {1, 2}, {3, 4} };
        int[,] b = new int[,] { {5, 6}, {7, 8} };

        int m = a.GetLength(0); 
        int n = a.GetLength(1); 
        int p = b.GetLength(1); 

        int[,] c = new int[m, p]; 
        
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < p; j++) {
                for (int k = 0; k < n; k++) {
                    c[i, j] += a[i, k] * b[k, j];
                }
            }
        }

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < p; j++) {
                Console.Write("{0} ", c[i, j]);
            }
            Console.WriteLine();
        }
    }
}
