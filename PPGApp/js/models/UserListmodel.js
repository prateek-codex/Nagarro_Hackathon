"use strict";
mainApp.UserDataModel = Backbone.Model.extend({
    // you can set any defaults you would like here
    defaults: {
        UserId: "",
        MaskedPhoneNumber: "",
        PhoneNumber: "",
    },

    validate: function(attrs) {
        var errors = {};
        if (!attrs.UserId) errors.title = "This User is not authenticated!!";
        if (!attrs.MaskedPhoneNumber) errors.description = "Please Enter a valid phone number";
        if (!attrs.PhoneNumber) errors.author = "Please Enter a valid phone number";
        if (!_.isEmpty(errors)) return errors;
    }
});

mainApp.userDataCollection = Backbone.Collection.extend({
    // Reference to this collection's model.
    url: AppConstants.usersUrl + "locationId",
    parse: function(data) {
        var userDataList = [];
        var id = 1;
        data.forEach(function(val){
            userDataList.push({mockNumber: val.MaskedPhoneNumber, Id: val.UserId});
        });
        return userDataList;
    }
});