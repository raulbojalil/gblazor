var getGBKey = function (keyCode) {

    switch (keyCode) {

        case 38: return "Up"; 
        case 40: return "Down";
        case 37: return "Left";
        case 39: return "Right";
        case 90: return "A";
        case 88: return "B";
        case 13: return "Start";
        case 32: return "Select";
    }

    return null;
}


var downKeys = {
    "A": false,
    "B": false,
    "Start": false,
    "Select": false,
    "Up": false,
    "Down": false,
    "Left": false,
    "Right" : false
}

document.addEventListener("keydown", function (e) {

    var gbKey = getGBKey(e.keyCode);

    if (gbKey == null) return;

    if (downKeys[gbKey] === true) return;

    downKeys[gbKey] = true;
    DotNet.invokeMethodAsync('GBlazor', 'SetInput', gbKey, true);

}, false);

document.addEventListener("keyup", function (e) {

    var gbKey = getGBKey(e.keyCode);

    if (gbKey == null) return;

    downKeys[gbKey] = false;
    DotNet.invokeMethodAsync('GBlazor', 'SetInput', gbKey, false);

}, false);

