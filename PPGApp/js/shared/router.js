"use strict";

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
    },
    users: function (locId) {
        var view = new mainApp.UserInLocationView({ locationId: locId, locationName: this.collection.toJSON()[parseInt(locId.replace(':', '')) - 1].LocationName });
        var html = view.render().el;
        this.$container.html(html);
    }
});