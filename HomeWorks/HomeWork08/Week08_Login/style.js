document.querySelector("#show-login").addEventListener("click", function() {
    document.querySelector(".popup").classList.add("active");
});

document.querySelector(".popup .close-btn").addEventListener("click", function() {
    document.querySelector(".popup").classList.remove("active");
});

document.querySelector("#login-btn").addEventListener("click", function() {
    const username = document.querySelector("#email").value;
    const password = document.querySelector("#password").value;

    const correctUsername = "admin";  // Sabit kullanıcı adı
    const correctPassword = "12345";  // Sabit parola

    if (username === correctUsername && password === correctPassword) {
        document.querySelector(".popup").classList.remove("active");
        document.querySelector(".success-page").style.display = "block";

        setTimeout(function() {
            document.querySelector(".success-page").style.display = "none";
        }, 3000); 
    } else {
        document.querySelector(".popup").classList.remove("active");
        document.querySelector(".failure-page").style.display = "block";

        setTimeout(function() {
            document.querySelector(".failure-page").style.display = "none";
        }, 3000);
    }
});
