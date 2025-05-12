var builder = DistributedApplication.CreateBuilder(args);

builder.AddAzureContainerAppEnvironment("empty-env");

var postgres = builder.AddPostgres("postgres")
    .WithEnvironment("POSTGRES_DB", "postgres")
    .WithPgAdmin();

var db = postgres.AddDatabase("db");

builder.Build().Run();
