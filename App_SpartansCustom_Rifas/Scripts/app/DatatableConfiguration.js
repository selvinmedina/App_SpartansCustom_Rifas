$(document).ready(function () {
    //INICIALIZACION DEL DATATABLE
    $('.datatable-Initial').DataTable();

    //ADICION DE BOTONES
    var table = $('.datatable-Initial').DataTable({
        lengthChange: false,
        buttons: ['copy', 'excel', 'pdf', 'colvis'],
        language: { "url": "//cdn.datatables.net/plug-ins/9dcbecd42ad/i18n/Spanish.json" },
    });

    //ADICION DE BOTONES EN EL WRAPPER
    table.buttons().container()
        .appendTo('#datatables_wrapper .col-md-6:eq(0)');

});