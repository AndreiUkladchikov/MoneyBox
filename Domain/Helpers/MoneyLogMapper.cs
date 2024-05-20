using Domain.Models;
using Repository.Models;

namespace Domain.Helpers
{
    public static class MoneyLogMapper
    {
        public static MoneyLogDto Map(MoneyLog moneyLog)
        {
            return new MoneyLogDto
            {
                Date = moneyLog.Date,
                Amount = moneyLog.Amount,
            };
        }
    }
}
