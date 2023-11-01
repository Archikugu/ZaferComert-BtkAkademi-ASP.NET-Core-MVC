using Microsoft.EntityFrameworkCore;
using StoreApp.Entities.Models;
using StoreApp.Models;
using StoreApp.Repositories;
using StoreApp.Repositories.Contracts;
using StoreApp.Services;
using StoreApp.Services.Contracts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddDbContext<RepositoryContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection"), b => b.MigrationsAssembly("StoreApp.Repositories"));
});

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(opt =>
{
    opt.Cookie.Name = "StoreApp.Session";
    opt.IdleTimeout = TimeSpan.FromMinutes(10);
});

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();

builder.Services.AddScoped<IServiceManager, ServiceManager>();
builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IOrderService, OrderManager>();

builder.Services.AddScoped<Cart>(c => SessionCart.GetCart(c));

builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

app.UseStaticFiles();
app.UseSession();

app.UseHttpsRedirection();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(name: "Admin", areaName: "Admin", pattern: "Admin/{controller=Dashboard}/{action=Index}/{id?}");
    endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
    endpoints.MapRazorPages();
});



app.Run();
