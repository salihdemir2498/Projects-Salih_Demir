let addToDoButton = document.querySelector("#addToDo");
let clearToDoButton = document.querySelector("#clearToDo");
let toDoContainer = document.getElementById("toDoContainer");
let inputText = document.getElementById("inputText");
addToDoButton.addEventListener("click", function(){
    let paragraph = document.createElement("p");
    paragraph.classList.add("paragraph-styling");
    toDoContainer.appendChild(paragraph);
    paragraph.innerHTML= inputText.value;
    inputText.value="";
    inputText.focus();

    paragraph.addEventListener("click", () =>{
        paragraph.style.textDecoration = "line-through";
    })

    paragraph.addEventListener("dblclick", () => {       //paragraph 'a 2.kez tıklandığında
        toDoContainer.removeChild(paragraph);
    })

    clearToDoButton.addEventListener("click",() => {
        paragraph.remove();
    })
})

