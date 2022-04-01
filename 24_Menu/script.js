
let slideIndex = 0;
let allSlides = $(".slide").toArray();
let allDot=$(".dot").toArray();

$(".nextSlide").click(function () {
    // slideIndex++;
    if (allSlides.length == slideIndex + 1) {
        slideIndex = -1;
    }
    showSlide(++slideIndex); //1 arttırıp öyle çalışır
})
$(".prevSlide").click(function () {
    // slideIndex--;
    if (slideIndex == 0) {
        slideIndex = allSlides.length;
    }
    showSlide(--slideIndex);
})

let showSlide = (n) => {
    for (let i = 0; i < allSlides.length; i++) {
        allSlides[i].style.display = "none";
        allDot[i].classList.remove("active");
    }
    
    allSlides[n].style.display = "block";
    allDot[n].classList.add("active");


    //ödev kayarak giden slider
}

$(".dot").mousemove(function () {
    slideIndex = $(this).index();
    showSlide(slideIndex);
   

})

showSlide(slideIndex);

//-------------




$(document).ready(function(){
    $(".img-1").click(function(){
        $(".mainnn").css({
            display: "block",
               
        })
        $(".main-popup").css({
            display: "block",
               
        })
        $("#pop-1").css({
            display: "block"    
        })
        $(".container").css({
            opacity: 0.3,
               
        })
    })
    $(".img-2").click(function(){
        $(".mainnn").css({
            display: "block",
               
        })
        $(".main-popup").css({
            display: "block",
               
        })
        $("#pop-2").css({
            display: "block"    
        })
        $(".container").css({
            opacity: 0.3   
        })
    })
    $(".img-3").click(function(){
        $(".mainnn").css({
            display: "block",
               
        })
        $(".main-popup").css({
            display: "block",
               
        })
        $("#pop-3").css({
            display: "block"    
        })
        $(".container").css({
            opacity: 0.3   
        })
    })
    $(".img-4").click(function(){
        $(".mainnn").css({
            display: "block",
               
        })
        $(".main-popup").css({
            display: "block",
               
        })
        $("#pop-4").css({
            display: "block"    
        })
        $(".container").css({
            opacity: 0.3   
        })
    })
    $(".img-5").click(function(){
        $(".mainnn").css({
            display: "block",
               
        })
        $(".main-popup").css({
            display: "block",
               
        })
        $("#pop-5").css({
            display: "block"    
        })
        $(".container").css({
            opacity: 0.3   
        })
    })
    $(".close-popup").click(function(){
        $(".mainnn").css({
            display: "none",
               
        })
        $(".main-popup").css({
            display: "none",
               
        })

        $("#pop-5").css({
            display: "none"    
        })
        $("#pop-4").css({
            display: "none"    
        })
        $("#pop-3").css({
            display: "none"    
        })
        $("#pop-2").css({
            display: "none"    
        })
        $("#pop-1").css({
            display: "none"    
        })
        $(".container").css({
            opacity: 1   
        })
    })

    $(".mainnn").click(function(){
        $(".mainnn").css({
            display: "none"
        })
        $(".main-popup").css({
            display: "none"
        })
        $(".container").css({
            display: "block",
            opacity: 1
        })
        $("#pop-5").css({
            display: "none"    
        })
        $("#pop-4").css({
            display: "none"    
        })
        $("#pop-3").css({
            display: "none"    
        })
        $("#pop-2").css({
            display: "none"    
        })
        $("#pop-1").css({
            display: "none"    
        })
    })
})




