using TF.Model.User;

namespace TF.Services.Impl
{
    public class UserService : IUsersService
    {
        private readonly IHttpRepository _httpRepository;

        private const string GET_ACCOUNTS = "tinkoff.public.invest.api.contract.v1.UsersService/GetAccounts";
        private const string GET_INFO = "tinkoff.public.invest.api.contract.v1.UsersService/GetInfo";
        private const string GET_MARGIN_ATTRIBUTES = "tinkoff.public.invest.api.contract.v1.UsersService/GetMarginAttributes";
        private const string GET_USER_TARIFF = "tinkoff.public.invest.api.contract.v1.UsersService/GetUserTariff";
        
        public UserService(IHttpRepository httpRepository)
        {
            _httpRepository = httpRepository;
        }

        public Task<Account> GetAccountsAsync()
        {
            return _httpRepository.PostRequestAsync<Account>($"{GET_ACCOUNTS}", new { });
        }

        public Task<Info> GetInfoAsync()
        {
            return _httpRepository.PostRequestAsync<Info>($"{GET_INFO}", new { });
        }

        public Task<MarginAttributes> GetMarginAttributesAsync(string accountId)
        {
            return _httpRepository.PostRequestAsync<MarginAttributes>($"{GET_MARGIN_ATTRIBUTES}", new { AccountId = accountId });
        }

        public Task<UserTaffir> GetUserTariffAsync()
        {
            return _httpRepository.PostRequestAsync<UserTaffir>($"{GET_USER_TARIFF}", new { });
        }
    }
}
