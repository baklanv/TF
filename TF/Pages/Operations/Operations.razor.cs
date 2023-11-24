using Microsoft.AspNetCore.Components;
using TF.Enums.Operation;
using TF.Model.Operation.Operations;
using TF.Services;

namespace TF.Pages.Operations
{
    public partial class Operations
    {
        [Inject]
        public IOperationsService OperationsService { get; set; }

        private bool _isLoadingFinish;
        private double Commission = 0;

        private OperationsResponse OperationsMargin { get; set; } = new()
        { 
            Operations = new()
        };
		private OperationsResponse OperationsTax { get; set; } = new()
		{
			Operations = new()
		};
		private OperationsResponse OperationsTaxCorrection { get; set; } = new()
		{
			Operations = new()
		};
		

		private OperationsRequest OperationsRequest { get; } = new()
        {
            AccountId = "2039490012",
            From = new(2020, 01, 01, 13, 45, 30, DateTimeKind.Utc) ,
            To = new(2020, 07, 01, 13, 45, 30, DateTimeKind.Utc) ,
            State = OperationState.OPERATION_STATE_EXECUTED,
            Figi = ""
        };

        private OperationsResponse OperationsResponse { get; set; }

        private async Task GetPortfolioAsync()
        {
			OperationsResponse = await OperationsService.GetOperationsAsync(OperationsRequest);

			while (OperationsRequest.To <  DateTime.Now) 
            {
				DateTime From = OperationsRequest.From.AddMonths(6);
				DateTime To = OperationsRequest.To.AddMonths(6);

				OperationsRequest.From = From;
                OperationsRequest.To = To;

                OperationsResponse.Operations.AddRange((await OperationsService.GetOperationsAsync(OperationsRequest)).Operations);
            }

            OperationsResponse.Operations.Sort();

			CreateLists();

			StateHasChanged();
        }

		private async Task CreateLists()
		{
			foreach (var item in OperationsResponse.Operations)
			{
                if (item.OperationType == OperationType.OPERATION_TYPE_MARGIN_FEE)
                    OperationsMargin.Operations.Add(item);
                if (item.OperationType == OperationType.OPERATION_TYPE_TAX)
                    OperationsTax.Operations.Add(item);
				if (item.OperationType == OperationType.OPERATION_TYPE_TAX_CORRECTION)
					OperationsTaxCorrection.Operations.Add(item);
			}
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
