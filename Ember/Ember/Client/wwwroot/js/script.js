window.scrollToElementId = (elementId) => {
    console.info('scrolling to element', elementId);

    var element = document.getElementById(elementId);
    if (!element) {
        console.warn('element was not found', elementId);
        return false;
    }

    element.scrollIntoView({ block: "start", behavior: "smooth" });
    return true;
}

$(window).scroll(function () {
    if ($(this).scrollTop() > $("div.intro").height() - 50) {
        $('#header').addClass('header-background');
    } else {
        $('#header').removeClass('header-background');
    }
});

window.indexInit = function () {
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

    $('.counter').counterUp({
        delay: 10,
        time: 1000,
        triggerOnce: true
    });
};