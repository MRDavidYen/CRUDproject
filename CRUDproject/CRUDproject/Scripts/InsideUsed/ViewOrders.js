
$(function () {
    $('#StartDate').datepicker({
        dateFormat: 'yymmdd',
        changeYear: true,
        changeMonth: true,
        defaultDate: new Date("1996-01-01"),
    });
    $('#EndDate').datepicker({
        dateFormat: 'yymmdd',
        changeYear: true,
        changeMonth: true,
        defaultDate: new Date("1997-01-01"),

    });
    $('#SearchOrders').click(function () {
        var regex = /[0-9]{4}(0[1-9]|1[0-2])(0[1-9]|[1-2][0-9]|3[0-1])/;
        if (!regex.test($('#StartDate').val()) || !regex.test($('#EndDate').val())) {
            return false;
        }
    });
    $('.DeleteItem').on("click", function () {
        var Item = $(this);
        var OrderID = $(this).next().next().val();
        $.ajax({
            url: "/DeleteOrder/DeleteItem",
            method: "POST",
            data: { OrderID: OrderID },
            success: function (result) {
                if (result) {
                    Item.parent().parent().slideUp();
                }
            }
        });
    });
});
