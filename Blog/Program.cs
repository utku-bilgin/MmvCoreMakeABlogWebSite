using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Blog.Data;
using Blog.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("BlogContextConnection") ?? throw new InvalidOperationException("Connection string 'BlogContextConnection' not found.");

//****************************************************************************************
var connectionStringData = builder.Configuration.GetConnectionString("BlogDataContextConnection") ?? throw new InvalidOperationException("Connection string 'BlogDataContextConnection' not found.");
//****************************************************************************************



builder.Services.AddDbContext<BlogContext>(options =>
    options.UseSqlServer(connectionString));

//****************************************************************************************
builder.Services.AddDbContext<BlogDataDbContext>(options =>
    options.UseSqlServer(connectionStringData));
//****************************************************************************************


builder.Services.AddDefaultIdentity<BlogUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<BlogContext>();


// Add services to the container.
builder.Services.AddControllersWithViews();


//****************************************************************************************
//Areas ra bulunan Identity Pages sayfalarýný görüntüleyebilmek için
builder.Services.AddRazorPages();
//****************************************************************************************



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
app.UseAuthentication();;

app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

//****************************************************************************************
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name:"MyArea",
        pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
        );

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
        );

    endpoints.MapRazorPages();
});
//****************************************************************************************

app.Run();
