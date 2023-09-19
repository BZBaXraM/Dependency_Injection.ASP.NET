using SampleAppPractice.Models;

namespace SampleAppPractice.Data;

public interface ISmtpClient
{
    void Send(SmtpMessage smtpMessage);
}