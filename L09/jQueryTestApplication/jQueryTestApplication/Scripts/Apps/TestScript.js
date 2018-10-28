$(document).ready(function(){
    $("#hide_btn").on("click", function () {
        $(".hide_content").hide();
    });

    $("#show_btn").on("click", function () {
        $(".hide_content").show();
    });

    $("#red_btn").on("click", function () {
        $("#mainJQ").children("p").toggleClass("red important");
        $("#mainJQ").find("a").css({ "color": "purple" });
    })
});