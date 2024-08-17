using Microsoft.EntityFrameworkCore;
using Scrape.Worker;
using ScrapeAPI.Data;


var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();

builder.Services.AddDbContext<ScrapeContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var host = builder.Build();
await host.RunAsync();
