using uppfinnaren_1_0_MilicaBl.Models;
using Microsoft.EntityFrameworkCore;
using uppfinnaren_1_0_MilicaBl.Models.About;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// builder.Services.AddScoped<IProductRepository, MockProductRepository>();
// builder.Services.AddScoped<ICategoryRepository, MockCategoryRepository>();
builder.Services.AddScoped<IProductRepository, DatabaseProductRepository>();
builder.Services.AddScoped<ICategoryRepository, DatabaseCategoryRepository>();
builder.Services.AddScoped<IMaterialRepository, DatabaseMaterialRepository>();
builder.Services.AddScoped<IAboutUsRepository, AboutUsRepository>();
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options=>
    options.UseInMemoryDatabase("uppfinnaren")
);

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
