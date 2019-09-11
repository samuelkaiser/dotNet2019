
$(document).ready(function () {
    /* Check all checkboxes by default */
    jQuery.each($('.form-check-input'), function () {
        $(this).prop('checked', true);
    });

    /* Randomizing Attention Seeker Animation */
    $('#attentionSeeker').addClass('animated' + ' ' + getRandomAttentionSeeker());

    /* Display toast element when there are no colors selected */
    $('#submit').click((e) => {
        if (!($('#black').is(':checked')) && !($('#blue').is(':checked')) && !($('#green').is(":checked"))) {
            console.log("show toast");
            $('.toast').toast('show');
        } else {
            console.log("hide toast");
            $('.toast').toast('hide');
        }
    });

    /* Toggle all checkboxes and trigger a change event to change the balloons */
    $('#toggleBalloonButton').click((e) => {
        $('.form-check-input').is(':checked') ?
            $('.form-check-input').prop('checked', false).trigger('change') :
            $('.form-check-input').prop('checked', true).trigger('change');
    });

    /* Selecting balloon image by color */
    $('.form-check-input').on('change', function () {
        let imgSelector = "#" + this.id + "Img";

        $(imgSelector).css('visibility', 'visible');

        $(this).is(':checked') ?
            $(imgSelector).removeClass().addClass('animated' + ' ' + getRandomEntrance()) :
            $(imgSelector).addClass('animated' + ' ' + getRandomExit());
    });

    /* Change attention seeker color on balloon label hover */
    // (aware that using "this" would have been easier here but it was fun to try this)
    // (I swear I usually go for the easy way)
    $('.form-check-label').hover((e) => {
        let that = e.currentTarget;
        $('#attentionSeeker').attr('style', 'color: ' + $(that).attr('for'));
        // console.log();
    });
    /* Randomized animation functions */

    function getRandomAttentionSeeker() {
        let attentionSeekers = [
            "bounce",
            "flash",
            "pulse",
            "rubberBand",
            "shake",
            "swing",
            "tada",
            "wobble",
            "jello",
            "heartBeat"
        ];
        return attentionSeekers[Math.floor(Math.random() * attentionSeekers.length)];
    }

    function getRandomEntrance() {
        var entrances = [
            "bounceIn",
            "bounceInDown",
            "bounceInRight",
            "bounceInLeft",
            "bounceInUp"
        ];
        return entrances[Math.floor(Math.random() * entrances.length)];
    }

    function getRandomExit() {
        var exits = [
            "bounceOut",
            "bounceOutDown",
            "bounceOutRight",
            "bounceOutLeft",
            "bounceOutUp"
        ];
        return exits[Math.floor(Math.random() * exits.length)];
    }
});
