using Microsoft.EntityFrameworkCore;
using ScoreApi.Models;
using ScoreApi.Types;


var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();
builder.Logging.AddConsole();

builder.Services.AddSpaStaticFiles(c => c.RootPath = "wwwroot");
builder.Services.AddPooledDbContextFactory<ScoreContext>(config => config.UseSqlite("Data Source=score.db"));

builder.AddGraphQL()
    .RegisterDbContextFactory<ScoreContext>()
    .AddSubscriptionType<SubscriptionType>()
    .AddMutationType<Mutation>()
    .AddInMemorySubscriptions()
    .AddTypes();

var app = builder.Build();
app.MapGraphQL();
app.UseWebSockets();
app.UseDefaultFiles();
app.UseSpaStaticFiles();
app.UseSpa(c => c.Options.SourcePath = "/wwwwroot");

app.RunWithGraphQLCommands(args);
