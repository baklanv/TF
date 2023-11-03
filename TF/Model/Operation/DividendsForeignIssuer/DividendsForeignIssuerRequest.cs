namespace TF.Model.Operation.DividendsForeignIssuer
{
    public class DividendsForeignIssuerRequest
    {
        /// <summary>
        /// Объект запроса формирования отчёта.
        /// </summary>
        public GenerateDividendsForeignIssuerReportRequest GenerateDivForeignIssuerReport { get; set; }

        /// <summary>
        /// Объект запроса сформированного отчёта.
        /// </summary>
        public DividendsForeignIssuerReportRequest GetDivForeignIssuerReport { get; set; }
    }
}
