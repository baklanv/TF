using TF.Constants;

namespace TF.Model.Operation.DividendsForeignIssuer
{
    public class DividendsForeignIssuerReport
    {
        /// <summary>
        /// Дата фиксации реестра.
        /// </summary>
        public DateTime RecordDate { get; set; }

        /// <summary>
        /// Дата выплаты.
        /// </summary>
        public DateTime PaymentDate { get; set; }

        /// <summary>
        /// Наименование ценной бумаги.
        /// </summary>
        public string SecurityName { get; set; }

        /// <summary>
        /// ISIN-идентификатор ценной бумаги.
        /// </summary>
        public string Isin { get; set; }

        /// <summary>
        /// Страна эмитента. Для депозитарных расписок указывается страна эмитента базового актива.
        /// </summary>
        public string IssuerCountry { get; set; }

        /// <summary>
        /// Количество ценных бумаг.
        /// </summary>
        public string Quantity { get; set; }

        /// <summary>
        /// Выплаты на одну бумагу
        /// </summary>
        public Quotation Dividend { get; set; }

        /// <summary>
        /// Комиссия внешних платёжных агентов.
        /// </summary>
        public Quotation ExternalCommission { get; set; }

        /// <summary>
        /// Сумма до удержания налога.
        /// </summary>
        public Quotation DividendGross { get; set; }

        /// <summary>
        /// Сумма налога, удержанного агентом.
        /// </summary>
        public Quotation Tax { get; set; }

        /// <summary>
        /// Итоговая сумма выплаты.
        /// </summary>
        public Quotation DividendAmount { get; set; }

        /// <summary>
        /// Валюта.
        /// </summary>
        public string Currency { get; set; }
    }
}
