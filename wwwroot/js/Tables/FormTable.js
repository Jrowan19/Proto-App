var dataTable
$(document).ready(function () {
    dataTable = $('#formTable').DataTable({

        "ajax": {
            "url": "information/Index?handler=FormData",
            "dataSrc": '',
            "type": "GET",
            "datatype": "jsonp",
            "responsive": "true",
            "fixedColumns": "true",
        },
        "columnDefs": [
            {
                "targets": [0],
                "visible": false,
                "searchable": false
            },

            {
                "targets": [1, 2, 3, 4, 5],
                "className": "text-center, table-border tb",
            }
        ],

        "columns": [

            { "data": "id", "width": "10%", "font-size": "11px" },
            { "data": "name", "width": "10%", "font-size": "11px" },
            {
                "data": "dateWorked",
                "render": function (data) {

                    return `
                                    <p> ${moment(data).format('DD/MM/YYYY')} </p>
        `;

                }, "width": "7%"
            },
            { "data": "notes", "width": "10%", "font-size": "11px", "text-align": "center" },
            { "data": "category", "width": "10%", "font-size": "11px", "text-align": "center" },
            {
                "data": "id",
                "render": function (data) {
                    return `<div class="text-center">
                        <a href="information/Edit?Id=${data}" class="fw-bold btn btn-light text-white me-1" style="background: #78be20 !important">
                           <i class="fas fa-edit"></i> Edit
                        </a>

                        <a href="information/Delete?Id=${data}" class="fw-bold btn btn-light text-white ms-1" style="background: crimson !important">
                           <i class="fas fa-trash"></i> Delete
                        </a>
                    </div>
                   `;
                }, "width": "7%"
            }

        ],

        "language": {
            "emptyTable": "No Data found"
            ,
        },
    });

})
