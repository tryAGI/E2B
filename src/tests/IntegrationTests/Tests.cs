namespace E2B.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static E2BClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("E2B_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("E2B_API_KEY environment variable is not found.");

        var client = new E2BClient(apiKey);
        
        return client;
    }
}
