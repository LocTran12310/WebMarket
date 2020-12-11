$(document).ready(function () {
    $(".err").click(function () {
        Swal.fire({
            icon: 'error',
            title: 'Giỏ hàng rỗng',
        })
    });
    UpdateQuantity();
    let num = parseInt($(".qty-input").val());
    $(".qty-increase").click(function () {
        num += 1;
        var input = $(this).parent().find('.qty-input');
        input.val(num);
        $.ajax({
            type: "POST",
            url: "Cart/UpdateCart",
            data: {
                "Id": input.data("masp"),
                "Quantity": input.val(),
            },
            dataType: "json",
            success: function (res) {
                $(".count").text(res.soLuong);
                $('.prices__value--final').text(res.tongTien + ' đ');
            }
        });
    });
    $(".qty-decrease").click(function () {
        
        num -= 1;
        var input = $(this).parent().find('.qty-input');
        input.val(num);
        $.ajax({
            type: "POST",
            url: "Cart/UpdateCart",
            data: {
                "Id": input.data("masp"),
                "Quantity": parseInt(input.val()),
            },
            dataType: "json",
            success: function (data) {
                $(".count").text(data.soLuong);
                $('.prices__value--final').text(data.tongTien + ' đ');
            }
        });
    });
    
    
    $('.cart-products__del').click(function () {
        let deleteButton = $(this).parent().parent().parent();
        let id = $(this).data("masp");
        $.ajax({
            type: "POST",
            url: "Cart/DeleteItem",
            data: {
                "Id": id,
            },
            dataType: "json",
            success: function (data) {
                $('.' + id).remove();
                   deleteButton.remove();
                $(".count").text(data.soLuong);
                $('.prices__value--final').text(data.tongTien + ' đ');
                if (data.soLuong == 0) {
                    var string = "<h2>Your shopping cart contains: <span> 0 Products </span> </h2>";
                    $(".checkout-right").html(string);
                }
            }
        });
    });
});

function UpdateQuantity() {
    $('.qty-input').change(function () {
        $.ajax({
            type: "POST",
            url: "Cart/UpdateCart",
            data: {
                "Id": $(this).data("masp"),
                "Quantity": $(this).val(),
            },
            dataType: "json",
            success: function (data) {
                $(".count").text(data.soLuong);
                $('.prices__value--final').text(data.tongTien + ' đ');
            }
        });
    });
}

