using SampleAppPractice.Data;

namespace SampleAppPractice.Models;

public class SmtpSettings : ISmtpSettings
{
    public int Port { get; }
    public string? Host { get; }
}