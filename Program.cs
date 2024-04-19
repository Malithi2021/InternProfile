using InternProfile.Data;
using InternProfile.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlite("Data Source=Xternship.db"));


builder.Services.AddGrpc().AddJsonTranscoding();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<InternProfileService>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
