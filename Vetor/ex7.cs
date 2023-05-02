using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Digite a quantidade de números a serem inseridos: ");
        int quantidade = int.Parse(Console.ReadLine());
        int[] numeros = new int[quantidade];

        for (int i = 0; i < quantidade; i++) {
            Console.Write("Digite o número {0}: ", i+1);
            numeros[i] = int.Parse(Console.ReadLine());
        }

        int[] pares = new int[quantidade];
        int[] impares = new int[quantidade];
        int qtdPares = 0, qtdImpares = 0;

        for (int i = 0; i < quantidade; i++) {
            if (numeros[i] % 2 == 0) {
                pares[qtdPares] = numeros[i];
                qtdPares++;
            } else {
                impares[qtdImpares] = numeros[i];
                qtdImpares++;
            }
        }

        Array.Sort(pares, 0, qtdPares);
        Array.Sort(impares, 0, qtdImpares);
        Array.Reverse(impares, 0, qtdImpares);

        int[] resultado = new int[quantidade];
        Array.Copy(pares, resultado, qtdPares);
        Array.Copy(impares, 0, resultado, qtdPares, qtdImpares);

        Console.WriteLine("Resultado:");
        for (int i = 0; i < quantidade; i++) {
            Console.Write("{0} ", resultado[i]);
        }
        Console.WriteLine();
    }
}
