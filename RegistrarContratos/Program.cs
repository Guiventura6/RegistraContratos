using System;
using RegistrarContratos.Entities;
using System.Globalization;

namespace RegistrarContratos
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            /*              
                Enter number of installments: 3
                Installments:
                25/07/2018 - 206.04
                25/08/2018 - 208.08
                25/09/2018 - 210.12
             */
            Console.WriteLine(" Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CI);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CI);

            Contract contract = new Contract(number, date, value);

            Console.WriteLine(contract.Number);
            Console.WriteLine(contract.Date);
            Console.WriteLine(contract.TotalValue);
            
        }
    }
}
