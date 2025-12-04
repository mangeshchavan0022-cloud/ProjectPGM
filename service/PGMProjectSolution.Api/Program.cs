using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PGMProjectSolution.Application.Interfaces;
using PGMProjectSolution.Application.Services;
using PGMProjectSolution.Infrastructure.Context;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IAspNetUsers, AspNetUsersService>();
builder.Services.AddTransient<IAspNetRole, AspNetRoleService>();
builder.Services.AddTransient<IAspPgOwnerService, AspNetPgOwnerService>();
builder.Services.AddTransient<IAgenciesService, AgencyService>();
builder.Services.AddTransient<IUIMenuService, UIMenuService>();
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));






var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
