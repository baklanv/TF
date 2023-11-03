namespace TF.Model.Operation.OperationsByCursor
{
    public class OperationsByCursorResponse
    {
        /// <summary>
        /// Признак, есть ли следующий элемент.
        /// </summary>
        public bool HasNext { get; set; }

        /// <summary>
        /// Следующий курсор.
        /// </summary>
        public string NextCursor { get; set; }

        /// <summary>
        /// Список операций.
        /// </summary>
        public List<OperationItem> Items { get; set; }
    }
}
