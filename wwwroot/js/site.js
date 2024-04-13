// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//#region Setting up slick slider library
(function ($) {

  "use strict";

  // PRE LOADER
  $(window).load(function () {
    $('.preloader').delay(500).slideUp('slow'); // set duration in brackets
  });

  // NAVBAR
  $(".navbar").headroom();

  $('.navbar-collapse a').click(function () {
    $(".navbar-collapse").collapse('hide');
  });

  $('.slick-slideshow').slick({
    autoplay: true,
    infinite: true,
    arrows: false,
    fade: true,
    dots: true,
  });

  $('.slick-testimonial').slick({
    arrows: false,
    dots: true,
  });

})(window.jQuery)
//#endregion

//#region Setting up headroom
(function($) {

  if(!$) {
    return;
  }

  ////////////
  // Plugin //
  ////////////

  $.fn.headroom = function(option) {
    return this.each(function() {
      var $this   = $(this),
        data      = $this.data('headroom'),
        options   = typeof option === 'object' && option;

      options = $.extend(true, {}, Headroom.options, options);

      if (!data) {
        data = new Headroom(this, options);
        data.init();
        $this.data('headroom', data);
      }
      if (typeof option === 'string') {
        data[option]();

        if(option === 'destroy'){
          $this.removeData('headroom');
        }
      }
    });
  };

  //////////////
  // Data API //
  //////////////

  $('[data-headroom]').each(function() {
    var $this = $(this);
    $this.headroom($this.data());
  });

}(window.Zepto || window.jQuery));
//#endregion