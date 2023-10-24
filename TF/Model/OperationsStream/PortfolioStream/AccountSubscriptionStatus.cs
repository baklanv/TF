using TF.Enums.Operation;

namespace TF.Model.OperationsStream.PortfolioStream
{
    public class AccountSubscriptionStatus
    {
        /// <summary>
        /// Идентификатор счёта.
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Результат подписки.
        /// </summary>
        public PortfolioSubscriptionStatus SubscriptionStatus { get; set; }
    }
}
