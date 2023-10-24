using TF.Constants;

namespace TF.Model.User
{
    public class MarginAttributes
    {
        /// <summary>
        /// Ликвидная стоимость портфеля.
        /// </summary>
        public MoneyValue LiquidPortfolio { get; set; }

        /// <summary>
        /// Начальная маржа — начальное обеспечение для совершения новой сделки.
        /// </summary>
        public MoneyValue StartingMargin { get; set; }

        /// <summary>
        /// Минимальная маржа — это минимальное обеспечение для поддержания позиции, которую вы уже открыли.
        /// </summary>
        public MoneyValue MinimalMargin { get; set; }

        /// <summary>
        /// Уровень достаточности средств. Соотношение стоимости ликвидного портфеля к начальной марже.
        /// </summary>
        public Quotation FundsSufficiencyLevel { get; set; }

        /// <summary>
        /// Объем недостающих средств. Разница между стартовой маржой и ликвидной стоимости портфеля.
        /// </summary>
        public MoneyValue AmountOfMissingFunds { get; set; }

        /// <summary>
        /// Скорректированная маржа.Начальная маржа, в которой плановые позиции рассчитываются с учётом активных заявок на покупку позиций лонг или продажу позиций шорт.
        /// </summary>
        public MoneyValue CorrectedMargin { get; set; }

    }
}
