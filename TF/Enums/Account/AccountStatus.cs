namespace TF.Enums.Account
{
    public enum AccountStatus
    {
        /// <summary>
        /// Статус счёта не определён. 
        /// </summary>
        ACCOUNT_STATUS_UNSPECIFIED = 0,

        /// <summary>
        /// Новый, в процессе открытия. 
        /// </summary>
        ACCOUNT_STATUS_NEW = 1,

        /// <summary>
        /// Открытый и активный счёт. 
        /// </summary>
        ACCOUNT_STATUS_OPEN = 2,

        /// <summary>
        /// Закрытый счёт. 
        /// </summary>
        ACCOUNT_STATUS_CLOSED = 3,
    }
}
