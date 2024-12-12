using System;
namespace CotacaoDolar { 

class Program { 

    static void Main(string[] args)
    {
        Console.Write(" Digite a cotação : ");
        double cotacao = double.Parse(Console.ReadLine());

        Console.Write("Digite a quantidade da moeda : ");
        double qte = double.Parse(Console.ReadLine());

        double result = ConversorMoeda.DolarReal(qte, cotacao);

        Console.WriteLine($"O valor da compra é de : {result.ToString("F2")}");



    }





}
}
