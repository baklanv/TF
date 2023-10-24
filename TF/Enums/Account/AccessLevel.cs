namespace TF.Enums.Account
{
    public enum AccessLevel
    {
        /// <summary>
        /// Уровень доступа не определён. 
        /// </summary>
        ACCOUNT_ACCESS_LEVEL_UNSPECIFIED = 0,

        /// <summary>
        /// Полный доступ к счёту. 
        /// </summary>
        ACCOUNT_ACCESS_LEVEL_FULL_ACCESS = 1,

        /// <summary>
        /// Доступ с уровнем прав "только чтение". 
        /// </summary>
        ACCOUNT_ACCESS_LEVEL_READ_ONLY = 2,

        /// <summary>
        /// Доступ отсутствует. 
        /// </summary>
        ACCOUNT_ACCESS_LEVEL_NO_ACCESS = 3,
    }
}
