using Microsoft.AspNetCore.ResponseCompression;
using DecisoesEmGrupo.Server.Context;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using DecisoesEmGrupo.Shared.Models;
using Microsoft.Extensions.Configuration;
using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IConfiguration config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .AddEnvironmentVariables()
    .Build();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
    
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
//builder.Services.AddDbContext<DatabaseDbContext>(o=>o.UseSqlServer(config.GetConnectionString("Decisoesemgrupodb")));
builder.Services.AddDbContext<DatabaseDbContext>();
builder.Services.AddControllersWithViews().AddJsonOptions(options => {
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
    options.JsonSerializerOptions.PropertyNamingPolicy = null;
});

//DatabaseDbContext db = new();
//var res = await db.Database.EnsureCreatedAsync();
//Console.WriteLine("Db criada:" + res);



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//using (var db = new DatabaseDbContext())
//{
//    await db.Database.EnsureCreatedAsync();
//    Utilizador user = new() { Username = "Ricardo" };
//    db.Proposta.Add(new Proposta());
//    db.Utilizador.Add(user);
//    db.SaveChanges();
//}
app.Logger.LogInformation("LogInformação");


//var db = app.Services.GetService<DatabaseDbContext>();

//if(db!=null)
//{
//    Console.WriteLine("EnsureCreated");
//    db.Database.EnsureCreated();
//}
//else
//{
//    Console.WriteLine("db==null");
//}
DatabaseDbContext database = new DatabaseDbContext();
database.Database.EnsureCreated();

app.UseWebAssemblyDebugging();

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");
//app.MapGet("/db", ()=>db.Database.EnsureCreated());

app.Run();

