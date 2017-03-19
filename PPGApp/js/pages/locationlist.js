"use strict";

mainApp.LocationIndexView = Backbone.View.extend({

    template: _.template($('#locationIndex').html()),

    // populate the html to the dom
    render: function() {
        var self = this;

        var GetUserBookings = function (position) {
            
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
                    globalCollection = data;
                        self.$el.html(
                            self.template({
                                locationList: data
                            })
                        )},
                // dataType: dataType
            });
        }

        var DefaultBookings = function () {
            GetUserBookings({coords: { latitude: "28.4796004", longitude: "77.0798767"}})
        }

        getLocation(GetUserBookings, DefaultBookings);

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