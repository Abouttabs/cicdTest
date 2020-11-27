function play() {
    const audio = document.getElementById("audio");
    audio.play();
}

$(document).keypress(function (e) {
    play();
})