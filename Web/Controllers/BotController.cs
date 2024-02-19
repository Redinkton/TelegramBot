using Application;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot.Types;

namespace Web.Controllers
{
    [ApiController]
    [Route("/")]
    public class BotController : ControllerBase
    {
        private readonly IBotService _botService;

        public BotController(IBotService botService)
        {
            _botService = botService;
        }

        [HttpPost]
        public void Post(Update update)
        {
            Console.WriteLine("Message received and sent to gRPC service.");

            if (!string.IsNullOrEmpty(update.Message.Text))
            {
                _botService.SendToGRPCService(update.Message.Text);
            }
            else
            {
                Console.WriteLine("Empty message");
            }
        }
    }
}