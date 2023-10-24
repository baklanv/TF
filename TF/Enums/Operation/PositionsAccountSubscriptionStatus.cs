namespace TF.Enums.Operation
{
    public enum PositionsAccountSubscriptionStatus
    {
        /// <summary>
        /// Тип не определён.
        /// </summary>
        POSITIONS_SUBSCRIPTION_STATUS_UNSPECIFIED = 0,

        /// <summary>
        /// Успешно.
        /// </summary>
        POSITIONS_SUBSCRIPTION_STATUS_SUCCESS = 1,

        /// <summary>
        /// Счёт не найден или недостаточно прав.
        /// </summary>
        POSITIONS_SUBSCRIPTION_STATUS_ACCOUNT_NOT_FOUND = 2,

        /// <summary>
        /// Произошла ошибка.
        /// </summary>
        POSITIONS_SUBSCRIPTION_STATUS_INTERNAL_ERROR = 3,
    }
}
