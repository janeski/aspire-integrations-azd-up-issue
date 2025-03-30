var builder = DistributedApplication.CreateBuilder(args);

var postgres = builder.AddPostgres("postgres")
    .WithEnvironment("POSTGRES_DB", "postgres")
    .WithPgAdmin();

var db = postgres.AddDatabase("db");

builder.Build().Run();
