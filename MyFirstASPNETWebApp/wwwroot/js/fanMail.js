// Normal JS
//document.getElementById('btnsend').addEventListener("click", function () {
//    alert('From: ' + document.getElementById("textFrom").value +
//        ", Subject: " + document.getElementById("textSubject").value +
//        ", Message: " + document.getElementById("textMessage").value);
//});


$('#btnsend').click(function () {
    alert("From: " + $("#textFrom").val() +
        ", Subject: " + $("#textSubject").val() +
        ", Message: " + $("#textMessage").val());

    $("#picGanderson").fadeToggle();

});

