using TF.Constants;

namespace TF.Model.Operation.OperationsByCursor
{
    public class OperationItemTrade
    {
        /// <summary>
        /// Номер сделки.
        /// </summary>
        public string Num { get; set; }

        /// <summary>
        /// Дата сделки.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Количество в единицах.
        /// </summary>
        public string Quantity { get; set; }

        /// <summary>
        /// Цена.
        /// </summary>
        public MoneyValue Price { get; set; }

        /// <summary>
        /// Доходность.
        /// </summary>
        public MoneyValue Yield { get; set; }

        /// <summary>
        /// Относительная доходность.
        /// </summary>
        public Quotation YieldRelative { get; set; }
    }
}
