using Microsoft.AspNetCore.Components;
using TF.Enums.Operation;
using TF.Model.Operation.Operations;
using TF.Model.Operation.Portfolio;
using TF.Services;

namespace TF.Pages.Operations
{
    public partial class Operations
    {
        [Inject]
        public IOperationsService OperationsService { get; set; }

        private bool _isLoadingFinish;

        private PageResult<PortfolioResponse> _OperationsPageResult { get; set; } = new()
        {
            Data = Enumerable.Empty<PortfolioResponse>()
        };

        private PageContext _pageContext { get; } = new()
        {
            Offset = 0,
            Limit = 25

        };

        private PortfolioRequest OperationRequest { get; } = new()
        {
            AccountId = "2039490012",
            Currency = CurrencyRequest.RUB
        };

        private OperationsRequest OperationsRequest { get; } = new()
        {
            AccountId = "2039490012",
            From = new(2022, 10, 10, 13, 45, 30, DateTimeKind.Utc) ,
            To = new(2023, 10, 10, 13, 45, 30, DateTimeKind.Utc) ,
            State = OperationState.OPERATION_STATE_EXECUTED,
            Figi = ""
        };

        private async Task GetPortfolioAsync()
        {
            //var hj = await OperationsService.GetPortfolioAsync(OperationRequest);
            var hj12 = await OperationsService.GetOperationsAsync(OperationsRequest);
            // _OperationsPageResult = await OperationsService.GetPageAsync(_pageContext.Search, _pageContext.Limit, _pageContext.Offset);
            StateHasChanged();
        }


        protected async override Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            await GetPortfolioAsync();
            _isLoadingFinish = true;
        }

        /*private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
        }*/
    }
}
