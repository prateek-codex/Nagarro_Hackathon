mongod --dbpath C:\MongoData\ --logpath C:\MongoLogs\mongolog.log

use LastMileConnectivity

db.createCollection('Bookings')


db.Bookings.insert(
   {
      "UserId" : 1,
	  "PhoneNumber": 9654669109,
	  "Location" : [ -77.07, 28.49 ],
	  "DestLocation" : [ -77.07, 28.49 ]
	}

	db.Bookings.createIndex({Location:"2dsphere"});