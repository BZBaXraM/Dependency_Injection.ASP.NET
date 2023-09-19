using System.Diagnostics;
using SampleAppPractice.Data;

namespace SampleAppPractice.Models;

public class SmtpClient : ISmtpClient
{
    private readonly ISmtpSettings _settings;

    public SmtpClient(ISmtpSettings settings)
    {
        _settings = settings;
    }

    public void Send(SmtpMessage smtpMessage)
    {
        Debug.WriteLine("Message sent by SmtpClient.");
    }
}


public class SmtpMessage
{
    public string? Body { get; internal set; }
}