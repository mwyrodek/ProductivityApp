function PlayBell() {
    var audio = new Audio('./Audio/service-bell_daniel_simion.mp3');
    setTimeout(function () {
        audio.play();
    }, 1000);
    audio.pause();
}

