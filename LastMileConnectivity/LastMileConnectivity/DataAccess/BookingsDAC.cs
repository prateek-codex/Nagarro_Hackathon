using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.GeoJsonObjectModel;

namespace LastMileConnectivity
{
    public class BookingsDAC
    {
        const string connectionString = "mongodb://hackathonvm8955.cloudapp.net:27017";

        public string GetNearByUsers(LocationPoint locationPoint)
        {
            try
            {
                MongoClient client = new MongoClient(connectionString);
                IMongoDatabase mongoDatabase = client.GetDatabase("LastMileConnectivity");
                var collection = mongoDatabase.GetCollection<BsonDocument>("Bookings");

                var query = //"{'Location': { '$near': [" + locationPoint.Longitude + ", " + locationPoint.Latitude + "], $maxDistance: 0.10 } }";

                 @"{Location: { $near :   {   $geometry: { type: 'Point',  coordinates: [ " + locationPoint.Longitude + ", " + locationPoint.Latitude + " ] },       $minDistance: 0,      $maxDistance: 5000      }   }}";

                var filter = MongoDB.Bson.Serialization.BsonSerializer.Deserialize<BsonDocument>(query);

                var result = collection.Find(filter).ToList();

                string a = "";
                foreach (var document in result)
                {
                    a += document;
                }


                // Group by the booking location

                // Get all location name

                return mongoDatabase.DatabaseNamespace.DatabaseName;
            }
            catch
            {
            }
            return String.Empty;
        }
    }
}