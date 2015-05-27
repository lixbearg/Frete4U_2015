/******************************************************************************
	Transforms the basic Twitter Bootstrap Carousel into Fullscreen Mode
	@author Fabio Mangolini
     http://www.responsivewebmobile.com
******************************************************************************/
jQuery(document).ready(function () {
    $('.carousel').carousel({
        pause: true,
        interval: false
    });

    $('.carousel').css({ 'margin-top': 60, 'width': 1024, 'height': 768 });
    $('.carousel .item').css({ 'width': '1024px', 'height': '768px' });
    $('.carousel-inner div.item img').each(function () {
        var imgSrc = $(this).attr('src');
        $(this).parent().css({ 'background': 'url(' + imgSrc + ') no-repeat center' });
        $(this).remove();
    });
    $(window).on('resize', function () {
        $('.carousel').css({ 'width': $(window).outerWidth(), 'height': $(window).outerHeight() });
    });
}); 