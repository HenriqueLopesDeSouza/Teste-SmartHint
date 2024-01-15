$(document).ready(function () {
    $("#filtrarBtn").on("click", function () {
        $("#areaFiltros").toggle();
    });

    $('#limparFiltrosBtn').click(function (e) {
        e.preventDefault(); 
        $('input[type="text"]').val('');
        $('input[type="date"]').val('');
        $('select').val(null);
    });

});

function checkControle()
{
    $("[id^='Check_']").prop("checked", $("#checkAll").prop("checked"));
}