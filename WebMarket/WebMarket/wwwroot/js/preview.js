﻿this.imagePreview = function () {
    /* CONFIG */
    xOffset = 300;
    yOffset = 30;
    // these 2 variable determine popup's distance from the cursor
    // you might want to adjust to get the right result

    /* END CONFIG */
    $(".preview").hover(function (e) {
        this.t = this.title;
        this.title = "";
        var c = (this.t != "") ? "<br/>" + this.t : "";
        $(".container-fluid").append("<p id='preview'><img src='" + this.src + "' alt='Image preview' width='250px' height='250px'/>" + c + "</p>");
        $("#preview")
            .css("top", (e.pageY - xOffset) + "px")
            .css("left", (e.pageX + yOffset) + "px")
            .fadeIn("fast");
    },
        function () {
            this.title = this.t;
            $("#preview").remove();
        });
    $("a.preview").mousemove(function (e) {
        $("#preview")
            .css("top", (e.pageY - xOffset) + "px")
            .css("left", (e.pageX + yOffset) + "px");
    });
};


// starting the script on page load
$(document).ready(function () {
    imagePreview();
});