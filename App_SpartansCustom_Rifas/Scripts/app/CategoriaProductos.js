/*
 Template Name: Lexa - Responsive Bootstrap 4 Admin Dashboard
 Author: Themesbrand
 File: Datatable js
 */

$(document).ready(function () {
    $('#datatable').DataTable();

    //Buttons examples
    var table = $('#datatable-buttons').DataTable({
        lengthChange: false,
        buttons: ['copy', 'excel', 'pdf', 'colvis']
    });

    table.buttons().container()
        .appendTo('#datatable-buttons_wrapper .col-md-6:eq(0)');

    // Select2
    $(".select2").select2(
        {
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
        }
    );
    $("input[name='demo0']").TouchSpin({
        buttondown_class: 'btn btn-primary',
        buttonup_class: 'btn btn-primary'
    });

    jQuery('#datepicker-autoclose').datepicker({
        autoclose: true,
        todayHighlight: true
    });
});

$('#datatable-buttons tbody tr td #btnEditar').click(function () {
    $('#modalEditar').modal();
});

$('#datatable-buttons tbody tr td #btnDetalles').click(function () {
    $('#modalDetalles').modal();
});

$('#datatable-buttons tbody tr td #btnEliminar').click(function () {
    $('#modalEliminar').modal();
});

$('#Crear').click(function () {
    $('#modalCrear').modal();
});

