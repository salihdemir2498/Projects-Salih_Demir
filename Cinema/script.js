let buton = document.querySelector("#btntikla");
const mainPopup = document.querySelector(".main-popup");
const close = document.querySelector(".close-popup");
const mainProg = document.querySelector(".main");
let text = document.querySelector(".text");
let password = document.querySelector(".password");

buton.addEventListener("click",() =>{
  mainPopup.style.display="block";
  mainPopup.style.display=1;
  mainProg.style.opacity=0.3;
})

close.addEventListener("click",() =>{

   mainPopup.style.display="none";
   mainProg.style.opacity=1;
   text.style.value="";
   password.style.value="";

})

mainPopup.addEventListener("click",e =>{
    if(e.target.className=="main-popup" || e.target.textContent=="Kapat")
    {
   mainProg.style.opacity=1;
   mainPopup.style.display="none";
   text.style.value="";
   password.style.value="";
    }
})

$(document).ready(function(){
  $(".seyirci").click(function(){
      $(".views").css({
        display: "block"
      })
      $(".revenues").css({
        display: "none"
      })
  })
  $(".hasilat").click(function(){
    $(".views").css({
      display: "none"
    })
    $(".revenues").css({
      display: "block"
    })
})
});