$('#useremail').change(function (e) {
    var emailRegex = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/;
    var EmailId = this.value;
    if (emailRegex.test(EmailId))
        console.log('Email valido');

    else
        console.log('Email invalido');


});