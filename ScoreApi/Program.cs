using Microsoft.EntityFrameworkCore;
using ScoreApi.Migrations;
using ScoreApi.Models;
using ScoreApi.Types;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSpaStaticFiles(c => c.RootPath = "wwwroot");
builder.Services.AddPooledDbContextFactory<ScoreContext>(config => config.UseSqlite("score.db"));

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
