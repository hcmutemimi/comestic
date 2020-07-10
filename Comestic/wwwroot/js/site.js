document.addEventListener("DOMContentLoaded", function () {
    // Xử lí navbar
    var menunho = document.querySelector('.navbar');
  
    window.addEventListener('scroll', function () {
        if (window.pageYOffset > 0) {
            menunho.classList.add('navbar-larger')
           
        }
        else {
            menunho.classList.remove('navbar-larger')
        
        }
    });

    //Xử lí button scroll
    var mybutton = document.getElementById("scroll-to-top");
    window.onscroll = function () { scrollFunction() };
    function scrollFunction() {
        if (document.body.scrollTop > 142 || document.documentElement.scrollTop > 82) {
            mybutton.style.display = "block";
        } else {
            mybutton.style.display = "none";
        }
    }
    document.getElementById('scroll-to-top').addEventListener("click", function () {
        $("html,body").animate({ scrollTop: 0 }, 500, 'swing');
        return false;
    });
 
}, false)