namespace TF.Model.Operation.Positions
{
    public class PositionsSecurities
    {
        /// <summary>
        /// Figi-идентификатор бумаги.
        /// </summary>
        public string Figi { get; set; }

        /// <summary>
        /// Количество бумаг заблокированных выставленными заявками.
        /// </summary>
        public string Blocked { get; set; }

        /// <summary>
        /// Текущий незаблокированный баланс.
        /// </summary>
        public string Balance { get; set; }

        /// <summary>
        /// Уникальный идентификатор позиции.
        /// </summary>
        public string PositionUid { get; set; }

        /// <summary>
        /// Уникальный идентификатор инструмента.
        /// </summary>
        public string InstrumentUid { get; set; }

        /// <summary>
        /// Заблокировано на бирже.
        /// </summary>
        public bool ExchangeBlocked { get; set; }

        /// <summary>
        /// Тип инструмента.
        /// </summary>
        public string InstrumentType { get; set; }
    }
}
