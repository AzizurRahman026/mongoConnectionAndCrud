using MongoDB.Bson;

namespace MongoDBCRUD.Models
{
    public class Person
    {
        public ObjectId Id { get; set; } // MongoDB generates Id auto
        public string Name { get; set; }
    }
}
