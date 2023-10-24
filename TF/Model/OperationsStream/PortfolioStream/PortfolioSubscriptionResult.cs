namespace TF.Model.OperationsStream.PortfolioStream
{
    public class PortfolioSubscriptionResult
    {
        /// <summary>
        /// Массив счетов клиента.
        /// </summary>
        public List<AccountSubscriptionStatus> Accounts { get; set; }
    }
}
