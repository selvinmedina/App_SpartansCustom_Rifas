
//#region Declaración de Variables
var descripcionCreate = $('#ModalCrear #rang_Descripcion');
var descripcionEdit = $('#ModalEditar #rang_Descripcion');
const __RequestVerificationToken = $('#frmCrearRangos input[name="__RequestVerificationToken"]').val();
//#endregion

// Ready
$(document).ready(async function () {

    //#region Instancias
    await listar();

    //Evitar el submit al crear
    await submit('#frmCrearRangos');
    await submit('#frmEditarRangos');

});

async function listar() {
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
    await clickDentroDelTBody('#datatables tbody', table);
}

// LLenar la data 
async function llenarData() {
    await table.clear();
    await get('/Rangos/GetData/', async (data) => {
        await table.rows.add(data.data).draw();
    });
}

async function clickDentroDelTBody(body, table) {
    $(body).on('click', 'button#btnEditar', function () {
        let { numero, descripcion } = table.row($(this).parents('tr')).data();

        $(`${modalEditar} #rang_Descripcion`).val(descripcion);
        $(`${modalEditar} #rang_Id`).val(numero);

        mostrarModal(modalEditar);
    });

    //Cuando de click en detalles, que obtenga el id del tr, y que redireccione a la pantalla de Details
    $(body).on('click', 'button#btnDetalles', async function () {
        var { numero } = table.row($(this).parents('tr')).data();

        await $.get('/Rangos/Details/' + numero, (data) => {
            const { descripcion, usuarioCrea, fechaCrea, usuarioModifica, fechaModifica } = data;
            $(`${modalDetalles} #valDescripcion`).html(descripcion)
            $(`${modalDetalles} #valUsuarioCrea`).html(usuarioCrea)
            $(`${modalDetalles} #valFechaCrea`).html(fechaCrea)
            $(`${modalDetalles} #valUsuarioModifica`).html(usuarioModifica)
            $(`${modalDetalles} #valFechaModifica`).html(fechaModifica)
            mostrarModal(modalDetalles)
        });
    });

    $(body).on('click', 'button#btnActivar', async function () {

        await localStorage.setItem('id', table.row($(this).parents('tr')).data().numero);

        mostrarModal(modalHabilitar);

    });

    $(body).on('click', 'button#btnEliminar', async function () {
        await localStorage.setItem('id', table.row($(this).parents('tr')).data().numero);

        mostrarModal(modalInHabilitar);
    });
}

//#region Crear
$('#Crear_Rangos').click(async function () {
    await ocultarValidaciones(modalCrear);
    mostrarModal(modalCrear);
});
//#endregion

//#region CRUD
//Crear
$('#btnCrear').click(async function (e) {
    let dataFormulario = $('#frmCrearRangos').serializeArray();
    var esteBoton = this;
    if (camposRequeridos([descripcionCreate])) {
        // Deshabilitar el boton actual
        await disabled(esteBoton, true);

        // Enviar la data
        await post(
            '/Rangos/Create', // url
            dataFormulario, // Data del formulario
            async data => { //Retorno del backend 
                if (data === 'bien') {
                    await success(mensaje.insertado);
                    await llenarData();
                    await ocultarModal(modalCrear);
                }
                else {
                    await error(mensaje.falloInsersion);
                    await ocultarModal(modalCrear);
                }
            },
            async err => {
                error(mensaje.falloInsersion);
                ocultarModal(modalCrear);
            });
    }
    await disabled(esteBoton, false);
});

//Editar
$('#btnGuardarEdicion').click(async function (e) {
    let dataFormulario = $('#frmEditarRangos').serializeArray();
    var esteBoton = this;

    if (camposRequeridos([descripcionEdit])) {
        await disabled(esteBoton, true);
        await post(
            '/Rangos/Edit', // url
            dataFormulario, // Data del formulario
            async data => { //Retorno del backend 
                if (data === bien) {
                    await success(mensaje.editado);
                    await llenarData();
                    await ocultarModal(modalEditar);
                }
                else {
                    await error(mensaje.falloEdicion);
                    await ocultarModal(modalEditar);
                }
            },
            async err => {
                await ocultarModal(modalEditar);
                await error(mensaje.falloEdicion);
            });

    }
    await disabled(esteBoton, false);
})

//Eliminar
$('#btnConfirmarModalInhabilitar').click(async function (e) {
    await disabled(this, true);
    await post(
        '/Rangos/Delete/' + localStorage.getItem('id'), // url
        {
            __RequestVerificationToken
        }, // Data del formulario
        async data => { //Retorno del backend 
            if (data === bien) {
                await success(mensaje.inactivado);
                await llenarData();
                await ocultarModal(modalInHabilitar);
            }
            else {
                await error(mensaje.falloInactivacion);
                await ocultarModal(modalInHabilitar);
            }
        },
        async err => {
            await error(mensaje.falloInactivacion);
            await ocultarModal(modalInHabilitar);
        });
    await disabled(this, false);
});

//#endregion