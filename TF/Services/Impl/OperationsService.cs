using TF.Model.Operation.Operations;
using TF.Model.Operation.Portfolio;

namespace TF.Services.Impl
{
    public class OperationsService : IOperationsService
    {
        private readonly IHttpRepository _httpRepository;

        private const string GET_PORTFOLIO = "tinkoff.public.invest.api.contract.v1.OperationsService/GetPortfolio";
        private const string GET_OPERATIONS = "tinkoff.public.invest.api.contract.v1.OperationsService/GetOperations";
        
        public OperationsService(IHttpRepository httpRepository)
        {
            _httpRepository = httpRepository;
        }

        public Task<PortfolioResponse> GetPortfolioAsync(PortfolioRequest portfolioRequestDto)
        {
            return _httpRepository.PostRequestAsync<PortfolioResponse>(
                $"{GET_PORTFOLIO}", portfolioRequestDto);
        }

        public Task<OperationsResponse> GetOperationsAsync(OperationsRequest operationRequestDto)
        {
            return _httpRepository.PostRequestAsync<OperationsResponse>(
                $"{GET_OPERATIONS}", operationRequestDto);
        }
    }
}
