using SampleAppPractice.Models;

namespace SampleAppPractice.Data;

public interface IMessageFactory
{
    SmtpMessage Create(string message);
}