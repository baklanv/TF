using TF.Model.Operation.BrokerReport;
using TF.Model.Operation.DividendsForeignIssuer;
using TF.Model.Operation.Operations;
using TF.Model.Operation.OperationsByCursor;
using TF.Model.Operation.Portfolio;
using TF.Model.Operation.Positions;
using TF.Model.Operation.WithdrawLimits;

namespace TF.Services.Impl
{
    public class OperationsService : IOperationsService
    {
        private readonly IHttpRepository _httpRepository;

        private const string GET_BROKER_REPORT = "tinkoff.public.invest.api.contract.v1.OperationsService/GetBrokerReport";
        private const string GET_DIVIDENDS_FOREIGN_ISSUER = "tinkoff.public.invest.api.contract.v1.OperationsService/GetDividendsForeignIssuer";
        private const string GET_OPERATIONS = "tinkoff.public.invest.api.contract.v1.OperationsService/GetOperations";
        private const string GET_OPERATIONS_BY_CURSOR = "tinkoff.public.invest.api.contract.v1.OperationsService/GetOperationsByCursor";
        private const string GET_PORTFOLIO = "tinkoff.public.invest.api.contract.v1.OperationsService/GetPortfolio";
        private const string GET_POSITIONS = "tinkoff.public.invest.api.contract.v1.OperationsService/GetPositions";
        private const string GET_WITHDRAW_LIMITS = "tinkoff.public.invest.api.contract.v1.OperationsService/GetWithdrawLimits";

        public OperationsService(IHttpRepository httpRepository)
        {
            _httpRepository = httpRepository;
        }

        public Task<BrokerReportResponse> GetBrokerReportAsync(BrokerReportRequest brokerReportRequest)
        {
            return _httpRepository.PostRequestAsync<BrokerReportResponse>(
                $"{GET_BROKER_REPORT}", brokerReportRequest);
        }

        public Task<DividendsForeignIssuerResponse> GetDividendsForeignIssuerAsync(DividendsForeignIssuerRequest dividendsForeignIssuerRequest)
        {
            return _httpRepository.PostRequestAsync<DividendsForeignIssuerResponse>(
                $"{GET_DIVIDENDS_FOREIGN_ISSUER}", dividendsForeignIssuerRequest);
        }
        
        public Task<OperationsResponse> GetOperationsAsync(OperationsRequest operationsRequest)
        {
            return _httpRepository.PostRequestAsync<OperationsResponse>(
                $"{GET_OPERATIONS}", operationsRequest);
        }

        public Task<OperationsByCursorResponse> GetOperationsByCursorAsync(OperationsByCursorRequest operationsByCursorRequest)
        {
            return _httpRepository.PostRequestAsync<OperationsByCursorResponse>(
                $"{GET_OPERATIONS_BY_CURSOR}", operationsByCursorRequest);
        }

        public Task<PortfolioResponse> GetPortfolioAsync(PortfolioRequest portfolioRequest)
        {
            return _httpRepository.PostRequestAsync<PortfolioResponse>(
                $"{GET_PORTFOLIO}", portfolioRequest);
        }

        public Task<PositionsResponse> GetPositionsAsync(PositionsRequest positionsRequest)
        {
            return _httpRepository.PostRequestAsync<PositionsResponse>(
                $"{GET_POSITIONS}", positionsRequest);
        }

        public Task<WithdrawLimitsResponse> GetWithdrawLimitsAsync(WithdrawLimitsRequest withdrawLimitsRequest)
        {
            return _httpRepository.PostRequestAsync<WithdrawLimitsResponse>(
                $"{GET_WITHDRAW_LIMITS}", withdrawLimitsRequest);
        }
    }
}
