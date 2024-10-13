document.getElementById("button").addEventListener("click", function(){
    const message = document.getElementById("message");
    message.classList.remove("hidden");
    message.style.display = "block";
    
    setTimeout(() => {
            message.style.display = "none";
            }, 3000);
})