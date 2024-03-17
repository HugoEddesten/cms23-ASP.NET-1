let forms = document.querySelectorAll('section')
let inputs = forms[0].querySelectorAll('input')
console.log(forms);

inputs.forEach(input => {
    if (input.dataset.val === 'true') {
        input.addEventListener('keyup', (e) => {
            switch (e.target.type) {
                case 'text':
                    hej();
                    break;
                case 'email':
                    hej();
                    break;
                case 'password':
                    hej();
                    break;
            }
        })
    }
})

const hej = (e) => {
    console.log("hej");
}