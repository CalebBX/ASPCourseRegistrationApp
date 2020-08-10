
$(document).ready(function () {

    var registeredCourseIds = JSON.parse($('#registeredCourseIds').val());
    var courseListElement = $('#registered-courses-list');

    $('.course-card').click(function (e) {
        var courseId = $(this).data('id');
        var courseCode = $(this).data('code');
        if (registeredCourseIds.includes(courseId)) {
            removeFromRegisteredCoursesList(courseId, courseCode);
            $(this).removeClass('selected');
        } else {
            addToRegisteredCoursesList(courseId, courseCode);
            $(this).addClass('selected');
        }

    });
    $('#form-register-courses').submit(function (e) {
        e.preventDefault();
        $.ajax({
            url: '/course/RegisterCourses',
            data: {
                'registeredCourseIds': registeredCourseIds
            },
            type: 'POST',
            headers: {
                RequestVerificationToken:
                    $('input:hidden[name="__RequestVerificationToken"]').val()
            },
            success: function(result) {

            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                alert("Status: " + textStatus); alert("Error: " + errorThrown);
            }  

        })
    });
    function addToRegisteredCoursesList(id, code) {
        registeredCourseIds.push(id);
        courseListElement.append(`<li>${code}</li>`)
    }
    function removeFromRegisteredCoursesList(id, code) {
        registeredCourseIds.splice(registeredCourseIds.indexOf(id), 1)
        courseListElement.find(`li:contains(${code})`).remove();
    }

});