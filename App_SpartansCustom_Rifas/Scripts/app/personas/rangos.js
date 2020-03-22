
var descripcionCreate = $('#ModalCrear #rang_Descripcion');
var descripcionEdit = $('#ModalEditar #rang_Descripcion');


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
    $('#ModalEditar').modal();
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
    $('#modalDetalles').modal();
});
//#endregion

//#region Activar
$('#datatables tbody tr td #btnActivar').click(function () {
    $('#Modalhabilitar').modal();
});
//#endregion

//#region Eliminar
$('#datatables tbody tr td #btnEliminar').click(function () {
    $('#ModalInhabilitar').modal();
});
//#endregion

//#region Crear
$('#Crear_Rangos').click(function () {
    $('#ModalCrear').modal();
});
//#endregion
//#endregion

// Validaciones

function requerido(input) {
    console.log(input);
}

function validacionCrear(input) {
    console.log(input);

}



//#region Click
$('#btnCrear').click(function (e) {
    e.preventDefault();
    let form = $('#frmCrearRangos').serializeArray()

    validacionCrear(descripcionCreate.val());


    post(
        '/Rangos/Create', // url
        form, // Data del formulario
        data => { //Retorno del backend 
            console.log(data);
        },
        err => {
            console.log(err);
        })
    //console.log(e);
    //var array = $('#frmCrearRangos').serializeArray();

    ////if (array.find(x => x.name == 'rang_Descripcion').value == "") {
    ////    console.log('No supero la valiacion')
    ////    $('#frmCrearRangos #rang_Descripcion').addClass('parsley-error');
    ////    $('#frmCrearRangos #requerido').show();
    ////}


    //console.log(array);

})
//#endregion