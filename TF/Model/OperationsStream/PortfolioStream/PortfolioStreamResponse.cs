using System.Net.NetworkInformation;
using TF.Model.Operation.Portfolio;

namespace TF.Model.OperationsStream.PortfolioStream
{
    public class PortfolioStreamResponse
    {
        /// <summary>
        /// Объект результата подписки.
        /// </summary>
        public PortfolioSubscriptionResult Subscriptions { get; set; }

        /// <summary>
        /// Объект стриминга портфеля.
        /// </summary>
        public PortfolioResponse Portfolio { get; set; }

        /// <summary>
        /// Проверка активности стрима.
        /// </summary>
        public Ping Ping { get; set; }
    }
}
