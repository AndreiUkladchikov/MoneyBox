using Domain.Models;
using Repository.Models;

namespace Domain.Helpers
{
    public static class MoneyMapper
    {
        public static MoneyDto Map(MoneyTotal money)
        {
            return new MoneyDto
            {
                Total = money.Total,
            };
        }
    }
}
