








$(document).on("click", "#GelenListele", function () {
    var Mukellef = document.getElementById("Mukellef").value;

    var Tarih = document.getElementById("Tarih").value;

    $.ajax({
        url: '/Mukellef/GelenListele',
        type: 'Post',
        data: { "Mukellef": Mukellef, "Tarih": Tarih },
        dataType: "json",
        

    })

});