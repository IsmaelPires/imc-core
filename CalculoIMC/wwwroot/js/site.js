$("#btn-editar-usuario").on("click", function () {
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