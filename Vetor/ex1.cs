using System;

class Program {
    static void Main(string[] args) {
        int[] numeros = new int[10];

        for (int i = 0; i < 10; i++) {
            Console.Write("Digite o {0}º número: ", i + 1);
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nVetor no sentido normal:");
        for (int i = 0; i < 10; i++) {
            Console.Write("{0} ", numeros[i]);
        }

        Console.WriteLine("\n\nVetor no sentido inverso:");
        for (int i = 9; i >= 0; i--) {
            Console.Write("{0} ", numeros[i]);
        }

        Console.ReadKey();
    }
}
