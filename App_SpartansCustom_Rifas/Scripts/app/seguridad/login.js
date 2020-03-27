// Module Login
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
        passRepeatRequerida = $('#passRepeatRequerida'),
        __RequestVerificationToken = $('form input[name="__RequestVerificationToken"]').val();;

    //#endregion    

    function validarRegistro() {
        let pasa = true;

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
        pasa = required(valEmail, emailRequerido, () => validarEmail(valEmail));

        // Validate user
        pasa = required(valUserName, usuarioRequerido, () => { });

        // Validate password
        pasa = required(valPassword, passRequerida, () => { });

        // Validate repeated password
        pasa = required(valRepeatPassword, passRepeatRequerida, () => { });

        //#endregion

        if (valPassword !== '' && valRepeatPassword !== '' && valPassword !== valRepeatPassword) {
            pasa = false;
        }
        return pasa;
    }

    function validarLogin() {
        let pasa = true;

        // Real-time userName
        userName.change(function (e) {
            required(this.value, usuarioRequerido, () => { });
        });

        // Real-time password
        password.change(function (e) {
            required(this.value, pass, () => { });
        });

        const valUserName = userName.val().trim();
        const valPassword = password.val().trim();

        pasa = required(valUserName, usuarioRequerido, () => { });

        // Validate password
        pasa = required(valPassword, pass, () => { });
        return pasa;
    }

    function required(val, validation, func) {
        let pasa = true;
        if (val === '') {
            pasa = false;
            validation.show();
        } else {
            validation.hide();
            func();
        }
        return pasa;
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

    if (userRepeatPassword.val()) {
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
    }


    $('#btnRegistrar').click(function () {
        this.disabled = true;

        if (validarRegistro())
            post(
                '/Login/Register/',
                {
                    correo: email.val().trim(),
                    nombreUsuario: userName.val().trim(),
                    contrasenia: password.val().trim(),
                    __RequestVerificationToken
                },
                async data => {
                    if (data == bien) {
                        await success('El usuario ha sido creado exitosamente.');
                        await ocultarValidaciones('form');
                    } else {
                        await await error('Hubo un error al registrar el usuario');
                    }
                },
                async err => {
                    await await error('Hubo un error al enviar la información');
                }
            );

        this.disabled = false;
    });

    function validarEmail(valEmail) {
        if (emailRegex.test(valEmail))
            emailInvalido.hide();
        else
            emailInvalido.show();
    }

    $('#login').click(function () {
        this.disabled = true;

        if (validarLogin())
            post(
                '/Login/Index/',
                {
                    nombreUsuario: userName.val().trim(),
                    contrasenia: password.val().trim(),
                    __RequestVerificationToken
                },
                async data => {
                    console.log(data);
                    // if (data == bien) {
                    //     await success('El usuario ha sido logueado');
                    //     await ocultarValidaciones('form');
                    // } else {
                    //     await await error('Hubo un error al loguearse');
                    // }
                },
                async err => {
                    await await error('Hubo un error al enviar la información');
                }
            );

        this.disabled = false;

    })

})();