using System;

class Program {
    static void Main(string[] args) {
        int[,] A = { {1, 2, 3}, {4, 5, 6}, {7, 8, 9} };
        int[,] B = { {9, 8, 7}, {6, 5, 4}, {3, 2, 1} };

        if (A.GetLength(0) != B.GetLength(0) || A.GetLength(1) != B.GetLength(1)) {
            Console.WriteLine("As matrizes têm tamanhos diferentes.");
            return;
        }

        int[,] C = new int[A.GetLength(0), A.GetLength(1)];

        for (int i = 0; i < A.GetLength(0); i++) {
            for (int j = 0; j < A.GetLength(1); j++) {
                C[i, j] = A[i, j] + B[i, j];
            }
        }

        Console.WriteLine("Matriz A + B =");
        for (int i = 0; i < C.GetLength(0); i++) {
            for (int j = 0; j < C.GetLength(1); j++) {
                Console.Write("{0,3}", C[i, j]);
            }
            Console.WriteLine();
        }
    }
}
