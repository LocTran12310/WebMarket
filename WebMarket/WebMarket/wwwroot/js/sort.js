
$(document).ready(function () {
    $('#country').on('change', function () {
;        var div = $('.products-right');
        $.ajax({
            method: 'POST',
            url: "Discount",
            data: { data: 1 },
            error: function (xhr, ajaxOptions, thrownError) {
                alert('Failed to retrieve books.');
            },
            success: function (res) {
                $('#mypartial').html(res);
            },
           

        });
        
    });
});