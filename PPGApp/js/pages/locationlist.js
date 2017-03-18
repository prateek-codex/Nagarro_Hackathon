"use strict";

mainApp.LocationIndexView = Backbone.View.extend({

    template: _.template($('#locationIndex').html()),
    // populate the html to the dom
    render: function () {
        var self = this;

        this.collection.fetch().done(function (data) {
            self.$el.html(
                self.template({
                    locationList: data
                })
            )
        });

        return this;
    }

});