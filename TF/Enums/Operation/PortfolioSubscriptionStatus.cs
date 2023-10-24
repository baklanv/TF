namespace TF.Enums.Operation
{
    public enum PortfolioSubscriptionStatus
    {
        /// <summary>
        /// Тип не определён.
        /// </summary>
        PORTFOLIO_SUBSCRIPTION_STATUS_UNSPECIFIED = 0,

        /// <summary>
        /// Успешно.
        /// </summary>
        PORTFOLIO_SUBSCRIPTION_STATUS_SUCCESS = 1,

        /// <summary>
        /// Счёт не найден или недостаточно прав.
        /// </summary>
        PORTFOLIO_SUBSCRIPTION_STATUS_ACCOUNT_NOT_FOUND = 2,

        /// <summary>
        /// Произошла ошибка.
        /// </summary>
        PORTFOLIO_SUBSCRIPTION_STATUS_INTERNAL_ERROR = 3,
    }
}
