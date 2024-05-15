using Microsoft.Extensions.Logging;
using MinerApp;

using ILoggerFactory factory = LoggerFactory.Create(builder =>
{
    builder.AddConsole();
});
ILogger logger = factory.CreateLogger("Program");


Miner miner = new Miner(logger);
miner.Mine();
