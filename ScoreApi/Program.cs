using ScoreApi.Types;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSpaStaticFiles(c => c.RootPath = "wwwroot");

builder.AddGraphQL()
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
