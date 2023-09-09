using BlazorApp.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;


// Critical
// Error
// Warning
// Information 
// Debug
// Trace


var builder = WebApplication.CreateBuilder(args);

// Logging Configuration


// Turns off all the existing logging we can turn o various loggers
builder.Logging.ClearProviders();


// Kestrel Console
builder.Logging.AddConsole();

// turns on Output window
builder.Logging.AddDebug();





// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
