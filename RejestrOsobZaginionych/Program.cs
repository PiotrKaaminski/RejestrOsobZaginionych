using RejestrOsobZaginionych.DAL.DbContext;
using RejestrOsobZaginionych.Services.MissingPerson;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// @@@ Database @@@
builder.Services.AddScoped<RozDbContext>();

// @@@ Data Access Layer @@@

// @@@ Web services @@@
// Missing person services
builder.Services.AddScoped<GetMissingPersonService>();

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