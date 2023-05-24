namespace DisposingHostTwiceIssue;

public class MyHostedService : IHostedService
{
    private readonly ILogger<MyHostedService> _logger;

    public MyHostedService(ILogger<MyHostedService> logger)
    {
        _logger = logger;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _logger.LogError("StopAsync called from MyHostedService");
        return Task.CompletedTask;
    }
}
