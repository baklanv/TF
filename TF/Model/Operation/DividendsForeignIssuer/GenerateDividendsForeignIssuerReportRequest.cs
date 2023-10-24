namespace TF.Model.Operation.DividendsForeignIssuer
{
    public class GenerateDividendsForeignIssuerReportRequest
    {
        /// <summary>
        /// Идентификатор счёта клиента.
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Начало периода (по UTC).
        /// </summary>
        public DateTime From {  get; set; }

        /// <summary>
        /// Окончание периода (по UTC).
        /// </summary>
        public DateTime To { get; set; }
    }
}
