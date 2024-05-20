using Repository.Helpers;
using Repository.Models;

namespace Repository
{
    public class MoneyRepository : IRepository
    {
        private readonly MoneyContext _dbContext;

        public MoneyRepository() 
        {
            _dbContext = new MoneyContext();
        }

        public void AddCoins(int coins)
        {
            MoneyLog log = new MoneyLog();
            log.Date = DateTime.Now;
            log.Amount = coins;

            _dbContext.Add(log);

            MoneyTotal total = MoneyTotalMapper.Map(log);
            total.Total = coins;

            var lastRecord = _dbContext.MoneyTotals.OrderBy(r => r.Date).LastOrDefault();
            if (lastRecord is not null)
            {
                total.Total = coins + lastRecord.Total;
            }

            _dbContext.Add(total);
            _dbContext.SaveChanges();
        }

        public IEnumerable<MoneyLog> GetMoneyLogs()
        {
            var result = _dbContext.MoneyLogs;

            return result.ToList();
        }

        public MoneyTotal GetMoneyTotal()
        {
            var lastRecord = _dbContext.MoneyTotals.OrderBy(r => r.Date).LastOrDefault();
            
            if (lastRecord is not null)
            {
                return lastRecord;
            }

            return new MoneyTotal();
        }
    }
}
