using TF.Constants;

namespace TF.Model.Operation.Operations
{
    public class OperationTrade
    {
        /// <summary>
        /// Идентификатор сделки.
        /// </summary>
        public string TradeId { get; set; }

        /// <summary>
        /// Дата и время сделки в часовом поясе UTC.
        /// </summary>
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Количество инструментов.
        /// </summary>
        public string Quantity { get; set; }

        /// <summary>
        /// Цена за 1 инструмент. Для получения стоимости лота требуется умножить на лотность инструмента.
        /// </summary>
        public MoneyValue Price { get; set; }
    }
}
