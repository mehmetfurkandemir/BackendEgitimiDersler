const birthday = new Date("2025-07-14T00:00:00").getTime();

const countdown = setInterval(function() {
    const now = new Date().getTime();
    const distance = birthday - now;

    const days = Math.floor(distance / (1000 * 60 * 60 * 24));
    const hours = Math.floor((distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
    const minutes = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
    const seconds = Math.floor((distance % (1000 * 60)) / 1000);

    document.getElementById("days").innerText = `${days} Gün`;
    document.getElementById("hours").innerText = `${hours} Saat`;
    document.getElementById("minutes").innerText = `${minutes} Dakika`;
    document.getElementById("seconds").innerText = `${seconds} Saniye`;
}, 1000);
