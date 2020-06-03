$(document).ready(function () {

    Eventos();
});


function Eventos() {

    $('#login').on('click', function () {

        $.ajax({
            url: '/Login/Login',
            type: 'POST',
            dataType: 'json',
            data: $('#formLogin').serialize(),
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