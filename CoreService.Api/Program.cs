using CoreService.Api.Extensions;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCustomExceptionHandling();
app.UseCorrelationId();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();
app.Run();