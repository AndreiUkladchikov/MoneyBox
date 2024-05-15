using Repository.Models;

namespace Repository.Helpers
{
    public static class MoneyLogMapper
    {
        public static MoneyLog Map(MoneyTotal money)
        {
            MoneyLog log = new MoneyLog();
            log.Date = money.Date;

            return log;
        }
    }
}
