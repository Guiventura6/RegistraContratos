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
  
            Console.WriteLine(" Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CI);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CI);

            Contract contract = new Contract(number, date, value);

            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            ContractService contractService = new ContractService(months, new Paypal());

            contractService.ProcessInstallments(contract);

            Console.WriteLine("Installments:");
            foreach (var item in contract.Installments)
            {
                Console.WriteLine(item.DueDate + " - " + item.Amount.ToString("F2", CI));
            }

        }
    }
}
