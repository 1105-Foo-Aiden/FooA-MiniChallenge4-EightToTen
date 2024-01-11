using FooA_MiniChallenge4_EightToTen.Services;
using FooA_MiniChallenge4_EightToTen.Services.Magic8Ball;
using FooA_MiniChallenge4_EightToTen.Services.RestarauntPicker;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<INumberGuesser, NumberGuesserClass>();
builder.Services.AddScoped<IEightBall, EightBall>();
builder.Services.AddScoped<IPicker, Picker>();

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
