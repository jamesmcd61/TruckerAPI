using System.Data.Common;

using TuckerAPIProject.Data;

using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TuckerAPIProject;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var startup = new Startup(builder.Configuration);

startup.ConfigureServices(builder.Services);

var app = builder.Build();

startup.Configure(app, app.Environment);

app.MapControllers();
app.Run();
