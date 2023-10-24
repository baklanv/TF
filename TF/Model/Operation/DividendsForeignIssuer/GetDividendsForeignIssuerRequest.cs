namespace TF.Model.Operation.DividendsForeignIssuer
{
    public class GetDividendsForeignIssuerRequest
    {
        /// <summary>
        /// Объект запроса формирования отчёта.
        /// </summary>
        public GenerateDividendsForeignIssuerReportRequest GenerateDivForeignIssuerReport { get; set; }

        /// <summary>
        /// Объект запроса сформированного отчёта.
        /// </summary>
        public GetDividendsForeignIssuerReportRequest GetDivForeignIssuerReport { get; set; }
    }
}
