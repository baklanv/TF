using TF.Constants;

namespace TF.Model.Operation.Portfolio
{
    public class PortfolioResponse
    {
        /// <summary>
        /// Общая стоимость акций в портфеле.
        /// </summary>
        public MoneyValue TotalAmountShares { get; set; }

        /// <summary>
        /// Общая стоимость облигаций в портфеле.
        /// </summary>
        public MoneyValue TotalAmountBonds { get; set; }

        /// <summary>
        /// Общая стоимость фондов в портфеле.
        /// </summary>
        public MoneyValue TotalAmountEtf { get; set; }

        /// <summary>
        /// Общая стоимость валют в портфеле.
        /// </summary>
        public MoneyValue TotalAmountCurrencies { get; set; }

        /// <summary>
        /// Общая стоимость фьючерсов в портфеле.
        /// </summary>
        public MoneyValue TotalAmountFutures { get; set; }

        /// <summary>
        /// Текущая относительная доходность портфеля, в %.
        /// </summary>
        public Quotation ExpectedYield { get; set; }

        /// <summary>
        /// Список позиций портфеля.
        /// </summary>
        public List<PortfolioPosition> Positions { get; set; }

        /// <summary>
        /// Идентификатор счёта пользователя.
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Общая стоимость опционов в портфеле.
        /// </summary>
        public MoneyValue TotalAmountOptions { get; set; }

        /// <summary>
        /// Общая стоимость структурных нот в портфеле.
        /// </summary>
        public MoneyValue TotalAmountSp { get; set; }

        /// <summary>
        /// Общая стоимость портфеля.
        /// </summary>
        public MoneyValue TotalAmountPortfolio { get; set; }

        /// <summary>
        /// Массив виртуальных позиций портфеля.
        /// </summary>
        public List<VirtualPortfolioPosition> VirtualPositions { get; set; }
    }
}
