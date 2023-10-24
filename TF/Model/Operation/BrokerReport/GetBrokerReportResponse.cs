namespace TF.Model.Operation.BrokerReport
{
    public class GetBrokerReportResponse
    {
        /// <summary>
        /// Массив объектов
        /// </summary>
        public List<BrokerReport> BrokerReport { get; set; }

        /// <summary>
        /// Количество записей в отчете.
        /// </summary>
        public int ItemsCount { get; set; }

        /// <summary>
        /// Количество страниц с данными отчета (начинается с 0).
        /// </summary>
        public int PagesCount { get; set;}

        /// <summary>
        /// Текущая страница (начинается с 0).
        /// </summary>
        public int Page { get; set;}
    }
}
