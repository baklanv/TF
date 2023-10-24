namespace TF.Model.Operation.BrokerReport
{
    public class GenerateBrokerReportRequest
    {
        /// <summary>
        /// Идентификатор счёта клиента.
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Начало периода в часовом поясе UTC.
        /// </summary>
        public DateTime From { get; set; }

        /// <summary>
        /// Окончание периода в часовом поясе UTC.
        /// </summary>
        public DateTime To { get; set; }
    }
}
