
$(document).ready(function () {
    $('#country').on('change', function () {

        var data = $(this).val();
        var div = $('.products-right');
       
      
        $.ajax({
            method: 'POST',
            url: "Discount",
            data: { data: data },
            success:function(response) {
                console.log(response);
            },
            error: function (xhr, ajaxOptions, thrownError) {
                alert('Failed to retrieve books.');
            }  

        });
        
    });
});