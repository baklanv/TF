using TF.Enums.Operation;

namespace TF.Model.Operation.OperationsByCursor
{
    public class GetOperationsByCursorRequest
    {
        /// <summary>
        /// Идентификатор счёта клиента. Обязательный параметр для данного метода, остальные параметры опциональны.
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Идентификатор инструмента (Figi инструмента или uid инструмента)
        /// </summary>
        public string InstrumentId { get; set; }

        /// <summary>
        /// Начало периода (по UTC).
        /// </summary>
        public DateTime From { get; set; }

        /// <summary>
        /// Окончание периода (по UTC).
        /// </summary>
        public DateTime To { get; set; }

        /// <summary>
        /// Идентификатор элемента, с которого начать формировать ответ.
        /// </summary>
        public string Cursor { get; set; }

        /// <summary>
        /// Лимит количества операций. По умолчанию устанавливается значение 100, максимальное значение 1000.
        /// </summary>
        public int Limit { get; set; }

        /// <summary>
        /// Тип операции. Принимает значение из списка OperationType.
        /// </summary>
        public List<OperationType> OperationTypes { get; set; }

        /// <summary>
        /// Статус запрашиваемых операций, возможные значения указаны в OperationState.
        /// </summary>
        public OperationState State { get; set; }

        /// <summary>
        /// Флаг возвращать ли комиссии, по умолчанию false
        /// </summary>
        public bool WithoutCommissions { get; set; }

        /// <summary>
        /// Флаг получения ответа без массива сделок.
        /// </summary>
        public bool WithoutTrades { get; set; }

        /// <summary>
        /// Флаг не показывать overnight операций.
        /// </summary>
        public bool WithoutOvernights { get; set; }
    }
}
