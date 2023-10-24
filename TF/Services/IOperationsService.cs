using TF.Model.Operation.Operations;
using TF.Model.Operation.Portfolio;

namespace TF.Services
{
    public interface IOperationsService
    {
        Task<PortfolioResponse> GetPortfolioAsync(PortfolioRequest operationRequestDto);
        Task<OperationsResponse> GetOperationsAsync(OperationsRequest operationRequestDto);
    }
}
