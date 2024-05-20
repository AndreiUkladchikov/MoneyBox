using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoneyHistoryController : ControllerBase
    {
        private readonly ILogger<MoneyController> _logger;
        private readonly IMoneyProvider _moneyProvider;

        public MoneyHistoryController(ILogger<MoneyController> logger, IMoneyProvider moneyProvider)
        {
            _logger = logger;
            _moneyProvider = moneyProvider;
        }

        [HttpGet(Name = "GetMoneyHistory")]
        public IEnumerable<MoneyLogDto> Get()
        {
            return _moneyProvider.GetMoneyLogs();
        }
    }
}
