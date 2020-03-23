
var descripcionCreate = $('#ModalCrear #rang_Descripcion');
var descripcionEdit = $('#ModalEditar #rang_Descripcion');
var otroCampoEdit = $('#ModalEditar #otroCampo');
var table;
$(document).ready(function () {

    //#region Instancias
    listar();

    table.buttons().container()
        .appendTo('#datatables_wrapper .col-md-6:eq(0)');
});

var activo = `
    ${botonEditar}
    ${botonDetalles}
    ${botonEliminar}
    `;
var inactivo = `
    ${botonEditar}
    ${botonDetalles}
    ${botonActivar}
`;


function listar() {
    //Almacenar la tabla creada
    table = $('#datatables').DataTable({
        //Con este metodo se le dan los estilos y funcionalidades de datatable a la tabla
        destroy: true,
        //Es para que pueda volver a inicializar el datatable, aunque ya este creado
        ajax: objetoAjaxDataTables('/Rangos/GetData'),
        columns: [
            {
                data: 'numero'
            },
            {
                data: 'descripcion'
            }, //Columna 2: descripción de la planilla, esto viene de la petición que se hizo al servidor
            {
                data: 'estado',
                render: function (data) {
                    return (data) ? "Activo" : "Inactivo";
                }
            },
            {
                //Columna 4: los botones que tendrá cada fila, editar y detalles de la planilla
                orderable: false,
                data: 'estado',
                render: function (data) {
                    return (data) ? activo : inactivo;
                }
            }],
        language: traduccion,
        pageLength: 10,
        "order": [[0, "desc"]]
        //Con esto se hace la traducción al español del datatables
    });
    //Cuando le de click en detalles, o editar, le pasare el id
    obtenerIdDetallesEditar('#datatables tbody', table);
}

//#endregion

// LLenar la data 
async function llenarData() {
    await table.clear();
    await get('/Rangos/GetData/', async (data) => {
        await table.rows.add(data.data).draw();
    });
}


function obtenerIdDetallesEditar(body, table) {
    $(body).on('click', 'button#btnEditar', function () {
        let { numero } = table.row($(this).parents('tr')).data();

        get('/Rangos/Edit/' + numero, (data) => {
            $('#ModalEditar #rang_Descripcion').val(data);
            $('#ModalEditar #rang_Id').val(numero);
        });

        $('#ModalEditar').modal({
            backdrop: 'static',
            keyboard: false
        });
    });

    //Cuando de click en detalles, que obtenga el id del tr, y que redireccione a la pantalla de Details
    $(body).on('click', 'button#btnDetalles', function () {
        var data = table.row($(this).parents('tr')).data();
        location.href = urlSinElIndex + '/Details/' + data.idPlanilla;
    });

    $(body).on('click', 'button#btnActivar', function () {
        localStorage.setItem('id', table.row($(this).parents('tr')).data().numero);

        $('#Modalhabilitar').modal({
            backdrop: 'static',
            keyboard: false
        });
    });

    $(body).on('click', 'button#btnEliminar', function () {
        localStorage.setItem('id', table.row($(this).parents('tr')).data().numero);

        $('#ModalInhabilitar').modal({
            backdrop: 'static',
            keyboard: false
        });
    });
}


//#region Abrir Modales
//#region Detalles
$('#datatables tbody tr td #btnDetalles').click(function () {

    let ID = $(this).data('id');
    $.get('/Rangos/Details/' + ID, (data) => {
        //$('#ModalEditar #rang_Descripcion').val(data);
        //$('#ModalEditar #rang_Id').val(ID);
    });
    $('#modalDetalles').modal({
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
//Crear
$('#btnCrear').click(function (e) {
    let dataFormulario = $('#frmCrearRangos').serializeArray();

    if (camposRequeridos([descripcionCreate]))
        post(
            '/Rangos/Create', // url
            dataFormulario, // Data del formulario
            async data => { //Retorno del backend 
                if (data === 'bien') {
                    await llenarData();
                    await $('#ModalEditar').modal('hide');
                }
                else
                    alert('Algo paso mal');
            },
            err => {
            });
});

//Editar
$('#btnGuardarEdicion').click(function (e) {
    let dataFormulario = $('#frmEditarRangos').serializeArray();

    if (camposRequeridos([descripcionEdit, otroCampoEdit])) {
        post(
            '/Rangos/Edit', // url
            dataFormulario, // Data del formulario
            async data => { //Retorno del backend 
                if (data === 'bien') {
                    await llenarData();
                    await $('#ModalEditar').modal('hide');
                }
                else
                    alert('Algo paso mal');
            },
            err => {
            });

    } else {
    }
})

//Eliminar
$('#btnConfirmarModalInhabilitar').click(function (e) {
    post(
        '/Rangos/Edit', // url
        dataFormulario, // Data del formulario
        async data => { //Retorno del backend 
            if (data === 'bien') {
                await llenarData();
                await $('#ModalEditar').modal('hide');
            }
            else
                alert('Algo paso mal');
        },
        err => {
        });
});

//#endregion