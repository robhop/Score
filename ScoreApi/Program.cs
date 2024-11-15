using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using ScoreApi.Types;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "Cors",
                      policy  =>
                      {
                          policy.WithOrigins("http://localhost:5173");
                          policy.WithExposedHeaders("content-type");
                      });
});
builder.AddGraphQL()
    .AddSubscriptionType<SubscriptionType>()
    .AddMutationType<Mutation>()
    .AddInMemorySubscriptions()
    .AddTypes();

var app = builder.Build();
app.UseWebSockets();

var options = new DefaultFilesOptions();
options.DefaultFileNames.Clear();
options.DefaultFileNames.Add("index.html");
app.UseDefaultFiles(options);
app.UseStaticFiles();
app.MapGraphQL();

app.RunWithGraphQLCommands(args);
