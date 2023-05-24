using Microsoft.AspNetCore.Mvc.Testing;

namespace TestProject;

public class IntegrationTest
    : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public IntegrationTest(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Fact]
    public async Task Test1()
    {
        // Arrange
        var client = _factory.CreateClient();

        // Act
        using var response = await client.GetAsync("lifetime");

        // Assert
        response.EnsureSuccessStatusCode(); // Status Code 200-299
    }
}