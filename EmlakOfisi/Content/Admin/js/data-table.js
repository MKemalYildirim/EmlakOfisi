
(function ($) {
    'use strict';


    $(document).ready(function () {

        var PropTable = $('#PropTable').DataTable({
            "dom": '<"top">rt<"bottom"lp><"clear">',
            autoWidth: false,
            colReorder: true,
            paging: false,
            scrollY: "600px",
            scrollX: true,
            scrollCollapse: true,
        });
   
      

        $('#PropTable tbody').on('click', 'tr', function () {
            if ($(this).hasClass('selected')) {
                $(this).removeClass('selected');
                $('#SelectedRow').val($(this).data("container"));
                $("#DeleteRow").attr("href", "Home/DeleteProp/?Id=" + $(this).data("container"));
            }
            else {
                PropTable.$('tr.selected').removeClass('selected');
                $(this).addClass('selected');
                $('#SelectedRow').val($(this).data("container"));
                $("#DeleteRow").attr("href", "Home/DeleteProp/?Id=" + $(this).data("container"));
            }
        });



    });

})(jQuery);