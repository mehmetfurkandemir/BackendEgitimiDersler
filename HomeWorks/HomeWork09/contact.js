function validateForm() {
    const name = document.getElementById("name").value.trim();
    const email = document.getElementById("email").value.trim();
    const subject = document.getElementById("subject").value.trim();
    const message = document.getElementById("message").value.trim();
    const successMessage = document.getElementById("successMessage");
  
    const emailPattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    if (!emailPattern.test(email)) {
      alert("Please enter a valid email address.");
      return false;
    }
  
    if (!name || !email || !subject || !message) {
      alert("Please fill out all fields.");
      return false;
    }
  
    successMessage.style.display = "block";
    successMessage.innerHTML = "Thank you for contacting us!";
  
    document.getElementById("contactForm").reset();
    return false;
  }
  