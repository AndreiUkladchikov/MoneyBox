using Domain.Constants;
using Domain.Helpers;
using Domain.Interfaces;
using Domain.Models;
using Repository;

namespace Domain.Services
{
    public class MoneyProvider : IMoneyProvider
    {
        private readonly IRepository _repository;
        public MoneyProvider(IRepository repository) 
        { 
            _repository = repository;
        }

        public MoneyDto GetMoneyTotal()
        {
            var total = _repository.GetMoneyTotal();
            return MoneyMapper.Map(total);
        }

        public string WithdrawMoney(int withdraw)
        {
            var money = _repository.GetMoneyTotal();
            
            if (withdraw > money.Total)
            {
                return Messages.ERROR;
            }

            _repository.AddCoins(-withdraw);
            return Messages.SUCCESS;
        }

        public IEnumerable<MoneyLogDto> GetMoneyLogs()
        {
            List<MoneyLogDto> result = new List<MoneyLogDto>();

            var logs = _repository.GetMoneyLogs();

            foreach ( var log in logs )
            {
                result.Add(MoneyLogMapper.Map(log));
            }

            return result;
        }
    }
}
