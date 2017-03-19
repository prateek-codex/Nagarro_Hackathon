// app.js
(function (app, $) {

    // Initialization
    function init() {
        if (window.index) index.init();
        if (window.settings) settings.init();
        if (window.about) about.init();
        if (window.router) router.init();

        $(".back-button").on("click", function () {
            window.history.go(-1);
            return false;
        });

        $("#imgFingerPrint").click(function () {
            var counter = $(this).attr("clickCount") || 1;
            counter++;
            $(this).attr("clickCount", counter);
            if (counter % 2 == 0) {
                $('#startRideModal').modal();

            } else {
                $('#endRideModal').modal();
            }
        });

    }

    // Startup 
    if (window.cordova) { // We're in PhoneGap
        document.addEventListener("deviceready", init, false);
    } else {
        $(document).ready(init);
    }

})(window.app = window.app || {}, $);