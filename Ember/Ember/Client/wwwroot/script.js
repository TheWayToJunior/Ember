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

//$(document).ready(function () {
//    $('.multiple-items').slick({
//        infinite: true,
//        slidesToShow: 3,
//        slidesToScroll: 3
//    });
//});

$(window).scroll(function () {
    if ($(this).scrollTop() > $("div.intro").height() - 50) {
        $('#header').addClass('header-background');
    } else {
        $('#header').removeClass('header-background');
        this.console.log(($("div.intro").height()));
    }
});