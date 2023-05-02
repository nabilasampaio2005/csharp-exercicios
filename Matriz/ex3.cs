using System;

class Program {
    static void Main(string[] args) {
        int[,] matrizOriginal = new int[,] {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int[,] matrizTransposta = new int[matrizOriginal.GetLength(1), matrizOriginal.GetLength(0)];

        for (int i = 0; i < matrizOriginal.GetLength(0); i++) {
            for (int j = 0; j < matrizOriginal.GetLength(1); j++) {
                matrizTransposta[j, i] = matrizOriginal[i, j];
            }
        }

        Console.WriteLine("Matriz transposta:");
        for (int i = 0; i < matrizTransposta.GetLength(0); i++) {
            for (int j = 0; j < matrizTransposta.GetLength(1); j++) {
                Console.Write("{0} ", matrizTransposta[i, j]);
            }
            Console.WriteLine();
        }
    }
}
