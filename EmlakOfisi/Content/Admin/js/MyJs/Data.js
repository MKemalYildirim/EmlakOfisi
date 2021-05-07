

    function loadCust(result) {
        ("ajax-main").html(result);

        }







   

        $(document).on("click", "#TebligatSorgulaBtn", async function () {
            $.ajax({
                url: '/Maliye/TebligatTopluListele',
                type: 'Post',
                dataType: "json",


            })
            
        });

    
function myFunction() {
    var x = document.getElementById("password-field");
    if (x.type === "password") {
        x.type = "text";

    } else {
        x.type = "password";
    }

};
function myFunction2() {
    var x = document.getElementById("password-field1");
    if (x.type === "password") {
        x.type = "text";

    } else {
        x.type = "password";
    }

};
  