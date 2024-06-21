using CadCliBlazor.Data;
using CadCliBlazor.Data.Repositories;
using CadCliBlazor.Domain.Contracts.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<CadCliDbContext>(
    options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"))
);

builder.Services.AddSwaggerGen();

// AddTRansient, AddScoped, AddSingleton => Ciclo de vida Injeção de dependência
//AddTransient => A cada solicitação na Injeção de dependência é criada uma nova instância

builder.Services.AddTransient<IClienteRepository, ClienteRepository>();

// builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
// builder.Services.AddSingleton<IClienteRepository, ClienteRepository>();

//AddScoped => A cada requisição é criada uma nova instância
// AddSingleton => Uma única instância para toda a aplicação


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    using var scope = app.Services.CreateScope();
    var dbContext = scope.ServiceProvider.GetRequiredService<CadCliDbContext>();
    await dbContext.Database.MigrateAsync();

    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();