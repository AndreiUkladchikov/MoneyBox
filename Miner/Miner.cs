using Microsoft.Extensions.Logging;

namespace MinerApp
{
    public class Miner
    {
        private readonly ILogger _logger;     
        private int _totalCoins = 0;

        public Miner(ILogger logger)
        {
            _logger = logger;               
        }

        private void AddCoins()
        {
            Random rnd = new Random();           
            int coinsToAdd = rnd.Next(10, 50);
            _totalCoins += coinsToAdd;

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
