using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();
//mvc 
//rest api
//razer pages 
//{controller=Home}/{action=Index}/id?
//app.MapDefaultControllerRoute();
app.MapControllerRoute (
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);
app.Run();
