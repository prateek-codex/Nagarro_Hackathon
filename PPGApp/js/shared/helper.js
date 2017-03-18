
(function () {
  mainApp.helpers = {

    debug: function (collection) {
      collection.on('all', function () {
        $('#output').text(JSON.stringify(collection.toJSON(), null, 4));
      });
      collection.trigger('reset');
    },

    showErrors: function (note, errors) {
      $('.has-error').removeClass('has-error');
      $('.alert').html(_.values(errors).join('<br>')).show();

      // highlight the fields with errors
      _.each(_.keys(errors), function (key) {
        $('*[name=' + key + ']').parent().addClass('has-error');
      });
    }
  };
}());

        function getLocation(callback) {
            if (navigator.geolocation) {
                navigator.geolocation.getCurrentPosition(callback);
            } else {
                alert("Geolocation is not supported by this browser.");
            }
        }

        function showPosition(position) {
            var lat = position.coords.latitude;
            var lng = position.coords.longitude;
            map.setCenter(new google.maps.LatLng(lat, lng));
        }
