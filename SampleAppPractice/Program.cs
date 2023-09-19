using SampleAppPractice.Data;
using SampleAppPractice.Models;
using SampleAppPractice.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IMessageFactory, MessageFactory>();
builder.Services.AddSingleton<ISmtpSettings, SmtpSettings>();
builder.Services.AddSingleton<ISmtpClient, SmtpClient>();
builder.Services.AddSingleton<MessageService>();
var app = builder.Build();

app.MapDefaultControllerRoute();

app.Run();