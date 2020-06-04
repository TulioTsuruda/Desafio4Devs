$(document).ready(function () {

    Eventos();
});


function Eventos() {

    $('#save').on('click', function () {

        $.ajax({
            url: '/Survey/SaveSurvey',
            type: 'POST',
            dataType: 'json',
            data: $('#formSurvey').serialize(),
            success: function (sucess) {
                console.log();
                document.location.href = '/survey/saved'
            },
            error: function (xhr, textStatus, errorThrown) {
                console.log(textStatus);
            }

        });
        event.preventDefault();
    });

}