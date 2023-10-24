using TF.Enums.Account;

namespace TF.Model.User
{
    public class Account
    {
        /// <summary>
        /// Идентификатор счёта. 
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Тип счёта. 
        /// </summary>
        public AccountType AccountType { get; set; }

        /// <summary>
        /// Название счёта. 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Статус счёта. 
        /// </summary>
        public AccountStatus AccountStatus { get; set; }

        /// <summary>
        /// Дата открытия счёта в часовом поясе UTC.
        /// </summary>
        public DateTime OpenedDate { get; set; }

        /// <summary>
        /// Дата закрытия счёта в часовом поясе UTC. 
        /// </summary>
        public DateTime ClosedDate { get; set; }

        /// <summary>
        /// Уровень доступа к текущему счёту (определяется токеном). 
        /// </summary>
        public AccessLevel AccessLevel { get; set; }
    }
}
