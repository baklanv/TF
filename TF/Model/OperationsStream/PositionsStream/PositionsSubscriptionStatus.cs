using TF.Enums.Operation;

namespace TF.Model.OperationsStream.PositionsStream
{
    public class PositionsSubscriptionStatus
    {
        /// <summary>
        /// Идентификатор счёта.
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Результат подписки.
        /// </summary>
        public PositionsAccountSubscriptionStatus SubscriptionStatus { get; set; }
    }
}
