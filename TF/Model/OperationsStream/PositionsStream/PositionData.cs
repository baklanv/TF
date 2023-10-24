using TF.Model.Operation.Positions;

namespace TF.Model.OperationsStream.PositionsStream
{
    public class PositionData
    {
        /// <summary>
        /// Идентификатор счёта.
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Массив валютных позиций портфеля.
        /// </summary>
        public List<PositionsMoney> Money { get; set; }

        /// <summary>
        /// Список ценно-бумажных позиций портфеля.
        /// </summary>
        public List<PositionsSecurities> Securities { get; set; }

        /// <summary>
        /// Список фьючерсов портфеля.
        /// </summary>
        public List<PositionsFutures> Futures { get; set; }

        /// <summary>
        /// Список опционов портфеля.
        /// </summary>
        public List<PositionsOptions> Options { get; set; }

        /// <summary>
        /// Дата и время операции в формате UTC.
        /// </summary>
        public DateTime Date { get; set; }
    }
}
