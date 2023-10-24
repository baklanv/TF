namespace TF.Model.User
{
    public class StreamLimit
    {
        /// <summary>
        /// Максимальное количество stream-соединений.
        /// </summary>
        public int Limit { get; set; }

        /// <summary>
        /// Названия stream-методов.
        /// </summary>
        public List<string> Streams { get; set; }

        /// <summary>
        /// Текущее количество открытых stream-соединений.
        /// </summary>
        public int Open { get; set; }
    }
}
