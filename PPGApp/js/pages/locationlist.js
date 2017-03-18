"use strict";

mainApp.LocationIndexView = Backbone.View.extend({

    template: _.template($('#locationIndex').html()),

    // populate the html to the dom
    render: function() {
        var self = this;

        var GetUserBookings = function (position) {
            
          alert("lat: " + position.coords.latitude);
          alert("long: " + position.coords.longitude);
            var postData = {
                Latitude: position.coords.latitude,
                Longitude: position.coords.longitude,
            }

            var lat = position.coords.latitude;
            var lng = position.coords.longitude;

            $.ajax({
                type: "POST",
                url: AppConstants.apiUrl + "Driver",
                data: postData,
                success: function(data) {
                        self.$el.html(
                            self.template({
                                locationList: data
                            })
                        )},
                // dataType: dataType
            });
        }

        getLocation(GetUserBookings);

        // $.get(AppConstants.apiUrl + "Driver/" + this.locationId, 
        // });

        // this.collection.fetch().done(function(data) {
        //     self.$el.html(
        //         self.template({
        //             locationList: data
        //         })
        //     )
        // });

        return this;
    }

});