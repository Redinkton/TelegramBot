using Application;
using Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddNewtonsoftJson();

builder.Services.AddHttpClient();
builder.Services.AddScoped<IBotService, BotService>();

builder.Services.AddSingleton<IConfiguration>(builder.Configuration);


var app = builder.Build();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Run();
