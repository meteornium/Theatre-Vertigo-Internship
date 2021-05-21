// Rentals Dropdown & Page Form Logic (create&edit pages)
$(document).ready(function () {
    $("select").change(function () {

        $(this).find("option:selected").each(function () {
            var optionValue = $(this).attr("value");
            var optionData = $(this).attr("data-rental");
            if (optionValue) {
                $(".box").not("." + optionValue).hide();
                $("." + optionValue).show();
            } else {
                $(".box").hide();
            }
            $("#beginForm").attr("action", optionData);
        });
    }).change();
});
