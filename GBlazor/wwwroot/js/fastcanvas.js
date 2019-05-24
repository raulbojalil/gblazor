var _canvas;
var _canvasContext;
var _imgData;

var initCanvas = function (id) {

    _canvas = document.getElementById(id);
    _canvasContext = _canvas.getContext("2d");
    _imgData = _canvasContext.createImageData(_canvas.width, _canvas.height);
}

var drawPixels = function (rawData) {

    var array = Blazor.platform.readObjectField(rawData, 4);
    var arrayLength = Blazor.platform.getArrayLength(array);

    for (var i = 0; i < arrayLength; i++) {
        var arrayEntry = Blazor.platform.getArrayEntryPtr(array, i, 4);
        _imgData.data[i] = Blazor.platform.readInt32Field(arrayEntry, 0);
    }

    _canvasContext.putImageData(_imgData, 0, 0);
}
