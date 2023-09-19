using Microsoft.AspNetCore.Mvc;
using SampleAppPractice.Data;
using SampleAppPractice.Models;
using SampleAppPractice.Services;

namespace SampleAppPractice.Controllers;

public class HomeController : Controller
{
    private readonly MessageService _service;
    private readonly IMessageFactory _factory;
    private readonly ISmtpClient _smtpClient;

    public HomeController(MessageService service, IMessageFactory factory, ISmtpClient client)
    {
        _service = service;
        _factory = factory;
        _smtpClient = client;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(string message)
    {
        SmtpMessage smtpMessage = _service.Create(message);
        _service.Send(smtpMessage);

        return View();
    }
}