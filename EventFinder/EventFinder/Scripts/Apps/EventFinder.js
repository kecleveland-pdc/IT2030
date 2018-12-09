function searchFailed() {

    $("#eventfinderevents-search").html("Search failed. Please try again.");
}

$(function () {
    $(".RemoveLink").click(function () {
        console.log("clicked");
        var id = $(this).attr("data-id");
        $.post("/EventFinderCarts/RemoveFromCart", { "id": id }, function (data) {
            //populate elements in my view with data from the controller
            $("#update-message").text(data.Message);
            $("#cart-total").text(data.CartTotal);
            $("#item-count-" + data.DeleteId).text(data.ItemCount);
            if (data.ItemCount == 0) { $("#record-" + data.DeleteId).fadeOut(); } //hide if row count = 0 
        });
    });
});

