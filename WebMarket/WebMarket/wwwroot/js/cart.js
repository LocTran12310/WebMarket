showModel();

function showModel() {
    $(".show").click(function () {
        var product = $(this).parent().parent();
        var id = product.attr("data-id");
        var name = product.find("p").text();
        var img = product.find("img").attr("src");
        var price = product.find("h4").text();
        var modal = $(".modal-body");
        modal.find("img").attr("src", img)
        modal.find("h2").text(name);
        modal.find("h3").text(price);
        modal.attr("data-id", id);
    })
    addToCart();
}

function addToCart() {
    $(".add-to-cart").click(function () {
        var id = $(".modal-body").attr("data-id");
        var quantity = $(".modal-body").find('input[name=quantity]').val();
        $.ajax({
            type: "POST",
            url: '/Cart/AddToCart',
            data: {
                'id': id,
                'quantity': quantity,
                'type': "ajax"
            },
            success: function (data) {
                Swal.fire({
                    icon: 'success',
                    title: 'Thêm giỏ hàng thành công',
                    showConfirmButton: false,
                    timer: 2500
                });
                $("#cart_count").html(data.quantity);
                $(".modal-body").find('input[name=quantity]').val("1");
                console.log($(".modal-body").find('input[name=quantity]').val());
                $('#modal-cart').modal('hide');
            },
            error: function () {
                Swal.fire({
                    icon: 'error',
                    title: 'Thêm giỏ hàng thất bại',
                    text: 'Vui lòng thử lại',
                    showConfirmButton: false,
                    timer: 2500
                });
                $(".modal-body").find('input[name=quantity]').val("1");
                $('#modal-cart').modal('hide');
            },
        })
    })
   
}


