const login = (() => {
    //#region Variables
    const email = $('#useremail'),
        password = $('#userpassword'),
        userName = $('#username'),
        userRepeatPassword = $('#userpasswordRepetir'),
        pass = $('#pass'),
        confirmPass = $('#confirmPass'),
        emailInvalido = $('#emailInvalido'),
        emailRegex = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/,
        emailRequerido = $('#emailRequerido'),
        usuarioRequerido = $('#usuarioRequerido'),
        passRequerida = $('#passRequerida'),
        passRepeatRequerida = $('#passRepeatRequerida');

    //#endregion    

    function validarRegistro() {

        //#region Enable real-time validations

        // Real-time email
        email.change(function (e) {
            var EmailId = this.value;
            required(EmailId, emailRequerido, () => {
                validarEmail(EmailId);
            });
        });

        // Real-time userName
        userName.change(function (e) {
            required(this.value, usuarioRequerido, () => { });
        });

        // Real-time password
        password.change(function (e) {
            required(this.value, passRequerida, () => { });
        });

        // Real-time userRepeatPassword
        userRepeatPassword.change(function (e) {
            required(this.value, passRepeatRequerida, () => { });
        })
        //#endregion

        //#region Declaracion de variables
        const valEmail = email.val().trim();
        const valUserName = userName.val().trim();
        const valPassword = password.val().trim();
        const valRepeatPassword = userRepeatPassword.val().trim();
        //#endregion

        //#region Required

        // Validate email
        required(valEmail, emailRequerido, () => validarEmail(valEmail));

        // Validate user
        required(valUserName, usuarioRequerido, () => { });

        // Validate password
        required(valPassword, passRequerida, () => { });

        // Validate repeated password
        required(valRepeatPassword, passRepeatRequerida, () => { });

        //#endregion

        if (valPassword !== '' && valRepeatPassword !== '') {
            if (valPassword !== valRepeatPassword) {
                console.log('La repeticion de contra no es igual');
            }
        }
    }

    function required(val, validation, func) {
        if (val === '') {
            validation.show();
        } else {
            console.log('entra');

            validation.hide();
            func();
        }
    }

    userRepeatPassword.blur(function (e) {
        const valPassword = password.val().trim();
        if (this.value !== '' && this.value !== valPassword) {
            pass.show();
            confirmPass.show();
        } else {
            pass.hide();
            confirmPass.hide();
        }
    });

    password.blur(function (e) {
        const valPassword = userRepeatPassword.val().trim();
        if (this.value !== '' && valPassword !== '' && this.value !== valPassword) {
            pass.show();
            confirmPass.show();
        } else {
            pass.hide();
            confirmPass.hide();
        }
    });

    $('#btnRegistrar').click(function () {
        this.disabled = true;

        validarRegistro();

        this.disabled = false;
    });

    function validarEmail(valEmail) {
        if (emailRegex.test(valEmail))
            emailInvalido.hide();
        else
            emailInvalido.show();
    }

})();