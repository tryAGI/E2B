/*
order: 20
title: Templates
slug: templates

List available sandbox templates.
*/

namespace E2B.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListTemplates()
    {
        using var client = GetAuthenticatedClient();

        //// List all sandbox templates available in your team.
        var templates = await client.Templates.GetTemplatesAsync();

        Assert.IsNotNull(templates);
    }
}
