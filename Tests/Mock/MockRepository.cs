using Repository;
using Repository.Models;

namespace Tests.Mock
{
    public class MockRepository : IRepository
    {
        public void AddCoins(int coins)
        {
        }

        public IEnumerable<MoneyLog> GetMoneyLogs()
        {
            return new List<MoneyLog>();
        }

        public MoneyTotal GetMoneyTotal()
        {
            return new MoneyTotal { Total = 15 };
        }
    }
}
