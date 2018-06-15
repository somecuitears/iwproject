 function Validate() {
     var index = 0;
     var preferences = [];
     var emailRegex = /^[a-zA-Z0-9.!#$%&’*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/i;
     var fname = document.forms["jsFormValid"]["fname"];
     var address = document.forms["jsFormValid"]["address"];
     var zip = document.forms["jsFormValid"]["zip"];
     var country = document.forms["jsFormValid"]["country"];
     var gender = document.forms["jsFormValid"]["gender"];

     //Internet Method...
     var noSelected = document.querySelectorAll('input[type="checkbox"]:checked').length;
     if (noSelected == 0) {
         DisplayError("prefError", "Select One or more color.");
     } else {
         DisplayError("prefError", "");
     }
     //My Method.
     /*
     var elements = document.getElementsByName('color'); for (var i = 0; elements[i]; ++i) { if (elements[i].checked) { preferences[index++] = elements[i].value; } } if (preferences.length == 0) { DisplayError("prefError", "Select One or more color."); } else { DisplayError("prefError", ""); }
     */

     var phone = document.forms["jsFormValid"]["phone"];
     var email = document.forms["jsFormValid"]["email"];
     var password = document.forms["jsFormValid"]["password"];
     var confirmPassword = document.forms["jsFormValid"]["confirmPassword"];

     if (fname.value === "") {
         DisplayError("nameError", "Please enter your name");
     } else {
         DisplayError("nameError", "")
     }

     if (isNaN(zip.value) || zip.value.length != 6) {
         DisplayError("zipError", "Numeric Value and 6 Digit Required");
     } else {
         DisplayError("zipError", "")
     }

     if (country.value === "") {
         DisplayError("countryError", "Please Select Value...");
     } else {
         DisplayError("countryError", "")
     }

     if (gender.value === "") {
         DisplayError("genderError", "Please Choose Gender")
     } else {
         DisplayError("genderError", "")
     }

     if (isNaN(phone.value) || phone.value.length != 10) {
         DisplayError("phoneError", "Numeric Value and 10 Digit Required");
     } else {
         DisplayError("phoneError", "");
     }

     var pattern = new RegExp(emailRegex);
     var emailTest = pattern.test(email.value);
     if (!emailTest) {
         DisplayError("emailError", "Enter valid email address");
     } else {
         DisplayError("emailError", "");
     }

     var p1 = password.value.length;
     var p2 = confirmPassword.value.length;
     if (p1 == 0 || p2 == 0) {

         DisplayError("passError", "Password length must be 6-8 characters");

     } else {
         if (password.value === confirmPassword.value) {
             if (p1 < 5 && p1 > 9 || p2 < 5 && p2 > 9) {
                 DisplayError("passError", "Password length must be 6-8 characters");
             } else {
                 DisplayError("passError", "");
             }
         } else {

             DisplayError("passError", "Password do not match");
         }
     }
 }

 function Reset() {
     //            var a = document.querySelectorAll("input");
     //            a.forEach(a => {
     //            var fieldtype = a.type.toLowerCase();

     //Clear Input fields
     var selectField = document.getElementsByTagName("select");
     selectField.country.selectedIndex = 0;

     var allElements = document.getElementsByTagName("input");

     for (var i = 0; i < allElements.length; i++) {
         var fieldtype = allElements[i].type.toLowerCase();
         //console.log(fieldtype);
         switch (fieldtype) {
             case "text":
             case "password":
             case "textarea":
                 //alert("text");
                 allElements[i].value = "";
                 break;
             case "radio":
             case "checkbox":
                 // alert("box");
                 if (allElements[i].checked) {
                     allElements[i].checked = false;
                 }
                 break;
             case "select":
                 //alert("select");
                 allElements[i].selectedIndex = 1;
                 break;
         }
     }

     //Clear Error msg
     var allSpan = document.getElementsByTagName("span");
     console.log(allSpan);
     for (var i = 0; i < allSpan.length; i++) {
         allSpan[i].innerText = "";
     }

 }

 function DisplayError(id, message) {
     document.getElementById(id).innerHTML = "<span>" + message + "</span>"
 }
