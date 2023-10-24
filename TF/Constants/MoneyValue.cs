namespace TF.Constants
{
    public class MoneyValue
    {
        /// <summary>
        /// Строковый ISO-код валюты.
        /// </summary>
        public string Currency {  get; set; }

        /// <summary>
        /// Целая часть суммы, может быть отрицательным числом.
        /// </summary>
        public string Units { get; set; }

        /// <summary>
        /// Дробная часть суммы, может быть отрицательным числом.
        /// </summary>
        public int Nano { get; set; }
    }
}
