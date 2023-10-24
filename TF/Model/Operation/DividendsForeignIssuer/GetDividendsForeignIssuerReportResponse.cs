namespace TF.Model.Operation.DividendsForeignIssuer
{
    public class GetDividendsForeignIssuerReportResponse
    {
        /// <summary>
        /// Отчёт "Справка о доходах за пределами РФ".
        /// </summary>
        public List<DividendsForeignIssuerReport> dividends_foreign_issuer_report {  get; set; }

        /// <summary>
        /// Количество записей в отчете.
        /// </summary>
        public int ItemsCount { get; set; }

        /// <summary>
        /// Количество страниц с данными отчета (начинается с 0).
        /// </summary>
        public int PagesCount { get; set; }

        /// <summary>
        /// Текущая страница (начинается с 0).
        /// </summary>
        public int Page {  get; set; }
    }
}
