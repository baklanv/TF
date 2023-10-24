namespace TF.Model.OperationsStream.PortfolioStream
{
    public class PortfolioStreamRequest
    {
        /// <summary>
        /// Массив идентификаторов счётов пользователя.
        /// </summary>
        public List<string> Accounts { get; set; }
    }
}
