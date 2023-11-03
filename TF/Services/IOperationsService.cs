using TF.Model.Operation.BrokerReport;
using TF.Model.Operation.DividendsForeignIssuer;
using TF.Model.Operation.Operations;
using TF.Model.Operation.OperationsByCursor;
using TF.Model.Operation.Portfolio;
using TF.Model.Operation.Positions;
using TF.Model.Operation.WithdrawLimits;

namespace TF.Services
{
    public interface IOperationsService
    {
        Task<BrokerReportResponse> GetBrokerReportAsync(BrokerReportRequest brokerReportRequest);

        Task<DividendsForeignIssuerResponse> GetDividendsForeignIssuerAsync(DividendsForeignIssuerRequest dividendsForeignIssuerRequest);

        Task<OperationsResponse> GetOperationsAsync(OperationsRequest operationsRequest);

        Task<OperationsByCursorResponse> GetOperationsByCursorAsync(OperationsByCursorRequest operationsByCursorRequest);

        Task<PortfolioResponse> GetPortfolioAsync(PortfolioRequest portfolioRequest);

        Task<PositionsResponse> GetPositionsAsync(PositionsRequest positionsRequest);

        Task<WithdrawLimitsResponse> GetWithdrawLimitsAsync(WithdrawLimitsRequest withdrawLimitsRequest);
    }
}
