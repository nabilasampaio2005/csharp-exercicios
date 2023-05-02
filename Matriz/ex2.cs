using System;

class Program {
    static void Main(string[] args) {
        double[,] matriz = new double[50, 50];
        double[] vetor = new double[50];

        Random rand = new Random();
        for (int i = 0; i < 50; i++) {
            for (int j = 0; j < 50; j++) {
                matriz[i, j] = rand.NextDouble();
            }
        }

        for (int i = 0; i < 50; i++) {
            vetor[i] = matriz[i, i];
        }

        Console.Write("Vetor resultante: [ ");
        for (int i = 0; i < 50; i++) {
            Console.Write(vetor[i] + " ");
        }
        Console.WriteLine("]");
    }
}
