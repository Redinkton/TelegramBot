using Application;
using Grpc.Net.Client;
using TelegramBot;

namespace Infrastructure.Services
{
    public class BotService : IBotService
    {
        public async Task SendToGRPCService(string text)
        {
            try
            {
                using var channel = GrpcChannel.ForAddress("https://localhost:7002");

                var client = new Messages.MessagesClient(channel);
                var response = await client.ProcessMessageAsync(new MessageRequest { Text = text });

                Console.WriteLine(response.Result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
