using System;
namespace CotacaoDolar
{

    public class ConversorMoeda
    {
        public static double iof = 1.06;


        public static double DolarReal(double qte, double cotacao)
        {
            double total = qte * cotacao;
            return total * iof;
    
    }



    }
}
