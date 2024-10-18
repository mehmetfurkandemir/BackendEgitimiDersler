document.getElementById("revealTips").addEventListener("click", function() {
    const tipsContainer = document.getElementById("tipsContainer");
    if (tipsContainer.style.display === "none") {
        tipsContainer.style.display = "block";
        this.textContent = "Hide Tips"; // Change button text
    } else {
        tipsContainer.style.display = "none";
        this.textContent = "Reveal Tips"; // Change button text back
    }
});

