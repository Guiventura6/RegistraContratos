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

        public void ProcessInstallments()
        {

        }
    }
}
