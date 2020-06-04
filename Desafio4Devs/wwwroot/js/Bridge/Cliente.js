$(document).ready(function () {

    Eventos();
});


function Eventos() {

    $('#next').on('click', function () {

        $.ajax({
            url: '/Survey/NextStep',
            type: 'POST',
            dataType: 'json',
            data: $('#formSurvey').serialize(),
            success: function (sucess) {
                console.log();
                document.location.href = '/survey/survey'
            },
            error: function (xhr, textStatus, errorThrown) {
                console.log(textStatus);
            }

        });
        event.preventDefault();
    });

    $('#create').on('click', function () {

        $.ajax({
            url: '/Cliente/Create',
            type: 'POST',
            dataType: 'json',
            data: $('#formSurvey').serialize(),
            success: function (sucess) {
                console.log();
                document.location.href = '/survey'
            },
            error: function (xhr, textStatus, errorThrown) {
                console.log(textStatus);
            }

        });
        event.preventDefault();
    });
}
