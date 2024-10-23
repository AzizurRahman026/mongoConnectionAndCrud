using MongoDB.Driver;
using MongoDBCRUD.Data;
using MongoDBCRUD.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container...
builder.Services.AddControllers();
builder.Services.AddSingleton<MongoDbContext>(sp =>
{
    var connectionString = "mongodb://localhost:27017"; // Adjust if needed
    var databaseName = "testdb";
    return new MongoDbContext(connectionString, databaseName);
});

var app = builder.Build();

app.MapControllers();

app.Run();