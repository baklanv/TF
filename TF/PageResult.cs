namespace TF
{
    public class PageResult<TData>
    {
        //
        // Сводка:
        //     Data result.
        public IEnumerable<TData> Data { get; set; }

        //
        // Сводка:
        //     Current page.
        public int Page { get; set; }

        //
        // Сводка:
        //     Общее количество
        public int Count { get; set; }

        //
        // Сводка:
        //     All filtered rows.
        public int FilteredCount { get; set; }
    }
}
