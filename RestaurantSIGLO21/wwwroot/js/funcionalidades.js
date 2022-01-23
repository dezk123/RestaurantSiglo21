function login() {
    var user, pass;

    user = document.getElementById("usuario").value;
    pass = document.getElementById("contrasena").value;

    if (user == "Ricardo" && pass == "123") {
        window.location = "reservation.html";
    }
}