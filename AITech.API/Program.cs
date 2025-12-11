using AITech.Business.Extensions;
using AITech.DataAccess.Context;
using AITech.DataAccess.Extensions;
using AITech.DataAccess.Interceptors;
using AITech.Entity.Entities; // 1. BU NAMESPACE'Ý EKLEMEN GEREKÝYOR (AppUser için)
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDataAccesServices();
builder.Services.AddBusinessServices();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"));
    options.AddInterceptors(new AuditDbContextInterceptor());
});

// --- 2. HATAYI ÇÖZEN KISIM (BURAYI EKLE) ---
// Bu kod sayesinde API projesi Identity sistemini ve veritabaný tablolarýný tanýr.
builder.Services.AddIdentity<AppUser, AppRole>()
    .AddEntityFrameworkStores<AppDbContext>();
// -------------------------------------------

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();