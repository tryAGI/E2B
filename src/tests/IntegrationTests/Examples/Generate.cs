/*
order: 10
title: List Sandboxes
slug: list-sandboxes

Basic example showing how to create a client and list running sandboxes.
*/

namespace E2B.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListSandboxes()
    {
        using var client = GetAuthenticatedClient();

        //// List all currently running sandboxes.
        var sandboxes = await client.Sandboxes.GetSandboxesAsync();

        Assert.IsNotNull(sandboxes);
    }
}
