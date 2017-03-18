
"use strict";

window.mainApp = window.mainApp || {};
mainApp.LocationRouter = Backbone.Router.extend({
  routes: {
    "location/index": "index",
  },

  $container: $('#primary-content'),

  initialize: function () {
    this.collection = new mainApp.LocationCollection();
    this.collection.fetch();
    mainApp.helpers.debug(this.collection);
    this.index();
    // start backbone watching url changes
    Backbone.history.start();
  },
  index: function () {
    debugger;
    var view = new mainApp.LocationIndexView({collection: this.collection});
    var html = view.render().el;
    this.$container.html(html);
  }
});