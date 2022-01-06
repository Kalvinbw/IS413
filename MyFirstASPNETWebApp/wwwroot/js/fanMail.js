// Normal JS
//document.getElementById('btnsend').addEventListener("click", function () {
//    alert('From: ' + document.getElementById("textFrom").value +
//        ", Subject: " + document.getElementById("textSubject").value +
//        ", Message: " + document.getElementById("textMessage").value);
//});


//$('#btnsend').click(function () {
//    alert("From: " + $("#textFrom").val() +
//        ", Subject: " + $("#textSubject").val() +
//        ", Message: " + $("#textMessage").val());

//    $("#picGanderson").fadeToggle();

//});

$("#btnsend").click(function () {
    // Get all the values and calculate what they are worth
    let assignments = $("#assign").val() * .55;
    let groupProject = $("#gp").val() * .05;
    let quiz = $("#qz").val() * .10;
    let exam = $("#ex").val() * .20;
    let intex = $("#intex").val() * .10;

    // calculate the grade 
    let grade = Math.round((assignments + groupProject + quiz + exam + intex));
    let letter;

    // determine the letter grade
    if (grade >= 94) {
        letter = 'A';
    } else if (grade >= 90) {
        letter = 'A-';
    } else if (grade >= 87) {
        letter = 'B+';
    } else if (grade >= 84) {
        letter = 'B';
    } else if (grade >= 80) {
        letter = 'B-';
    } else if (grade >= 77) {
        letter = 'C+';
    } else if (grade >= 74) {
        letter = 'C';
    } else if (grade >= 70) {
        letter = 'C-';
    } else if (grade >= 67) {
        letter = 'D+';
    } else if (grade >= 64) {
        letter = 'D';
    } else if (grade >= 60) {
        letter = 'D-';
    } else {
        letter = 'E'
    }

    // alert the results
    alert("Final Grade: " + grade + "%" + " " + letter)
})