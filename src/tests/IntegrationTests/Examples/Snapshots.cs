/*
order: 30
title: Snapshots
slug: snapshots

List sandbox snapshots for resuming paused sandboxes.
*/

namespace E2B.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListSnapshots()
    {
        using var client = GetAuthenticatedClient();

        //// List all snapshots with pagination.
        var snapshots = await client.Snapshots.GetSnapshotsAsync(
            limit: 10);

        Assert.IsNotNull(snapshots);
    }
}
