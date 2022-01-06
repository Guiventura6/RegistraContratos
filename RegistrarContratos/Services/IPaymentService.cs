namespace RegistrarContratos.Services
{
    interface IPaymentService
    {
        double MonthlySimpleInterest(double amount);
        double PaymentFee(double amount);
    }
}
