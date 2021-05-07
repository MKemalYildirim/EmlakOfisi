
(function ($) {
    'use strict';


    $(document).ready(function () {
        var t = $('#ticaretSicil').DataTable({
            "ordering": false,
            paging: false
        });
        $('#addRowTicaretSicil').on('click', function () {

            var MukellefId = $("#mukellef_MukellefId").val();
            t.row.add([
                '<td style="text-align: center;"><span class="form-control" style="background: none; border:none; text-align:center;"></span></td>',
                '<td style="text-align: center;"><span class="form-control" style="background: none; border:none; text-align:center;"></span></td>',
                '<td style="text-align: center;"><a class="fa fa-pencil-square-o form-control" style="background: none; color:black; border:none; text-align:center;" data-ajax="true" data-ajax-failure="OnFailure" data-ajax-loading="#progress" data-ajax-mode="replace" data-ajax-success="OnSuccess" data-ajax-update="#DetayModal" data-target="#duzenle_menu" data-toggle="modal" href="/Mukellef/TSDetay?MukellefId=' + MukellefId + '">Düzenle</a></td>',
                '<td style="text-align: center;"><a href="#" id="deleterowTicaretSicil" class="form-control" style="background: none; color:black; border:none; text-align:center;"><i class="fa fa-trash" aria-hidden="true"></i>Sil</a></td>'
            ]).draw(false);

        });
        $('#ticaretSicil tbody').on('click', '#deleterowTicaretSicil', function () {
            t
                .row($(this).parents('tr'))
                .remove()
                .draw();
        });
    });

    $(document).ready(function () {


        var t = $('#sgkSube').DataTable({
            "ordering": false,
            paging: false
        });
        //var counter = 1;

        //var SgkCount = $("#ortak_table tr").last().data("count") + 1;

        //if (isNaN(SgkCount)) {
        //    SgkCount = 0;
        //};

        $('#addRowSgk').on('click', function () {

            var MukellefId = $("#mukellef_MukellefId").val();
            t.row.add([
                '<td style="text-align: center;"><span class="form-control" style="background: none; border:none; text-align:center;"></span></td>',
                '<td style="text-align: center;"><span class="form-control" style="background: none; border:none; text-align:center;"></span></td>',
                '<td style="text-align: center;"><span class="form-control" style="background: none; border:none; text-align:center;"></span></td>',
                '<td style="text-align: center;"><a class="fa fa-pencil-square-o form-control" style="background: none; color:black; border:none; text-align:center;" data-ajax="true" data-ajax-failure="OnFailure" data-ajax-loading="#progress" data-ajax-mode="replace" data-ajax-success="OnSuccess" data-ajax-update="#DetayModal" data-target="#duzenle_menu" data-toggle="modal" href="/Sgk/SgkDetay?MukellefId=' + MukellefId + '">Düzenle</a></td>',
                '<td style="text-align: center;"><a href="#" id="deleterowSgk" class="form-control" style="background: none; color:black; border:none; text-align:center;"><i class="fa fa-trash" aria-hidden="true"></i> Sil</a></td>'
            ]).draw(false);





            //SgkCount++;
            //counter++;
        });

        // Automatically add a first row of data
        $('#sgkSube tbody').on('click', '#deleterowSgk', function () {
            t
                .row($(this).parents('tr'))
                .remove()
                .draw();
        });


    });

    $(document).ready(function () {
        var t = $('#Muhattap').DataTable({
            "ordering": false,
            paging: false
        });
        var counter = 1;

        var OrtakCount = $("#ortak_table tr").last().data("count") + 1;

        if (isNaN(OrtakCount)) {
            OrtakCount = 0;
        };

        $('#addRowM').on('click', function () {

            t.row.add([
                ' <td width="32%"><input class="col-12 form-control" style="font-size:12px; height: 25px;" id="MeslekKoduMuk" name="mukellef.Ortaklar[' + OrtakCount + '].HitapSekli" style="text-align:center;" type="text"></td>',
                ' <td width="32%"><input class="number col-12 form-control" style="font-size:12px; height: 25px;" id="MeslekKoduMuk" name="mukellef.Ortaklar[' + OrtakCount + '].Telefon" style="text-align:center;" type="text"></td>',
                ' <td width="32%"><input class="col-12 form-control" style="font-size:12px; height: 25px;" id="MeslekKoduMuk" name="mukellef.Ortaklar[' + OrtakCount + '].Mail" style="text-align:center;" type="text"></td>',
                '<td width="4%" style="text-align: center;">' +/*<a id="deletenewrow" style="cursor: pointer; margin-left:5px;"><i class="fa fa-trash-o fa-lg" aria-hidden="true"></i></a>*/'</td>'

            ]).draw(false);



            $('.number').inputmask({ "mask": "(+99) 999-999-9999", 'autoUnmask': true, 'removeMaskOnSubmit': true }).val("+90");


            OrtakCount++;
            counter++;
        });

        // Automatically add a first row of data

        $('#Muhattap tbody').on('click', '#deletenewrow', function () {
            t
                .row($(this).parents('tr'))
                .remove()
                .draw();
        });
        //$('#addRowM').click();


    });

    $(document).ready(function () {
        var t = $('#Faaliyet').DataTable({
            "ordering": false,
            paging: false,
            //rowReorder: true

        });
        var counter = 1;

        var FaaliyetCount = $("#faaliyet_table tr").last().data("count") + 1;

        if (isNaN(FaaliyetCount)) {
            FaaliyetCount = 0;
        };

        $('#addRowF').on('click', function () {
            t.row.add([
                '<td width="20%"><input class="col-12 form-control" style="font-size: 14px; height: 25px; text-align: center;" id="MeslekKoduMuk" name="mukellef.Faaliyetler[' + FaaliyetCount + '].FaaliyetKodu" type="text"></td>',
                '<td width="76%"><input class="col-12 form-control" style="font-size: 14px; height: 25px; text-align: center;" id="MeslekAdiMuk" name="mukellef.Faaliyetler[' + FaaliyetCount + '].FaaliyetAciklama" type="text"></td>',
                '<td width="4%" style="text-align: center;">' +/*<a id="deletenewrow" style="cursor: pointer; margin-left:5px;"><i class="fa fa-trash-o fa-lg" aria-hidden="true"></i></a>*/'</td>'
            ]).draw(false);
            FaaliyetCount++;
            counter++;
        });



        // Automatically add a first row of data

        $('#Faaliyet tbody').on('click', '#deletenewrow', function () {
            t
                .row($(this).parents('tr'))
                .remove()
                .draw();
        });
        //$('#addRowF').click();


    });


})(jQuery);