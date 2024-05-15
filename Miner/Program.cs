using Microsoft.Extensions.Logging;
using MinerApp;
using Repository;

using ILoggerFactory factory = LoggerFactory.Create(builder =>
{
    builder.AddConsole();
});
ILogger logger = factory.CreateLogger("Program");

IRepository repository = new MoneyRepository();

Miner miner = new Miner(logger, repository);
miner.Mine();
