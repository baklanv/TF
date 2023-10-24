namespace TF.Model.User
{
    public class Info
    {
        /// <summary>
        /// Признак премиум клиента.
        /// </summary>
        public bool PremStatus { get; set; }

        /// <summary>
        /// Признак квалифицированного инвестора.
        /// </summary>
        public bool QualStatus { get; set; }

        /// <summary>
        /// Набор требующих тестирования инструментов и возможностей, с которыми может работать пользователь.
        /// </summary>
        public List<string> QualifiedForWorkWith { get; set; }

        /// <summary>
        /// Наименование тарифа пользователя.
        /// </summary>
        public string Tariff { get; set; }
    }
}
