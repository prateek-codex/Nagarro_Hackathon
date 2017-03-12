"use strict";
mainApp.ProductModel = Backbone.Model.extend({
    // you can set any defaults you would like here
    defaults: {
        Name: "",
        Description: "",
        Price: "",
        Manufacturer: "",
        // just setting random number for id would set as primary key from server
        Id: _.random(0, 10000)
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

mainApp.ProductCollection = Backbone.Collection.extend({
    // Reference to this collection's model.
    url: AppConstants.apiUrl + "Product",
    // model: mainApp.ProductModel,
    parse: function(data) {
        var productList = [];
        var id = 1;
        data.forEach(function(val){
            productList.push({Name: val, Id: id++});
        });
        return productList;
    }
});