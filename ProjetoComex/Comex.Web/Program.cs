using Comex.Web.Data;
using Comex.Web.Repositorio.ProdutoRepositorio;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Configurando o Context
builder.Services.AddDbContext<ComexDbContext>(opts => opts.UseInMemoryDatabase(databaseName: "ComexDb"));
builder.Services.AddDbContext<ComexDbSqliteContext>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Add Repositories
builder.Services.AddScoped<ProdutoRepositorio>();

// Add Mapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
