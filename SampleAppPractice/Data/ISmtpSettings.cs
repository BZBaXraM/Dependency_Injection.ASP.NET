namespace SampleAppPractice.Data;

public interface ISmtpSettings
{
    public int Port { get; }
    public string? Host { get; }
}