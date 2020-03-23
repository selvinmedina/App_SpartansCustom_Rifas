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
