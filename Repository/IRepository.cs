using Repository.Models;

namespace Repository
{
    public interface IRepository
    {
        void AddCoins(int coins);
        MoneyTotal GetMoneyTotal();
        IEnumerable<MoneyLog> GetMoneyLogs();
    }
}
