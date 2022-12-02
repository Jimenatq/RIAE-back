using back_riae.Models;
using back_riae.Models.Repository;
using FluentAssertions.Common;
using Microsoft.EntityFrameworkCore;


IConfiguration configuration = new ConfigurationBuilder()

  .AddJsonFile("appsettings.json")

  .Build();


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRazorPages();

builder.Services.AddDbContext<AplicationDbContext>(
    options =>
    {
        options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    //app.UseSwagger();
    //app.UseSwaggerUI();
//}
if (!app.Environment.IsDevelopment())

{

    app.UseExceptionHandler("/Home/Error");

    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.

    app.UseHsts();

}
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();
app.MapControllers();

//app.MapControllerRoute(
 //   name: "default",

 //  pattern: "{controller=Home}/{action=Index}/{id?}");

//app.MapControllerRoute(

//   name: "MyArea",

 //  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.Run();

builder.Services.AddTransient<ItipoRepository, tipoRepository>();
