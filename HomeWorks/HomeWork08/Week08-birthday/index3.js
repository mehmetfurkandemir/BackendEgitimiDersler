const dogumGunu = new Date("2025-07-14T00:00:00").getTime();

const kalanGun = setInterval(function(){
    const now = new Date().getTime();
    const mesafe = dogumGunu - now;
})

const gun = Math.floor(mesafe / (1000 * 60 * 60 * 24));
const saat = Math.floor((distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
    const dakika = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
    const saniye = Math.floor((distance % (1000 * 60)) / 1000);

document.getElementById("gun").innerText = `${gun} Gün`;
document.getElementById("saat").innerText = `${saat} Saat`;
document.getElementById("dakika").innerText = `${dakika} Dakika`;
document.getElementById("saniye").innerText = `${saniye} Saniye`;;