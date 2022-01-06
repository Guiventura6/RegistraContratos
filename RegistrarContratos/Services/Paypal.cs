namespace RegistrarContratos.Services
{
    class Paypal : IPaymentService
    {
        public double MonthlySimpleInterest(double amount)
        {
            return amount * 0.01;
        }

        public double PaymentFee(double amount)
        {
            return amount * 0.02;
        }
    }
}
