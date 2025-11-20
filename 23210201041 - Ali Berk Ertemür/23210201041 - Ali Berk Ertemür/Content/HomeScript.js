function ShowText(a,b) {
    if (document.getElementById(a).classList.contains("limited-paragraph-3")) {
        document.getElementById(a).classList.remove("limited-paragraph-3");
        document.getElementById(b).innerText = "Daha az göster";
    }
    else {
        document.getElementById(a).classList.add("limited-paragraph-3");
        document.getElementById(b).innerText = "Devamını Oku";
    }
}