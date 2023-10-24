using TF.Constants;

namespace TF.Model.OperationsStream.PositionsStream
{
    public class PositionsMoney
    {
        /// <summary>
        /// Доступное количество валютный позиций.
        /// </summary>
        public MoneyValue AvailableValue { get; set; }

        /// <summary>
        /// Заблокированное количество валютный позиций.
        /// </summary>
        public MoneyValue BlockedValue{ get; set; }
    }
}
