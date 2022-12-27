using System.Data;
using Microsoft.Data.Sqlite;
using Payment.Common;
using Payment.Repositories;
using Payment.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

builder.Services.AddScoped<TransactionService>();
builder.Services.AddScoped<IDbConnection>( _ =>
{
    var connection = new SqliteConnection(connectionString);
    connection.Open();
    return connection;
});

builder.Services.AddScoped<IDbTransaction>(provider => provider.GetRequiredService<TransactionService>().BeginTransaction());
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddTransient<IBankRepository, BankRepository>();
builder.Services.AddTransient<IOrderRepository, OrderRepository>();

builder.Services.AddTransient<IPaymentService, PaymentService>();

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();