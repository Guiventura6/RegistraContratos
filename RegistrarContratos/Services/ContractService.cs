using System;
using RegistrarContratos.Entities;

namespace RegistrarContratos.Services
{
    class ContractService
    {        
        private IPaymentService _paymentService;

        public ContractService(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updateQuota = basicQuota +  _paymentService.MonthlySimpleInterest(basicQuota, i);
                double fullQuota = updateQuota +  _paymentService.PaymentFee(updateQuota);
                
                contract.Installments.Add(new Installment(date, fullQuota));
            }
        }
    }
}
