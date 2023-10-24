using TF.Constants;

namespace TF.Model.Operation.Positions
{
    public class PositionsResponse
    {
        /// <summary>
        /// Массив валютных позиций портфеля.
        /// </summary>
        public List<MoneyValue> Money { get; set; }

        /// <summary>
        /// Массив заблокированных валютных позиций портфеля.
        /// </summary>
        public List<MoneyValue> Blocked { get; set; }

        /// <summary>
        /// Список ценно-бумажных позиций портфеля.
        /// </summary>
        public List<PositionsSecurities> Securities { get; set; }

        /// <summary>
        /// Признак идущей в данный момент выгрузки лимитов.
        /// </summary>
        public bool LimitsLoadingInProgress { get; set; }

        /// <summary>
        /// Список фьючерсов портфеля.
        /// </summary>
        public List<PositionsFutures> Futures { get; set; }

        /// <summary>
        /// Список опционов портфеля.
        /// </summary>
        public List<PositionsOptions> Options { get; set; }
        
    }
}
