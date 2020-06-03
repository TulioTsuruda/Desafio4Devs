$(document).ready(function () {

    Eventos();
});


function Eventos() {

    $('#register').on('click', function () {

        $.ajax({
            url: '/Login/Register',
            type: 'POST',
            dataType: 'json',
            data: $('#formRegister').serialize(),
            success: function (sucess) {
                console.log();
                document.location.href = '/home'
            },
            error: function (xhr, textStatus, errorThrown) {
                console.log(textStatus);
            }

        });
        event.preventDefault();
    });

}