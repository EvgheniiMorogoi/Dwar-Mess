function Switchtheme() {
    var bar = document.getElementById("navbar");
    var currentClass = bar.className;
    if (currentClass == "navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-light") { 
        bar.className = "navbar navbar-expand-sm navbar-toggleable-sm navbar-dark bg-dark";
    } else {
        bar.className = "navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-light";
    }
}   