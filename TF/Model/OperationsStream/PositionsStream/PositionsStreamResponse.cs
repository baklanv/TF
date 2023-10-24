using System.Net.NetworkInformation;

namespace TF.Model.OperationsStream.PositionsStream
{
    public class PositionsStreamResponse
    {
        /// <summary>
        /// Объект результата подписки.
        /// </summary>
        public PositionsSubscriptionResult Subscriptions { get; set; }

        /// <summary>
        /// Объект стриминга позиций.
        /// </summary>
        public PositionData Position { get; set; }

        /// <summary>
        /// Проверка активности стрима.
        /// </summary>
        public Ping Ping { get; set; }
    }
}
