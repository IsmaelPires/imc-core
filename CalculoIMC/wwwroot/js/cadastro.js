/*Ações*/
$("#btn-calcular-imc").on("click", function () {
    var obj = {
        Nome: $("#nome").val(),
        Peso: $("#peso").val(),
        Altura: $("#altura").val()
    };

    if (obj.Nome == '' || obj.Nome == undefined) {
        $('#nome').addClass('campo-obg');
        $.notify({
            icon: 'fa fa-exclamation-triangle',
            message: 'Atenção! Nome é um campo obrigatório.'
        }, {
            // settings
            type: 'danger'
        });
        return;
    } else {
        $('#nome').removeClass('campo-obg');
    }

    if (obj.Peso == '' || obj.Peso == undefined) {
        $('#peso').addClass('campo-obg');
        $.notify({
            icon: 'fa fa-exclamation-triangle',
            message: 'Atenção! Peso é um campo obrigatório.'
        }, {
            // settings
            type: 'danger'
        });
        return;
    } else {
        $('#peso').removeClass('campo-obg');
    }

    if (obj.Altura == '' || obj.Altura == undefined) {
        $('#altura').addClass('campo-obg');
        $.notify({
            icon: 'fa fa-exclamation-triangle',
            message: 'Atenção! Altura é um campo obrigatório.'
        }, {
            // settings
            type: 'danger'
        });
        return;
    } else {
        $('#altura').removeClass('campo-obg');
    }

    calcularIMC(obj);

});

$("#btn-limpar").on("click", function () {
    var classe = localStorage.getItem('classe');

    $('#nome').val('');
    $('#peso').val('');
    $('#altura').val('');

    $('.resultado').html('');
    $('.resultado').removeClass('alert alert-' + classe);
    $('.tabela-imc').attr('style', 'display:none;');
});
/*Funções*/

function calcularIMC(obj) {
    var nome = obj.Nome;
    var peso = parseFloat(obj.Peso);
    var altura = parseFloat(obj.Altura);
    var imc = parseInt(peso / (altura * altura));
    var classeAlerta = "";

    var dadosSalvar = {
        Nome: nome,
        Peso: peso,
        Altura: altura,
        Imc: imc
    };

    if (imc < 18.5) {
        classeAlerta = "primary"
    }

    if (imc >= 18.5 && imc <= 29.9) {
        classeAlerta = "warning"
    }

    if (imc > 29.9) {
        classeAlerta = "danger"
    }

    localStorage.setItem('classe', classeAlerta);

    salvar(dadosSalvar);
}

function salvar(dados) {
    $.ajax({
        url: "/Home/Cadastrar",
        context: document.body,
        data: dados
    }).done(function () {
        $('.resultado').html('<p>Atenção ' + dados.Nome + ',' + ' o seu IMC é ' + dados.Imc + '.</p>');
        $('.resultado').addClass('alert alert-' + localStorage.getItem("classe"));

        $('.tabela-imc').removeAttr('style');
    });
}