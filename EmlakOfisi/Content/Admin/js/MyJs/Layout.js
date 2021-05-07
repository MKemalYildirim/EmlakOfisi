//$(document).on("click", "#EBeyanGiris", function () {
//    $.ajax({
//        url: '/Home/EBeyanGiris',
//        type: 'Post',
//        dataType: "json"


//    })
//});

//--------------------------------------------------------------------------

$(document).on("click", "#myselect", function () {

  
    $.ajax({
        url: '/Home/Layout',
        type: 'Post',
        data: { },
        dataType: "json",
        success: function (data) {
            if (data.Result.success) {

                document.querySelector('#_select').innerHTML = data.Result.Unvan;

            } else {
                // DoSomethingElse()
                alert(data.Result.responseText);
                //document.querySelector('#label_select').innerHTML = "123";
            }
        },
        error: function (response) {
            alert("error!");  
        }

    })

});

//--------------------------------------------------------------------------


//$(document).on("click", "#Loadmukkelleff", function () {
//    var TcNo = document.querySelector(".TcKimlikNo").value;
//    var VKNo = document.querySelector(".VergiKimlikNo").value;
//    $.ajax({
//        url: '/Home/MukellefBilgileri',
//        type: 'Post',
//        data: { "TcNo": TcNo,"VKNo":VKNo },
//        dataType: "json",
//        success: function (data) {
//            if (data.Result.success) {

//                document.querySelector('.Unvan').value = data.Result.Unvan;
//                document.querySelector('.VergiDairesiAdi').value = data.Result.VergiDairesi;

//                document.querySelector('.VergiKimlikNo').value = data.Result.VergiNo;

//                document.querySelector('.Faal').value = data.Result.Faal;
//                if (data.Result.IsCaddeSokak != null) {
//                    document.querySelector('.IsAdres').value = data.Result.IsCaddeSokak +
//                        " " +
//                        data.Result.IsMahalleSemt +
//                        "Kapı No:" +
//                        data.Result.IsKapiNo +
//                        " Daire: " +
//                        data.Result.IsDaireNo +
//                        " " +
//                        data.Result.IsIlAdi +
//                        "/" +
//                        data.Result.IsIlceAdi;
//                    document.querySelector('.IsIlAdi').value = data.Result.IsIlAdi;
//                    document.querySelector('.IsIlceAdi').value = data.Result.IsIlceAdi;
//                } else {
//                    document.querySelector('.IsAdres').value = "";
//                    document.querySelector('.IsIlAdi').value = "";
//                    document.querySelector('.IsIlceAdi').value ="";
//                }
//                if (data.Result.IkametCaddeSokak != null) {
//                    document.querySelector('.IkametAdres').value = data.Result.IkametCaddeSokak + " " + data.Result.IkametMahalleSemt + " KAPI NO:" + data.Result.IkametKapiNo + " DAİRE: " + data.Result.IkametDaireNo + " " + data.Result.IkametIlAdi + "/" + data.Result.IkametIlceAdi;

//                    document.querySelector('.IkametIlAdi').value = data.Result.IkametIlAdi;
//                    document.querySelector('.IkametIlceAdi').value = data.Result.IkametIlceAdi;

//                    document.querySelector('.MeslekAdi').value = data.Result.FaaliyetAciklama;
//                    document.querySelector('.MeslekKodu').value = data.Result.FaaliyetKodu;
//                } else {
//                    document.querySelector('.IkametAdres').value = "";
//                    document.querySelector('.IkametIlAdi').value = "";
//                    document.querySelector('.IkametIlceAdi').value ="";

//                    document.querySelector('.MeslekAdi').value = "";
//                    document.querySelector('.MeslekKodu').value = "";
//                }

             

//            } else {
//                // DoSomethingElse()
//                alert(data.Result.responseText);
//            }
//        },
//        error: function (response) {
//            alert("error!");  //
//        }

//    })
//});



