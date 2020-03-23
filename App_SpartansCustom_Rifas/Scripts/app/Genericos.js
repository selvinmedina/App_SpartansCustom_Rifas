function ocultarValidaciones(modal) {
    let li = $(modal).find('ul').find('li');
    let inputs = $(modal).find('input');

    for (const el of li) {
        $(el).hide();
    }

    for (const input of inputs) {
        $(input).removeClass('parsley-error')
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
    sEmptyTable: 'No se cargó la información, contacte al administrador.',
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







