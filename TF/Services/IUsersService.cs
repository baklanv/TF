using TF.Model.User;

namespace TF.Services
{
    public interface IUsersService
    {
        Task<Account> GetAccountsAsync();

        Task<Info> GetInfoAsync();

        Task<MarginAttributes> GetMarginAttributesAsync(string accountId);

        Task<UserTaffir> GetUserTariffAsync();
    }
}
