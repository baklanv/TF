namespace TF.Model.User
{
    public class UnaryLimit
    {
        /// <summary>
        /// Количество unary-запросов в минуту.
        /// </summary>
        public int LimitPerMinute { get; set; }

        /// <summary>
        /// Названия методов.
        /// </summary>
        public List<string> Methods { get; set; }
    }
}
