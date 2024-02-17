var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Logout}");


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=UpdateEmail}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=ChangePassword}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Faq}");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Documentation}");




app.Run();