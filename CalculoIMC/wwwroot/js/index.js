/*Ações*/
$("#btn-excluir").on("click", function () {
    var id = $(this).data("id");
    var obj = {
        id: id
    }

    $.ajax({
        url: "/Home/Excluir",
        context: document.body,
        data: obj
    }).done(function () {
        $.notify({
            icon: 'fa fa-check-o',
            message: 'Sucesso! Usuário excluído.'
        }, {
            // settings
            type: 'success',

        });
    });
});

$("#btn-editar").on("click", function () {
    var id = $(this).data("id");
    var obj = {
        id: id
    }

    $.ajax({
        url: "/Home/Editar",
        context: document.body,
        data: obj
    }).done(function () { }
    );
});

/*Funções*/
