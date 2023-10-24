namespace TF.Model.Operation.DividendsForeignIssuer
{
    public class GetDividendsForeignIssuerResponse
    {
        /// <summary>
        /// Объект результата задачи запуска формирования отчёта.
        /// </summary>
        public GenerateDividendsForeignIssuerReportResponse GenerateDivForeignIssuerReportResponse { get; set; }

        /// <summary>
        /// Отчёт "Справка о доходах за пределами РФ".
        /// </summary>
        public GetDividendsForeignIssuerReportResponse DivForeignIssuerReport { get; set; }
    }
}
