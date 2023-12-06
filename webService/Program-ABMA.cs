var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Начало добавки Самойловой
//services cors
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));
//Конец добавки

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



//app cors - Начало добавки Самойловой 
app.UseRouting();
app.UseCors("corsapp");
//app.UseCors(prodCorsPolicy); Конец добавки

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
