namespace TF.Model.Operation.DividendsForeignIssuer
{
    public class GetDividendsForeignIssuerReportRequest
    {
        /// <summary>
        /// Идентификатор задачи формирования отчёта.
        /// </summary>
        public string TaskId { get; set; }

        /// <summary>
        /// Номер страницы отчета (начинается с 0), значение по умолчанию: 0.
        /// </summary>
        public int Page {  get; set; }
    }
}
