"use strict";

mainApp.ProductIndexView = Backbone.View.extend({

    template: _.template($('#indexTemplate').html()),

    // populate the html to the dom
    render: function() {
        
        var self = this;

        this.collection.fetch().done(function(data){
            console.log(data);
        });
       
        this.collection.fetch().done(function(data) {
            self.$el.html(
                self.template({
                    products: data
                })
            )
        });
    
        return this;
    }

});