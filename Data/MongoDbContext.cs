// database connection setup...

using MongoDB.Driver;
using MongoDBCRUD.Models;

namespace MongoDBCRUD.Data
{
    public class MongoDbContext
    {
        // this holds a reference to the MongoDB database...
        private readonly IMongoDatabase _database;

        public MongoDbContext(string connectionString, string databaseName)
        {
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(databaseName);
        }
        public IMongoCollection<Person> People => _database.GetCollection<Person>("people");

    }
}
