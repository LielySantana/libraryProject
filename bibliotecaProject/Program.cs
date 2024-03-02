using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using bibliotecaProject.Data;
using bibliotecaProject.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<PagesUsuariosContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("PagesUsuariosContext") ?? throw new InvalidOperationException("Connection string 'PagesUsuariosContext' not found.")));
builder.Services.AddDbContext<PagesTiposBibliografiaContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("PagesTiposBibliografiaContext") ?? throw new InvalidOperationException("Connection string 'PagesTiposBibliografiaContext' not found.")));
builder.Services.AddDbContext<PagesPrestamosContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("PagesPrestamosContext") ?? throw new InvalidOperationException("Connection string 'PagesPrestamosContext' not found.")));
builder.Services.AddDbContext<PagesLibrosContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("PagesLibrosContext") ?? throw new InvalidOperationException("Connection string 'PagesLibrosContext' not found.")));
builder.Services.AddDbContext<PagesIdiomasContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("PagesIdiomasContext") ?? throw new InvalidOperationException("Connection string 'PagesIdiomasContext' not found.")));
builder.Services.AddDbContext<PagesEmpleadosContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("PagesEmpleadosContext") ?? throw new InvalidOperationException("Connection string 'PagesEmpleadosContext' not found.")));
builder.Services.AddDbContext<PagesEditorasContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("PagesEditorasContext") ?? throw new InvalidOperationException("Connection string 'PagesEditorasContext' not found.")));
builder.Services.AddDbContext<PagesCienciasContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("PagesCienciasContext") ?? throw new InvalidOperationException("Connection string 'PagesCienciasContext' not found.")));
builder.Services.AddDbContext<PagesAutoresContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("PagesAutoresContext") ?? throw new InvalidOperationException("Connection string 'PagesAutoresContext' not found.")));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    seedEmployees.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

