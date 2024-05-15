using Microsoft.Extensions.Logging;
using Repository;

namespace MinerApp
{
    public class Miner
    {
        private readonly ILogger _logger;
        private readonly IRepository _repository;
        private int _totalCoins = 0;

        public Miner(ILogger logger, IRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        private void AddCoins()
        {
            Random rnd = new Random();           
            int coinsToAdd = rnd.Next(10, 50);
            _totalCoins += coinsToAdd;

            _repository.AddCoins(coinsToAdd);

            _logger.LogInformation("Added {} coins.", coinsToAdd);
            _logger.LogInformation("Total amount is {} coins.", _totalCoins);
        }

        public void Mine()
        {
            Random rnd = new Random();
            bool doWork = true;
            while (doWork)
            {
                var timer = 1000 * rnd.Next(1, 10);
                Thread.Sleep(timer);

                AddCoins();
            }
        }
    }
}
