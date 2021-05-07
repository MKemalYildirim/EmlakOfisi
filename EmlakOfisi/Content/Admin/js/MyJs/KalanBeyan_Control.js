

$(document).ready(function () {

    //__________________BEYANNAME DROPDOWNLIST SELECTED__________________________________________
    if (document.querySelector("#KontrolAraligi1").value == "1") {
        document.querySelector("#kdv1Aylik").selected = "1";
        document.querySelector("#kdv1Aylik").style.backgroundColor = "green";
        $("#kdv1").click();
    }
    else if (document.querySelector("#KontrolAraligi1").value == "3") {
        document.querySelector("#kdv1_3Aylik").selected = "2";
        document.querySelector("#kdv1_3Aylik").style.backgroundColor = "green";
        $("#kdv1").click();
    }
    else {
        document.querySelector("#kdv1bos").selected = "0";
        document.querySelector("#kdv1bos").style.backgroundColor = "red";
        $("#kdv1").click();
    }

    if (document.querySelector("#KontrolAraligi2").value == "1") {
        document.querySelector("#kdv2Aylik").selected = "1";
        document.querySelector("#kdv2Aylik").style.backgroundColor = "green";
        $("#kdv2").click();
    }
    else if (document.querySelector("#KontrolAraligi2").value == "3") {
        document.querySelector("#kdv2_3Aylik").selected = "2";
        document.querySelector("#kdv2_3Aylik").style.backgroundColor = "green";
        $("#kdv2").click();
    }
    else {
        document.querySelector("#kdv2bos").selected = "0";
        document.querySelector("#kdv2bos").style.backgroundColor = "red";
        $("#kdv2").click();
    }

    if (document.querySelector("#KontrolAraligi3").value == "1") {
        document.querySelector("#muhsgkAylik").selected = "1";
        document.querySelector("#muhsgkAylik").style.backgroundColor = "green";
        $("#muhsgk").click();
    }
    else if (document.querySelector("#KontrolAraligi3").value == "3") {
        document.querySelector("#muhsgk3Aylik").selected = "2";
        document.querySelector("#muhsgk3Aylik").style.backgroundColor = "green";
        $("#muhsgk").click();
    }
    else {
        document.querySelector("#muhsgkbos").selected = "0";
        document.querySelector("#muhsgkbos").style.backgroundColor = "red";
        $("#muhsgk").click();
    }

    if (document.querySelector("#KontrolAraligi4").value == "1") {
        document.querySelector("#posetAylik").selected = "1";
        document.querySelector("#posetAylik").style.backgroundColor = "green";
        $("#poset").click();
    }
    else if (document.querySelector("#KontrolAraligi4").value == "3") {
        document.querySelector("#poset3Aylik").selected = "2";
        document.querySelector("#poset3Aylik").style.backgroundColor = "green";
        $("#poset").click();
    }
    else {
        document.querySelector("#posetbos").selected = "0";
        document.querySelector("#posetbos").style.backgroundColor = "red";
        $("#poset").click();
    }

    if (document.querySelector("#KontrolAraligi5").value == "1") {
        document.querySelector("#turizmAylik").selected = "1";
        document.querySelector("#turizmAylik").style.backgroundColor = "green";
        $("#turizm").click();
    }
    else if (document.querySelector("#KontrolAraligi5").value == "3") {
        document.querySelector("#turizm3Aylik").selected = "2";
        document.querySelector("#turizm3Aylik").style.backgroundColor = "green";
        $("#turizm").click();
    }
    else {
        document.querySelector("#turizmbos").selected = "0";
        document.querySelector("#turizmbos").style.backgroundColor = "red";
        $("#turizm").click();
    }


        //__________________BEYANNAME İNPUT SELECTED__________________________________________

    if (document.querySelector("#beyantakip2").value == "True") {
        document.querySelector("#kdv4").value = '';
        document.querySelector("#kdv4").style.backgroundColor = "green";
    }
    else {
        document.querySelector("#kdv4").value = '';
        document.querySelector("#kdv4").style.backgroundColor = "red";
    }

    if (document.querySelector("#beyantakip3").value == "True") {
        document.querySelector("#ggecici").value = '';
        document.querySelector("#ggecici").style.backgroundColor = "green";
    }
    else {
        document.querySelector("#ggecici").value = '';
        document.querySelector("#ggecici").style.backgroundColor = "red";
    }
    if (document.querySelector("#beyantakip4").value == "True") {
        document.querySelector("#kgecici").value = '';
        document.querySelector("#kgecici").style.backgroundColor = "green";
    }
    else {
        document.querySelector("#kgecici").value = '';
        document.querySelector("#kgecici").style.backgroundColor = "red";
    }

    if (document.querySelector("#beyantakip6").value == "True") {
        document.querySelector("#ba").value = '';
        document.querySelector("#ba").style.backgroundColor = "green";
    }
    else {
        document.querySelector("#ba").value = '';
        document.querySelector("#ba").style.backgroundColor = "red";
    }

    if (document.querySelector("#beyantakip7").value == "True") {
        document.querySelector("#bs").value = '';
        document.querySelector("#bs").style.backgroundColor = "green";
    }
    else {
        document.querySelector("#bs").value = '';
        document.querySelector("#bs").style.backgroundColor = "red";
    }

    if (document.querySelector("#beyantakip10").value == "True") {
        document.querySelector("#gelir").value = '';
        document.querySelector("#gelir").style.backgroundColor = "green";
    }
    else {
        document.querySelector("#gelir").value = '';
        document.querySelector("#gelir").style.backgroundColor = "red";
    }
    if (document.querySelector("#beyantakip11").value == "True") {
        document.querySelector("#gelir1001e").value = '';
        document.querySelector("#gelir1001e").style.backgroundColor = "green";
    }
    else {
        document.querySelector("#gelir1001e").value = '';
        document.querySelector("#gelir1001e").style.backgroundColor = "red";
    }
    if (document.querySelector("#beyantakip12").value == "True") {
        document.querySelector("#kurumlar").value = '';
        document.querySelector("#kurumlar").style.backgroundColor = "green";
    }
    else {
        document.querySelector("#kurumlar").value = '';
        document.querySelector("#kurumlar").style.backgroundColor = "red";
    }
    if (document.querySelector("#beyantakip13").value == "True") {
        document.querySelector("#basit").value = '';
        document.querySelector("#basit").style.backgroundColor = "green";
    }
    else {
        document.querySelector("#basit").value = '';
        document.querySelector("#basit").style.backgroundColor = "red";
    }

    if (document.querySelector("#beyantakip14").value == "True") {
        document.querySelector("#oiv").value = '';
        document.querySelector("#oiv").style.backgroundColor = "green";
    }
    else {
        document.querySelector("#oiv").value = '';
        document.querySelector("#oiv").style.backgroundColor = "red";
    }

    if (document.querySelector("#beyantakip15").value == "True") {
        document.querySelector("#otv").value = '';
        document.querySelector("#otv").style.backgroundColor = "green";
    }
    else {
        document.querySelector("#otv").value = '';
        document.querySelector("#otv").style.backgroundColor = "red";
    }

    if (document.querySelector("#beyantakip16").value == "True") {
        document.querySelector("#gmsi").value = '';
        document.querySelector("#gmsi").style.backgroundColor = "green";
    }
    else {
        document.querySelector("#gmsi").value = '';
        document.querySelector("#gmsi").style.backgroundColor = "red";
    }
    if (document.querySelector("#beyantakip17").value == "True") {
        document.querySelector("#damga").value = '';
        document.querySelector("#damga").style.backgroundColor = "green";
    }
    else {
        document.querySelector("#damga").value = '';
        document.querySelector("#damga").style.backgroundColor = "red";
    }
});
// &#xF00d;  false
// &#xF00c;  true
function select_function(elmnt, val) {
    if (elmnt.value == "") {
        elmnt.value = '';
        elmnt.style.backgroundColor = "red";
        document.getElementById(val).value = false;

    }
    else {
        elmnt.value = '';
        elmnt.style.backgroundColor = "green";
        document.getElementById(val).value = true;

    }
}

function sgk_function(elmnt, val) {
    if (elmnt.value == "") {
        elmnt.value = '';
        elmnt.style.backgroundColor = "red";
        document.getElementById(val).value = false;

    }
    else {
        elmnt.value = '';
        elmnt.style.backgroundColor = "green";
        document.getElementById(val).value = true;

    }
}


function dropDownSelect(elmnt, val) {
    if (elmnt.value == 1 || elmnt.value == 3) {
        document.getElementById(val).value = true;
        elmnt.style.backgroundColor = "green";
        elmnt.style.color = "white";
    }
    else {
        document.getElementById(val).value = false;
        elmnt.style.backgroundColor = "red";
        elmnt.style.color = "white";
    }
}

