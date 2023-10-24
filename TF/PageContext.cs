namespace TF
{
    public class PageContext
    {
        //
        // Сводка:
        //     Текущая страница.
        public int Offset { get; set; }

        //
        // Сводка:
        //     Количество выводимых строк.
        public int Limit { get; set; }

        //
        // Сводка:
        //     Быстрый поиск
        public string Search { get; set; }

        public PageContext()
        {
            Offset = 0;
            Limit = 250;
        }
    }
}
