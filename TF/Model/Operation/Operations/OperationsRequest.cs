using TF.Enums.Operation;

namespace TF.Model.Operation.Operations
{
    public class OperationsRequest
    {
        /// <summary>
        /// Идентификатор счёта клиента.
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Начало периода (по UTC).
        /// </summary>
        public DateTime From { get; set; }

        /// <summary>
        /// Окончание периода (по UTC).
        /// </summary>
        public DateTime To { get; set; }

        /// <summary>
        /// Статус запрашиваемых операций.
        /// </summary>
        public OperationState State { get; set; }

        /// <summary>
        /// Figi-идентификатор инструмента для фильтрации.
        /// </summary>
        public string Figi { get; set; }
    }
}
