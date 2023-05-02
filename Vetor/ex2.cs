using System;

class Program {
    static void Main(string[] args) {
        int[] vetor1 = new int[10];
        int[] vetor2 = new int[10];

        Console.WriteLine("Digite os elementos do vetor:");
        for (int i = 0; i < 10; i++) {
            Console.Write("Elemento {0}: ", i + 1);
            vetor1[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 10; i++) {
            vetor2[i] = vetor1[9 - i];
        }

        Console.WriteLine("\nVetor1: ");
        for (int i = 0; i < 10; i++) {
            Console.Write("{0} ", vetor1[i]);
        }

        Console.WriteLine("\nVetor2: ");
        for (int i = 0; i < 10; i++) {
            Console.Write("{0} ", vetor2[i]);
        }

        Console.ReadKey();
    }
}
