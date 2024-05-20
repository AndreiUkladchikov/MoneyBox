using Domain.Models;

namespace Domain.Interfaces
{
    public interface IMoneyProvider
    {
        MoneyDto GetMoneyTotal();
        string WithdrawMoney(int withdraw);
        IEnumerable<MoneyLogDto> GetMoneyLogs();
    }
}
