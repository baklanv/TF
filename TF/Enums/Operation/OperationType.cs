namespace TF.Enums.Operation
{
    public enum OperationType
    {
        /// <summary>
        /// 
        /// </summary>
        OPERATION_TYPE_UNSPECIFIED = 0,

        /// <summary>
        /// Пополнение брокерского счёта.
        /// </summary>
        OPERATION_TYPE_INPUT = 1,

        /// <summary>
        /// Удержание НДФЛ по купонам.
        /// </summary>
        OPERATION_TYPE_BOND_TAX = 2,

        /// <summary>
        /// Вывод ЦБ.
        /// </summary>
        OPERATION_TYPE_OUTPUT_SECURITIES = 3,

        /// <summary>
        /// Доход по сделке РЕПО овернайт.
        /// </summary>
        OPERATION_TYPE_OVERNIGHT = 4,

        /// <summary>
        /// Удержание налога.
        /// </summary>
        OPERATION_TYPE_TAX = 5,

        /// <summary>
        /// Полное погашение облигаций.
        /// </summary>
        OPERATION_TYPE_BOND_REPAYMENT_FULL = 6,

        /// <summary>
        /// Продажа ЦБ с карты.
        /// </summary>
        OPERATION_TYPE_SELL_CARD = 7,

        /// <summary>
        /// Удержание налога по дивидендам.
        /// </summary>
        OPERATION_TYPE_DIVIDEND_TAX = 8,

        /// <summary>
        /// Вывод денежных средств.
        /// </summary>
        OPERATION_TYPE_OUTPUT = 9,

        /// <summary>
        /// Частичное погашение облигаций.
        /// </summary>
        OPERATION_TYPE_BOND_REPAYMENT = 10,

        /// <summary>
        /// Корректировка налога.
        /// </summary>
        OPERATION_TYPE_TAX_CORRECTION = 11,

        /// <summary>
        /// Удержание комиссии за обслуживание брокерского счёта.
        /// </summary>
        OPERATION_TYPE_SERVICE_FEE = 12,

        /// <summary>
        /// Удержание налога за материальную выгоду
        /// </summary>
        OPERATION_TYPE_BENEFIT_TAX = 13,

        /// <summary>
        /// Удержание комиссии за непокрытую позицию.
        /// </summary>
        OPERATION_TYPE_MARGIN_FEE = 14,

        /// <summary>
        /// Покупка ЦБ.
        /// </summary>
        OPERATION_TYPE_BUY = 15,

        /// <summary>
        /// Покупка ЦБ с карты.
        /// </summary>
        OPERATION_TYPE_BUY_CARD = 16,

        /// <summary>
        /// Перевод ценных бумаг из другого депозитария.
        /// </summary>
        OPERATION_TYPE_INPUT_SECURITIES = 17,

        /// <summary>
        /// Продажа в результате Margin-call.
        /// </summary>
        OPERATION_TYPE_SELL_MARGIN = 18,

        /// <summary>
        /// Удержание комиссии за операцию.
        /// </summary>
        OPERATION_TYPE_BROKER_FEE = 19,

        /// <summary>
        /// Покупка в результате Margin-call.
        /// </summary>
        OPERATION_TYPE_BUY_MARGIN = 20,

        /// <summary>
        /// Выплата дивидендов.
        /// </summary>
        OPERATION_TYPE_DIVIDEND = 21,

        /// <summary>
        /// Продажа ЦБ.
        /// </summary>
        OPERATION_TYPE_SELL = 22,

        /// <summary>
        /// Выплата купонов.
        /// </summary>
        OPERATION_TYPE_COUPON = 23,

        /// <summary>
        /// Удержание комиссии SuccessFee.
        /// </summary>
        OPERATION_TYPE_SUCCESS_FEE = 24,

        /// <summary>
        /// Передача дивидендного дохода.
        /// </summary>
        OPERATION_TYPE_DIVIDEND_TRANSFER = 25,

        /// <summary>
        /// Зачисление вариационной маржи.
        /// </summary>
        OPERATION_TYPE_ACCRUING_VARMARGIN = 26,

        /// <summary>
        /// Списание вариационной маржи.
        /// </summary>
        OPERATION_TYPE_WRITING_OFF_VARMARGIN = 27,

        /// <summary>
        /// Покупка в рамках экспирации фьючерсного контракта.
        /// </summary>
        OPERATION_TYPE_DELIVERY_BUY = 28,

        /// <summary>
        /// Продажа в рамках экспирации фьючерсного контракта.
        /// </summary>
        OPERATION_TYPE_DELIVERY_SELL = 29,

        /// <summary>
        /// Комиссия за управление по счёту автоследования.
        /// </summary>
        OPERATION_TYPE_TRACK_MFEE = 30,

        /// <summary>
        /// Комиссия за результат по счёту автоследования.
        /// </summary>
        OPERATION_TYPE_TRACK_PFEE = 31,

        /// <summary>
        /// Удержание налога по ставке 15%.
        /// </summary>
        OPERATION_TYPE_TAX_PROGRESSIVE = 32,

        /// <summary>
        /// Удержание налога по купонам по ставке 15%.
        /// </summary>
        OPERATION_TYPE_BOND_TAX_PROGRESSIVE = 33,

        /// <summary>
        /// Удержание налога по дивидендам по ставке 15%.
        /// </summary>
        OPERATION_TYPE_DIVIDEND_TAX_PROGRESSIVE = 34,

        /// <summary>
        /// Удержание налога за материальную выгоду по ставке 15%.
        /// </summary>
        OPERATION_TYPE_BENEFIT_TAX_PROGRESSIVE = 35,

        /// <summary>
        /// Корректировка налога по ставке 15%.
        /// </summary>
        OPERATION_TYPE_TAX_CORRECTION_PROGRESSIVE = 36,

        /// <summary>
        /// Удержание налога за возмещение по сделкам РЕПО по ставке 15%.
        /// </summary>
        OPERATION_TYPE_TAX_REPO_PROGRESSIVE = 37,

        /// <summary>
        /// Удержание налога за возмещение по сделкам РЕПО.
        /// </summary>
        OPERATION_TYPE_TAX_REPO = 38,

        /// <summary>
        /// Удержание налога по сделкам РЕПО.
        /// </summary>
        OPERATION_TYPE_TAX_REPO_HOLD = 39,

        /// <summary>
        /// Возврат налога по сделкам РЕПО.
        /// </summary>
        OPERATION_TYPE_TAX_REPO_REFUND = 40,

        /// <summary>
        /// Удержание налога по сделкам РЕПО по ставке 15%.
        /// </summary>
        OPERATION_TYPE_TAX_REPO_HOLD_PROGRESSIVE = 41,

        /// <summary>
        /// Возврат налога по сделкам РЕПО по ставке 15%.
        /// </summary>
        OPERATION_TYPE_TAX_REPO_REFUND_PROGRESSIVE = 42,

        /// <summary>
        /// Выплата дивидендов на карту.
        /// </summary>
        OPERATION_TYPE_DIV_EXT = 43,

        /// <summary>
        /// Корректировка налога по купонам.
        /// </summary>
        OPERATION_TYPE_TAX_CORRECTION_COUPON = 44,

        /// <summary>
        /// Комиссия за валютный остаток.
        /// </summary>
        OPERATION_TYPE_CASH_FEE = 45,

        /// <summary>
        /// Комиссия за вывод валюты с брокерского счета.
        /// </summary>
        OPERATION_TYPE_OUT_FEE = 46,

        /// <summary>
        /// Гербовый сбор.
        /// </summary>
        OPERATION_TYPE_OUT_STAMP_DUTY = 47,

        /// <summary>
        /// SWIFT-перевод.
        /// </summary>
        OPERATION_TYPE_OUTPUT_SWIFT = 50,

        /// <summary>
        /// SWIFT-перевод.
        /// </summary>
        OPERATION_TYPE_INPUT_SWIFT = 51,

        /// <summary>
        /// Перевод на карту.
        /// </summary>
        OPERATION_TYPE_OUTPUT_ACQUIRING = 53,

        /// <summary>
        /// Перевод с карты.
        /// </summary>
        OPERATION_TYPE_INPUT_ACQUIRING = 54,

        /// <summary>
        /// Комиссия за вывод средств.
        /// </summary>
        OPERATION_TYPE_OUTPUT_PENALTY = 55,

        /// <summary>
        /// Списание оплаты за сервис Советов.
        /// </summary>
        OPERATION_TYPE_ADVICE_FEE = 56,

        /// <summary>
        /// Перевод ценных бумаг с ИИС на Брокерский счет.
        /// </summary>
        OPERATION_TYPE_TRANS_IIS_BS = 57,

        /// <summary>
        /// Перевод ценных бумаг с одного брокерского счета на другой.
        /// </summary>
        OPERATION_TYPE_TRANS_BS_BS = 58,

        /// <summary>
        /// Вывод денежных средств со счета.
        /// </summary>
        OPERATION_TYPE_OUT_MULTI = 59,

        /// <summary>
        /// Пополнение денежных средств со счета.
        /// </summary>
        OPERATION_TYPE_INP_MULTI = 60,

        /// <summary>
        /// Размещение биржевого овернайта.
        /// </summary>
        OPERATION_TYPE_OVER_PLACEMENT = 61,

        /// <summary>
        /// Списание комиссии.
        /// </summary>
        OPERATION_TYPE_OVER_COM = 62,

        /// <summary>
        /// Доход от оверанайта.
        /// </summary>
        OPERATION_TYPE_OVER_INCOME = 63,

        /// <summary>
        /// Экспирация.
        /// </summary>
        OPERATION_TYPE_OPTION_EXPIRATION = 64,
    }
}
