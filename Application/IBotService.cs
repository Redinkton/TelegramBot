namespace Application
{
    public interface IBotService
    {
        Task SendToGRPCService(string text);
    }
}
