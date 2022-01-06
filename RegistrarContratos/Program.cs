using System;
using System.Globalization;
using RegistrarContratos.Entities;
using RegistrarContratos.Services;

namespace RegistrarContratos
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
  
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CI);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CI);
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, value);

            ContractService contractService = new ContractService(new Paypal());

            contractService.ProcessContract(contract, months);

            Console.WriteLine("Installments:");
            foreach (var item in contract.Installments)
            {
                Console.WriteLine(item);
            }

        }
    }
}
