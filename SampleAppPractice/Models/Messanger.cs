using SampleAppPractice.Data;

namespace SampleAppPractice.Models;

public class Messenger
{
    private readonly ISmtpClient _client;
    private readonly IMessageFactory _factory;

    public Messenger(ISmtpClient client, IMessageFactory factory)
    {
        _client = client;
        _factory = factory;
    }

    public void SendMessage(string message, string user)
    {
        var smtpMessage = _factory.Create(message);
        _client.Send(smtpMessage);
    }
}
