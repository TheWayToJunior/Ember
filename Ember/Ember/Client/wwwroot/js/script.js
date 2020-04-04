﻿$(window).scroll(function () {
    if ($(this).scrollTop() > $("div.intro").height() - 50) {
        $('#header').addClass('header-background');
    } else {
        $('#header').removeClass('header-background');
    }
});

window.scrollToElementId = (elementId) => {
    var element = document.getElementById(elementId);
    if (!element) {
        console.warn('element was not found', elementId);
        return false;
    }

    element.scrollIntoView({ block: "start", behavior: "smooth" });
    return true;
}
window.scrollLineOn = (dotnetObject, elementId) => {
    var element = document.getElementById(elementId);
    $(window).on('scroll.line', function () {
        if ($(window).scrollTop() >= element.offsetTop / 2) {
            dotnetObject.invokeMethodAsync('SetMaxHeight', $(element).height());
            if ($(window).width() > 770) {
                dotnetObject.invokeMethodAsync('SetHeight', $(window).scrollTop() - element.offsetTop / 2);
                return;
            }
        }
        dotnetObject.invokeMethodAsync('SetHeight', 0);
    });
}

window.scrollLineOff = function (){
    $(window).off('scroll.line');
}

window.initSlick = function () {
    $('.center').slick({
        centerMode: true,
        centerPadding: '60px',
        slidesToShow: 3,
        autoplay: true,
        responsive: [
            {
                breakpoint: 1256,
                settings: {
                    arrows: false,
                    centerMode: true,
                    centerPadding: '40px',
                    slidesToShow: 2
                }
            },
            {
                breakpoint: 768,
                settings: {
                    arrows: false,
                    centerMode: true,
                    centerPadding: '40px',
                    slidesToShow: 1
                }
            },
        ]
    });
};

window.initCounter = function () {
    $('.counter').counterUp({
        delay: 10,
        time: 1000,
        triggerOnce: true
    });
}

window.initMap = function () {
    var map = new google.maps.Map(
        document.getElementById('map'),{
            zoom: 14, center: { lat: 48.30627, lng: 38.0077283 }
    });

    var marker = new google.maps.Marker({
        position: { lat: 48.306820, lng: 38.028227 },
        map: map
    });
}