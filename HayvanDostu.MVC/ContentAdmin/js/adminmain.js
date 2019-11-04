$(".btnModal").click(function () {
    console.log('click');
    var modalID = $(this).attr("data-modalID")
    $.ajax({
        url: "/Admin/AdminReadMail/" + modalID,
        type: "POST",
        data: { "id": modalID },
        success: function (response) {
            console.log(response);
            if (response.isSuccess == true) {

                var text = '<h4 class="modal-title">Kimden:  ' + response.items.Email + '</h4><div class="mailbox-read-message">'+ response.items.Message +'</div>';
            $("#modalInfo .modal-body").html(text);
            $("#modalInfo").modal("show");
            }

            //if (response == "ok") {

            //    var text = '<h2 class="modal-title">' + response + '</h2>';
            //    $("#modalInfo .modal-body").html(text);
            //    $("#modalInfo").modal("show");
            //}
            //else {
            //    $("#modalInfo .modal-body").text("Error!!");
            //    $("#modalInfo").modal("show");
            //}
        }

    });

})