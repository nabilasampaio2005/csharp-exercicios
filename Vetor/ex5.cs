using System;

class Program {
    static void Main(string[] args) {
        int[] vetor1 = new int[20];
        int[] vetor2 = new int[20];
        int[] vetorDif = new int[20];
        int[] vetorSoma = new int[20];
        int[] vetorMult = new int[20];

        Console.WriteLine("Digite os números do primeiro vetor:");
        for (int i = 0; i < 20; i++) {
            Console.Write("Número {0}: ", i + 1);
            vetor1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nDigite os números do segundo vetor:");
        for (int i = 0; i < 20; i++) {
            Console.Write("Número {0}: ", i + 1);
            vetor2[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 20; i++) {
            vetorDif[i] = vetor1[i] - vetor2[i];
        }

        for (int i = 0; i < 20; i++) {
            vetorSoma[i] = vetor1[i] + vetor2[i];
        }

        for (int i = 0; i < 20; i++) {
            vetorMult[i] = vetor1[i] * vetor2[i];
        }

        Console.WriteLine("\nVetor de diferença:");
        for (int i = 0; i < 20; i++) {
            Console.Write("{0} ", vetorDif[i]);
        }

        Console.WriteLine("\n\nVetor de soma:");
        for (int i = 0; i < 20; i++) {
            Console.Write("{0} ", vetorSoma[i]);
        }

        Console.WriteLine("\n\nVetor de multiplicação:");
        for (int i = 0; i < 20; i++) {
            Console.Write("{0} ", vetorMult[i]);
        }

        Console.ReadKey();
    }
}
