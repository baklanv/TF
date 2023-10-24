namespace TF.Model.OperationsStream.PositionsStream
{
    public class PositionsStreamRequest
    {
        /// <summary>
        /// Массив идентификаторов счётов пользователя
        /// </summary>
        public List<string> Accounts { get; set; }
    }
}
