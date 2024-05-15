using Repository.Models;

namespace Repository.Helpers
{
    public static class MoneyTotalMapper
    {
        public static MoneyTotal Map(MoneyLog log)
        {
            MoneyTotal total = new MoneyTotal();
            total.Date = log.Date;

            return total;
        }
    }
}
