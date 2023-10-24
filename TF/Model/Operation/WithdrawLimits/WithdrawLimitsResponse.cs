using TF.Constants;

namespace TF.Model.Operation.WithdrawLimits
{
    public class WithdrawLimitsResponse
    {
        /// <summary>
        /// Массив валютных позиций портфеля.
        /// </summary>
        public MoneyValue Money { get; set; }

        /// <summary>
        /// Массив заблокированных валютных позиций портфеля.
        /// </summary>
        public MoneyValue Blocked { get; set; }

        /// <summary>
        /// Заблокировано под гарантийное обеспечение фьючерсов.
        /// </summary>
        public MoneyValue BlockedGuarantee { get; set; }
    }
}
