var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Add services to the container.
builder.Services.AddControllersWithViews();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.MapControllerRoute(
    name: "story",
    pattern: "story/{alias}",
    defaults: new { controller = "Pages", action = "Story" });


app.MapControllerRoute(
    name: "cat",
    pattern: "category/{alias}",
    defaults: new { controller = "Pages", action = "Category" });

app.Run();
