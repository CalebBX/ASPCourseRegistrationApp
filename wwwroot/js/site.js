
$(document).ready(function () {

    var registeredCourseIds = $('#registeredCourseIds').val() ? JSON.parse($('#registeredCourseIds').val()) : [];
    var courseListElement = $('#registered-courses-list');

    $('.course-list').on('click', '.course-card', function (e) {
        var courseId = $(this).data('id');
        var courseCode = $(this).data('code');
        if (registeredCourseIds.includes(courseId)) {
            removeFromRegisteredCoursesList(courseId, courseCode);
            $(this).find('.status-badge .badge-success').remove();
            $(this).removeClass('selected');
        } else {
            addToRegisteredCoursesList(courseId, courseCode);
            $(this).find('.status-badge').html('<span class="badge badge-success">Registered</span>');
            $(this).addClass('selected');
        }
    })
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
            success: function (result) {
                $('.main').html($(result).find('.partial').html());
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                alert("Status: " + textStatus); alert("Error: " + errorThrown);
            }  

        })
    });
    $('#form-course-filter').submit(function (e) {
        e.preventDefault();
        var order = $('#order-select').val();
        var terms = $('#course-search').val();
        var queryString = `?order=${order}&terms=${terms}`;
        $.ajax({
            url: '/course/Index' + queryString,
            type: 'GET',
            headers: {
                RequestVerificationToken:
                    $('input:hidden[name="__RequestVerificationToken"]').val()
            },
            success: function (result) {
                $('.course-list').html($(result).find('.course-list').html());
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