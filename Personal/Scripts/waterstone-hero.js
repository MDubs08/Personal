
document.addEventListener("keydown", keyDown, false);
document.addEventListener("keypress", keyPressed, false);

function keyDown(e) {
    var key = e.keyCode;

    switch (key) {
        case 97:
            keyPressedA();
            break;

        case 83:
            keyPressedS();
            break;

        case 68:
            keyPressedD();
            break;

        case 70:
            keyPressedF();
            break;

        default:
            return false;
    }
}