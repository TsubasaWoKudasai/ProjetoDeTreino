using System.Globalization;
using PaymentService.Entities;
using PaymentService.Services;
namespace PaymentService;

class Program
{
static void Main(string[] args)
{

        Console.WriteLine("Enter contract data");
        Console.Write("Number: ");
        int contractNumber = int.Parse(Console.ReadLine());
        Console.Write("Date (dd/MM/yyyy): ");
        DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy",CultureInfo.InvariantCulture);
        Console.Write("Contract value: ");
        double contractValue = double.Parse(Console.ReadLine());
        Console.Write("Enter number of installments:");
        int months = int.Parse(Console.ReadLine());

        Contract myContract = new Contract(contractNumber, contractDate, contractValue);
        ContractService contractService = new ContractService(new PaypalService());
        contractService.ProcessContract(myContract, months);

        Console.Write("Installments:");
        foreach (Installment installment in myContract.Installments)
        {
            Console.WriteLine(installment);
        }

    }

}