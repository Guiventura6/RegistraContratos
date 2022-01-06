namespace RegistrarContratos.Services
{
    interface IPaymentService
    {
        public double MonthlySimpleInterest { get; set; }
        public double PaymentFee { get; set; }
       
        public void ProcessInstallments()
        {

        }
    }
}
