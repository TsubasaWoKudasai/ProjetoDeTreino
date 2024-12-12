using System;
namespace AluguelEstudante;

class Program
{
    static void Main(string[] args)
    {
        var vect = new Estudante[10];

        Console.WriteLine("Quantos quartos serão alugados?");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine();
            Console.WriteLine($" Aluguel : #{i +1 }");
            Console.Write($" Nome : ");
            string nome = Console.ReadLine();
            Console.Write("E-mail : ");
            string email = Console.ReadLine();
            Console.Write("Quarto : ");
            int quarto = int.Parse(Console.ReadLine());
            vect[quarto] = new Estudante(nome, email);
        }

        Console.WriteLine();
        Console.WriteLine(" Quartos Ocupados : ");
        for (int i = 0; i < 10; i++)
        {
            if (vect[i] != null)
            {
                Console.WriteLine($"{i} : {vect[i]}");
            }
        }
    }
}