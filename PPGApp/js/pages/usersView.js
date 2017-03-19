"use strict";

mainApp.UserInLocationView = Backbone.View.extend({

    template: _.template($('#usersView').html()),

    // populate the html to the dom
    render: function () {
        var self = this;
        debugger
        $.get(AppConstants.apiUrl + "Driver/" + globalId, function (data) {
            self.$el.html(
                self.template({
                    userList: data,
                    locName: self.locationName
                })
            )
        });

        return this;
    }

});