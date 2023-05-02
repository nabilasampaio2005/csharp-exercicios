
using System;

class Program {
    static void Main(string[] args) {
        string[] nomes = new string[10];

        Console.WriteLine("Digite os nomes:");
        for (int i = 0; i < 10; i++) {
            Console.Write("Nome {0}: ", i + 1);
            nomes[i] = Console.ReadLine();
        }

        Console.Write("\nDigite um nome qualquer: ");
        string nomeProcurado = Console.ReadLine();

        bool achou = false;
        for (int i = 0; i < 10; i++) {
            if (nomes[i].Equals(nomeProcurado)) {
                achou = true;
                break;
            }
        }

        if (achou) {
            Console.WriteLine("ACHEI");
        } else {
            Console.WriteLine("NÃO ACHEI");
        }

        Console.ReadKey();
    }
}
