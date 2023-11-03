using TF.Constants;

namespace TF.Model.Operation.WithdrawLimits
{
    public class WithdrawLimitsResponse
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
        /// Заблокировано под гарантийное обеспечение фьючерсов.
        /// </summary>
        public List<MoneyValue> BlockedGuarantee { get; set; }
    }
}
