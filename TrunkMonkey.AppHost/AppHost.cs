var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.TrunkMonkey>("trunkmonkey");

builder.Build().Run();
