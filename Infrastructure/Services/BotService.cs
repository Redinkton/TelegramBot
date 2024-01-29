using Application;
using Domain;

namespace Infrastructure.Services
{
    public class BotService : IBotService
    {
        private readonly HttpClient _httpClient;
        public BotService(HttpClient httpClient) 
        {
            _httpClient = new HttpClient();
        }
        public async Task<string> GetUpdates()
        {
            string apiUrl = $"https://api.telegram.org/bot{Bot.ApiKey}/getUpdates";

            var response = await _httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                // Process the received data
                return responseBody;
            }
            else
            {
                // Handle the error
            }
        }
    }
}
