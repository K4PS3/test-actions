using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

WebApplication app
    = WebApplication.CreateBuilder(args)
        .Build();

app.MapGet("/", async context
    => await context.Response
        .WriteAsync("Hello Github!")
        .ConfigureAwait(false));

app.Run();
