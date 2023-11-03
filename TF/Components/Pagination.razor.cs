using Microsoft.AspNetCore.Components;

namespace TF.Components
{
    public partial class Pagination
    {

        [Parameter]
        public PageContext PageContext { get; set; }

        [Parameter]
        public EventCallback<PageContext> PageContextChanged { get; set; }

        [Parameter]
        public int Spread { get; set; }

        [Parameter]
        public int EntitiesCount { get; set; }

        [Parameter]
        public string SearchPlaceholder { get; set; }

        [Parameter]
        public RenderFragment Header { get; set; }

        [Parameter]
        public RenderFragment Body { get; set; }

        [Parameter]
        public RenderFragment Footer { get; set; }

        [Parameter] 
        public bool EnableSearch { get; set; } = true;

        private int _pageCount { get => (int)Math.Ceiling((double)EntitiesCount / PageContext.Limit); }

        private Timer _timer;

        protected override void OnInitialized()
        {
            base.OnInitialized();
            SearchPlaceholder ??= "123";
        }

        private async Task OnPageChangeAsync(int page)
        {
            if (page != PageContext.Offset && page >= 0 && page < _pageCount)
            {
                PageContext.Offset = page;
                await PageContextChanged.InvokeAsync();
            }
        }

        private async Task OnLimitChangeAsync()
        {
            PageContext.Offset = 0;
            await PageContextChanged.InvokeAsync();
        }

        private IEnumerable<int> GetPageNumbers()
        {
            var displayStartPage = Math.Max(PageContext.Offset - Spread, 0);
            var displayPageCount = Math.Min(_pageCount - displayStartPage, 2 * Spread + 1);

            if (displayStartPage > 0)
            {
                var countDifference = (2 * Spread) + 1 - displayPageCount;
                displayStartPage = Math.Max(displayStartPage - countDifference, 0);
                displayPageCount = Math.Min(_pageCount - displayStartPage, 2 * Spread + 1);
            }

            return Enumerable.Range(displayStartPage, displayPageCount);
        }

        private void OnSearchChanged()
        {
            _timer?.Dispose();
            _timer = new Timer(async _ =>
            {
                PageContext.Offset = 0;

                await PageContextChanged.InvokeAsync();

                StateHasChanged();
            }, null, 500, 0);
        }
    }
}
