using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UserIdentification : ControllerBase {
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<UserIdentification> _logger;

    public UserIdentification(ILogger<UserIdentification> logger) {
        _logger = logger;
    }

    [HttpGet("{name}")]
    public String Get(String name) {
        return "Hello " + name + "!";
    }
}
