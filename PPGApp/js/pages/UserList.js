"use strict";

mainApp.UsersView = Backbone.View.extend({

    template: _.template($('#userDataTemplate').html()),

    // populate the html to the dom
    render: function() {
        
        var self = this;

        this.collection.fetch().done(function(data){
            console.log(data);
        });
       
        this.collection.fetch().done(function(data) {
            self.$el.html(
                self.template({
                    userList: data
                })
            )
        });	
    
        return this;
    }

});