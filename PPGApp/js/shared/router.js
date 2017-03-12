
"use strict";

window.mainApp = window.mainApp || {};
mainApp.ProductRouter = Backbone.Router.extend({
  routes: {
    "product/new": "create",
    "product/index": "index",
    "product/:id/edit": "edit",
    "product/:id/delete": "delete"
  },

  $container: $('#primary-content'),

  initialize: function () {
    this.collection = new mainApp.ProductCollection();
    this.collection.fetch();
    mainApp.helpers.debug(this.collection);
    this.index();
    // start backbone watching url changes
    Backbone.history.start();
  },

  create: function () {
    var view = new mainApp.ProductNewView({
      collection: this.collection, 
      model: new mainApp.ProductModel()
    });
    this.$container.html(view.render().el);
  },

  delete: function (id) {
    var product = this.collection.get(id);
    product.destroy();
    Backbone.history.navigate("products/index", {trigger: true});
  },

  edit: function (id) {
    var view = new mainApp.ProductEditView({model: this.collection.get(id)});
    this.$container.html(view.render().el);
  },

  index: function () {
    var view = new mainApp.ProductIndexView({collection: this.collection});
    this.$container.html(view.render().el);
  }
});