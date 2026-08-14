using Microsoft.EntityFrameworkCore;
using Tienda.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<EccomerceDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EccomerceDbContext")));

var app = builder.Build();
//invocar la ejecución del DbSeeder con un using scops
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
    var context = services.GetRequiredService<EccomerceDbContext>();
         DbSeeder.Seed(context); 
    }
    catch (Exception ex)
    {
        var logger= services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "Ocurrió un error al sembrar la base de datos.");   

    }

}


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
