namespace TF.Model.OperationsStream.PositionsStream
{
    public class PositionsSubscriptionResult
    {
        /// <summary>
        /// Массив счетов клиента.
        /// </summary>
        public List<PositionsSubscriptionStatus> Accounts { get; set; }
    }
}
