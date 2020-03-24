function ocultarValidaciones(modal) {
    let li = $(modal).find('ul').find('li');
    let inputs = $(modal).find('input');

    for (const el of li) {
        $(el).hide();
    }

    for (const input of inputs) {
        if (input.name != '__RequestVerificationToken') {
            $(input).removeClass('parsley-error');
            $(input).val('');
        }
    }
}

function camposRequeridos(campos) {
    var validacion = true;

    let camposError = new Array();

    for (const campo of campos) {
        let campoVal = campo.val();
        const campoError = $(campo).parent().find('#requerido');

        if (campoVal == '') {

            camposError.push(campo);
            campo.addClass('parsley-error');
            validacion = false;
            campoError.show();

            campo.keyup(function (val) {
                // Obtener valores
                var esteCampo = $(this);
                let valorKeyup = $(this).val();

                if (valorKeyup.trim() == '') {
                    esteCampo.addClass('parsley-error');
                    campoError.show();
                } else {
                    esteCampo.removeClass('parsley-error');
                    campoError.hide();
                }
            });
        } else {
            campo.removeClass('parsley-error');
            campoError.hide();
        }
    }

    if (camposError.length > 0) {
        camposError[0].focus();
    }
    return validacion
}

function objetoAjaxDataTables(url) {
    return {
        //Hacer la peticion asíncrona y obtener los datos que se mostraran en el datatable
        method: 'GET',
        url,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json'
    }
}

var botonEditar = '<button type="button" id="btnEditar" class="btn btn-primary waves-effect waves-light">Editar</button>';
var botonDetalles = '<button type="button" id="btnDetalles" class="btn btn-secondary waves-effect">Detalles</button>';
var botonEliminar = '<button type="button" id="btnEliminar" class="btn btn-danger waves-effect waves-light">Eliminar</button>';
var botonActivar = '<button type="button" id="btnActivar" class="btn btn-success waves-effect waves-light">Activar</button>';

var traduccion = {
    sProcessing: 'Procesado...',
    sLengthMenu: 'Mostrar _MENU_ registros',
    sZeroRecords: 'No se encontraron resultados',
    sEmptyTable: 'No hay datos para mostrar.',
    sInfo: 'Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros',
    sInfoEmpty: 'Mostrando registros del 0 al 0 de un total de 0 registros',
    sInfoFiltered: '(filtrado de un total de _MAX_ registros)',
    sInfoPostFix: '',
    sSearch: 'Buscar:',
    sUrl: '',
    sInfoThousands: ',',
    sLoadingRecords: 'Cargando...',
    oPaginate: {
        sFirst: 'Primero',
        sLast: 'Último',
        sNext: 'Siguiente',
        sPrevious: 'Anterior'
    },
    oAria: {
        sSortAscending: ': Activar para ordenar la columna de manera ascendente',
        sSortDescending: ': Activar para ordenar la columna de manera descendente'
    }
}

async function success(mensaje) {
    await iziToast.success({
        title: 'Éxito',
        message: mensaje
    });
}

async function error(mensaje) {
    await iziToast.error({
        title: 'Error',
        message: mensaje
    });
}



var mensaje = {
    //Insersión
    insertado: '¡El registro se agregó de forma exitosa!',
    falloInsersion: 'No se guardó el registro, contacte al administrador',

    //Inactivación
    inactivado: '¡El registro se inactivó de forma exitosa!',
    falloInactivacion: 'No se inactivó el registro, contacte al administrador',

    //Permisos
    permisos: 'No tienes permisos para realizar esta acción',

    //Activación
    activado: '¡El registro se activó de forma exitosa!',
    falloActivacion: 'No se activó el registro, contacte al administrador',

    //Edición
    editado: '¡El registro se editó de forma exitosa!',
    falloEdicion: 'No se editó el registro, contacte al administrador'
}

async function submit(form) {
    $(form).submit(ev => false);
}

function disabled(boton, estado) {
    if (estado) {
        boton.disabled = estado
    } else {
        setTimeout(() => boton.disabled = estado, 1000);
    }
}

//#region Constantes

const bien = 'bien',
    activo = `
    ${botonEditar}
    ${botonDetalles}
    ${botonEliminar}
    `,
    inactivo = `
    ${botonEditar}
    ${botonDetalles}
    ${botonActivar}
    `,
    modalEditar = '#ModalEditar',
    modalCrear = '#ModalCrear',
    modalHabilitar = '#Modalhabilitar',
    modalDetalles = '#modalDetalles',
    modalInHabilitar = '#ModalInhabilitar'
    ;
var table;

async function mostrarModal(modal) {
    await $(modal).modal({
        backdrop: 'static',
        keyboard: false
    });
}

async function ocultarModal(modal) {
    await $(modal).modal('hide');
}

//#endregion