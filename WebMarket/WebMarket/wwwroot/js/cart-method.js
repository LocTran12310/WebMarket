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
        let deleteButton = $(this).parent().parent().parent().parent();
        $.ajax({
            type: "POST",
            url: "Cart/DeleteItem",
            data: {
                "Id": $(this).data("masp"),
            },
            dataType: "json",
            success: function (data) {
                deleteButton.remove();
                $(".count").text(data.soLuong);
                $('.prices__value--final').text(data.TongTien)+ ' đ');
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
                $(".nb-pds").html(data.Count);
                $('.prices__value--final').html(number_format(data.TongTien) + ' đ');
            }
        });
    });
}