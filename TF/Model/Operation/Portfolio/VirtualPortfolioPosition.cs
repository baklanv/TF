using TF.Constants;

namespace TF.Model.Operation.Portfolio
{
    public class VirtualPortfolioPosition
    {
        /// <summary>
        /// position_uid-идентификатора инструмента.
        /// </summary>
        public string PositionUid { get; set; }

        /// <summary>
        /// instrument_uid-идентификатора инструмента.
        /// </summary>
        public string InstrumentUid { get; set; }

        /// <summary>
        /// Figi-идентификатора инструмента.
        /// </summary>
        public string Figi { get; set; }

        /// <summary>
        /// Тип инструмента.
        /// </summary>
        public string InstrumentType { get; set; }

        /// <summary>
        /// Количество инструмента в портфеле в штуках.
        /// </summary>
        public Quotation Quantity { get; set; }

        /// <summary>
        /// Средневзвешенная цена позиции. Возможна задержка до секунды для пересчёта.
        /// </summary>
        public MoneyValue AveragePositionPrice { get; set; }

        /// <summary>
        /// Текущая рассчитанная доходность позиции.
        /// </summary>
        public Quotation ExpectedYield { get; set; }

        /// <summary>
        /// Текущая рассчитанная доходность позиции.
        /// </summary>
        public Quotation ExpectedYieldFifo { get; set; }

        /// <summary>
        /// Дата до которой нужно продать виртуальные бумаги, после этой даты виртуальная позиция "сгорит"
        /// </summary>
        public DateTime ExpireDate { get; set; }

        /// <summary>
        /// Текущая цена за 1 инструмент. Для получения стоимости лота требуется умножить на лотность инструмента.
        /// </summary>
        public MoneyValue CurrentPrice { get; set; }

        /// <summary>
        /// Средняя цена позиции по методу FIFO. Возможна задержка до секунды для пересчёта.
        /// </summary>
        public MoneyValue AveragePositionPriceFifo { get; set; }
    }
}
