using TF.Constants;

namespace TF.Model.Operation.BrokerReport
{
    public class BrokerReport
    {
        /// <summary>
        /// Номер сделки.
        /// </summary>
        public string TradeId { get; set; }

        /// <summary>
        /// Номер поручения.
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// Figi-идентификатор инструмента.
        /// </summary>
        public string Figi { get; set; }

        /// <summary>
        /// Признак исполнения.
        /// </summary>
        public string ExecuteSign { get; set; }

        /// <summary>
        /// Дата и время заключения в часовом поясе UTC.
        /// </summary>
        public DateTime TradeDatetime { get; set; }

        /// <summary>
        /// Торговая площадка.
        /// </summary>
        public string Exchange { get; set; }

        /// <summary>
        /// Режим торгов.
        /// </summary>
        public string ClassCode { get; set; }

        /// <summary>
        /// Вид сделки.
        /// </summary>
        public string Direction { get; set; }

        /// <summary>
        /// Сокращённое наименование актива.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Код актива.
        /// </summary>
        public string Ticker { get; set; }

        /// <summary>
        /// Цена за единицу.
        /// </summary>
        public MoneyValue Price { get; set; }

        /// <summary>
        /// Количество.
        /// </summary>
        public string Quantity { get; set; }

        /// <summary>
        /// Сумма (без НКД).
        /// </summary>
        public MoneyValue OrderAmount { get; set; }

        /// <summary>
        /// НКД.
        /// </summary>
        public Quotation AciValue { get; set; }

        /// <summary>
        /// Сумма сделки.
        /// </summary>
        public MoneyValue TotalOrderAmount { get; set; }

        /// <summary>
        /// Комиссия брокера.
        /// </summary>
        public MoneyValue BrokerCommission { get; set; }

        /// <summary>
        /// Комиссия биржи.
        /// </summary>
        public MoneyValue ExchangeCommission { get; set; }

        /// <summary>
        /// Комиссия клир. центра.
        /// </summary>
        public MoneyValue ExchangeClearingCommission { get; set; }

        /// <summary>
        /// Ставка РЕПО (%).
        /// </summary>
        public Quotation RepoRate { get; set; }

        /// <summary>
        /// Контрагент/Брокер.
        /// </summary>
        public string Party { get; set; }

        /// <summary>
        /// Дата расчётов в часовом поясе UTC.
        /// </summary>
        public DateTime ClearValueDate { get; set; }

        /// <summary>
        /// Дата поставки в часовом поясе UTC.
        /// </summary>
        public DateTime SecValueDate { get; set; }

        /// <summary>
        /// Статус брокера.
        /// </summary>
        public string BrokerStatus { get; set; }

        /// <summary>
        /// Тип дог.
        /// </summary>
        public string SeparateAgreementType { get; set; }

        /// <summary>
        /// Номер дог.
        /// </summary>
        public string SeparateAgreementNumber { get; set; }

        /// <summary>
        /// Дата дог.
        /// </summary>
        public string SeparateAgreementDate { get; set; }

        /// <summary>
        /// Тип расчёта по сделке.
        /// </summary>
        public string DeliveryType { get; set; }
    }
}
