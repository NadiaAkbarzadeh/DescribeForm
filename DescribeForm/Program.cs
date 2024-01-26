using DescribeForm.Models;
using Microsoft.EntityFrameworkCore;
using DescribeForm.Repositories.Implementation;
using DescribeForm.Repositories.Interface;
using DescribeForm.Services.Implementation;
using DescribeForm.Services.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<ApplicationDbContext>(op => {
    op.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddScoped<IDescribeRepository, DescribeRepository>();
builder.Services.AddScoped<ICommandDescribeService, CommandDescribeService>();
builder.Services.AddScoped<IDescribesService, DescribesService>();
//builder.Services.AddScoped<IUserService, UserService>();

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
    pattern: "{controller=Describe}/{action=Index}/{id?}");

app.Run();
