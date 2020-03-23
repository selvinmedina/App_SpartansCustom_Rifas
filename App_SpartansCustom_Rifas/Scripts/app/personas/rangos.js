
var descripcionCreate = $('#ModalCrear #rang_Descripcion');
var descripcionEdit = $('#ModalEditar #rang_Descripcion');
var otroCampoEdit = $('#ModalEditar #otroCampo');

$(document).ready(function () {

    //#region Instancias
    var table = $('#datatables').DataTable({
        lengthChange: false,
        buttons: ['copy', 'excel', 'pdf', 'colvis'],
        language: {
            "url": "//cdn.datatables.net/plug-ins/9dcbecd42ad/i18n/Spanish.json"
        },
    });

    table.buttons().container()
        .appendTo('#datatables_wrapper .col-md-6:eq(0)');

    // Select2
    $(".select2").select2({
        dropdownParent: $('#formEditar'),
        placeholder: 'Seleccione un empleado',
        language: {
            noResults: function () {
                return 'Resultados no encontrados.';
            },
            searching: function () {
                return 'Buscando...';
            }
        }
    });
    $("input[name='demo0']").TouchSpin({
        buttondown_class: 'btn btn-primary',
        buttonup_class: 'btn btn-primary'
    });

    jQuery('.datepicker-autoclose').datepicker({
        autoclose: true,
        todayHighlight: true
    });
});

//Hacer que no recargue la pagina
$('#btnGuardar').submit(e => e.preventDefault());

//#endregion

//#region Abrir Modales
//#region Editar
$('#datatables tbody tr td #btnEditar').click(function () {
    //$('#ModalEditar #rang_Descripcion').val(this.parentElement.pa)

    let ID = $(this).data('id');

    get('/Rangos/Edit/' + ID, (data) => {
        $('#ModalEditar #rang_Descripcion').val(data);
        $('#ModalEditar #rang_Id').val(ID);
    });

    console.log($(this).data('id'));
    $('#ModalEditar').modal({
        backdrop: 'static',
        keyboard: false
    });
});
//#endregion

//#region Detalles
$('#datatables tbody tr td #btnDetalles').click(function () {

    let ID = $(this).data('id');
    $.get('/Rangos/Details/' + ID, (data) => {

        console.log(data);
        //$('#ModalEditar #rang_Descripcion').val(data);
        //$('#ModalEditar #rang_Id').val(ID);
    });
    $('#modalDetalles').modal({
        backdrop: 'static',
        keyboard: false
    });
});
//#endregion

//#region Activar
$('#datatables tbody tr td #btnActivar').click(function () {
    $('#Modalhabilitar').modal({
        backdrop: 'static',
        keyboard: false
    });
});
//#endregion

//#region Eliminar
$('#datatables tbody tr td #btnEliminar').click(function () {
    $('#ModalInhabilitar').modal({
        backdrop: 'static',
        keyboard: false
    });
});
//#endregion

//#region Crear
$('#Crear_Rangos').click(function () {
    ocultarValidaciones('#ModalCrear');
    $('#ModalCrear').modal({
        backdrop: 'static',
        keyboard: false
    });
});
//#endregion
//#endregion

// Validaciones

//#region CRUD

$('#btnCrear').click(function (e) {
    let dataFormulario = $('#frmCrearRangos').serializeArray();

    if (camposRequeridos([descripcionCreate]))
        post(
            '/Rangos/Create', // url
            dataFormulario, // Data del formulario
            data => { //Retorno del backend 
                if (data === 'bien') {
                    console.log(data);

                    get('/Rangos/GetData/', (data) => {
                        console.log(data);
                    });
                }
            },
            err => {
                console.log(err);
            });
    else console.log('fallo');

})
$('#btnGuardarEdicion').click(function (e) {
    let dataFormulario = $('#frmEditarRangos').serializeArray();

    if (camposRequeridos([descripcionEdit, otroCampoEdit])) {
        post(
            '/Rangos/Edit', // url
            dataFormulario, // Data del formulario
            data => { //Retorno del backend 
                console.log(data);
            },
            err => {
                console.log(err);
            });

    } else {
        console.log('no enviado');

    }
})

//#endregion