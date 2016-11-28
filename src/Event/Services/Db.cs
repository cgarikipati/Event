using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization;

namespace Event.Services
{
    public class Db
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;

       public  Db()
        {
            _client = new MongoClient();
            
            _database = _client.GetDatabase("test");

            BsonClassMap.RegisterClassMap<_team>();
        }

        public async void InsertAsync()
        {
            var document = new BsonDocument
{
    { "address" , new BsonDocument
        {
            { "street", "2 Avenue" },
            { "zipcode", "10075" },
            { "building", "1480" },
            { "coord", new BsonArray { 73.9557413, 40.7720266 } }
        }
    },
    { "borough", "Manhattan" },
    { "cuisine", "Italian" },
    { "grades", new BsonArray
        {
            new BsonDocument
            {
                { "date", new DateTime(2014, 10, 1, 0, 0, 0, DateTimeKind.Utc) },
                { "grade", "A" },
                { "score", 11 }
            },
            new BsonDocument
            {
                { "date", new DateTime(2014, 1, 6, 0, 0, 0, DateTimeKind.Utc) },
                { "grade", "B" },
                { "score", 17 }
            }
        }
    },
    { "name", "Vella" },
    { "restaurant_id", "41704620" }
};

            var collection = _database.GetCollection<BsonDocument>("restaurants");
            await collection.InsertOneAsync(document);
        }

        public void Save() {



            var team = new _team {

                name = "RoboWarrors",
                year = DateTime.Now
        };

            var collection = _database.GetCollection<_team>("Team");
            collection.InsertOne(team);

        }

        private class _team
        {
            
            public string name { get; set; }
            public object year { get; set; }
        }
    }
}
