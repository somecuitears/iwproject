function LoginValidate() {
    var emailRegex = /^[a-zA-Z0-9.!#$%&’*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/i;
    var emailPattern = new RegExp(emailRegex);
    var numberRegex = /^[0-9]+$/i;
    var numberPattern = new RegExp(numberRegex);
    //alert("Import Success");
    var loginEmail = document.getElementById("lemail").value;
    var loginPassword = document.getElementById("lpassword").value;


    var emailTest = emailPattern.test(loginEmail);
    var phoneTest = numberPattern.test(loginEmail);

    if (emailTest || phoneTest)
        window.open("second.html?email=" + loginEmail, '_self', false);
    else
        alert("Email or Phone validation failed.")
}


function SignUpValidation() {

}
