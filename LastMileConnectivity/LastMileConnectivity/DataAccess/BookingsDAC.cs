using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using MongoDB.Bson;

namespace LastMileConnectivity
{
    public class BookingsDAC
    {
        const string connectionString = "mongodb://hackathonvm8955.cloudapp.net:27017";
        
        public string GetDBConnection()
        {
            try
            {
                MongoClient client = new MongoClient(connectionString);
                IMongoDatabase mongoDatabase = client.GetDatabase("test");

                return mongoDatabase.DatabaseNamespace.DatabaseName;
            }
            catch {
            }
            return String.Empty;
        }
    }
}