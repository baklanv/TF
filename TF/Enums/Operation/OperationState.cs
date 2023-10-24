namespace TF.Enums.Operation
{
    public enum OperationState
    {
        /// <summary>
        /// Статус операции не определён.
        /// </summary>
        OPERATION_STATE_UNSPECIFIED = 0,

        /// <summary>
        /// Исполнена.
        /// </summary>
        OPERATION_STATE_EXECUTED = 1,

        /// <summary>
        /// Отменена.
        /// </summary>
        OPERATION_STATE_CANCELED = 2,

        /// <summary>
        /// Исполняется.
        /// </summary>
        OPERATION_STATE_PROGRESS = 3,
    }
}
