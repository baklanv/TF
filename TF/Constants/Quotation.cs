namespace TF.Constants
{
    public class Quotation
    {
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
