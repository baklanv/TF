namespace TF.Model.Operation.BrokerReport
{
    public class GetBrokerReportRequest
    {
        /// <summary>
        /// Идентификатор задачи формирования брокерского отчёта.
        /// </summary>
        public string TaskId { get; set; }

        /// <summary>
        /// Номер страницы отчета (начинается с 1), значение по умолчанию: 0.
        /// </summary>
        public int Page { get; set; }
    }
}
