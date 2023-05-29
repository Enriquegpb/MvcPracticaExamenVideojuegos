using Microsoft.EntityFrameworkCore;
using MvcPracticaExamenVideojuegos.Data;
using MvcPracticaExamenVideojuegos.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string connectionString = builder.Configuration.GetConnectionString("PostGresSqlVideojuegos");
builder.Services.AddDbContext<VideoJuegosContext>(options => options.UseNpgsql(connectionString));
builder.Services.AddTransient<RepositoryVideoJuegos>();
builder.Services.AddControllersWithViews();

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
	pattern: "{controller=VideoJuegos}/{action=Index}/{id?}");

app.Run();
