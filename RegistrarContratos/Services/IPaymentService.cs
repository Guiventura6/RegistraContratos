namespace RegistrarContratos.Services
{
    interface IPaymentService
    {
        double MonthlySimpleInterest(double amount, int months);
        double PaymentFee(double amount);
    }
}
