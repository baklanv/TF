namespace TF.Enums
{
    public enum SecurityTradingStatus
    {
        /// <summary>
        /// Торговый статус не определён. 
        /// </summary>
        SECURITY_TRADING_STATUS_UNSPECIFIED = 0,

        /// <summary>
        /// Недоступен для торгов. 
        /// </summary>
        SECURITY_TRADING_STATUS_NOT_AVAILABLE_FOR_TRADING = 1,

        /// <summary>
        /// Период открытия торгов. 
        /// </summary>
        SECURITY_TRADING_STATUS_OPENING_PERIOD = 2,

        /// <summary>
        /// Период закрытия торгов. 
        /// </summary>
        SECURITY_TRADING_STATUS_CLOSING_PERIOD = 3,

        /// <summary>
        /// Перерыв в торговле. 
        /// </summary>
        SECURITY_TRADING_STATUS_BREAK_IN_TRADING = 4,

        /// <summary>
        /// Нормальная торговля. 
        /// </summary>
        SECURITY_TRADING_STATUS_NORMAL_TRADING = 5,

        /// <summary>
        /// Аукцион закрытия. 
        /// </summary>
        SECURITY_TRADING_STATUS_CLOSING_AUCTION = 6,

        /// <summary>
        /// Аукцион крупных пакетов. 
        /// </summary>
        SECURITY_TRADING_STATUS_DARK_POOL_AUCTION = 7,

        /// <summary>
        /// Дискретный аукцион. 
        /// </summary>
        SECURITY_TRADING_STATUS_DISCRETE_AUCTION = 8,

        /// <summary>
        /// Аукцион открытия. 
        /// </summary>
        SECURITY_TRADING_STATUS_OPENING_AUCTION_PERIOD = 9,

        /// <summary>
        /// Период торгов по цене аукциона закрытия. 
        /// </summary>
        SECURITY_TRADING_STATUS_TRADING_AT_CLOSING_AUCTION_PRICE = 10,

        /// <summary>
        /// Сессия назначена. 
        /// </summary>
        SECURITY_TRADING_STATUS_SESSION_ASSIGNED = 11,

        /// <summary>
        /// Сессия закрыта. 
        /// </summary>
        SECURITY_TRADING_STATUS_SESSION_CLOSE = 12,

        /// <summary>
        /// Сессия открыта. 
        /// </summary>
        SECURITY_TRADING_STATUS_SESSION_OPEN = 13,

        /// <summary>
        /// Доступна торговля в режиме внутренней ликвидности брокера. 
        /// </summary>
        SECURITY_TRADING_STATUS_DEALER_NORMAL_TRADING = 14,

        /// <summary>
        /// Перерыв торговли в режиме внутренней ликвидности брокера. 
        /// </summary>
        SECURITY_TRADING_STATUS_DEALER_BREAK_IN_TRADING = 15,

        /// <summary>
        /// Недоступна торговля в режиме внутренней ликвидности брокера. 
        /// </summary>
        SECURITY_TRADING_STATUS_DEALER_NOT_AVAILABLE_FOR_TRADING = 16,
    }
}
