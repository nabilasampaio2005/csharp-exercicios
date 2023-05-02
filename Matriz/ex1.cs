using System;

class Program {
    static void Main(string[] args) {
        int[,] mat = new int[10, 15];

        Random rnd = new Random();
        for (int i = 0; i < 10; i++) {
            for (int j = 0; j < 15; j++) {
                mat[i, j] = rnd.Next(1, 11);
            }
        }

        Console.WriteLine("Matriz:");
        for (int i = 0; i < 10; i++) {
            for (int j = 0; j < 15; j++) {
                Console.Write("{0,2} ", mat[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        for (int i = 0; i < 10; i++) {
            int soma = 0;
            for (int j = 0; j < 15; j++) {
                soma += mat[i, j];
            }
            Console.WriteLine("A soma dos elementos da linha {0} é {1} ({2})", i, soma, soma % 2 == 0 ? "par" : "ímpar");
        }
        Console.WriteLine();

        for (int j = 0; j < 15; j++) {
            int soma = 0;
            for (int i = 0; i < 10; i++) {
                soma += mat[i, j];
            }
            Console.WriteLine("A soma dos elementos da coluna {0} é {1} ({2})", j, soma, soma % 2 == 0 ? "par" : "ímpar");
        }
    }
}
