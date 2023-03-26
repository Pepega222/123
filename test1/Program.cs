using test1.Context;
using test1.Models;
using test1.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DatabaseContext>();
builder.Services.AddScoped<VisitRequestRepository>();
builder.Services.AddScoped<UserRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/user", async (VisitRequestRepository repository) =>
{
    IEnumerable<User> users = await repository.GetUsers();
    return Results.Ok(users);
});
app.MapPost("/user", async (VisitRequestRepository repository) =>
{
    
});

app.UseHttpsRedirection();



app.Run();