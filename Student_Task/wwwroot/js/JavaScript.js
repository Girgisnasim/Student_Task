console.log("hello world")
let isvaild = true;

function validation() {

    const nameInput = document.getElementById('name').value;
    const nameError = document.getElementById('nameerror');
    const namePattern = /^[a-zA-Z\s]+$/;

    if (!namePattern.test(nameInput)) {
        nameError.textContent = "Name contains numbers or special characters.";
        isvaild=false
    }

    const dateinput = new Date(document.getElementById('Date').value)
    const dateError = document.getElementById('dateerror');
    const today = new Date()
    const age = today.getFullYear() - dateinput.getFullYear();
    if (age < 15) {
        dateError.textContent = "Student's age must be more than 15 years.";
        isvaild = false;
    }

    const emailinput = document.getElementById("email").value
    const emailerror = document.getElementById("emailerror")
    const emailPattern = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;
    if (!emailPattern.test(emailinput)) {
        emailerror.textContent = "Invalid email"
        isvaild = false
    }

    const subjectInputs = document.querySelectorAll('input[name="subject"]:checked');
    const subjectsError = document.getElementById('suberror');
    if (subjectInputs.length > 2) {
        suberror.textContent = "You can only choose up to 2 subjects.";
        isValid = false;
    }

   



return isvaild
}