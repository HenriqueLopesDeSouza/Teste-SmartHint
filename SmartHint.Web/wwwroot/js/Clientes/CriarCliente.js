$(document).ready(function () {    

    let tipoPessoa = $('#TipoPessoa');
    let camposPessoaFisica = $("#CamposPessoaFisica");
    let isentoCheckbox = $("#Isento");
    let inscricaoEstadual = $("#InscricaoEstadual");

    tipoPessoa.change(function () {
        if (tipoPessoa.val() === 'Juridica') {
            inscricaoEstadual.val("");
            isentoCheckbox.prop('checked', false);
        }
        atualizarCampos();
    });

    function atualizarCampos() {
        let selectedOption = tipoPessoa.val();
        camposPessoaFisica.toggle(selectedOption === 'Fisica');
        isentoCheckbox.prop('disabled', selectedOption === 'Juridica');

        if (isentoCheckbox.is(':checked')) {
            inscricaoEstadual.val("").prop('disabled', true);
            $("[data-valmsg-for='InscricaoEstadual']").text("");
        } else {
            inscricaoEstadual.prop('disabled', false);
        }
    }

    isentoCheckbox.change(function () {
        if ($(this).is(':checked')) {
            inscricaoEstadual.val("").prop('disabled', true);
            $("[data-valmsg-for='InscricaoEstadual']").text("");
        } else {
            inscricaoEstadual.prop('disabled', false);
        }
    });

    atualizarCampos();


    $('#CpfCnpj').on('keydown',  function (e) {

        var digit = e.key.replace(/\D/g, '');

        var value = $(this).val().replace(/\D/g, '');

        var size = value.concat(digit).length;

        $(this).mask((size <= 11) ? '000.000.000-00' : '00.000.000/0000-00');
    });


});