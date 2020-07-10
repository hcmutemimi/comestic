document.addEventListener("DOMContentLoaded", function () {
    // Xử lí navbar
    var menunho = document.querySelector('.navbar');
    //var breadcrumbscroll = document.querySelector('.breadcrumb-')
    window.addEventListener('scroll', function () {
        if (window.pageYOffset > 0) {
            menunho.classList.add('navbar-larger')
            //breadcrumbscroll.classList.add('breadcrumb2')
        }
        else {
            menunho.classList.remove('navbar-larger')
            //breadcrumbscroll.classList.remove('breadcrumb2')
        }
    });

    //var blocksearch = document.querySelector('.header-search-block');
    //window.addEventListener('scroll', function () {
    //    if (window.pageYOffset > 142) {
    //        blocksearch.classList.add('header-search-block-small')
    //    } else {
    //        blocksearch.classList.remove('header-search-block-small')

    //    }
    //});
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
    // Xử lí button đăng kí, đăng nhập
    //modal
    //var modalid = document.getElementById("modal__layout");

    //// Nếu nhấn vào button đăng nhập
    //var modallogin = document.getElementById("login-button");

    //var showformlogin = document.getElementById("form-login");

    //var btnshowformregisterfromlogin = document.getElementById("heading-register-from-loginform");
    //var showformregisterfromlogin = document.getElementById("form-register")

    ////Listen for click
    //modallogin.addEventListener('click', openModal);
    //function openModal() {
    //    modalid.style.display = 'flex';
    //    showformregisterfromlogin.style.display = 'block';

    //}
    //btnshowformregisterfromlogin.addEventListener('click', openfromrgisterfromlogin);
    //function openfromrgisterfromlogin() {
    //    showformlogin.style.display = 'none';

    //    showformregister.style.display = 'block';

    //}

    //// Nếu nhấn vào button đăng ký

    //var modalregister = document.getElementById("register-button");

    //var showformregister = document.getElementById("form-register");

    //var btnshowformloginfromregister = document.getElementById("heading-login-from-registerform");
    //var showformloginfromregister = document.getElementById("form-login")

    ////Listen for click
    //modalregister.addEventListener('click', openModal);
    //function openModal() {
    //    modalid.style.display = 'flex';
    //    showformregister.style.display = 'block';

    //}
    //// Khi nhán vào button đăng nhập
    //btnshowformloginfromregister.addEventListener('click', openfromloginfromregister);
    //function openfromloginfromregister() {
    //    showformregister.style.display = 'none';
    //    showformloginfromregister.style.display = 'block';
    //}
    //// xử lí ảnh khi onmouseover, onmouseout
    //var imagebig = document.getElementById("image-big");
    //var imagesmall = document.getElementById("image-small");

    //(function (window, document, undefined) {
    //    var images = document.getElementById('image-small');
    //    for (var i = 0; i < images.length; i++) {
    //        images[i].addEventListener('mouseover', imageMouseOver, false);
    //        images[i].addEventListener('mouseout', imageMouseOut, false);
    //    }
    //})(window, window.document);
    //function imageMouseOver(event) {
    //    event = event || window.event;
    //    var image = event.target;
    //    image.src = getNewImagePath(image.src);
    //    console.log(image);
    //}
    //function imageMouseOut(event) {
    //    event = event || window.event;
    //    var image = event.target;
    //    image.src = getNewImagePath(image.src);
    //    console.log(image);
    //}
    //function getNewImagePath(path) {
    //    var newPath;
    //    if (path.indexOf('_Hover') === -1) {
    //        newPath = path.replace('.png', '_Hover.png');
    //    } else {
    //        newPath = path.replace('_Hover', '');
    //    }
    //    return newPath;
    //}
   
}, false)