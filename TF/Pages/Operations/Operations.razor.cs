using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Infrastructure;
using TF.Enums.Operation;
using TF.Model.Operation.BrokerReport;
using TF.Model.Operation.DividendsForeignIssuer;
using TF.Model.Operation.Operations;
using TF.Model.Operation.OperationsByCursor;
using TF.Model.Operation.Portfolio;
using TF.Model.Operation.Positions;
using TF.Model.Operation.WithdrawLimits;
using TF.Services;

namespace TF.Pages.Operations
{
    public partial class Operations
    {
        [Inject]
        public IOperationsService OperationsService { get; set; }

        private bool _isLoadingFinish;
        private double Commission = 0;

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
            From = new(2021, 01, 01, 13, 45, 30, DateTimeKind.Utc) ,
            To = new(2023, 10, 10, 13, 45, 30, DateTimeKind.Utc) ,
            State = OperationState.OPERATION_STATE_EXECUTED,
            Figi = ""
        };

        private OperationsResponse OperationsResponse { get; set; }
        private PositionsRequest PositionsRequest { get; } = new()
        {
            AccountId = "2039490012",
        };

        private WithdrawLimitsRequest WithdrawLimitsRequest { get; } = new()
        {
            AccountId = "2039490012",
        };

        private BrokerReportRequest BrokerReportRequest { get; } = new()
        {
            GenerateBrokerReportRequest = new()
            {
                AccountId = "2039490012",
                From = new(2023, 09, 10, 13, 45, 30, DateTimeKind.Utc),
                To = new(2023, 10, 10, 13, 45, 30, DateTimeKind.Utc),
            }
        };

        private DividendsForeignIssuerRequest DividendsForeignIssuerRequest { get; } = new()
        {
            GenerateDivForeignIssuerReport = new()
            {
                AccountId = "2039490012",
                From = new(2023, 09, 10, 13, 45, 30, DateTimeKind.Utc),
                To = new(2023, 10, 10, 13, 45, 30, DateTimeKind.Utc),
            }
        };

        private OperationsByCursorRequest OperationsByCursorRequest { get; } = new()
        {
            AccountId = "2039490012",
            From = new(2022, 10, 10, 13, 45, 30, DateTimeKind.Utc),
            To = new(2023, 10, 10, 13, 45, 30, DateTimeKind.Utc),
        };

        private async Task GetPortfolioAsync()
        {
            //var hj = await OperationsService.GetPortfolioAsync(OperationRequest);
            //var hj12 = await OperationsService.GetPositionsAsync(PositionsRequest);
            //var hj1223 = await OperationsService.GetWithdrawLimitsAsync(WithdrawLimitsRequest);
            //var hj12wq = await OperationsService.GetBrokerReportAsync(BrokerReportRequest);
            //var hj1122 = await OperationsService.GetDividendsForeignIssuerAsync(DividendsForeignIssuerRequest);
            OperationsResponse = await OperationsService.GetOperationsAsync(OperationsRequest);
            //var hj12wdew = await OperationsService.GetOperationsByCursorAsync(OperationsByCursorRequest);
            
            // _OperationsPageResult = await OperationsService.GetPageAsync(_pageContext.Search, _pageContext.Limit, _pageContext.Offset);
            StateHasChanged();
        }


        protected async override Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            await GetPortfolioAsync();
            _isLoadingFinish = true;
        }

        private void CalculateTheCommission()
        {
            double commission = 0;
            double tax = 0;
            double taxCorrection = 0;
            Console.WriteLine("кол-во" + OperationsResponse.Operations.Count);
            foreach (var item in OperationsResponse.Operations)
            {
                if (item.OperationType == OperationType.OPERATION_TYPE_MARGIN_FEE)
                    commission += double.Parse(item.Payment.Units);
                if (item.OperationType == OperationType.OPERATION_TYPE_TAX)
                    tax += double.Parse(item.Payment.Units);
                if (item.OperationType == OperationType.OPERATION_TYPE_TAX_CORRECTION)
                    taxCorrection += double.Parse(item.Payment.Units);
            }

            Console.WriteLine("налог" + tax);
            Console.WriteLine("корректировка налога" + taxCorrection);
            Console.WriteLine("комиссия" + commission);

            Commission = commission;
        }

        private void CalculateTheTax()
        {
            double tax = 0;
            //Console.WriteLine("кол-во" + OperationsResponse.Operations.Count);
            foreach (var item in OperationsResponse.Operations)
            {
                if (item.OperationType == OperationType.OPERATION_TYPE_TAX)
                    tax += double.Parse(item.Payment.Units);
            }

            Console.WriteLine("налог" + tax);
            //Commission = commission;
        }
    }
}
