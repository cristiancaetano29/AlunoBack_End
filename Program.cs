using Microsoft.EntityFrameworkCore;
using ProjetoEscola_API.Data;

var builder = WebApplication.CreateBuilder(args);

//Criando o CORS
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

// Add services to the container.

//Fazendo o builder do CORS
builder.Services.AddCors(options => {
    options.AddPolicy(MyAllowSpecificOrigins, builder => { 
        builder.WithOrigins("http://localhost").AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
        builder.SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost");
        builder.SetIsOriginAllowed(origin => true);
    });
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<EscolaContext>(options =>
{
options.UseSqlServer(builder.Configuration.GetConnectionString("StringConexaoSQLServer"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

//Fazendo o App usar o CORS
app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();





