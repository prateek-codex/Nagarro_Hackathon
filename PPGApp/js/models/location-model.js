"use strict";
mainApp.ProductModel = Backbone.Model.extend({
    // you can set any defaults you would like here
    defaults: {
        LocationId: "",
        LocationName: ""
    },

    validate: function(attrs) {
        var errors = {};
        if (!attrs.Name) errors.title = "Hey! Give this thing a Name.";
        if (!attrs.Description) errors.description = "You gotta write a description, duh!";
        if (!attrs.Price) errors.author = "Put your Price in dumb dumb...";
        if (!attrs.Manufacturer) errors.author = "Put your Manufacturer in dumb dumb...";
        if (!_.isEmpty(errors)) return errors;
    }
});

mainApp.LocationCollection = Backbone.Collection.extend({
    // Reference to this collection's model.
    url: AppConstants.apiUrl + "Driver",
    parse: function(data) {
        var locationList = [];
        var id = 1;
        data.forEach(function(val){
            locationList.push({LocationName: val.LocationName });//, LocationId: val.LocationId});
        });
        return locationList;
    }
});