﻿using System;
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

        public IList<string> GetUserNearToStop(LocationPoint locationPoint)
        {
            List<string> stops = new List<string>();
            try
            {
                MongoClient client = new MongoClient(connectionString);
                IMongoDatabase mongoDatabase = client.GetDatabase("LastMileConnectivity");
                var collection = mongoDatabase.GetCollection<BsonDocument>("Bookings");

                var query = //"{'Location': { '$near': [" + locationPoint.Longitude + ", " + locationPoint.Latitude + "], $maxDistance: 0.10 } }";

                 @"{Location: { $near :   {   $geometry: { type: 'Point',  coordinates: [ " + locationPoint.Longitude + ", " + locationPoint.Latitude + " ] },       $minDistance: 0,      $maxDistance: 60      }   }}";

                var filter = MongoDB.Bson.Serialization.BsonSerializer.Deserialize<BsonDocument>(query);

                var result = collection.Find(filter).ToList();

                foreach (var document in result)
                {
                    stops.Add(document.ToList()[2].Value.ToString());
                }
            }
            catch
            {
            }
            return stops;
        }
    }
}