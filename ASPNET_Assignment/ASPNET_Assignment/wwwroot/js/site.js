let forms = document.querySelectorAll('form')
let inputs = forms[0].querySelectorAll('input')


inputs.forEach(input => {
    if (input.dataset.val === 'true') {
        input.addEventListener('keyup', (e) => {
            switch (e.target.name) {
                case 'FirstName':
                    textValidation(e, e.target.dataset.valMinlengthMin)
                    break

                case 'LastName':
                    textValidation(e, e.target.dataset.valMinlengthMin)
                    break

                case 'Email':
                    emailValidation(e)
                    break

                case 'Password':
                    passwordValidation(e)
                    break

                case 'ConfirmPassword':
                    passwordConfirmationValidation(e)
                    break
            }
        })
    }
})

const handleValidationOutput = (isValid, e, text = "") => {
    let span = document.querySelector(`[data-valmsg-for="${e.target.name}"]`)


    if (isValid) {
        e.target.classList.remove('error')
        span.classList.remove('error')
        span.classList.add('valid')
        span.innerHTML = "Looks good!"

    } else {
        e.target.classList.add('error')
        span.classList.add('error')
        span.classList.remove('valid')
        span.innerHTML = text
    }
}



const textValidation = (e, minLength = 1) => {
    if (e.target.value.length > 0)
        handleValidationOutput(e.target.value.length >= minLength, e, e.target.dataset.valMinlength)
    else
        handleValidationOutput(false, e, e.target.dataset.valRequired)
}




const emailValidation = (e) => {
    const regEx = /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*\.[a-zA-Z]{2,}$/

    if (e.target.value.length > 0)
        handleValidationOutput(regEx.test(e.target.value), e, e.target.dataset.valRegex)
    else
        handleValidationOutput(false, e, e.target.dataset.valRequired)
}




const passwordValidation = (e) => {
    const regEx = /^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[\W_])(?!.*\s).{8,}$/


    

    if (e.target.value.length > 0) {
        if (e.target.value.length < 8) {
            console.log(e.target.dataset);
            handleValidationOutput(false, e, e.target.dataset.valMinlength);
        } else {

            handleValidationOutput(regEx.test(e.target.value), e, e.target.dataset.valRegex);
        }

    }
    else {
        handleValidationOutput(false, e, e.target.dataset.valRequired)
    }
        
}

const passwordConfirmationValidation = (e) => {
    
    let password = document.querySelectorAll('div.password');
    console.log(e);
    if (e.target.value.length > 0) {
        console.log("hej");
    }
    else {
        handleValidationOutput(false, e, e.target.dataset.valRequired)
    }
}