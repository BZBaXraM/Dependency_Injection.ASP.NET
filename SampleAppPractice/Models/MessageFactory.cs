using SampleAppPractice.Data;

namespace SampleAppPractice.Models;

public class MessageFactory : IMessageFactory
{
    public SmtpMessage Create(string message)
    {
        return new SmtpMessage() { Body = message };
    }
}