using Microsoft.AspNetCore.Mvc;

namespace DisposingHostTwiceIssue.Controllers;

[ApiController]
[Route("[controller]")]
public class LifetimeController : ControllerBase
{
    private readonly IHostApplicationLifetime _hostApplicationLifetime;

    public LifetimeController(IHostApplicationLifetime hostApplicationLifetime)
    {
        _hostApplicationLifetime = hostApplicationLifetime;
    }

    [HttpGet]
    public void Stop()
    {
        _hostApplicationLifetime.StopApplication();
    }
}