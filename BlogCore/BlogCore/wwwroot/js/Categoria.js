var dataTable;

$(document).ready(function () {
    cargarDataTable();
});


function cargarDataTable() {
    dataTable = $("#tblCategorias").DataTable({
        "ajax": {
            "url": "/admin/categorias/GetAll",
            "type": "GET",
            "datatype": "jason"
        },
        "columns": [
            { "data": "id", "width": "5%" },
            { "data": "nombre", "width": "50%" },
            { "data": "orden", "width": "20%" },
            {
                "data": "id",
                "render": function (data) {
                    return `<div class=text-center>
                            <a href='/Admin/Categorias/Edit/${data}' class='btn btn-sucess text-white' style='cursor:pointer;width:100px;'>
                                <i class='fas fa-edit'></i> Editar</a> $nbsp;
                            <a onclick=Delete("/Admin/Categorias/Delete/${data}") class='btn btn-danger text-white' style='cursor:pointer;width:100px;'>
                                <i class='fas fa-edit'></i> Borrar</a>
                    `;
                }, "width": "30%"
            }
        ],
        "language": {
            "emptyTable": "No hay registro"
        },
        "width": "100%"
    });
}

function Delete(url) {
    swal({
        title: "Esta seguro de borrar?",
        text: "Este contenido no se puede recuperar!",
        type: "warning",
        showCancelButton: true,
        confirmButtonColor: "#DD6B55",
        confirmButtonText: "Si, borrar!",
        closeOnconfirm: true
    }, function () {
        $.ajax({
            type: 'DELETE',
            url: url,
            sucess: function (data) {
                if (data.sucess) {
                    toastr.success(data.message);
                    dataTable.ajax.reload();
                }
                else {
                    toastr.error(data.message)
                }
            }
        });
    });
}