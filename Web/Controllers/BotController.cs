using Microsoft.AspNetCore.Mvc;
using Telegram.Bot.Types;

namespace Web.Controllers
{
    [ApiController]
    [Route("/")]
    public class BotController : ControllerBase
    {
        [HttpPost]
        public void Post(Update update)
        {
            Console.WriteLine(update.Message.Text);
        }
    }
}