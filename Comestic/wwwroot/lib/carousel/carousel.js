$('.carousel-main').owlCarousel({
  loop:true,
  margin:10,
  autoplay:true,
  autoplayHoverPause:true,
responsiveClass: true,
  autoHeight: true,
  autoplayTimeout: 6000,
  smartSpeed: 2500,
  //nav: true,
      responsive: {
      0: {
        items: 1
      },

      600: {
        items: 3
      },

      1024: {
        items: 6
      }
    }
//nav: true,
// dots: false,
// navText: ['<span class="fas fa-chevron-left fa-2x"></span>','<span class="fas fa-chevron-right fa-2x"></span>'],
})
$('.carousel-second').owlCarousel({
  loop:true,
  margin:10,
  autoplayHoverPause:true,
  responsiveClass: true,
  autoHeight: true,
  autoplayTimeout: 6000,
  smartSpeed: 3000,
  //nav: true,
  responsive: {
  0: {
    items: 1
  },

  600: {
    items: 2
  },

  1024: {
    items: 4
  },

  1349: {
    items: 4
  }
},
//nav: true,
// dots: false,
 //navText: ['<span class="fas fa-chevron-left fa-2x"></span>','<span class="fas fa-chevron-right fa-2x"></span>'],
})

$('.third-second').owlCarousel({
  loop:true,
  margin:10,
  //autoplayHoverPause:true,
  responsiveClass: true,
  autoplay:false,
  autoHeight: true,
  //autoplayTimeout: 5000,
  smartSpeed: 3000,
  //nav: true,
  responsive: {
  0: {
    items: 1
  },

  600: {
    items: 2
  },

  1024: {
    items: 4
  },

  1349: {
    items: 4
  }
},
//nav: true,
 //dots: false,
 //navText: ['<span class="fas fa-chevron-left fa-2x"></span>','<span class="fas fa-chevron-right fa-2x"></span>'],
})