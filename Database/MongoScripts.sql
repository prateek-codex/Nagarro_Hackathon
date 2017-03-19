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

-- Insert The Mappings in the Mongo
db.createCollection('Stops')

db.Stops.insert (	{		"Name": "MG Road Metro Station"	,	"Location": [77.0798767,28.4796004]	})
db.Stops.insert (
	{
		"Name": "Infospace, Gurgaon",
		"Location": [77.07214599999998,28.5100411]
	}
)
db.Stops.insert (
	{
		"Name": "Nagarro Plot 36",
		"Location": [77.07007799999997,28.50141619999999]
	}
)
db.Stops.insert (
	{
		"Name": "Taj Mahal, Agra",
		"Location": [78.04215520000002,27.1750151]
	}
)

	db.Stops.createIndex({Location:"2dsphere"});

	
db.Bookings.insert( {"UserId" : 2, "PhoneNumber": 9324234909, "Location" : [77.0721459959998,28.510211], "DestLocation" : [ -77.07, 28.49 ]})
db.Bookings.insert( {"UserId" : 3, "PhoneNumber": 9234534909, "Location" : [77.0721659959998,28.510211], "DestLocation" : [ -77.07, 28.49 ]})
db.Bookings.insert( {"UserId" : 4, "PhoneNumber": 9986634909, "Location" : [77.0721859959998,28.510211], "DestLocation" : [ -77.07, 28.49 ]})
db.Bookings.insert( {"UserId" : 5, "PhoneNumber": 9453454909, "Location" : [77.0721359959998,28.510211], "DestLocation" : [ -77.07, 28.49 ]})
db.Bookings.insert( {"UserId" : 6, "PhoneNumber": 9724234909, "Location" : [77.0721659959998,28.510211], "DestLocation" : [ -77.07, 28.49 ]})
db.Bookings.insert( {"UserId" : 7, "PhoneNumber": 9012334909, "Location" : [77.0721359959998,28.510211], "DestLocation" : [ -77.07, 28.49 ]})


db.Bookings.insert( {"UserId" : 9, "PhoneNumber": 8012334909, "Location" : [77.07017799999997,28.50141619999999], "DestLocation" : [ -77.07, 28.49 ]})
db.Bookings.insert( {"UserId" : 10, "PhoneNumber": 8234534909, "Location" : [77.07027799999997,28.50141619999999], "DestLocation" : [ -77.07, 28.49 ]})
db.Bookings.insert( {"UserId" : 8, "PhoneNumber": 8986634909, "Location" : [77.07037799999997,28.50141619999999], "DestLocation" : [ -77.07, 28.49 ]})
db.Bookings.insert( {"UserId" : 11, "PhoneNumber": 8453454909, "Location" : [77.0707799999997,28.50131619999999], "DestLocation" : [ -77.07, 28.49 ]})
db.Bookings.insert( {"UserId" : 12, "PhoneNumber": 8724234909, "Location" : [77.07007799999997,28.50121619999999], "DestLocation" : [ -77.07, 28.49 ]})

db.Bookings.insert( {"UserId" : 12, "PhoneNumber": 8724234909, "Location" : [77.07214599999998,28.5100411], "DestLocation" : [ -77.07, 28.49 ]})
