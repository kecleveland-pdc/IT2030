$(document).ready(function(){
    $("#hide_btn").on("click", function () {
        $(".hide_content").hide();
    });

    $("#show_btn").on("click", function () {
        $(".hide_content").show();
    });
});