using System;
using System.Numerics;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] vetor = new Estudante[10];

            Console.WriteLine("Quantos quartos serão alugados?");
            int qtdQuartos =  int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdQuartos; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vetor[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0;i < 10; i++)
            {
                if (vetor[i] != null)
                {
                    Console.WriteLine("Quarto - " + i + " Estudante: " + vetor[i]) ;
                }
            }
        }
    }
}
