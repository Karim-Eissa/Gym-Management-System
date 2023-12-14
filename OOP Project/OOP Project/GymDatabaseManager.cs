using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Text.RegularExpressions;

namespace OOP_Project
{
    public class GymDatabaseManager
    {
        private IMongoDatabase _database;
        public GymDatabaseManager(string connectionString, string databaseName)
        {
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(databaseName);
        }
        public void InsertDocument(BsonDocument document)
        {
            try
            {
                var collection = _database.GetCollection<BsonDocument>("members");
                collection.InsertOne(document);

                Console.WriteLine("Gym member document inserted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inserting gym member document: {ex.Message}");
            }
        }
        public IMongoCollection<Member> GetMemberCollection()
        {
            return _database.GetCollection<Member>("members");
        }

        public IMongoCollection<Coach> GetCoachCollection()
        {
            return _database.GetCollection<Coach>("members");
        }

        public IMongoCollection<Staff> GetStaffCollection()
        {
            return _database.GetCollection<Staff>("members");
        }

    }
}
