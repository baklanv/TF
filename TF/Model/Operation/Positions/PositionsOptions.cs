namespace TF.Model.Operation.Positions
{
    public class PositionsOptions
    {
        /// <summary>
        /// Уникальный идентификатор позиции опциона.
        /// </summary>
        public string PositionUid { get; set; }

        /// <summary>
        /// Уникальный идентификатор инструмента.
        /// </summary>
        public string InstrumentUid { get; set; }

        /// <summary>
        /// Количество бумаг заблокированных выставленными заявками.
        /// </summary>
        public string Blocked { get; set; }

        /// <summary>
        /// Текущий незаблокированный баланс.
        /// </summary>
        public string Balance { get; set; }      
    }
}
