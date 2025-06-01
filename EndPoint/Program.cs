using EndPoint.Context;
using EndPoint.Repository;
using EndPoint.Services.Impelementations;
using EndPoint.Services.Interfaces;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// اگر ASP.NET Core 6 یا بالاتر هستی (Program.cs):
builder.Services.AddDbContext<MardipourDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MardipourConnection")));

// 3️ ثبت Generic Repository در DI container 👇
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));


builder.Services.AddScoped<IProductService, ProductService>();

var app = builder.Build();




// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
