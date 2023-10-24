namespace TF.Model.User
{
    public class UserTaffir
    {
        /// <summary>
        /// Массив лимитов пользователя по unary-запросам.
        /// </summary>
        public List<UnaryLimit> UnaryLimits { get; set; }

        /// <summary>
        /// Массив лимитов пользователей для stream-соединений.
        /// </summary>
        public List<StreamLimit> StreamLimits { get; set; }
    }
}
