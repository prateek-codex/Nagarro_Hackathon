"use strict";

var globalCollection = [];
var globalId = 1;
window.mainApp = window.mainApp || {};
mainApp.LocationRouter = Backbone.Router.extend({
    routes: {
        "": "index",
        "users/:locId": "users"
    },

    $container: $('#primary-content'),

    initialize: function () {
        this.collection = new mainApp.LocationCollection();
        this.collection.fetch();
        mainApp.helpers.debug(this.collection);
        Backbone.history.start();
    },
    index: function () {
        var view = new mainApp.LocationIndexView({ collection: this.collection });
        var html = view.render().el;
        this.$container.html(html);

        console.log(this.collection)
    },
    users: function (locId) {
        this.collection = globalCollection;
        // var view = new mainApp.UserInLocationView({ locationId: locId, locationName: this.collection.toJSON()[parseInt(locId.replace(':', '')) - 1].LocationName });
        var location = this.collection[parseInt(locId.replace(':', '')) - 1];
        globalId = location.LocationId;
        var view = new mainApp.UserInLocationView({ locationId: locId, locationName: location.LocationName });
        var html = view.render().el;
        this.$container.html(html);
    }
});