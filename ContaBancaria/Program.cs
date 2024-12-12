using System;
using ContaBancaria;

class Program
{
    static void Main(string[] args) // metodo main
    {

        ContaBanco conta; // objeto banco da classe ContaBanco


        // interface do console pra ler as primeiras entradas:
        // ( numero( da conta), titular e a resposta do saldo inicial
        Console.Write("Digite o número da conta: ");
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o titular da conta: ");
        string titular = Console.ReadLine();
        Console.WriteLine("Haverá depósito inicial ? (s/n) :");
        char resp = char.Parse(Console.ReadLine());

        // se a resposta for sim(s) gera uma nova ContaBanco com depositoInicial
        // se nao, gera so com numero e titular
        if (resp == 's')
        {
            Console.Write("Digite o valor de depósito inicial");
            double depositoInicial = double.Parse(Console.ReadLine());
            conta = new ContaBanco(numero, titular, depositoInicial);

            // interface escrevevendo os dados
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Digite um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine());
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Digite um valor pra saque :");
            quantia = double.Parse(Console.ReadLine());
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
        else
        {
            conta = new ContaBanco(numero, titular);

            // interface escrevevendo os dados
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);
        }
    }
}