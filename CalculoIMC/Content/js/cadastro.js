/*Ações*/
$("#btn-calcular-imc").on("click", function () {
    var obj = {
        Nome: $("#nome").val(),
        Peso: $("#peso").val(),
        Altura: $("#altura").val()
    };

    if (obj.Nome == '' || obj.Nome == undefined) {
        $('#nome').addClass('campo-obg');
        return;
    } else {
        $('#nome').removeClass('campo-obg');
    }

    if (obj.Peso == '' || obj.Peso == undefined) {
        $('#peso').addClass('campo-obg');
        return;
    } else {
        $('#peso').removeClass('campo-obg');
    }

    if (obj.Altura == '' || obj.Altura == undefined) {
        $('#altura').addClass('campo-obg');
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

    salvar(dadosSalvar);

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

    $('.resultado').html('<p>Atenção ' + obj.Nome + ',' + ' o seu IMC é ' + imc + '.</p>');
    $('.resultado').addClass('alert alert-' + classeAlerta);

    $('.tabela-imc').removeAttr('style');
}

function salvar(dados) {
    $.ajax({
        url: "/Home/Cadastrar",
        context: document.body,
        data: JSON.parse(dados)
    }).done(function () {
        alert("Done");
    });
}