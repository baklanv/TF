using TF.Enums.Operation;

namespace TF.Model.Operation.Portfolio
{
    public class PortfolioRequest
    {
        public string AccountId { get; set; }
        public CurrencyRequest Currency { get; set; }
    }
}
