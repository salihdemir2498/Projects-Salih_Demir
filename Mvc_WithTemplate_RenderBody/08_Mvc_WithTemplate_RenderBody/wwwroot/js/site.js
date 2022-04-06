////alert("selam");

$(document).ready(function () {
    $("li a").each(function () {
        if ($(this).attr("href") == window.location.pathname) {
            $(this).addClass("activeLinkk");
        }
    })
    //console.log($("li a").attr("href"));
    //console.log(window.location.pathname);
})