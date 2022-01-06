using System;
using RegistrarContratos.Entities;

namespace RegistrarContratos.Services
{
    class ContractService
    {
        public int Month { get; set; }

        private IPaymentService _paymentService;

        public ContractService(int month, IPaymentService paymentService)
        {
            Month = month;
            _paymentService = paymentService;
        }

        public void ProcessInstallments(Contract contract)
        {            
            for (int i = 1; i <= Month; i++)
            {
                DateTime dueDate = contract.Date.AddDays(i);
                double amount = contract.TotalValue + _paymentService.MonthlySimpleInterest(contract.TotalValue);
                amount += _paymentService.PaymentFee(amount);

                Installment installments = new Installment(dueDate, amount);

                contract.Installments.Add(installments);
            }
        }
    }
}
