using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoneyController : ControllerBase
    {
        private readonly ILogger<MoneyController> _logger;
        private readonly IMoneyProvider _moneyProvider;

        public MoneyController(ILogger<MoneyController> logger, IMoneyProvider moneyProvider)
        {
            _logger = logger;
            _moneyProvider = moneyProvider;
        }

        [HttpGet(Name = "GetMoneyTotal")]
        public MoneyDto Get()
        {
            return _moneyProvider.GetMoneyTotal();
        }

        [HttpPost(Name = "WithdrawMoney")]
        public string Post(int withdraw)
        {
            return _moneyProvider.WithdrawMoney(withdraw);
        }
    }
}
