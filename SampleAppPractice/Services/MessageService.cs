using System.Diagnostics;
using SampleAppPractice.Data;
using SampleAppPractice.Models;

namespace SampleAppPractice.Services;

public class MessageService
{
    private readonly IMessageFactory _factory;
    private readonly ISmtpClient _client;
    private readonly ISmtpSettings _settings;

    public MessageService(IMessageFactory factory, ISmtpClient client, ISmtpSettings settings)
    {
        _factory = factory;
        _client = client;
        _settings = settings;
    }
    
    public SmtpMessage Create(string message)
    {
        return new SmtpMessage() { Body = message };
    }

    public void Send(SmtpMessage smtpMessage)
    {
        _client.Send(smtpMessage);
    }
}